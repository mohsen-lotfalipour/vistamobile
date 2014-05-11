using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class checkout_step_4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //(this.Master as Main).hidepanel();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "timeout", String.Format("disable_remove();"), true);
        table_body_final.InnerHtml = "";
        total_price_final.InnerText = "0 ریال";
        int total_price = 0;
        DataTable cart = Session["cart"] as DataTable;
        foreach (DataRow dr in cart.Rows)
        {
            HtmlGenericControl tr = new HtmlGenericControl("tr");
            HtmlGenericControl tdimg = new HtmlGenericControl("td");
            tdimg.Attributes.Add("class", "image");
            HtmlGenericControl img = new HtmlGenericControl("img");
            img.Attributes.Add("src", dr["img"].ToString());
            img.Attributes.Add("alt", "");
            img.Attributes.Add("width", "124");
            img.Attributes.Add("height", "124");
            tdimg.Controls.Add(img);
            tr.Controls.Add(tdimg);//finish td img

            HtmlGenericControl tddesc = new HtmlGenericControl("td");
            tddesc.Attributes.Add("class", "desc");
            tddesc.InnerText = dr["name"].ToString();


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
            input.Attributes.Add("value", dr["number"].ToString());
            input.Attributes.Add("type", "text");
            input.Attributes.Add("readonly", "readonly");
            input.Attributes.Add("id", "input_number" + dr["id"].ToString());
            divnumber.Controls.Add(input);//finish input
            tdqty.Controls.Add(divnumber);
            tr.Controls.Add(tdqty);//finish td by class qty

            HtmlGenericControl tdprice = new HtmlGenericControl("td");
            tdprice.Attributes.Add("class", "price");
            tdprice.InnerText = ((Int32)dr["price"] * (Int16)dr["number"]).ToString() + "  ریال  ";
            tr.Controls.Add(tdprice);//finish td price
            table_body_final.Controls.Add(tr);
            total_price += (Int32)dr["price"] * (Int16)dr["number"];
        }
        send_price_final.InnerText = Session["send_price"].ToString();
        total_price_final.InnerText = (total_price + int.Parse(Session["send_price"].ToString())).ToString() + "  ریال  ";
    }
}