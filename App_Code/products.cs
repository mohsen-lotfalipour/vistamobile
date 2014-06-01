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
        string query = "SELECT * FROM vm_product";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getpic(int id)
    {
        string query = "SELECT TOP 3 name FROM vm_pic Where product_id=" + id;
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getonepic(int id)
    {
        string query = "SELECT TOP 1 name FROM vm_pic Where product_id=" + id;
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getproductbyid(int id)
    {
        string query = "SELECT * FROM vm_product Where id=" + id;
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }




    public DataTable getproduct_cat(string id)
    {
        string query = "SELECT * FROM vm_product where cat_id='" + id.ToString() + "'";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getproduct_brand(string id)
    {
        string query = "SELECT * FROM vm_product where brand_id='" + id.ToString() + "'";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getproduct_related_top(string name, string id)
    {
        string query = "SELECT TOP 4 * FROM vm_product where name='" + name + "'AND ID !='" + id + "'";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getproduct_feature()
    {
        string query = "SELECT * FROM vm_product where status='vip'";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }
    public DataTable getproduct_new()
    {
        string query = "SELECT * FROM vm_product where status='new'";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

}