using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Globalization;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        (this.Master as Main).active_index();
        set_featuredItems();
        set_newproduct();
    }
    public void set_featuredItems()
    {
        featuredItems.InnerHtml = "";
        products p = new products();
        DataTable dt = new DataTable();
        category cat = new category();
        brand brnd = new brand();
        string picname = null;
       // string brandname = null;

        dt = p.getproduct_feature();
        int i = 0;
        HtmlGenericControl divslide = null;
        HtmlGenericControl divrow = null;

        foreach (DataRow dr in dt.Rows)
        {

            if (i % 3 == 0)
            {
                divslide = new HtmlGenericControl("div");
                divslide.Attributes.Add("class", "slide");
                divrow = new HtmlGenericControl("div");
                divrow.Attributes.Add("class", "row");
            }

            string catname = cat.getcategory(dr["cat_id"].ToString()).Rows[0]["name"].ToString();
            string brandname = brnd.getbrandbyid(dr["brand_id"].ToString()).Rows[0]["name"].ToString();


            DataTable pname = p.getonepic(Convert.ToInt32(dr["id"]));
            HtmlGenericControl divspan4 = new HtmlGenericControl("div");
            divspan4.Attributes.Add("class", "span4");

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

            HtmlGenericControl divproduct = new HtmlGenericControl("div");
            divproduct.Attributes.Add("class", "product");


            HtmlGenericControl divproductimg = new HtmlGenericControl("div");
            divproductimg.Attributes.Add("class", "product-img featured");


            HtmlGenericControl divpicture = new HtmlGenericControl("div");
            divpicture.Attributes.Add("class", "picture");


            HtmlGenericControl imgpicture = new HtmlGenericControl("img");
            imgpicture.Attributes.Add("id", "p-img-f" + dr["id"].ToString());
            //img1.Attributes.Add("runat", "server");
            imgpicture.Attributes.Add("width", "518");
            imgpicture.Attributes.Add("height", "358");
            imgpicture.Attributes.Add("alt", "");

            imgpicture.Attributes.Add("src", picname);
            divpicture.Controls.Add(imgpicture);


            HtmlGenericControl divimgoverlay = new HtmlGenericControl("div");
            divimgoverlay.Attributes.Add("class", "img-overlay");


            HtmlGenericControl aimgoverlay = new HtmlGenericControl("a");
            aimgoverlay.Attributes.Add("href", "product.aspx?id=" + dr["id"].ToString());
            aimgoverlay.Attributes.Add("class", "btn more btn-primary");
            aimgoverlay.InnerText = "توضیحات بیشتر";
            divimgoverlay.Controls.Add(aimgoverlay);





            HtmlAnchor aimgoverlay2 = new HtmlAnchor();
            aimgoverlay2.ID = "addtocart" + dr["id"].ToString();
            aimgoverlay2.HRef = "#";
            aimgoverlay2.Name = dr["id"].ToString() + "," + dr["price"].ToString() + "," + picname + "," + catname + " - " + brandname + " - " + dr["name"].ToString();
            aimgoverlay2.ServerClick += new System.EventHandler(Addcart_Click);
            aimgoverlay2.Attributes.Add("class", "btn buy btn-danger");
            aimgoverlay2.Attributes.Add("onclick", "addtocart('" + "p-img-f" + dr["id"].ToString() + "');");
            aimgoverlay2.InnerText = "اضافه به سبد خرید";

            UpdatePanel up = new UpdatePanel();
            up.ContentTemplateContainer.Controls.Add(aimgoverlay2);
            divimgoverlay.Controls.Add(up);
            divimgoverlay.Controls.Add(aimgoverlay);
            divpicture.Controls.Add(divimgoverlay);
            divproductimg.Controls.Add(divpicture);
            divproduct.Controls.Add(divproductimg);

            HtmlGenericControl divmaintitle = new HtmlGenericControl("div");
            divmaintitle.Attributes.Add("class", "main-titles");


            HtmlGenericControl h4maintitle = new HtmlGenericControl("h4");
            h4maintitle.Attributes.Add("class", "title");
            h4maintitle.InnerText = catname + "-" + brandname + " - " + dr["name"].ToString();
            divmaintitle.Controls.Add(h4maintitle);

            HtmlGenericControl h5maintitle = new HtmlGenericControl("h5");
            h5maintitle.Attributes.Add("class", "no-margin");
            h5maintitle.InnerText = String.Format("{0:#,##0}", dr["price"]) + " ریال"; //int.Parse(dr["price"].ToString()).ToString("N1",CultureInfo.InvariantCulture);
            divmaintitle.Controls.Add(h5maintitle);
            divproduct.Controls.Add(divmaintitle);

            HtmlGenericControl pdesc = new HtmlGenericControl("p");
            pdesc.Attributes.Add("class", "desc");
            pdesc.InnerText = dr["detail"].ToString();
            divproduct.Controls.Add(pdesc);

            divspan4.Controls.Add(divproduct);


            if (i % 3 < 3)
            {
                divrow.Controls.Add(divspan4);
                divslide.Controls.Add(divrow);

            }
            if (i % 3 == 2 || (i + 1) == dt.Rows.Count)
            {
                featuredItems.Controls.Add(divslide);
            }
            i++;

        }

    }
    public void set_newproduct()
    {
        category cat = new category();
        brand brnd = new brand();
        string picname = null;
      
        new_product.InnerHtml = "";
        products p = new products();
        DataTable dt = new DataTable();
        dt = p.getproduct_new();
        int i = 0;

        foreach (DataRow dr in dt.Rows)
        {

            DataTable pname = p.getonepic(Convert.ToInt32(dr["id"]));
            HtmlGenericControl divspan3 = new HtmlGenericControl("div");
            divspan3.Attributes.Add("class", "span3");

            if (pname.Rows.Count != 0)
            {
                 picname = "images/Ppic/" + pname.Rows[0]["name"].ToString() + ".jpg";
            }
            else
            {
                 picname = "images/Ppic/noimage.jpg";
            }

            string catname = cat.getcategory(dr["cat_id"].ToString()).Rows[0]["name"].ToString();
            string brandname = brnd.getbrandbyid(dr["brand_id"].ToString()).Rows[0]["name"].ToString();

            HtmlGenericControl divproduct = new HtmlGenericControl("div");
            divproduct.Attributes.Add("class", "product");

            HtmlGenericControl divproductimg = new HtmlGenericControl("div");
            divproductimg.Attributes.Add("class", "product-img");

            HtmlGenericControl divpicture = new HtmlGenericControl("div");
            divpicture.Attributes.Add("class", "picture");

            HtmlGenericControl imgpicture = new HtmlGenericControl("img");
            imgpicture.Attributes.Add("id", "p-img-new" + dr["id"].ToString());
            imgpicture.Attributes.Add("width", "540");
            imgpicture.Attributes.Add("height", "374");
            imgpicture.Attributes.Add("alt", "");
            imgpicture.Attributes.Add("src", picname);
            divpicture.Controls.Add(imgpicture);

            HtmlGenericControl divimgoverlay = new HtmlGenericControl("div");
            divimgoverlay.Attributes.Add("class", "img-overlay");


            HtmlGenericControl aimgoverlay = new HtmlGenericControl("a");
            aimgoverlay.Attributes.Add("href", "product.aspx?id=" + dr["id"].ToString());
            aimgoverlay.Attributes.Add("class", "btn more btn-primary");
            aimgoverlay.InnerText = "توضیحات بیشتر";
            divimgoverlay.Controls.Add(aimgoverlay);



            HtmlAnchor aimgoverlay2 = new HtmlAnchor();
            aimgoverlay2.ID = "addtocart" + dr["id"].ToString();
            aimgoverlay2.HRef = "#";
            aimgoverlay2.Name = dr["id"].ToString() + "," + dr["price"].ToString() + "," + picname + "," + catname + " - " + brandname + " - " + dr["name"].ToString();
            aimgoverlay2.ServerClick += new System.EventHandler(Addcart_Click);
            aimgoverlay2.Attributes.Add("class", "btn buy btn-danger");
            aimgoverlay2.Attributes.Add("onclick", "addtocart('" + "p-img-new" + dr["id"].ToString() + "');");
            aimgoverlay2.InnerText = "اضافه به سبد خرید";

            UpdatePanel up = new UpdatePanel();
            up.ContentTemplateContainer.Controls.Add(aimgoverlay2);
            divimgoverlay.Controls.Add(up);
            divimgoverlay.Controls.Add(aimgoverlay);
            divpicture.Controls.Add(divimgoverlay);
            divproductimg.Controls.Add(divpicture);
            divproduct.Controls.Add(divproductimg);

            HtmlGenericControl divmaintitle = new HtmlGenericControl("div");
            divmaintitle.Attributes.Add("class", "main-titles no-margin");


            HtmlGenericControl h4maintitle = new HtmlGenericControl("h4");
            h4maintitle.Attributes.Add("class", "title");
            h4maintitle.InnerText = catname + " - " + brandname + " - " +dr["name"].ToString();
            divmaintitle.Controls.Add(h4maintitle);

            HtmlGenericControl h5maintitle = new HtmlGenericControl("h5");
            h5maintitle.Attributes.Add("class", "no-margin");
            h5maintitle.InnerText = String.Format("{0:#,##0}", dr["price"]) + " ریال"; //int.Parse(dr["price"].ToString()).ToString("N1",CultureInfo.InvariantCulture);
            divmaintitle.Controls.Add(h5maintitle);
            divproduct.Controls.Add(divmaintitle);

            HtmlGenericControl pdesc = new HtmlGenericControl("p");
            pdesc.Attributes.Add("class", "desc");
            pdesc.InnerText = dr["detail"].ToString();
            divproduct.Controls.Add(pdesc);

            divspan3.Controls.Add(divproduct);

            new_product.Controls.Add(divspan3);
            if (i != 0 && i % 3 == 0)
            {
                HtmlGenericControl divclearfix = new HtmlGenericControl("div");
                divclearfix.Attributes.Add("class", "clearfix");
                new_product.Controls.Add(divclearfix);
            }
            i++;

        }
    }

    protected void Addcart_Click(object sender, EventArgs e)
    {

        //Message.InnerHtml += (int.Parse(Session["count_cart"].ToString()) + 1).ToString();
        //ScriptManager.RegisterStartupScript(this, this.GetType(), "timeout", String.Format("Func('{0}');", myLinkButton), true);
        string[] arg = (sender as HtmlAnchor).Name.ToString().Split(',');
        // Session["count_cart"] = (int.Parse(Session["count_cart"].ToString()) + 1).ToString();
        // Session["total_price_cart"] = (int.Parse(Session["total_price_cart"].ToString())+int.Parse(arg[1]));
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