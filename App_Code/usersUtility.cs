﻿using System;
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
        string query = "SELECT id FROM vm_userinfo WHERE user_name='"+username+"'";
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
        string query = "SELECT id FROM vm_userinfo WHERE email='" + email+"'";
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
        string sql = @"INSERT INTO vm_userinfo (user_name,email,password)";
        sql += " VALUES('{0}','{1}','{2}')";
        sql = String.Format(sql, username,email,GenerateHash(password));
        db.db_ExecuteNonQuery(sql);
    }

    public static bool login(string username, string password)
    {

        string sql = @"SELECT id FROM vm_userinfo where ";
        sql += "(user_name='{0}' OR email='{0}') AND password='{1}'";
        sql = String.Format(sql, username,GenerateHash(password.Trim()));
        ds = db.db_ExecuteQuery(sql);
        if (ds!= null && ds.Tables[0].Rows.Count == 1)
        {
            return true;

        }
        return false;
    }

    public DataTable getUser(string username)
    {
        string sql = @"SELECT * FROM vm_userinfo where ";
        sql += "user_name='{0}' OR email='{0}'";
        sql = String.Format(sql, username);
        ds = db.db_ExecuteQuery(sql);
        return ds.Tables[0];
    }

    public static void update_user(string id,string fname,string lname,string phone,string mobile,string ostan,string city,string addres,string zip,string company)
    {
        string sql = @"UPDATE vm_userinfo SET";
        sql += " f_name='{0}',l_name='{1}',address='{2}',mobile='{3}',phone='{4}',zip_code='{5}',company='{6}',ostan='{7}',city='{8}' WHERE id='{9}'";
        sql = String.Format(sql, fname, lname, addres, mobile, phone, zip, company, Int32.Parse(ostan), Int32.Parse(city),id);
        db.db_ExecuteNonQuery(sql);
    }
    public static void update_user(string id,string fname, string lname, string phone, string mobile, string ostan, string city, string addres, string zip, string company,string email)
    {
        string sql = @"UPDATE vm_userinfo SET";
        sql += " f_name='{0}',l_name='{1}',address='{2}',mobile='{3}',phone='{4}',zip_code='{5}',company='{6}',ostan='{7}',city='{8}',email='{9}' WHERE id='{10}'";
        sql = String.Format(sql, fname, lname, addres, mobile, phone, zip, company, Int32.Parse(ostan), Int32.Parse(city),email, id);
        db.db_ExecuteNonQuery(sql);
    }
    public static void register_full(string fname, string lname, string phone, string mobile, string ostan, string city, string addres, string zip, string company, string email)
    {
        string sql = @"INSERT INTO vm_userinfo (user_name,password,f_name,l_name,email,address,mobile,phone,zip_code,company,ostan,city)";
        sql += " VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')";
        sql = String.Format(sql, email, GenerateHash(mobile), fname, lname, email, addres, mobile, phone, zip,company, Int32.Parse(ostan), Int32.Parse(city));
        db.db_ExecuteNonQuery(sql);
    }

    public static void update_user(string id, string new_pass)
    {
        string sql = @"UPDATE vm_userinfo SET";
        sql += " password='{0}' WHERE id='{1}'";
        sql = String.Format(sql, GenerateHash(new_pass.Trim()), id);
        db.db_ExecuteNonQuery(sql);
    }
    public static void update_user(string id, string new_pass, string username)
    {
        string sql = @"UPDATE vm_userinfo SET";
        sql += " password='{0}',user_name='{1}' WHERE id='{2}'";
        sql = String.Format(sql, GenerateHash(new_pass.Trim()),username, id);
        db.db_ExecuteNonQuery(sql);
    }

}
