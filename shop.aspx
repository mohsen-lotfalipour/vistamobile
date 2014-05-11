<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true"
    CodeFile="shop.aspx.cs" Inherits="shop" %>

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
                    <ul class="breadcrumb" id="list_footer_menu" runat="server" >
                        <li><a href="index.aspx">صفحه اصلی</a> </li>
                        <li><span class="icon-chevron-left"></span></li>
                        <li><a href="shop.aspx">فروشگاه</a> </li>
                        <%--<li><span class="icon-chevron-left"></span></li>--%>
                       <%-- <li><a href="shop.aspx">قالب بندی اصلی</a> </li>--%>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="push-up blocks-spacer">
            <div class="row">
                <!--  ==========  -->
                <!--  = Sidebar =  -->
                <!--  ==========  -->
                <aside class="span3 left-sidebar" id="tourStep1">
                    <div class="sidebar-item sidebar-filters" id="sidebarFilters">
                        
                        <!--  ==========  -->
                        <!--  = Sidebar Title =  -->
                        <!--  ==========  -->
                        <div class="underlined">
                        	<h3><span class="light">بر اساس فیلتر</span> خرید کنید</h3>
                        </div>
                        
                        <!--  ==========  -->
                        <!--  = Categories =  -->
                        <!--  ==========  -->
                        <div class="accordion-group" id="tourStep2" runat="server" ClientIDMode="Static">
                            <div class="accordion-heading"  >
                                <a class="accordion-toggle" data-toggle="collapse" href="#filterOne">دسته بندی ها <b class="caret"></b></a>
                            </div>
                            <div id="filterOne" class="accordion-body collapse in">
                                <div class="accordion-inner" id="category_filter" runat="server" ClientIDMode="Static">
                                    <%--<a href="#" data-target=".filter--accessories" class="selectable"><i class="box"></i> لوازم شخصی</a>--%>
                                   <%-- category filter--%>
                                    
                                </div>
                            </div>
                        </div> <!-- /categories -->
                        
                         <!--  ==========  -->
                        <!--  = Brand filter =  -->
                        <!--  ==========  -->
                        <div class="accordion-group">
                            <div class="accordion-heading">
                                <a class="accordion-toggle" data-toggle="collapse" href="#filterFour">برند <b class="caret"></b></a>
                            </div>
                            <div id="filterFour" class="accordion-body collapse in">
                                <div class="accordion-inner"  id="brand_filter" runat="server" ClientIDMode="Static">
                                    <%--<a href="#" data-target="s-oliver" data-type="brand" class="selectable detailed"><i class="box"></i> S. Oliver</a>--%>
                                    <%--brand filter--%>
                                </div>
                            </div>
                        </div> <!-- /brand filter -->

                        <!--  ==========  -->
                        <!--  = Prices slider =  -->
                        <!--  ==========  -->
                        <div class="accordion-group">
                            <div class="accordion-heading">
                                <a class="accordion-toggle" data-toggle="collapse" href="#filterPrices">قیمت <b class="caret"></b></a>
                            </div>
                            <div id="filterPrices" class="accordion-body in collapse">
                                <div class="accordion-inner with-slider">
                                    <div class="jqueryui-slider-container">
                                        <div id="pricesRange"></div>
                                    </div>
                                    <input type="text" data-initial="432" class="max-val" disabled />
                                    <input type="text" data-initial="99" class="min-val pull-right" disabled />
                                </div>
                            </div>
                        </div> <!-- /prices slider -->
                        
                        <!--  ==========  -->
                        <!--  = Size filter =  -->
                        <!--  ==========  -->
            <%--            <div class="accordion-group" id="tourStep3">
                            <div class="accordion-heading">
                                <a class="accordion-toggle collapsed" data-toggle="collapse" href="#filterTwo">سایز <b class="caret"></b></a>
                            </div>
                            <div id="filterTwo" class="accordion-body collapse">
                                <div class="accordion-inner">
                                    <a href="#" data-target="xs" data-type="size" class="selectable detailed"><i class="box"></i> XS</a>
                                    <a href="#" data-target="s" data-type="size" class="selectable detailed"><i class="box"></i> S</a>
                                    <a href="#" data-target="m" data-type="size" class="selectable detailed"><i class="box"></i> M</a>
                                    <a href="#" data-target="l" data-type="size" class="selectable detailed"><i class="box"></i> L</a>
                                    <a href="#" data-target="xl" data-type="size" class="selectable detailed"><i class="box"></i> XL</a>
                                    <a href="#" data-target="xxl" data-type="size" class="selectable detailed"><i class="box"></i> XXL</a>
 
                                </div>
                            </div>
                        </div> --%>
                        <!-- /size filter -->
                        
                        <!--  ==========  -->
                        <!--  = Color filter =  -->
                        <!--  ==========  -->
                 <%--       <div class="accordion-group">
                            <div class="accordion-heading">
                                <a class="accordion-toggle collapsed" data-toggle="collapse" href="#filterThree">رنگ <b class="caret"></b></a>
                            </div>
                            <div id="filterThree" class="accordion-body collapse">
                                <div class="accordion-inner">
                                    <a href="#" data-target="red" data-type="color" class="selectable detailed"><i class="box"></i> قرمز</a>
                                    <a href="#" data-target="green" data-type="color" class="selectable detailed"><i class="box"></i> سبز</a>
                                    <a href="#" data-target="blue" data-type="color" class="selectable detailed"><i class="box"></i> آبی</a>
                                    <a href="#" data-target="pink" data-type="color" class="selectable detailed"><i class="box"></i> صورتی</a>
                                    <a href="#" data-target="purple" data-type="color" class="selectable detailed"><i class="box"></i> بنفش</a>
                                    <a href="#" data-target="orange" data-type="color" class="selectable detailed"><i class="box"></i> نارنجی</a>
                                </div>
                            </div>
                        </div> --%>
                        <!-- /color filter -->
                        
                        
                        <a href="#" class="remove-filter" id="removeFilters"><span class="icon-ban-circle"></span> حذف همه فیلتر ها</a>
                        
                    </div>
                </aside>
                <!-- /sidebar -->
                <!--  ==========  -->
                <!--  = Main content =  -->
                <!--  ==========  -->
                <section class="span9">
                    
                    <!--  ==========  -->
                    <!--  = Title =  -->
                    <!--  ==========  -->
                    <div class="underlined push-down-20">
                        <div class="row">
                            <div class="span5">
                                <h3><span class="light">همه</span> محصولات</h3>
                            </div>
                            <div class="span4">
                                <div class="form-inline sorting-by" id="tourStep4">
                                    <label for="isotopeSorting" class="black-clr">چینش :</label>
                                    <select id="isotopeSorting" class="span3">
                                        <option value='{"sortBy":"price", "sortAscending":"true"}'>بر اساس قیمت (کم به زیاد) &uarr;</option>
                                        <option value='{"sortBy":"price", "sortAscending":"false"}'>بر اساس قیمت (زیاد به کم) &darr;</option>
                                        <option value='{"sortBy":"name", "sortAscending":"true"}'>بر اساس نام (صعودی) &uarr;</option>
                                        <option value='{"sortBy":"name", "sortAscending":"false"}'>بر اساس نام (نزولی) &darr;</option>
                                        <%--<option value='{"sortBy":"popularity", "sortAscending":"true"}'>بر اساس محبوبیت (کم به زیاد) &uarr;</option>
                                        <option value='{"sortBy":"popularity", "sortAscending":"false"}'>بر اساس محبوبیت (زیاد به کم) &darr;</option>--%>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div> <!-- /title -->
                    
                    <!--  ==========  -->
                    <!--  = Products =  -->   
                    <!--  ==========  -->  
<%--                    <asp:UpdatePanel runat="server" ID="upp1" >
                    <ContentTemplate>--%>
                    <div class="row popup-products">
                        <div id="isotopeContainer"  class="isotope-container" ClientIDMode="Static" runat="server">
                    	    <!--  ==========  -->
                            <!--  = Single Product =  -->
                            <!--  ==========  -->
    

                        <br /> 
                        </div>
                	</div> 
<%--                    </ContentTemplate>
                    </asp:UpdatePanel>--%>
                	<hr />
                </section>
                <!-- /main content -->
            </div>
        </div>
    </div>
    <!-- /container -->
</asp:Content>
