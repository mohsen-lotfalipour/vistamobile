using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class checkout_step_3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "timeout", String.Format("disable_remove();"), true);
    }
    protected void Acceptpayment_Click(object sender, EventArgs e)
    {
        Session["payment"]=Request.Form["payment"];
        Response.Redirect("checkout-step-4.aspx");
    }
}