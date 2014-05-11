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


            string catname = cat.getcategory(dt.Rows[0]["cat_id"].ToString()).Rows[0]["name"].ToString();
            string brandname = brnd.getbrandbyid(dt.Rows[0]["brand_id"].ToString()).Rows[0]["name"].ToString();


            DataTable pname = pro.getpic(Convert.ToInt32(id));
            string picname = "";

            if (pname.Rows.Count != 0)
            {
                picname = ("images/Ppic/" + pname.Rows[0]["name"].ToString() + ".jpg");

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
        }
        else
        {
            Response.Redirect("shop.aspx");
        }
    }
}