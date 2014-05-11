using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class checkout_step_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "timeout", String.Format("disable_remove();"), true);
    }
    protected void Acceptcart_Click(object sender, EventArgs e)
    {
        Response.Write(Request.Form.ToString());
    } 
}