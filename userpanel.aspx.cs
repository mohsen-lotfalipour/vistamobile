using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class userpanel : System.Web.UI.Page
{
    public DataTable dt_user = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        (this.Master as Main).active_userpanel();
        if (Session["login"] != null)
        {
            initpage();
            if (Request.QueryString["pass"] != null && Request.QueryString["pass"].Equals("true"))
            {
                set_message(" نام کاربری و پسورد شما با موفقیت تغییر یافت ", "success");
                Edit_Pass_show(sender, e);
            }
            if (Request.QueryString["change"] != null && Request.QueryString["change"].Equals("true"))
            {
                set_message(" اطلاعات شما با موفقیت تغییر یافت ", "success");
                edit_pass.Visible = false;
                order_detail.Visible = false;
            }
            else if (Request.QueryString["order"] != null && Request.QueryString["order"].Equals("true"))
            {
                order_detail_show(sender, e);
            }
            else
            {
                edit_pass.Visible = false;
                order_detail.Visible = false;
            }
        }
        else
        {
            Response.Redirect("index.aspx?login=true");
            
        }
        
    }
    protected void initpage()
    {

        usersUtility user = new usersUtility();
        dt_user = user.getUser(Session["login"].ToString());
        firstName.Value = dt_user.Rows[0]["f_name"].ToString();
        lastName.Value = dt_user.Rows[0]["l_name"].ToString();
        email.Value = dt_user.Rows[0]["email"].ToString();
        addr1.Value = dt_user.Rows[0]["address"].ToString();
        telephone.Value = dt_user.Rows[0]["phone"].ToString();
        mobile.Value = dt_user.Rows[0]["mobile"].ToString();
        company.Value = dt_user.Rows[0]["company"].ToString();
        zip.Value = dt_user.Rows[0]["zip_code"].ToString();
        ListItem ostan = ostan_id.Items.FindByValue(dt_user.Rows[0]["ostan"].ToString());
        ListItem defualt_ostan = ostan_id.Items[ostan_id.SelectedIndex];
        defualt_ostan.Selected = false;
        if (ostan == null)
        {
            ostan = defualt_ostan;
        }
        ostan.Selected = true;
        string str = "<script>city_selected('" + ostan.Value + "','" + dt_user.Rows[0]["city"].ToString() + "');</script>";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", str, false);

        //Response.Write("city "+city_id.DataValueField.ToString());

    }
    protected void Edit_Click(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            //update user in database
            if (dt_user.Rows[0]["email"].ToString().Equals(Request.Form["ctl00$MainContent$email"]))
            {
                usersUtility.update_user(dt_user.Rows[0]["id"].ToString(), Request.Form["ctl00$MainContent$firstName"], Request.Form["ctl00$MainContent$lastName"], Request.Form["ctl00$MainContent$telephone"], Request.Form["ctl00$MainContent$mobile"], Request.Form["ctl00$MainContent$ostan_id"], Request.Form["ctl00$MainContent$city_id"], Request.Form["ctl00$MainContent$addr1"], Request.Form["ctl00$MainContent$zip"], Request.Form["ctl00$MainContent$company"]);
                Response.Redirect("userpanel.aspx?change=true");
            }
            else
            {
                if (usersUtility.user_email_exist(Request.Form["ctl00$MainContent$email"]))
                {
                    set_message("این ایمیل قبلا در سیستم ثبت شده است ", "danger");
                }
                else
                {
                    usersUtility.update_user(dt_user.Rows[0]["id"].ToString(), Request.Form["ctl00$MainContent$firstName"], Request.Form["ctl00$MainContent$lastName"], Request.Form["ctl00$MainContent$telephone"], Request.Form["ctl00$MainContent$mobile"], Request.Form["ctl00$MainContent$ostan_id"], Request.Form["ctl00$MainContent$city_id"], Request.Form["ctl00$MainContent$addr1"], Request.Form["ctl00$MainContent$zip"], Request.Form["ctl00$MainContent$company"], Request.Form["ctl00$MainContent$email"]);
                    Response.Redirect("userpanel.aspx?change=true");
                }
            }
        }

    }

    protected void Edit_Pass_Click(object sender, EventArgs e)
    {
        if (Session["login"] != null)
        {
            //update user in database
            if (dt_user.Rows[0]["password"].ToString().Equals(usersUtility.GenerateHash(Request.Form["ctl00$MainContent$pass"])))
            {
                if (dt_user.Rows[0]["user_name"].ToString().Equals(Request.Form["ctl00$MainContent$user_name"]))
                {

                    usersUtility.update_user(dt_user.Rows[0]["id"].ToString(), Request.Form["ctl00$MainContent$new_pass"]);
                    set_message("پسورد شما با موفقیت تغییر یافت ", "success");
                    Edit_Pass_show(sender, e);

                }
                else
                {
                    if (usersUtility.user_login_exist(Request.Form["ctl00$MainContent$user_name"]))
                    {
                        set_message("این نام کاربری قبلا در سیستم ثبت شده است ", "danger");
                        Edit_Pass_show(sender, e);
                    }
                    else
                    {
                        usersUtility.update_user(dt_user.Rows[0]["id"].ToString(), Request.Form["ctl00$MainContent$new_pass"], Request.Form["ctl00$MainContent$user_name"]);
                        Session["login"] = Request.Form["ctl00$MainContent$user_name"];
                        Response.Redirect("userpanel.aspx?pass=true");

                    }
                }
            }
            else
            {
                set_message("پسورد قدیم اشتباه وارد شده است  ", "danger");
                Edit_Pass_show(sender, e);

            }

        }
    }
    protected void Edit_Pass_show(object sender, EventArgs e)
    {
        edit_user.Visible = false;
        edit_pass.Visible = true;
        order_detail.Visible = false;
        if (Session["login"] != null)
        {
            user_name.Value = dt_user.Rows[0]["user_name"].ToString();
        }
    }

    protected void order_detail_show(object sender, EventArgs e)
    {
        edit_user.Visible = false;
        edit_pass.Visible = false;
        order_detail.Visible = true;
        order or = new order();
        
        DataTable order_user = new DataTable();
        order_user = or.get_user_order(dt_user.Rows[0]["id"].ToString());
        int i = 0;
        foreach (DataRow dr in order_user.Rows)
        {
            HtmlGenericControl firstdiv = new HtmlGenericControl("div");
            if(i==0)
                firstdiv.Attributes.Add("class", "accordion-group accordion-style-2 active");
            else
                firstdiv.Attributes.Add("class", "accordion-group accordion-style-2");
            i++;
            HtmlGenericControl divheading = new HtmlGenericControl("div");
            divheading.Attributes.Add("class", "accordion-heading");

            HtmlGenericControl a_divheading = new HtmlGenericControl("a");
            a_divheading.Attributes.Add("class", "accordion-toggle");
            a_divheading.Attributes.Add("data-toggle", "collapse");
            a_divheading.Attributes.Add("data-parent", "#order_detail_toggle");
            a_divheading.Attributes.Add("href", "#" + dr["id"]);
            a_divheading.InnerHtml = " کد پیگیری  : " +dr["id"] +"-"+ "تاریخ سفارش  : "+ persian_date.Persian_date_toshamsi(dr["date"].ToString())+"-" + "وضعیت سفارش : " + dr["status"];
            HtmlGenericControl span_a_divheading = new HtmlGenericControl("span");
            span_a_divheading.Attributes.Add("class", "bg-for-icon");

            HtmlGenericControl imin_span_a_divheading = new HtmlGenericControl("i");
            imin_span_a_divheading.Attributes.Add("class", "icon-minus");

            HtmlGenericControl iplus_span_a_divheading = new HtmlGenericControl("i");
            iplus_span_a_divheading.Attributes.Add("class", "icon-plus");

            span_a_divheading.Controls.Add(imin_span_a_divheading);
            span_a_divheading.Controls.Add(iplus_span_a_divheading);

            a_divheading.Controls.Add(span_a_divheading);
            divheading.Controls.Add(a_divheading);

            HtmlGenericControl divcollapse = new HtmlGenericControl("div");
            divcollapse.Attributes.Add("class", "accordion-body collapse");
            divcollapse.Attributes.Add("id", ""+dr["id"].ToString());

            HtmlGenericControl divcollapse_inner = new HtmlGenericControl("div");
            divcollapse_inner.Attributes.Add("class", "accordion-inner");
           //divcollapse_inner.InnerText = "salam";
            order_detail_inner(divcollapse_inner, dr["id"].ToString(), dr["sendprice"].ToString(), dr["totalprice"].ToString());


            divcollapse.Controls.Add(divcollapse_inner);

            firstdiv.Controls.Add(divheading);
            firstdiv.Controls.Add(divcollapse);

            order_detail_toggle.Controls.Add(firstdiv);
        }

    }
    public void set_message(string Message, string type)
    {
        edit_error_label.Attributes.Add("class", "alert alert-" + type + " in fade");
        edit_error_label.InnerHtml = "<button data-dismiss=\"alert\" class=\"close\" type=\"button\">×</button>" + Message;
    }


    public void order_detail_inner(HtmlGenericControl divcollapse_inner, string order_id,string sendprice,string totalprice)
    {
        orderlist orlist = new orderlist();
        category cat = new category();
        brand brnd = new brand();
        DataTable product_order = orlist.get_product_order(order_id);
        products pro = new products();
        HtmlGenericControl table_order = new HtmlGenericControl("table");
        table_order.Attributes.Add("class", "table table-items");
        HtmlGenericControl table_head = new HtmlGenericControl("thead");
        HtmlGenericControl tr_table_head = new HtmlGenericControl("tr");

        HtmlGenericControl th_name_tr_table_head = new HtmlGenericControl("th");
        th_name_tr_table_head.Attributes.Add("colspan", "2");
        th_name_tr_table_head.InnerHtml = "مشخصات محصول";
        tr_table_head.Controls.Add(th_name_tr_table_head);

        HtmlGenericControl th_number_tr_table_head = new HtmlGenericControl("th");
        HtmlGenericControl div_th_number_tr_table_head = new HtmlGenericControl("div");
        div_th_number_tr_table_head.Attributes.Add("class", "align-center");
        div_th_number_tr_table_head.InnerText = "تعداد";
        th_number_tr_table_head.Controls.Add(div_th_number_tr_table_head);
        tr_table_head.Controls.Add(th_number_tr_table_head);

        HtmlGenericControl th_unitprice_tr_table_head = new HtmlGenericControl("th");
        HtmlGenericControl div_th_unitprice_tr_table_head = new HtmlGenericControl("div");
        div_th_unitprice_tr_table_head.Attributes.Add("class", "align-right");
        div_th_unitprice_tr_table_head.InnerText = "قیمت واحد";
        th_unitprice_tr_table_head.Controls.Add(div_th_unitprice_tr_table_head);
        tr_table_head.Controls.Add(th_unitprice_tr_table_head);

        HtmlGenericControl th_price_tr_table_head = new HtmlGenericControl("th");
        HtmlGenericControl div_th_price_tr_table_head = new HtmlGenericControl("div");
        div_th_price_tr_table_head.Attributes.Add("class", "align-right");
        div_th_price_tr_table_head.InnerText = "قیمت کل";
        th_price_tr_table_head.Controls.Add(div_th_price_tr_table_head);
        tr_table_head.Controls.Add(th_price_tr_table_head);


        table_head.Controls.Add(tr_table_head);
        table_order.Controls.Add(table_head);


        HtmlGenericControl table_body_order = new HtmlGenericControl("tbody");
        int total_price = 0;
        foreach (DataRow dr in product_order.Rows)
        {
            string catname = cat.getcategory(dr["cat_id"].ToString()).Rows[0]["name"].ToString();
            string brandname = brnd.getbrandbyid(dr["brand_id"].ToString()).Rows[0]["name"].ToString();
            DataTable pic = pro.getonepic(int.Parse(dr["product_id"].ToString()));
            HtmlGenericControl tr = new HtmlGenericControl("tr");
            HtmlGenericControl tdimg = new HtmlGenericControl("td");
            tdimg.Attributes.Add("class", "image");
            HtmlGenericControl img = new HtmlGenericControl("img");
            img.Attributes.Add("src", "images/Ppic/" + pic.Rows[0]["name"].ToString() + ".jpg");
            img.Attributes.Add("alt", "");
            img.Attributes.Add("width", "50");
            img.Attributes.Add("height", "50");
            tdimg.Controls.Add(img);
            tr.Controls.Add(tdimg);//finish td img

            HtmlGenericControl tddesc = new HtmlGenericControl("td");
            tddesc.Attributes.Add("class", "desc");
            tddesc.InnerText = catname + "-" + brandname + " - " +dr["name"].ToString();


            tr.Controls.Add(tddesc);//finish td by class desc

            HtmlGenericControl tdqty = new HtmlGenericControl("td");
            tdqty.Attributes.Add("class", "qty");
            HtmlGenericControl divnumber = new HtmlGenericControl("div");
            divnumber.Attributes.Add("class", "numbered");
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));
            //HtmlInputText input = new HtmlInputText();
            HtmlGenericControl input = new HtmlGenericControl("input");
            input.Attributes.Add("name", "input_number" + dr["id"].ToString());
            input.Attributes.Add("class", "tiny-size");
            input.Attributes.Add("value", dr["count"].ToString());
            input.Attributes.Add("type", "text");
            input.Attributes.Add("readonly", "readonly");
            input.Attributes.Add("id", "input_number" + dr["id"].ToString());
            divnumber.Controls.Add(input);//finish input
            tdqty.Controls.Add(divnumber);
            tr.Controls.Add(tdqty);//finish td by class qty

            HtmlGenericControl td_unit_price = new HtmlGenericControl("td");
            td_unit_price.Attributes.Add("class", "price");
            td_unit_price.InnerText = dr["price"].ToString()+ "  ریال  ";
            tr.Controls.Add(td_unit_price);//finish td price

            HtmlGenericControl tdprice = new HtmlGenericControl("td");
            tdprice.Attributes.Add("class", "price");
            tdprice.InnerText = ((Int32)dr["price"] * (Int16)dr["count"]).ToString() + "  ریال  ";
            tr.Controls.Add(tdprice);//finish td price
            table_body_order.Controls.Add(tr);
            total_price += (Int32)dr["price"] * (Int16)dr["count"];
        }


        HtmlGenericControl tr_send_price = new HtmlGenericControl("tr");
        HtmlGenericControl td_space = new HtmlGenericControl("td");
        td_space.Attributes.Add("colspan", "3");
        td_space.Attributes.Add("rowspan", "3");
        td_space.Controls.Add(new LiteralControl("&nbsp;"));
        tr_send_price.Controls.Add(td_space);

        HtmlGenericControl td_stronger_lable = new HtmlGenericControl("td");
        td_stronger_lable.Attributes.Add("class", "stronger");
        td_stronger_lable.InnerText = "هزينه ارسال :";
        tr_send_price.Controls.Add(td_stronger_lable);


        HtmlGenericControl td_stronger_price = new HtmlGenericControl("td");
        td_stronger_price.Attributes.Add("class", "stronger");
        HtmlGenericControl div_td_stronger_price = new HtmlGenericControl("div");
        div_td_stronger_price.Attributes.Add("class", "align-right");
        div_td_stronger_price.InnerText = sendprice + " ریال";
        td_stronger_price.Controls.Add(div_td_stronger_price);
        tr_send_price.Controls.Add(td_stronger_price);
        table_body_order.Controls.Add(tr_send_price);

        HtmlGenericControl tr_total_price = new HtmlGenericControl("tr");
        HtmlGenericControl td_stronger_lable_totalprice = new HtmlGenericControl("td");
        td_stronger_lable_totalprice.Attributes.Add("class", "stronger");
        td_stronger_lable_totalprice.InnerText = "جمع کل :";
        tr_total_price.Controls.Add(td_stronger_lable_totalprice);


        HtmlGenericControl td_stronger_totalprice = new HtmlGenericControl("td");
        td_stronger_totalprice.Attributes.Add("class", "stronger");
        HtmlGenericControl div_td_stronger_totalprice = new HtmlGenericControl("div");
        div_td_stronger_totalprice.Attributes.Add("class", "size-16 align-right");
        div_td_stronger_totalprice.InnerText = total_price + " ریال";
        td_stronger_totalprice.Controls.Add(div_td_stronger_totalprice);
        tr_total_price.Controls.Add(td_stronger_totalprice);
        table_body_order.Controls.Add(tr_total_price);


        table_order.Controls.Add(table_body_order);
        divcollapse_inner.Controls.Add(table_order);
    }
}