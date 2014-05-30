<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Admin_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mobile_hardwareConnectionString %>"
            SelectCommand="SELECT * FROM [product]" 
            ConflictDetection="CompareAllValues" 
            DeleteCommand="DELETE FROM [product] WHERE [id] = @original_id AND [name] = @original_name AND (([movjodi] = @original_movjodi) OR ([movjodi] IS NULL AND @original_movjodi IS NULL)) AND [price] = @original_price AND (([detail] = @original_detail) OR ([detail] IS NULL AND @original_detail IS NULL)) AND [cat_id] = @original_cat_id AND [brand_id] = @original_brand_id AND (([status] = @original_status) OR ([status] IS NULL AND @original_status IS NULL))" 
            InsertCommand="INSERT INTO [product] ([name], [movjodi], [price], [detail], [cat_id], [brand_id], [status]) VALUES (@name, @movjodi, @price, @detail, @cat_id, @brand_id, @status)" 
            OldValuesParameterFormatString="original_{0}" 
            UpdateCommand="UPDATE [product] SET [name] = @name, [movjodi] = @movjodi, [price] = @price, [detail] = @detail, [cat_id] = @cat_id, [brand_id] = @brand_id, [status] = @status WHERE [id] = @original_id AND [name] = @original_name AND (([movjodi] = @original_movjodi) OR ([movjodi] IS NULL AND @original_movjodi IS NULL)) AND [price] = @original_price AND (([detail] = @original_detail) OR ([detail] IS NULL AND @original_detail IS NULL)) AND [cat_id] = @original_cat_id AND [brand_id] = @original_brand_id AND (([status] = @original_status) OR ([status] IS NULL AND @original_status IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_movjodi" Type="Int32" />
                <asp:Parameter Name="original_price" Type="Int32" />
                <asp:Parameter Name="original_detail" Type="String" />
                <asp:Parameter Name="original_cat_id" Type="Int32" />
                <asp:Parameter Name="original_brand_id" Type="Int32" />
                <asp:Parameter Name="original_status" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="movjodi" Type="Int32" />
                <asp:Parameter Name="price" Type="Int32" />
                <asp:Parameter Name="detail" Type="String" />
                <asp:Parameter Name="cat_id" Type="Int32" />
                <asp:Parameter Name="brand_id" Type="Int32" />
                <asp:Parameter Name="status" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="movjodi" Type="Int32" />
                <asp:Parameter Name="price" Type="Int32" />
                <asp:Parameter Name="detail" Type="String" />
                <asp:Parameter Name="cat_id" Type="Int32" />
                <asp:Parameter Name="brand_id" Type="Int32" />
                <asp:Parameter Name="status" Type="String" />
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_movjodi" Type="Int32" />
                <asp:Parameter Name="original_price" Type="Int32" />
                <asp:Parameter Name="original_detail" Type="String" />
                <asp:Parameter Name="original_cat_id" Type="Int32" />
                <asp:Parameter Name="original_brand_id" Type="Int32" />
                <asp:Parameter Name="original_status" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
            BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField CancelText="انصراف" DeleteText="حذف" EditText="ویرایش" 
                    HeaderText="ویرایش" InsertText="اضافه کردن" NewText="جدید" SelectText="انتخاب" 
                    ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" 
                    UpdateText="اعمال" />
                <asp:BoundField DataField="detail" HeaderText="جزییات" 
                    SortExpression="detail" />
                <asp:BoundField DataField="price" HeaderText="قیمت" SortExpression="price" />
                <asp:BoundField DataField="movjodi" HeaderText="موجودی" 
                    SortExpression="movjodi" />
                <asp:BoundField DataField="status" HeaderText="وضعیت" SortExpression="status" />
                <asp:BoundField DataField="brand_id" HeaderText="برند" 
                    SortExpression="brand_id" />
                <asp:BoundField DataField="cat_id" HeaderText="دسته بندی" 
                    SortExpression="cat_id" />
                <asp:BoundField DataField="name" HeaderText="نام محصول" SortExpression="name" />
                <asp:BoundField DataField="id" HeaderText="ردیف" InsertVisible="False" 
                    ReadOnly="True" SortExpression="id" />
                <asp:TemplateField HeaderText="test">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" 
                            DataSourceID="SqlDataSource_Brand" DataTextField="name" DataValueField="id" 
                            SelectedIndex='<%# Eval("brand_id") %>'>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource_Brand" runat="server" 
                            ConflictDetection="CompareAllValues" 
                            ConnectionString="<%$ ConnectionStrings:mobile_hardwareConnectionString %>" 
                            DeleteCommand="DELETE FROM [brand] WHERE [id] = @original_id AND [name] = @original_name" 
                            InsertCommand="INSERT INTO [brand] ([name]) VALUES (@name)" 
                            OldValuesParameterFormatString="original_{0}" 
                            SelectCommand="SELECT * FROM [brand]" 
                            UpdateCommand="UPDATE [brand] SET [name] = @name WHERE [id] = @original_id AND [name] = @original_name">
                            <DeleteParameters>
                                <asp:Parameter Name="original_id" Type="Int32" />
                                <asp:Parameter Name="original_name" Type="String" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="name" Type="String" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="name" Type="String" />
                                <asp:Parameter Name="original_id" Type="Int32" />
                                <asp:Parameter Name="original_name" Type="String" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# this.TestString %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        <br />
    </div>
    </form>
</body>
</html>
