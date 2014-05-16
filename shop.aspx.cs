using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using vistamobile.DAL;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class shop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        (this.Master as Main).active_shop();
        setproduct();
        setcategoryfilter();
        setbrandfilter();

    }

    public void setbrandfilter()
    {
        //<a href="#" data-target="s-oliver" data-type="brand" class="selectable detailed"><i class="box"></i> S. Oliver</a>
        brand br = new brand();
        DataTable dtbr = new DataTable();
        dtbr = br.getbrand();
        foreach (DataRow dr in dtbr.Rows)
        {
            HtmlGenericControl afilterbrand = new HtmlGenericControl("a");
            afilterbrand.Attributes.Add("href", "#");
            afilterbrand.Attributes.Add("data-target", "brand_id" + dr["id"]);
            afilterbrand.Attributes.Add("data-type", "brand");
            afilterbrand.Attributes.Add("class", "selectable detailed");

            afilterbrand.InnerHtml = "<i class=\"box\"></i>" + dr["name"].ToString();

            brand_filter.Controls.Add(afilterbrand);


        }

    }
    public void setcategoryfilter()
    {
        category cat = new category();
        DataTable dtcat = new DataTable();
        dtcat = cat.getcategory();
        //<a href="#" data-target=".filter--accessories" class="selectable"><i class="box"></i> لوازم شخصی</a>
        //filter_category.InnerHtml = "";
        foreach (DataRow dr in dtcat.Rows)
        {
            HtmlGenericControl afiltercat = new HtmlGenericControl("a");
            afiltercat.Attributes.Add("href", "#");
            afiltercat.Attributes.Add("data-target", ".filter--cat_id" + dr["id"]);
            afiltercat.Attributes.Add("class", "selectable");
            afiltercat.InnerHtml = "<i class=\"box\"></i>" + dr["name"].ToString();
            category_filter.Controls.Add(afiltercat);
        }
    }

    public void setproduct()
    {
        products pr = new products();
        DataTable dt = new DataTable();
        category cat = new category();
        brand brnd = new brand();

        if (Request.QueryString["cat_id"] == null && Request.QueryString["brand_id"] == null)
        {
            dt = pr.getproduct();
        }
        else if (Request.QueryString["cat_id"] != null && Request.QueryString["brand_id"] == null)
        {
            dt = pr.getproduct_cat(Request.QueryString["cat_id"].ToString());
            list_footer_menu.InnerHtml += "<li><span class=\"icon-chevron-left\"></span></li>";

            string cat_name = cat.getcategory(Request.QueryString["cat_id"].ToString()).Rows[0]["name"].ToString();
            list_footer_menu.InnerHtml += "<li><a href=\"shop.aspx?cat_id=" + Request.QueryString["cat_id"].ToString() + "\">" + cat_name + "</a> </li>";
            tourStep2.InnerHtml = "";
        }
        else if (Request.QueryString["cat_id"] == null && Request.QueryString["brand_id"] != null)
        {
            dt = pr.getproduct_brand(Request.QueryString["brand_id"].ToString());
            list_footer_menu.InnerHtml += "<li><span class=\"icon-chevron-left\"></span></li>";

            string brand_name = brnd.getbrandbyid(Request.QueryString["brand_id"].ToString()).Rows[0]["name"].ToString();
            list_footer_menu.InnerHtml += "<li><a href=\"shop.aspx?brand_id=" + Request.QueryString["brand_id"].ToString() + "\">" + brand_name + "</a> </li>";
            tourStep2.InnerHtml = "";

        }


        foreach (DataRow list in dt.Rows)
        {
            DataTable pname = pr.getonepic(Convert.ToInt32(list["id"]));
            string catname = cat.getcategory(list["cat_id"].ToString()).Rows[0]["name"].ToString();
            string brandname = brnd.getbrandbyid(list["brand_id"].ToString()).Rows[0]["name"].ToString();

            //Response.Write(catname);
            //Response.Write("-");
            //Response.Write(pname["name"].ToString());
            //Response.Write("-");

            HtmlGenericControl div = new HtmlGenericControl("div");
            // div.Attributes.Add("id", "p-item" + list["id"].ToString());
            div.Attributes.Add("class", "span3 filter--cat_id" + list["cat_id"]);
            div.Attributes.Add("data-price", list["price"].ToString());
            div.Attributes.Add("data-popularity", "2");
            div.Attributes.Add("data-size", "xs|s|m|xl");
            div.Attributes.Add("data-color", "pink");
            div.Attributes.Add("data-brand", "brand_id" + list["brand_id"].ToString());
            //div.Attributes.Add("runat", "server");


            HtmlGenericControl divproduct = new HtmlGenericControl("div");
            //div2.Attributes.Add("id", "p-item2-" + list["id"].ToString());
            divproduct.Attributes.Add("class", "product");


            HtmlGenericControl divproductimg = new HtmlGenericControl("div");
            // div3.Attributes.Add("id", "p-item3-" + list["id"].ToString());
            divproductimg.Attributes.Add("class", "product-img");


            HtmlGenericControl divpicture = new HtmlGenericControl("div");
            //div4.Attributes.Add("id", "p-item4-" + list["id"].ToString());
            divpicture.Attributes.Add("class", "picture");


            HtmlGenericControl imgpicture = new HtmlGenericControl("img");
            imgpicture.Attributes.Add("id", "p-img" + list["id"].ToString());
            //img1.Attributes.Add("runat", "server");
            imgpicture.Attributes.Add("width", "540");
            imgpicture.Attributes.Add("height", "374");
            imgpicture.Attributes.Add("alt", "");
            // img1.Attributes.Add("src", (Server.MapPath("~/images/Ppic/").ToString())+list["id"].ToString()+".jpg");
            //imgpicture.Attributes.Add("src", "images/Ppic/" + pname.Rows[0]["name"].ToString() + ".jpg");
            string picname = null;
            if (pname.Rows.Count != 0)
            {
                //imgpicture.Attributes.Add("src", "images/Ppic/" + pname.Rows[0]["name"].ToString() + ".jpg");
                picname = "images/Ppic/" + pname.Rows[0]["name"].ToString() + ".jpg";
            }
            else
            {
                //imgpicture.Attributes.Add("src", "images/Ppic/noimage.jpg");
                picname = "images/Ppic/noimage.jpg";
            }
            imgpicture.Attributes.Add("src", picname);

            divpicture.Controls.Add(imgpicture);

            HtmlGenericControl divimgoverlay = new HtmlGenericControl("div");
            //div5.Attributes.Add("id", "p-div5" + list["id"].ToString());
            divimgoverlay.Attributes.Add("class", "img-overlay");


            //HtmlGenericControl br1 = new HtmlGenericControl("br");
            //div2.Controls.Add(br1);

            HtmlGenericControl aimgoverlay = new HtmlGenericControl("a");
            ///a1.Attributes.Add("id", "a1" + list["id"].ToString());
            aimgoverlay.Attributes.Add("href", "product.aspx?id=" + list["id"].ToString());
            aimgoverlay.Attributes.Add("class", "btn more btn-primary");
            aimgoverlay.InnerText = "توضیحات بیشتر";
            divimgoverlay.Controls.Add(aimgoverlay);

            HtmlAnchor aimgoverlay2 = new HtmlAnchor();
            aimgoverlay2.ID = "addtocart" + list["id"].ToString();
            aimgoverlay2.HRef = "#";
            aimgoverlay2.Name = list["id"].ToString() + "," + list["price"].ToString() + "," + picname + "," + catname + " - " + brandname + " - " + list["name"].ToString();
            aimgoverlay2.ServerClick += new System.EventHandler(addtocart_click);
            aimgoverlay2.Attributes.Add("class", "btn buy btn-danger");
            aimgoverlay2.Attributes.Add("onclick", "addtocart('" + "p-img" + list["id"].ToString() + "');");
            aimgoverlay2.InnerText = "اضافه به سبد خرید";

            UpdatePanel up = new UpdatePanel();
            up.ContentTemplateContainer.Controls.Add(aimgoverlay2);
            divimgoverlay.Controls.Add(up);
            divimgoverlay.Controls.Add(aimgoverlay);
            //divimgoverlay.Controls.Add(aimgoverlay2);
            divpicture.Controls.Add(divimgoverlay);
            divproductimg.Controls.Add(divpicture);
            divproduct.Controls.Add(divproductimg);
            //HtmlGenericControl a2 = new HtmlGenericControl("a");
            //// a2.Attributes.Add("id", "a2" + list["id"].ToString());
            //a2.Attributes.Add("href", "#");
            //a2.Attributes.Add("class", "btn buy btn-danger");
            //
            //div5.Controls.Add(a2);

            //                    <!-- Sub Text -->  
            HtmlGenericControl divmaintitle = new HtmlGenericControl("div");
            // div6.Attributes.Add("id", "p-div6" + list["id"].ToString());
            divmaintitle.Attributes.Add("class", "main-titles no-margin");


            HtmlGenericControl h4maintitle = new HtmlGenericControl("h4");
            h4maintitle.Attributes.Add("class", "title");
            h4maintitle.InnerText = catname + " - " + brandname + " - " + list["name"].ToString();
            divmaintitle.Controls.Add(h4maintitle);

            HtmlGenericControl h5maintitle = new HtmlGenericControl("h5");
            h5maintitle.Attributes.Add("class", "no-margin isotope--title");
            h5maintitle.InnerText = String.Format("{0:#,##0}", list["price"]) + " ریال";
            divmaintitle.Controls.Add(h5maintitle);
            divproduct.Controls.Add(divmaintitle);
            div.Controls.Add(divproduct);
            isotopeContainer.Controls.Add(div);
        }

    }
    protected void chap(object sender, EventArgs e)
    {
        Response.Write("tset");
    }

    public void addtocart_click(object sender, EventArgs e)
    {
        string[] arg = (sender as HtmlAnchor).Name.ToString().Split(',');
        //Session["count_cart"] = (int.Parse(Session["count_cart"].ToString()) + 1).ToString();
        //Session["total_price_cart"] = (int.Parse(Session["total_price_cart"].ToString()) + int.Parse(arg[1]));
        DataTable cart = Session["cart"] as DataTable;
        Boolean exist = false;
        foreach (DataRow dr in cart.Rows)
        {
            if (dr["id"].Equals(arg[0]))// check product exist in cart
            {
                dr["number"] = (Int16)dr["number"] + 1;
                //dr["price"] = int.Parse(arg[1]) * (Int16)dr["number"];
                exist = true;
            }
        }
        if (!exist)
        {
            //arg[0]=id , arg[1]=price,  arg[2]=img ,arg[3]=name
            cart.Rows.Add(new object[] { arg[0], arg[1], arg[2], arg[3], 1 });
        }
        Session["cart"] = cart;
        (this.Master as Main).update_cart();
    }
}