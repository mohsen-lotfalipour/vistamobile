<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="Admin_Manage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" DataSourceID="EntityDataSource1">
            <Columns>
                <asp:CommandField CancelText="انصراف" DeleteText="حذف" EditText="ویرایش" 
                    HeaderText="ویرایش" ShowDeleteButton="True" ShowEditButton="True" 
                    UpdateText="ثبت" />
            </Columns>
        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
            ConnectionString="name=mobile_hardwareEntities" 
            DefaultContainerName="mobile_hardwareEntities" EnableDelete="True" 
            EnableFlattening="False" EnableInsert="True" EnableUpdate="True" 
            EntitySetName="brands">
        </asp:EntityDataSource>
    
    </div>
    </form>
</body>
</html>
