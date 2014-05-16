using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using vistamobile.DAL;
using System.Data;
using System.Web.UI.HtmlControls;



public partial class product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        int i = 0;
        if (id != null)
        {
            category cat = new category();
            brand brnd = new brand();
            products pro = new products();
            DataTable dt = new DataTable();
            dt = pro.getproductbyid(Convert.ToInt16(id));
            string pro_name = dt.Rows[0]["name"].ToString();


            string catname = cat.getcategory(dt.Rows[0]["cat_id"].ToString()).Rows[0]["name"].ToString();
            string brandname = brnd.getbrandbyid(dt.Rows[0]["brand_id"].ToString()).Rows[0]["name"].ToString();


            DataTable pname = pro.getpic(Convert.ToInt32(id));
            string picname = "";

            if (pname.Rows.Count != 0)
            {
                picname = ("images/Ppic/" + pname.Rows[0]["name"].ToString() + ".jpg");

                HtmlGenericControl li_main = new HtmlGenericControl("li");
                HtmlAnchor a = new HtmlAnchor();
                a.Attributes.Add("href", "index.aspx");
                a.InnerText = "صفحه اصلی";
                li_main.Controls.Add(a);
                adres.Controls.Add(li_main);

                HtmlGenericControl li_shop_sp = new HtmlGenericControl("li");
                HtmlGenericControl a1_sp = new HtmlGenericControl("span");
                a1_sp.Attributes.Add("class", "icon-chevron-left");
                li_shop_sp.Controls.Add(a1_sp);
                adres.Controls.Add(li_shop_sp);



                HtmlGenericControl li_shop = new HtmlGenericControl("li");
                HtmlAnchor a2 = new HtmlAnchor();
                a2.Attributes.Add("href", "shop.aspx");
                a2.InnerText = "فروشگاه";
                li_shop.Controls.Add(a2);
                adres.Controls.Add(li_shop);


                HtmlGenericControl li_spliter2 = new HtmlGenericControl("li");
                HtmlGenericControl a_sp2 = new HtmlGenericControl("span");
                a_sp2.Attributes.Add("class", "icon-chevron-left");
                li_spliter2.Controls.Add(a_sp2);
                adres.Controls.Add(li_spliter2);


                HtmlGenericControl li_brand = new HtmlGenericControl("li");
                HtmlAnchor a4 = new HtmlAnchor();
                a4.Attributes.Add("href", "shop.aspx?brand_id=" + dt.Rows[0]["brand_id"].ToString());
                a4.InnerText = brandname;
                li_brand.Controls.Add(a4);
                adres.Controls.Add(li_brand);




                HtmlGenericControl li_spliter1 = new HtmlGenericControl("li");
                HtmlGenericControl a_sp = new HtmlGenericControl("span");
                a_sp.Attributes.Add("class", "icon-chevron-left");
                li_spliter1.Controls.Add(a_sp);
                adres.Controls.Add(li_spliter1);





                HtmlGenericControl li_cat = new HtmlGenericControl("li");
                HtmlAnchor a3 = new HtmlAnchor();
                a3.Attributes.Add("href", "shop.aspx?cat_id=" + dt.Rows[0]["cat_id"].ToString());
                a3.InnerText = catname;
                li_cat.Controls.Add(a3);
                adres.Controls.Add(li_cat);


                /*
                          <li><span class="icon-chevron-left"></span></li>
                          <li><a href="shop.aspx">فروشگاه</a> </li>
                          <li><span class="icon-chevron-left"></span></li>
                     
                  */


                //--------------------
                foreach (DataRow list in pname.Rows)
                {
                    HtmlGenericControl divimg = new HtmlGenericControl("div");
                    if (i == 0)
                    {
                        divimg.Attributes.Add("class", "thumb active");
                    }
                    else
                    {
                        divimg.Attributes.Add("class", "thumb");
                    }
                    imgroot.Controls.Add(divimg);
                    HtmlGenericControl an = new HtmlGenericControl("a");
                    an.Attributes.Add("href", "#MainContent_mainPreviewImg");
                    an.Attributes.Add("alt", "");
                    divimg.Controls.Add(an);
                    HtmlGenericControl pimg = new HtmlGenericControl("img");
                    pimg.Attributes.Add("alt", "");
                    pimg.Attributes.Add("width", "940");
                    pimg.Attributes.Add("height", "940");
                    pimg.Attributes.Add("src", "images/Ppic/" + list["name"].ToString() + ".jpg");
                    an.Controls.Add(pimg);
                    i++;
                }
            }
            //--------------------
            else
            {
                picname = ("images/Ppic/" + "noimage" + ".jpg");
                HtmlGenericControl divimg = new HtmlGenericControl("div");
                divimg.Attributes.Add("class", "thumb active");
                imgroot.Controls.Add(divimg);
                HtmlGenericControl an = new HtmlGenericControl("a");
                an.Attributes.Add("href", "#MainContent_mainPreviewImg");
                an.Attributes.Add("alt", "");
                divimg.Controls.Add(an);
                HtmlGenericControl pimg = new HtmlGenericControl("img");
                pimg.Attributes.Add("alt", "");
                pimg.Attributes.Add("width", "940");
                pimg.Attributes.Add("height", "940");
                pimg.Attributes.Add("src", picname);
                an.Controls.Add(pimg);
            }


            mainPreviewImg.Src = (picname);

            product_detail.InnerText = dt.Rows[0]["detail"].ToString();
            product_price.InnerText = string.Format("{0:#,##0}", dt.Rows[0]["price"]) + " ریال";
            product_name.InnerText = catname + " " + brandname + " " + dt.Rows[0]["name"].ToString();

            HtmlGenericControl span_status = new HtmlGenericControl("span_status");


            if ((Int16.Parse(dt.Rows[0]["movjodi"].ToString())) >= 5)
            {
                span_status.Attributes.Add("class", "btn btn-success");
                span_status.InnerText = "موجود";
            }
            else if ((Int16.Parse(dt.Rows[0]["movjodi"].ToString())) >= 1)
            {
                span_status.Attributes.Add("class", "btn btn-warning");
                span_status.InnerText = "تماس بگیرید";
            }
            else
            {
                span_status.Attributes.Add("class", "btn btn-danger");
                span_status.InnerText = "اتمام موجودی";
            }

            product_status.Controls.Add(span_status);




            //foreach (DataRow list in pname.Rows)
            //{
            //    HtmlGenericControl divimg = new HtmlGenericControl("div");
            //    if (i == 0)
            //    {
            //        divimg.Attributes.Add("class", "thumb active");
            //    }
            //    else
            //    {
            //        divimg.Attributes.Add("class", "thumb");
            //    }
            //    imgroot.Controls.Add(divimg);

            //    HtmlGenericControl an = new HtmlGenericControl("a");
            //    an.Attributes.Add("href", "#MainContent_mainPreviewImg");
            //    an.Attributes.Add("alt", "");
            //    divimg.Controls.Add(an);

            //    HtmlGenericControl pimg = new HtmlGenericControl("img");
            //    pimg.Attributes.Add("alt", "");
            //    pimg.Attributes.Add("width", "940");
            //    pimg.Attributes.Add("height", "940");
            //    pimg.Attributes.Add("src", "images/Ppic/" + list["name"].ToString() + ".jpg");
            //    an.Controls.Add(pimg);
            //    i++;

            //}
            set_related(pro_name, id);
        }
        else
        {
            Response.Redirect("shop.aspx");
        }
    }

    

    public void set_related(string name, string id)
    {
        related.InnerHtml = "";
        products p = new products();
        DataTable dt = new DataTable();
        category cat = new category();
        brand brnd = new brand();
        string picname = null;
        // string brandname = null;

        dt = p.getproduct_related_top(name, id); ;
        int i = 0;
        HtmlGenericControl divslide = null;
        HtmlGenericControl divrow = null;
        if (dt.Rows.Count > 0)
        {
            //<div class="arrows">
            //            <a href="#" class="icon-chevron-right" id="featuredItemsRight"></a><a href="#" class="icon-chevron-left"
            //                id="featuredItemsLeft"></a>
            //        </div>


            HtmlGenericControl h = new HtmlGenericControl("h2");
            h.Attributes.Add("class", "title");

            HtmlGenericControl span = new HtmlGenericControl("span");
            span.Attributes.Add("class", "light");
            span.InnerText = "محصولات مرتبط";

            HtmlGenericControl divarrow = new HtmlGenericControl("div");
            divarrow.Attributes.Add("class", "arrows");

            HtmlGenericControl a_right_divarrow = new HtmlGenericControl("a");
            a_right_divarrow.Attributes.Add("class", "icon-chevron-right");
            a_right_divarrow.Attributes.Add("id", "featuredItemsRight");
            a_right_divarrow.Attributes.Add("href", "#");
            a_right_divarrow.ClientIDMode = ClientIDMode.Static;
            divarrow.Controls.Add(a_right_divarrow);

            HtmlGenericControl a_left_divarrow = new HtmlGenericControl("a");
            a_left_divarrow.Attributes.Add("class", "icon-chevron-left");
            a_left_divarrow.Attributes.Add("id", "featuredItemsLeft");
            a_left_divarrow.Attributes.Add("href", "#");
            a_left_divarrow.ClientIDMode = ClientIDMode.Static;
            divarrow.Controls.Add(a_left_divarrow);


            h.Controls.Add(span);

            title.Controls.Add(h);
            title.Controls.Add(divarrow);
        }
      

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
                related.Controls.Add(divslide);
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

    //<div class="span3">
    //            <div class="product">
    //                <div class="product-img">
    //                    <div class="picture">
    //                        <img src="images/dummy/products/product-4.jpg" alt="" width="540" height="374" />
    //                        <div class="img-overlay">
    //                            <a href="#" class="btn more btn-primary">توضیحات بیشتر</a> <a href="#" class="btn buy btn-danger">
    //                                اضافه به سبد خرید</a>
    //                        </div>
    //                    </div>
    //                </div>
    //                <div class="main-titles no-margin">
    //                    <h4 class="title">
    //                        <span class="striked">10000 تومان</span> <span class="red-clr">5000 تومان</span></h4>
    //                    <h5 class="no-margin">
    //                        کاترپیلار 552</h5>
    //                </div>
    //                <p class="desc">
    //                    توضیحاتی که در مورد محصول لازم است را در اینجا مینویسید</p>
    //                <p class="center-align stars">
    //                    <span class="icon-star stars-clr"></span><span class="icon-star stars-clr"></span>
    //                    <span class="icon-star stars-clr"></span><span class="icon-star stars-clr"></span>
    //                    <span class="icon-star"></span>
    //                </p>
    //            </div>
    //        </div>
    //        <!-- /product -->


}
