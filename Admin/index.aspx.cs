using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using vistamobile.DAL;

public partial class Admin_index : System.Web.UI.Page
{
    protected string TestString { get; set; }
    DA db;
    public Admin_index()
    {
        db = new DA();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

        GridView1.EditIndex = e.NewEditIndex;

        BindData();
    }

    public DataTable getcategory()
    {
        string query = "SELECT * FROM product";
        DataSet ds = new DataSet();
        ds = db.db_ExecuteQuery(query);
        return ds.Tables[0];
    }

    public void BindData()
    {
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DB\mobile_hardware.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"].ConnectionString);

        DataTable ca = getcategory();
        //new SqlDataAdapter("SELECT * FROM category", con);
        //  DataTable dt = new DataTable();



        GridView1.DataSource = ca.DataSet;

        GridView1.DataBind();

    }

    protected override void OnPreInit(EventArgs e)
    {
        brand br = new brand();
        //DataTable dt = new DataTable();
       string dt = br.getbrandbyid(1);
        TestString = dt.ToString();
    }

}