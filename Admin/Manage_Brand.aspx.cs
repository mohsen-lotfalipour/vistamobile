using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Manage_Brand : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    DataClassesDataContext test = new DataClassesDataContext();
    vm_brand br = new vm_brand
    {
        name = "test",
    };

    protected void Button1_Click(object sender, EventArgs e)
    {




    }
}