using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using vistamobile.DAL;
/// <summary>
/// Summary description for orderlist
/// </summary>
public class orderlist
{
    public static DA db = new DA();
	public orderlist()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable get_product_order(string order_id)
    {
        // product.id,product.name,product.price,orderlist.count
        string query = "SELECT * FROM product INNER JOIN orderlist ON orderlist.product_id=product.id Where orderlist.order_id='" + order_id+"'";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }
}