using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class checkout_step_2 : System.Web.UI.Page
{
    public  DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "timeout", String.Format("disable_remove();"), true);
        if (Session["login"] != null)
        {
            initpage();
        }
        else
        {
            string str = "<script>city_selected('71','15');</script>";//select default fars,shiraz
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", str, false);
        }
    }
    protected void initpage()
    {
       
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
        ListItem ostan = ostan_id.Items.FindByValue(dt.Rows[0]["ostan"].ToString());
        ListItem defualt_ostan = ostan_id.Items[ostan_id.SelectedIndex];
        defualt_ostan.Selected = false;
        if (ostan == null)
        {
            ostan = defualt_ostan;
        }
        ostan.Selected = true;
        string str = "<script>city_selected('" + ostan.Value + "','" + dt.Rows[0]["city"].ToString() + "');</script>";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", str, false);
        
        //Response.Write("city "+city_id.DataValueField.ToString());

    }
    protected void Acceptcart_Click(object sender, EventArgs e)
    {
        //int city = city_id.Items.Count;
        //Response.Write("cityid="+city);
        //Response.Write("city:" + Request.Form["ctl00$MainContent$city_id"]);
        //add and user update to database
        if (Session["login"] != null)
        {
            //update user in database
            if (dt.Rows[0]["email"].ToString().Equals(Request.Form["ctl00$MainContent$email"]))
            {
                usersUtility.update_user(dt.Rows[0]["id"].ToString(),Request.Form["ctl00$MainContent$firstName"], Request.Form["ctl00$MainContent$lastName"], Request.Form["ctl00$MainContent$telephone"], Request.Form["ctl00$MainContent$mobile"], Request.Form["ctl00$MainContent$ostan_id"], Request.Form["ctl00$MainContent$city_id"], Request.Form["ctl00$MainContent$addr1"], Request.Form["ctl00$MainContent$zip"], Request.Form["ctl00$MainContent$company"]);
            }
            else
            {
                if (usersUtility.user_email_exist(Request.Form["ctl00$MainContent$email"]))
                {
                    (this.Master as Main).set_register_error("این ایمیل قبلا در سیستم ثبت شده است اگر این متعلق به شما لطفا ابتدا وارد سایت شوید");
                }
                else
                {
                    usersUtility.update_user(dt.Rows[0]["id"].ToString(),Request.Form["ctl00$MainContent$firstName"], Request.Form["ctl00$MainContent$lastName"], Request.Form["ctl00$MainContent$telephone"], Request.Form["ctl00$MainContent$mobile"], Request.Form["ctl00$MainContent$ostan_id"], Request.Form["ctl00$MainContent$city_id"], Request.Form["ctl00$MainContent$addr1"], Request.Form["ctl00$MainContent$zip"], Request.Form["ctl00$MainContent$company"], Request.Form["ctl00$MainContent$email"]);
                }
            }
        }
        else
        {
            //insert user in databse
            if (usersUtility.user_email_exist(Request.Form["ctl00$MainContent$email"]))
            {
                (this.Master as Main).set_register_error("این ایمیل قبلا در سیستم ثبت شده است اگر این متعلق به شما لطفا ابتدا وارد سایت شوید");
            }
            else
            {
                usersUtility.register_full(Request.Form["ctl00$MainContent$firstName"], Request.Form["ctl00$MainContent$lastName"], Request.Form["ctl00$MainContent$telephone"], Request.Form["ctl00$MainContent$mobile"], Request.Form["ctl00$MainContent$ostan_id"], Request.Form["ctl00$MainContent$city_id"], Request.Form["ctl00$MainContent$addr1"], Request.Form["ctl00$MainContent$zip"], Request.Form["ctl00$MainContent$company"], Request.Form["ctl00$MainContent$email"]);
                Session["login"] = Request.Form["ctl00$MainContent$email"];
            }

        }

        Response.Redirect("checkout-step-3.aspx");
    } 
    
}