using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


public partial class Admin_Manage : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        //  GridView1.Columns[2].HeaderText = "ردیف";
        // GridView1.Columns[2].HeaderText = "نام";


    }


    public void load()
    {

        brand b = new brand();

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //Response.Write(GridView1 .SelectedRow.Cells[1].ToString());
      //  Response.Write(GridView1.Rows[GridView1.EditIndex + 1].Cells[2].Text);
    }
    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
      //  Response.Write("Test_update");
        Response.Write(e.OldValues["name"]);
        Response.Write(",");
        Response.Write(e.NewValues["name"]);
    }
}