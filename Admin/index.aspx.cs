﻿using System;
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
   
    database db = new database();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
}