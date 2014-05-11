using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using vistamobile.DAL;
using System.Security.Cryptography;

/// <summary>
///check username and password and security
/// </summary>
public class usersUtility
{
    public static DA db =new DA();
    public static DataSet ds = new DataSet();
	public usersUtility()
	{
	}

    //hash input_data by SHA1 algorithm
    public static string GenerateHash(string input_data)
    {
        string hashText = "";
        string hexValue = "";

        byte[] stringData = System.Text.Encoding.ASCII.GetBytes(input_data);
        byte[] hashData = SHA1.Create().ComputeHash(stringData);

        foreach (byte b in hashData)
        {
            hexValue = b.ToString("X").ToLower();
            hashText += (hexValue.Length == 1 ? "0" : "") + hexValue;
        }

        return hashText;
    }

    // check username in database exist
    public static bool user_login_exist(string username)
    {
        string query = "SELECT id FROM userinfo WHERE user_name='"+username+"'";
        ds = db.db_ExecuteQuery(query);
        if (ds !=null && ds.Tables[0].Rows.Count == 1)
        {
            return true;

        }
        else
        {
            return false;
        }

    }
    //check email exist in databse
    public static bool user_email_exist(string email)
    {
        string query = "SELECT id FROM userinfo WHERE email='" + email+"'";
        ds = db.db_ExecuteQuery(query);
        if (ds != null && ds.Tables[0].Rows.Count == 1)
        {
            return true;

        }
        else
        {
            return false;
        }

    }
  
    public static void register(string username,string email,string password)
    {     
        string sql = @"INSERT INTO userinfo (user_name,email,password)";
        sql += " VALUES('{0}','{1}','{2}')";
        sql = String.Format(sql, username,email,GenerateHash(password));
        db.db_ExecuteNonQuery(sql);
    }

    public static bool login(string username, string password)
    {

        string sql = @"SELECT id FROM userinfo where ";
        sql += "(user_name='{0}' OR email='{0}') AND password='{1}'";
        sql = String.Format(sql, username,GenerateHash(password.Trim()));
        ds = db.db_ExecuteQuery(sql);
        if (ds!= null && ds.Tables[0].Rows.Count == 1)
        {
            return true;

        }
        return false;
    }
}
