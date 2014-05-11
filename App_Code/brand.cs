using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using vistamobile.DAL;
/// <summary>
/// Summary description for brand
/// </summary>
public class brand
{
    DA db;

	public brand()
	{
        db = new DA();

	}

    public DataTable getbrand()
    {
        string query = "SELECT * FROM brand";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public DataTable getbrandbyid(string id)
    {
        string query = "SELECT name FROM brand Where id=" + id;
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }
}