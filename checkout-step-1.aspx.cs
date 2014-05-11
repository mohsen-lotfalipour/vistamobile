using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;

public partial class checkout_step_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        (this.Master as Main).hidepanel();
        pageinit(true);

    }
    public void pageinit(bool first)
    {
       table_body.InnerHtml = "";
       total_price_review.InnerText = "0 ریال";
        int total_price =0;
        DataTable cart = Session["cart"] as DataTable;
        foreach (DataRow dr in cart.Rows)
        {

            //UpdatePanel upasli = new UpdatePanel();
            //upasli.ID = "updatepanelasli";

            HtmlGenericControl tr = new HtmlGenericControl("tr");
            tr.Attributes.Add("id", "tr"+dr["id"].ToString());
            HtmlGenericControl tdimg = new HtmlGenericControl("td");
            tdimg.Attributes.Add("class", "image");
            HtmlGenericControl img = new HtmlGenericControl("img");
            img.Attributes.Add("src", dr["img"].ToString());
            img.Attributes.Add("alt", "");
            img.Attributes.Add("width", "124");
            img.Attributes.Add("height", "124");
            tdimg.Controls.Add(img);
            tr.Controls.Add(tdimg);//finish td img
            //upasli.ContentTemplateContainer.Controls.Add(tdimg);
            
            HtmlGenericControl tddesc = new HtmlGenericControl("td");
            tddesc.Attributes.Add("class", "desc");
            tddesc.InnerText = dr["name"].ToString();


            HtmlAnchor adesc = new HtmlAnchor();
            //adesc.ID = "remove" + dr["id"].ToString();
            adesc.ID = "removetable" + dr["id"].ToString();
            adesc.HRef = "#";
            adesc.Name = dr["id"].ToString();
            adesc.Title = "حذف";
            adesc.ServerClick += new System.EventHandler(Removecarton_Click);
            adesc.Attributes.Add("class", "icon-remove-sign");
            tddesc.Controls.Add(new LiteralControl("&nbsp;"));
            tddesc.Controls.Add(new LiteralControl("&nbsp;")); 
            //UpdatePanel up = new UpdatePanel();
            //up.ContentTemplateContainer.Controls.Add(adesc);
            //tddesc.Controls.Add(up);
            tddesc.Controls.Add(adesc);
            //upasli.ContentTemplateContainer.Controls.Add(tddesc);
            //tr.Controls.Add(upasli);
           tr.Controls.Add(tddesc);//finish td by class desc

            HtmlGenericControl tdqty = new HtmlGenericControl("td");
            tdqty.Attributes.Add("class", "qty");
            tdqty.Attributes.Add("id", "qty" + dr["id"].ToString());

            HtmlGenericControl divnumber = new HtmlGenericControl("div");
            divnumber.Attributes.Add("class", "numbered");
            if (!first)
            {
                Response.Write("number");
                var dictionary = set_number();
                if (dictionary.Count !=0 && dictionary["input_number" + dr["id"].ToString()] != null)
                {
                    dr["number"] = dictionary["input_number" + dr["id"].ToString()];
                }
            }
            divnumber.Attributes.Add("id", "numbered"+dr["id"].ToString());

            HtmlGenericControl spanadd = new HtmlGenericControl("span");
            spanadd.Attributes.Add("class", "clickable add-one icon-plus-sign-alt");
            //spanadd.Attributes.Add("onclick", "number2();");
            divnumber.Controls.Add(spanadd);
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));

            HtmlGenericControl spandiff = new HtmlGenericControl("span");
            spandiff.Attributes.Add("class", "clickable remove-one icon-minus-sign-alt");
            //spanadd.Attributes.Add("onclick", "number2();");
            divnumber.Controls.Add(spandiff);
            divnumber.Controls.Add(new LiteralControl("&nbsp;"));

            //HtmlInputText input = new HtmlInputText();
           HtmlGenericControl input = new HtmlGenericControl("input");
            //TextBox input = new TextBox();
            input.Attributes.Add("name", "input_number" + dr["id"].ToString());
            input.Attributes.Add("class", "tiny-size");
            input.Attributes.Add("value", dr["number"].ToString());
            input.Attributes.Add("type", "text");
            input.Attributes.Add("readonly", "readonly");
            input.Attributes.Add("id", "input_number" + dr["id"].ToString());
            //input.ID = "input_number" + dr["id"].ToString();
            input.ClientIDMode = ClientIDMode.Static;
            input.EnableViewState = true;
            //input.AutoPostBack = true;
            //input.CausesValidation = true;
            //panel_table.Page.Controls.Add(input);
           // PostBackTrigger trigAsynPostback = new PostBackTrigger();
            //trigAsynPostback.ControlID = "input_number" + dr["id"].ToString();
            //trigAsynPostback.EventName = "Click";
            //panel_table.Triggers.Add(trigAsynPostback);
            //panel_table.ContentTemplateContainer.Controls.Add(input);
            //input.Name = "input_number" + dr["id"].ToString();
            //input.ID = "number" + dr["id"].ToString();
           // input.ServerChange += new EventHandler(Number_Change);
            divnumber.Controls.Add(input);//finish input
            tdqty.Controls.Add(divnumber);
            tr.Controls.Add(tdqty);//finish td by class qty

           HtmlGenericControl tdprice = new HtmlGenericControl("td");
           tdprice.Attributes.Add("class","price");
           tdprice.InnerText = ((Int32)dr["price"] * (Int16)dr["number"]).ToString()+ "  ریال  ";
           //UpdatePanel up = new UpdatePanel();
         // up.ContentTemplateContainer.Controls.Add(tdprice);
          // tr.Controls.Add(up);
           tr.Controls.Add(tdprice);//finish td price
           table_body.Controls.Add(tr);
          
           total_price += (Int32)dr["price"] * (Int16)dr["number"];
        }
        send_price_review.InnerText = Session["send_price"].ToString();
        total_price_review.InnerText = (total_price + int.Parse(Session["send_price"].ToString())).ToString() + "  ریال  ";
    }
    protected void Removecarton_Click(object sender, EventArgs e)
    {
        //ScriptManager.RegisterStartupScript(this, this.GetType(), "timeout", String.Format("fixtotalprice('{0}');", "00000"), true);
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
        pageinit(false);
        //(this.Master as Main).update_cart();

    }
    protected void Acceptcart_Click(object sender, EventArgs e)
    {
    //    System.Web.UI.ScriptManager.RegisterStartupScript(this, this.GetType(), "JCall1", sb.ToString(), false);
        //ScriptManager.RegisterStartupScript(this, this.GetType(), "timeout", "disable_remove", true);
        DataTable cart = Session["cart"] as DataTable;

        foreach (DataRow dr in cart.Rows)
        {
            string number = Request.Form["input_number" + dr["id"].ToString()];
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "timeout", String.Format("set_number('{0}');", "input_number" + dr["id"].ToString()), true);
            if (number != null)
                dr["number"] = number;
            else
            {
                var dictionary = set_number();
                dr["number"] = dictionary["input_number" + dr["id"].ToString()];
            }
           // Response.Write("dic" + dr["id"].ToString()+ ":" + dictionary["input_number" + dr["id"].ToString()]);
        }
        Session["cart"] = cart;
        (this.Master as Main).update_cart();
       

       //Response.Write(hdnfldVariable.Value);
       
        Response.Redirect("checkout-step-2.aspx");

    }

    public Dictionary<string,string> set_number(){
        string[] text = hdnfldVariable.Value.ToString().Split(',');
        var dictionary = new Dictionary<string, string>();
        foreach (string s in text)
        {
            if (s != "")
            {
                dictionary.Add(s.Split('=')[0], s.Split('=')[1]);//id and number
            }

        }
        return dictionary;
    }
}