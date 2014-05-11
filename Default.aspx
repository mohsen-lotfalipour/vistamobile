<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

<html xmlns="http://www.w3.org/1999/xhtml" > 

<head>
    <title> HtmlAnchor ServerClick Event Example </title>
<script runat="server">

      void Page_Load(Object sender, EventArgs e)
      {

         // Create an EventHandler delegate for the method you want to handle the event 
         // and then add it to the list of methods called when the event is raised.
         AnchorButton.ServerClick += new System.EventHandler(this.HtmlAnchor_Click);

      }

      void HtmlAnchor_Click(Object sender, EventArgs e)
      {

         Message.InnerHtml = "Thank you for clicking the HtmlAnchor control.";

      }

   </script>

</head>

<body>
      <h3> HtmlAnchor ServerClick Event Example </h3>
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
      <a id="AnchorButton"
         runat="server">

         Click Here
             
      </a>

      <br /><br />
        </ContentTemplate>
   </asp:UpdatePanel>
   <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
             <span id="Message" runat="server"/>
         </ContentTemplate>
    </asp:UpdatePanel>
   </form>

</body>
</html>

</asp:Content>
