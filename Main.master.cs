using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using vistamobile;
using System.Text.RegularExpressions;
using System.Data;
using System.Web.UI.HtmlControls;
public partial class Main : System.Web.UI.MasterPage
{
    static int i = 0;
    public void initi()
    {
        Session.RemoveAll();
        //add paramet cart in session
        DataTable cart = new DataTable();
        cart.Columns.Add("id", typeof(string));
        cart.Columns.Add("price", typeof(Int32));
        cart.Columns.Add("img", typeof(string));
        cart.Columns.Add("name", typeof(string));
        cart.Columns.Add("number", typeof(Int16));

        HttpContext.Current.Session.Add("cart", cart);
        HttpContext.Current.Session.Add("total_price_cart", 0);
        HttpContext.Current.Session.Add("send_price", 0);
        HttpContext.Current.Session.Add("count_cart", 0);
        update_cart();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["login"]!=null && Request.QueryString["login"].Equals("true"))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", String.Format("call_modal('loginModal');"), true);
            
        }
        if (i == 0)
        {
            initi();
            i++;
        }
        else
        {
            update_cart();
        }
        set_menu_item();
        if (!IsPostBack)
        {
            if (Request.Form.ToString() != null && Request.Form["inputEmailRegister"] != null)//check register form posted
            {
                register();

            }
            if (Session["login"] == null)
            {
                login_status.Text = "<a href=\"#loginModal\" role=\"button\" id=\"loginModalcall\" data-toggle=\"modal\">ورود</a> یا <a href=\"#registerModal\" role=\"button\" data-toggle=\"modal\">ثبت نام</a>";
                if (Request.Form.ToString() != null && Request.Form["inputEmail"] != null)//check login form posted
                {
                    login_user();
                    
                }
            }
            else
            {
                login_status.Text = Session["login"].ToString() + "   " + "خوش آمدید";
                login_status.Text += "<a href=\"logout.aspx\">  خروج</a>";
            }
        }


    }

    public void register()
    {
        string ErrorMessage = "";
        string username = Request.Form["inputUsernameRegister"];
        string email = Request.Form["inputEmailRegister"];
        string password = Request.Form["inputPasswordRegister"];


        if (usersUtility.user_login_exist(username))
            ErrorMessage = "نام کاربری موجود میباشد";
        else if (usersUtility.user_email_exist(email))
            ErrorMessage = " این ایمیل در سیستم ثبت شده است";
        else
        {
            //insert to databse
            usersUtility.register(username, email, password);
            HttpContext.Current.Session.Add("login", username);
            // Response.Redirect(Request.UrlReferrer.ToString());
        }
        if (ErrorMessage != "")
        {
            registerlableError.Attributes.Add("class", "alert alert-danger in fade");
            registerlableError.InnerHtml = "<button data-dismiss=\"alert\" class=\"close\" type=\"button\">×</button>" + ErrorMessage;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", String.Format("call_modal('registerModal');"), true);
        }
    }
    public void login_user()
    {
        string username = Request.Form["inputEmail"];
        string password = Request.Form["inputPassword"];
        string ErrorMessage = "";
        logineErrorlable.InnerText = "";
         if (usersUtility.login(username, password))
        {
            HttpContext.Current.Session.Add("login", username);
            if (Request.UrlReferrer.ToString().Contains("login=true"))
            {
                Response.Redirect("userpanel.aspx");
            }
            else
                Response.Redirect(Request.UrlReferrer.ToString());
        }
        else
            ErrorMessage = "نام کاربری یا کلمه عبور صحیح نمی باشد";

        if (ErrorMessage != "")
        {
            //Response.Write(ErrorMessage);
            logineErrorlable.Attributes.Add("class", "alert alert-danger in fade");
            logineErrorlable.InnerHtml = "<button data-dismiss=\"alert\" class=\"close\" type=\"button\">×</button>"+ErrorMessage;
            //logineErrorlable.InnerHtml += "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", String.Format("call_modal('loginModal');"), true);
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "LaunchServerSide", "$(function() { LoginFail(); });", true);
        }
    }

    public void set_menu_item()
    {
        category cat = new category();
        DataTable dt = new DataTable();
        dt = cat.getcategory();
        foreach (DataRow list in dt.Rows)
        {
            HtmlGenericControl li = new HtmlGenericControl("li");
            shop_menu.Controls.Add(li);
            HtmlGenericControl a = new HtmlGenericControl("a");
            a.Attributes.Add("href", "shop.aspx?cat_id=" + list["id"].ToString());
            a.InnerText = list["name"].ToString();
            li.Controls.Add(a);
        }
    }
    public void update_cart()
    {
        panel_cart.InnerHtml = "";
        DataTable cart = Session["cart"] as DataTable;
        Session["total_price_cart"] = 0;
        Session["count_cart"] = 0;
        try{
        foreach (DataRow dr in cart.Rows)
        {
            HtmlGenericControl firstdiv = new HtmlGenericControl("div");
            firstdiv.Attributes.Add("class", "item-in-cart clearfix");
            panel_cart.Controls.Add(firstdiv);

            HtmlGenericControl divimg = new HtmlGenericControl("div");
            HtmlGenericControl img = new HtmlGenericControl("img");
            divimg.Attributes.Add("class", "image");
            img.Attributes.Add("src", (String)dr["img"]);
            img.Attributes.Add("width", "124");
            img.Attributes.Add("height", "124");
            img.Attributes.Add("alt", "cart item");
            divimg.Controls.Add(img);
            firstdiv.Controls.Add(divimg);// finsh div img

            HtmlGenericControl divdesc = new HtmlGenericControl("div");
            divdesc.Attributes.Add("class", "desc");
            HtmlGenericControl strongdesc = new HtmlGenericControl("strong");
            HtmlGenericControl astrongdesc = new HtmlGenericControl("a");
            astrongdesc.Attributes.Add("href", "product.aspx?id=" + (String)dr["id"]);
            astrongdesc.InnerText = (String)dr["name"];
            strongdesc.Controls.Add(astrongdesc);
            divdesc.Controls.Add(strongdesc);

            HtmlGenericControl spandesc = new HtmlGenericControl("span");
            spandesc.Attributes.Add("class", "light-clr qty");
            spandesc.InnerText = "تعداد :" + dr["number"].ToString();
            spandesc.Controls.Add(new LiteralControl("&nbsp;"));

            HtmlAnchor aspan = new HtmlAnchor();
            aspan.ID = "remove" + dr["id"].ToString();
            aspan.HRef = "#";
            aspan.Name = dr["id"].ToString();
            aspan.ServerClick += new System.EventHandler(Removecarton_Click);
            aspan.Attributes.Add("class", "icon-remove-sign");
            //aspan.Attributes.Add("onclick", "return remove_cart(this);");
            spandesc.Controls.Add(aspan);
            

            divdesc.Controls.Add(strongdesc);
            divdesc.Controls.Add(spandesc);
            firstdiv.Controls.Add(divdesc);// finsh div by class desc

            HtmlGenericControl divprice = new HtmlGenericControl("div");
            divprice.Attributes.Add("class", "price");
            HtmlGenericControl strongprice = new HtmlGenericControl("strong");
            strongprice.InnerText = String.Format("{0:#,##0}", (Int16)dr["number"] * int.Parse(dr["price"].ToString())) + " ریال  ";
            divprice.Controls.Add(strongprice);
            firstdiv.Controls.Add(divprice);// finsh div by class price
            Session["count_cart"] = (int.Parse(Session["count_cart"].ToString()) + (Int16)dr["number"]).ToString();
            Session["total_price_cart"] = int.Parse(Session["total_price_cart"].ToString()) + (Int16)dr["number"] * int.Parse(dr["price"].ToString());
        }
        }catch(Exception e){
            initi();
        }
       count_cart.InnerText = " (" + Session["count_cart"].ToString() + ")";
       total_price_cart.InnerText = String.Format("{0:#,##0}", Session["total_price_cart"]) + " ریال";
       total_price_in_cart.InnerText =String.Format("{0:#,##0}", (int.Parse(Session["total_price_cart"].ToString())+int.Parse(Session["send_price"].ToString()))) + " ریال";
       send_price.InnerText = String.Format("{0:#,##0}",Session["send_price"]) + " ریال";
    }

    protected void Removecarton_Click(object sender, EventArgs e)
    {
        //String nameOfControl = (sender as HtmlAnchor).Name.ToString();
        //count_cart.InnerText = nameOfControl;
        string id = (sender as HtmlAnchor).Name.ToString();
        DataTable cart = Session["cart"] as DataTable;
        foreach (DataRow dr in cart.Rows)
        {
            if (dr["id"].ToString().Equals(id))
            {
                Session["count_cart"] = (int.Parse(Session["count_cart"].ToString()) - (Int16)dr["number"]);
                Session["total_price_cart"] = (int.Parse(Session["total_price_cart"].ToString()) - ((Int16)dr["number"] * (int.Parse(dr["price"].ToString()))));
                dr.Delete();
                break;
            }
        }
        Session["cart"] = cart;
        update_cart();
    }

    public void hidepanel()
    {
        //cart_panel_all.Dispose();
        cart_panel_all.InnerHtml = "";
    }

    public void active_index(){
       index_active.Attributes.Add("class", "active");
    }

    public void active_shop()
    {
        shop_active.Attributes.Add("class", "dropdown active");
    }
    public void active_about()
    {
        about_active.Attributes.Add("class", "active");
    }
    public void active_contact()
    {
        contact_active.Attributes.Add("class", "active");
    }
    public void active_userpanel()
    {
        userpanel_active.Attributes.Add("class", "active");
    }

    public void set_register_error(string ErrorMessage)
    {
        logineErrorlable.Attributes.Add("class", "alert alert-danger in fade");
        logineErrorlable.InnerHtml = "<button data-dismiss=\"alert\" class=\"close\" type=\"button\">×</button>" + ErrorMessage;
        //logineErrorlable.InnerHtml += "";
        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", String.Format("call_modal('loginModal');"), true);
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        //Response.Write(DateTime.Now.ToLocalTime().ToString());
        Response.Redirect("shop.aspx");
        //ScriptManager.RegisterStartupScript(this, this.GetType(), "timeout", String.Format("call_modal('{0}');", "salam"), true);
        ScriptManager.RegisterStartupScript(this, this.GetType(), "LaunchServerSide", "$(function() { LoginFail(); });", true);
    }
}
