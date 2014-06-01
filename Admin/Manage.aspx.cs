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
        GridView1.Columns[0].HeaderText = "ردیف";
        GridView1.Columns[0].HeaderText = "نام";
        GridView1.Columns[0].HeaderText = "test";
        GridView1.Columns[0].HeaderText = "test";


    }
    public void load()
    {
  
    }
}