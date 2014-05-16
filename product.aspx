<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true"
    CodeFile="product.aspx.cs" Inherits="product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <!--  ==========  -->
    <!--  = Breadcrumbs =  -->
    <!--  ==========  -->
    <div class="darker-stripe">
        <div class="container">
            <div class="row">
                <div class="span12">
                    <ul id="adres" runat="server" class="breadcrumb" clientidmode="Static">
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!--  ==========  -->
    <!--  = Main container =  -->
    <!--  ==========  -->
    <div class="container">
        <div class="push-up top-equal blocks-spacer">
            <!--  ==========  -->
            <!--  = Product =  -->
            <!--  ==========  -->
            <div class="row blocks-spacer">
                <!--  ==========  -->
                <!--  = Preview Images =  -->
                <!--  ==========  -->
                <div class="span5">
                    <div class="product-preview">
                        <div class="picture">
                            <img src="" runat="server" alt="" width="940" height="940" id="mainPreviewImg" />
                        </div>
                        <div id="imgroot" runat="server" class="thumbs clearfix">
                            <%--      <div class="thumb active">
                                <a href="#mainPreviewImg">
                                    <img id="img1" runat="server" alt="" width="940" height="940" /></a>
                            </div>--%>
                        </div>
                    </div>
                </div>
                <!--  ==========  -->
                <!--  = Title and short desc =  -->
                <!--  ==========  -->
                <div class="span7">
                    <div class="product-title">
                        <h1 class="name" id="product_name" runat="server">
                        </h1>
                        <div class="meta">
                            <span class="tag" id="product_price" runat="server"></span><span class="stock" id="product_status"
                                runat="server"></span>
                        </div>
                    </div>
                    <div class="product-description">
                        <p id="product_detail" runat="server">
                        </p>
                        <hr />
                        <!--  ==========  -->
                        <!--  = Add to cart form =  -->
                        <!--  ==========  -->
                        <form action="#" class="form form-inline clearfix">
                        <div class="numbered" style="text-align: center">
                            <input type="text" name="num" value="1" class="tiny-size" />
                            <span class="clickable add-one icon-plus-sign-alt"></span>&nbsp;<span class="clickable remove-one icon-minus-sign-alt">
                            </span>&nbsp;
                            <%-- <select name="color" class="span2">
                            <option value="-1">انتخاب رنگ</option>
                            <option value="blue">آبی</option>
                            <option value="orange">نارنجی</option>
                            <option value="black">مشکی</option>
                        </select>
                        &nbsp;
                        <select name="size" class="span2">
                            <option value="-1">انتخاب سایز</option>
                            <option value="XS">خیلی کوچک</option>
                            <option value="S">کوچک</option>
                            <option value="M">متوسط</option>
                            <option value="L">بزرگ</option>
                            <option value="XL">خیلی بزرگ</option>
                            <option value="XXL">خیلی خیلی بزرگ</option>
                        </select>--%>
                            <button class="btn btn-danger pull-right">
                                <i class="icon-shopping-cart"></i>اضافه به سبد خرید</button>
                        </div>
                        </form>
                        <hr />
                    </div>
                </div>
            </div>
            <!--  ==========  -->
            <!--  = Tabs with more info =  -->
            <!--  ==========  -->
            <!--  /==========  -->
        </div>
    </div>
    <!-- /container -->
    <!--  ==========  -->
    <!--  = Related Products =  -->
    <!--  ==========  -->
    <div class="boxed-area no-bottom">
        <div class="container">
            <!--  ==========  -->
            <!--  = Title =  -->
            <!--  ==========  -->
            <div class="row">
                <div  class="span12">
                     <div class="main-titles lined" id="title" runat="server">
                     </div>
                </div>
            </div>
            <!--  ==========  -->
            <!--  = Related products =  -->
            <!--  ==========  -->
            <div id="Related_products" runat="server" class="row popup-products" clientidmode="Static">
      
                 <div class="carouFredSel" data-autoplay="true" data-nav="featuredItems" id="related" runat="server" clientidmode="Static">

                 </div>
                   <%-- generate featuredItems--%>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
