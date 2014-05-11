using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class searchproduct : System.Web.UI.Page
{
    static int i=0;
    static XDocument productlist;
    protected void Page_Load(object sender, EventArgs e)
    {
        string key = Request.QueryString["q"].ToString();       
        if(i==0){
                 productlist = XDocument.Load(Server.MapPath("~/App_Data/listproduct.xml"));
                 i++;
        }
        int Find=0;
        foreach (XElement el in productlist.Root.Elements())
        {
            if ((el.Element("name").Value.IndexOf(key, StringComparison.CurrentCultureIgnoreCase) >= 0))
            {
                Response.Write("<a href=product.aspx?id=" + el.Element("id").Value + ">" + el.Element("name").Value + "</a></br>");
                Find=1;
            }
               
        }
        if(Find==0){
            Response.Write("محصول مورد نظر در فروشگاه یافت نشد!");
            }

         
       // Response.Write("search:"+ Request.QueryString["q"]);
    }
}