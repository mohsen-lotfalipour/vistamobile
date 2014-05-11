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
                    <ul class="breadcrumb">
                        <li><a href="index.aspx">صفحه اصلی</a> </li>
                        <li><span class="icon-chevron-left"></span></li>
                        <li><a href="shop.aspx">فروشگاه</a> </li>
                        <li><span class="icon-chevron-left"></span></li>
                        <li><a href="#">محصول ویژه</a> </li>
                        <li><span class="icon-chevron-left"></span></li>
                        <li><a href="product.aspx">تی شرت مردانه کلاه دار</a> </li>
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
                            <span class="tag" id="product_price" runat="server"> </span> 
                            
                            <span class="stock" id="product_status" runat="server">
                            
                            </span>
                        </div>
                    </div>
                    <div  class="product-description">
                        <p id="product_detail" runat="server">
                            
                        </p>
                        <hr />
                        <!--  ==========  -->
                        <!--  = Add to cart form =  -->
                        <!--  ==========  -->
                        <form action="#" class="form form-inline clearfix">
                        <div class="numbered">
                            <input type="text" name="num" value="1" class="tiny-size" />
                            <span class="clickable add-one icon-plus-sign-alt"></span><span class="clickable remove-one icon-minus-sign-alt">
                            </span>
                        </div>
                        &nbsp;
                        <select name="color" class="span2">
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
                        </select>
                        <button class="btn btn-danger pull-right">
                            <i class="icon-shopping-cart"></i>اضافه به سبد خرید</button>
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
                <div class="span12">
                    <div class="main-titles lined">
                        <h2 class="title">
                            <span class="light">محصولات</span> مرتبط</h2>
                    </div>
                </div>
            </div>
            <!--  ==========  -->
            <!--  = Related products =  -->
            <!--  ==========  -->
            <div class="row popup-products">
                <!--  ==========  -->
                <!--  = Products =  -->
                <!--  ==========  -->
                <div class="span3">
                    <div class="product">
                        <div class="product-img">
                            <div class="picture">
                                <img src="images/dummy/products/product-1.jpg" alt="" width="540" height="374" />
                                <div class="img-overlay">
                                    <a href="#" class="btn more btn-primary">توضیحات بیشتر</a> <a href="#" class="btn buy btn-danger">
                                        اضافه به سبد خرید</a>
                                </div>
                            </div>
                        </div>
                        <div class="main-titles no-margin">
                            <h4 class="title">
                                <span class="striked">90000 تومان</span> <span class="red-clr">80000 تومان</span></h4>
                            <h5 class="no-margin">
                                آدیداس کانورس</h5>
                        </div>
                        <p class="desc">
                            توضیحاتی که در مورد محصول لازم است را در اینجا مینویسید</p>
                        <p class="center-align stars">
                            <span class="icon-star stars-clr"></span><span class="icon-star stars-clr"></span>
                            <span class="icon-star stars-clr"></span><span class="icon-star stars-clr"></span>
                            <span class="icon-star"></span>
                        </p>
                    </div>
                </div>
                <!-- /product -->
                <!--  ==========  -->
                <!--  = Products =  -->
                <!--  ==========  -->
                <div class="span3">
                    <div class="product">
                        <div class="product-img">
                            <div class="picture">
                                <img src="images/dummy/products/product-2.jpg" alt="" width="540" height="374" />
                                <div class="img-overlay">
                                    <a href="#" class="btn more btn-primary">توضیحات بیشتر</a> <a href="#" class="btn buy btn-danger">
                                        اضافه به سبد خرید</a>
                                </div>
                            </div>
                        </div>
                        <div class="main-titles no-margin">
                            <h4 class="title">
                                <span class="striked">70000 تومان</span> <span class="red-clr">30000 تومان</span></h4>
                            <h5 class="no-margin">
                                نایک دانک 552</h5>
                        </div>
                        <p class="desc">
                            توضیحاتی که در مورد محصول لازم است را در اینجا مینویسید</p>
                        <p class="center-align stars">
                            <span class="icon-star stars-clr"></span><span class="icon-star stars-clr"></span>
                            <span class="icon-star stars-clr"></span><span class="icon-star stars-clr"></span>
                            <span class="icon-star"></span>
                        </p>
                    </div>
                </div>
                <!-- /product -->
                <!--  ==========  -->
                <!--  = Products =  -->
                <!--  ==========  -->
                <div class="span3">
                    <div class="product">
                        <div class="product-img">
                            <div class="picture">
                                <img src="images/dummy/products/product-3.jpg" alt="" width="540" height="374" />
                                <div class="img-overlay">
                                    <a href="#" class="btn more btn-primary">توضیحات بیشتر</a> <a href="#" class="btn buy btn-danger">
                                        اضافه به سبد خرید</a>
                                </div>
                            </div>
                        </div>
                        <div class="main-titles no-margin">
                            <h4 class="title">
                                <span class="striked">45000 تومان</span> <span class="red-clr">35000 تومان</span></h4>
                            <h5 class="no-margin">
                                آل استار 552</h5>
                        </div>
                        <p class="desc">
                            توضیحاتی که در مورد محصول لازم است را در اینجا مینویسید</p>
                        <p class="center-align stars">
                            <span class="icon-star stars-clr"></span><span class="icon-star stars-clr"></span>
                            <span class="icon-star stars-clr"></span><span class="icon-star stars-clr"></span>
                            <span class="icon-star"></span>
                        </p>
                    </div>
                </div>
                <!-- /product -->
                <!--  ==========  -->
                <!--  = Products =  -->
                <!--  ==========  -->
                <div class="span3">
                    <div class="product">
                        <div class="product-img">
                            <div class="picture">
                                <img src="images/dummy/products/product-4.jpg" alt="" width="540" height="374" />
                                <div class="img-overlay">
                                    <a href="#" class="btn more btn-primary">توضیحات بیشتر</a> <a href="#" class="btn buy btn-danger">
                                        اضافه به سبد خرید</a>
                                </div>
                            </div>
                        </div>
                        <div class="main-titles no-margin">
                            <h4 class="title">
                                <span class="striked">10000 تومان</span> <span class="red-clr">5000 تومان</span></h4>
                            <h5 class="no-margin">
                                کاترپیلار 552</h5>
                        </div>
                        <p class="desc">
                            توضیحاتی که در مورد محصول لازم است را در اینجا مینویسید</p>
                        <p class="center-align stars">
                            <span class="icon-star stars-clr"></span><span class="icon-star stars-clr"></span>
                            <span class="icon-star stars-clr"></span><span class="icon-star stars-clr"></span>
                            <span class="icon-star"></span>
                        </p>
                    </div>
                </div>
                <!-- /product -->
            </div>
        </div>
    </div>
</asp:Content>
