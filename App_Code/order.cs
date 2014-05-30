using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using vistamobile.DAL;
/// <summary>
/// Summary description for order
/// </summary>
public class order
{
    public static DA db = new DA();
	public order()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void create_order(DataTable cart,string user,string peyment,int total_price){
        string Date = persian_date.miladi_date_now();
        usersUtility u = new usersUtility(); 
        Random r = new Random();
        string user_id = u.getUser(user).Rows[0]["id"].ToString();
        string id = Date.Replace("/", "") + r.Next(0, 9) + total_price.ToString() + r.Next(0, 9)+user_id;
        string sql = @"INSERT INTO order_buy (id,user_id,peyment,date,totalprice)";
        sql += " VALUES('{0}','{1}','{2}','{3}','{4}')";
        sql = String.Format(sql, id,user_id, peyment, Date,total_price);
        db.db_ExecuteNonQuery(sql);
        foreach (DataRow dr in cart.Rows)
        {
            sql = @"INSERT INTO orderlist (product_id,order_id,count)";
            sql += " VALUES('{0}','{1}','{2}')";
            sql = String.Format(sql, dr["id"], id, dr["number"]);
            db.db_ExecuteNonQuery(sql);
        }

    }

    public DataTable get_user_order(string user_id)
    {
        string query = "SELECT * FROM order_buy Where user_id=" + user_id;
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }
}