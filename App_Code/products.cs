using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vistamobile.DAL;
using System.Data;



/// <summary>
/// Summary description for shop
/// </summary>
public class products
{

    DA db;
    public products()
    {
        // TODO: Add constructor logic here
        db = new DA();
    }

    public DataTable getproduct()
    {
        string query = "SELECT * FROM product";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getpic(int id)
    {
        string query = "SELECT TOP 3 name FROM pic Where product_id=" + id;
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getonepic(int id)
    {
        string query = "SELECT TOP 1 name FROM pic Where product_id=" + id;
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getproductbyid(int id)
    {
        string query = "SELECT * FROM product Where id=" + id;
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }




    public DataTable getproduct_cat(string id)
    {
        string query = "SELECT * FROM product where cat_id='" + id.ToString() + "'";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getproduct_brand(int id)
    {
        string query = "SELECT * FROM product where brand_id='" + id.ToString() + "'";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }
    public DataTable getproduct_feature()
    {
        string query = "SELECT * FROM product where status='vip'";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }
    public DataTable getproduct_new()
    {
        string query = "SELECT * FROM product where status='new'";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

}