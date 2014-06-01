using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using vistamobile.DAL;

/// <summary>
/// Summary description for product
/// </summary>
public class category
{
    DA db;
	public category()
	{
        db = new DA();
	}

    public DataTable getcategory()
    {
        string query = "SELECT * FROM vm_category";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }
    public DataTable getcategory(string id)
    {
        string query = "SELECT name FROM vm_category Where id=" + id;
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }
}