using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class checkout_step_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "timeout", String.Format("disable_remove();"), true);
        if (Session["login"] != null)
        {
            initpage();
        }
    }
    protected void initpage()
    {
        DataTable dt = new DataTable();
        usersUtility user=new usersUtility();
        dt = user.getUser(Session["login"].ToString());
        firstName.Value = dt.Rows[0]["f_name"].ToString();
        lastName.Value = dt.Rows[0]["l_name"].ToString();
        email.Value = dt.Rows[0]["email"].ToString();
        addr1.Value = dt.Rows[0]["address"].ToString();
        telephone.Value = dt.Rows[0]["phone"].ToString();
        mobile.Value = dt.Rows[0]["mobile"].ToString();
        company.Value = dt.Rows[0]["company"].ToString();
        zip.Value = dt.Rows[0]["zip_code"].ToString();
        //Response.Write("city "+city_id.DataValueField.ToString());

    }
    protected void Acceptcart_Click(object sender, EventArgs e)
    {
        Response.Write(Request.Form.ToString());


    } 
}