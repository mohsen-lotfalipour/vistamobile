<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true"
    CodeFile="Index.aspx.cs" Inherits="Home" %>

<%--Mohsen Lotfalipour--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <!--  ==========  -->
    <!--  = Slider Revolution =  -->
    <!--  ==========  -->
    <div class="fullwidthbanner-container">
        <div class="fullwidthbanner">
            <ul>
                <li data-transition="premium-random" data-slotamount="3">
                    <img src="images/dummy/slides/1/slide.jpg" alt="slider img" width="1400" height="377" />
                    <!-- baloons -->
                    <div class="caption lft ltt" data-x="570" data-y="30" data-speed="2000" data-start="2000"
                        data-easing="easeOutElastic">
                        <img src="images/dummy/slides/1/1.png" alt="baloon" width="135" height="186" />
                    </div>
                    <div class="caption lft ltt" data-x="870" data-y="60" data-speed="4000" data-start="1000"
                        data-easing="easeOutElastic">
                        <img src="images/dummy/slides/1/2.png" alt="baloon" width="60" height="75" />
                    </div>
                    <div class="caption lft ltt" data-x="1070" data-y="120" data-speed="4000" data-start="1200"
                        data-easing="easeOutElastic">
                        <img src="images/dummy/slides/1/3.png" alt="baloon" width="100" height="123" />
                    </div>
                    <!-- texts -->
                    <div class="caption lfl big_theme" data-x="120" data-y="120" data-speed="1000" data-start="500"
                        data-easing="easeInOutBack">
                        به ویستا موبایل خوش آمدید
                    </div>
                    <div class="caption lfl small_theme" data-x="120" data-y="190" data-speed="1000"
                        data-start="700" data-easing="easeInOutBack">
                        فروش قطعات تعمیراتی انواع موبایل
                    </div>
                    <a href="shop.aspx" class="caption lfl btn btn-primary btn_theme" data-x="120" data-y="260"
                        data-speed="1000" data-start="900" data-easing="easeInOutBack">ورود به فروشگاه
                    </a></li>
                <!-- /slide -->
                <li data-transition="premium-random" data-slotamount="3">
                    <img src="images/dummy/slides/2/slide.jpg" alt="slider img" width="1400" height="377" />
                    <!-- plane -->
                    <div class="caption lfl str" data-x="1400" data-y="20" data-speed="15000" data-start="1000"
                        data-easing="linear">
                        <img src="images/dummy/slides/2/plane.png" alt="aircraft" width="117" height="28" />
                    </div>
                    <!-- ship -->
                    <div class="caption lfl str" data-x="1400" data-y="180" data-speed="50000" data-start="0"
                        data-easing="linear">
                        <img src="images/dummy/slides/2/ship.png" alt="aircraft" width="107" height="8" />
                    </div>
                    <!-- woman -->
                    <div class="caption lfb ltb" data-x="800" data-y="50" data-speed="1000" data-start="1000"
                        data-easing="easeInOutCubic">
                        <img src="images/dummy/slides/2/man.gif" alt="woman" width="361" height="374" />
                    </div>
                    <!-- texts -->
                    <div class="caption lfl big_theme" data-x="120" data-y="120" data-speed="1000" data-start="500"
                        data-easing="easeInOutBack">
                        عرضه مستقیم محصولات از چین
                    </div>
                    <div class="caption lfl small_theme" data-x="120" data-y="190" data-speed="1000"
                        data-start="700" data-easing="easeInOutBack">
                        بهترین کیفیت - بهترین قیمت
                    </div>
                </li>
                <!-- /slide -->
                <li data-transition="premium-random" data-slotamount="3">
                    <img src="images/dummy/slides/3/slide.jpg" alt="slider img" width="1400" height="377" />
                    <!-- phone -->
                    <div class="caption sfr fadeout" data-x="750" data-y="10" data-speed="1000" data-start="1500"
                        data-easing="easeInOutCubic">
                        <img src="images/dummy/slides/3/phone.png" alt="phone in a hand" width="495" height="377" />
                    </div>
                    <!-- texts -->
                    <div class="caption lfl big_theme" data-x="120" data-y="120" data-speed="1000" data-start="500"
                        data-easing="easeInOutBack">
                        ارسال سفارشات به سرا سر کشور
                    </div>
                    <div class="caption lfl small_theme" data-x="120" data-y="190" data-speed="1000"
                        data-start="700" data-easing="easeInOutBack">
                        با گارانتی تعویض
                    </div>
                </li>
                <!-- /slide -->
                <li data-transition="premium-random" data-slotamount="3">
                    <img src="images/dummy/slides/4/slide.jpg" alt="slider img" width="1400" height="377" />
                    <!-- faces -->
                    
                    <div class="caption lft ltt" data-x="0" data-y="0" data-speed="300" data-start="2000"
                        data-easing="easeInOutCubic">
                        <img src="images/dummy/slides/4/person1.png" alt="satisfied customer" width="108"
                            height="321" />
                    </div>

                    <div class="caption lft ltt" data-x="200" data-y="0" data-speed="300" data-start="2200"
                        data-easing="easeInOutCubic">
                        <img src="images/dummy/slides/4/person2.png" alt="satisfied customer" width="108"
                            height="204" />
                    </div>

                    <div class="caption lft ltt" data-x="500" data-y="0" data-speed="300" data-start="2400"
                        data-easing="easeInOutCubic">
                        <img src="images/dummy/slides/4/person3.png" alt="satisfied customer" width="108"
                            height="139" />
                    </div>
                    <div class="caption lft ltt" data-x="720" data-y="0" data-speed="300" data-start="2600"
                        data-easing="easeInOutCubic">
                        <img src="images/dummy/slides/4/person4.png" alt="satisfied customer" width="108"
                            height="191" />
                    </div>
                    <div class="caption lft ltt" data-x="940" data-y="0" data-speed="300" data-start="2800"
                        data-easing="easeInOutCubic">
                        <img src="images/dummy/slides/4/person5.png" alt="satisfied customer" width="108"
                            height="139" />
                    </div>
                    <div class="caption lft ltt" data-x="1200" data-y="0" data-speed="300" data-start="3000"
                        data-easing="easeInOutCubic">
                        <img src="images/dummy/slides/4/person6.png" alt="satisfied customer" width="108"
                            height="179" />
                    </div>
                    <div class="caption lft ltt" data-x="1350" data-y="0" data-speed="300" data-start="3200"
                        data-easing="easeInOutCubic">
                        <img src="images/dummy/slides/4/person7.png" alt="satisfied customer" width="108"
                            height="133" />
                    </div>
                    <!-- texts -->
                    <div class="caption lfl big_theme" data-x="120" data-y="140" data-speed="1000" data-start="500"
                        data-easing="easeInOutBack">
                        تامین کننده قطعات تمامی برندها
                    </div>
                </li>
                <!-- /slide -->
            </ul>
            <div class="tp-bannertimer">
            </div>
        </div>
        <!--  ==========  -->
        <!--  = Nav Arrows =  -->
        <!--  ==========  -->
        <div id="sliderRevLeft">
            <i class="icon-chevron-left"></i>
        </div>
        <div id="sliderRevRight">
            <i class="icon-chevron-right"></i>
        </div>
    </div>
    <!-- /slider revolution -->
    <!--  ==========  -->
    <!--  = Main container =  -->
    <!--  ==========  -->
    <div class="container">
        <div class="row">
            <div class="span12">
                <div class="push-up over-slider blocks-spacer">
                    <!--  ==========  -->
                    <!--  = Three Banners =  -->
                    <!--  ==========  -->
                    <div class="row">
                        <div class="span4">
                            <a href="#" class="btn btn-block banner"><span class="title"><span class="light">فروش</span>
                                کلی و جزیی</span> <em>کلیه قطعات و ابزارهای تعمیرات</em> </a>
                        </div>
                        <div class="span4">
                            <a href="#" class="btn btn-block colored banner"><span class="title"><span class="light">
                                ارسال</span> رایگان</span> <em>به تمام نقاط شیراز</em> </a>
                        </div>
                        <div class="span4">
                            <a href="#" class="btn btn-block banner"><span class="title"><span class="light">عرضه محصولات</span>
                                </span> <em> جدید و بروز </em> </a>
                        </div>
                    </div>
                    <!-- /three banners -->
                </div>
            </div>
        </div>
        <!--  ==========  -->
        <!--  = Featured Items =  -->
        <!--  ==========  -->
        <div class="row featured-items blocks-spacer">
            <div class="span12">
                <!--  ==========  -->
                <!--  = Title =  -->
                <!--  ==========  -->
                <div class="main-titles lined">
                    <h2 class="title">
                        <span class="light">محصولات</span> ویژه</h2>
                    <div class="arrows">
                        <a href="#" class="icon-chevron-right" id="featuredItemsRight"></a><a href="#" class="icon-chevron-left"
                            id="featuredItemsLeft"></a>
                    </div>
                </div>
            </div>
            <div class="span12">
                <!--  ==========  -->
                <!--  = Carousel =  -->
                <!--  ==========  -->
                <div class="carouFredSel" data-autoplay="true" data-nav="featuredItems" id="featuredItems" runat="server" clientidmode="Static">
                   <%-- generate featuredItems--%>
                </div>
                <!-- /carousel -->
            </div>
        </div>
    </div>
    <!-- /container -->
    <!--  ==========  -->
    <!--  = New Products =  -->
    <!--  ==========  -->
    <div class="boxed-area blocks-spacer">
        <div class="container">
            <!--  ==========  -->
            <!--  = Title =  -->
            <!--  ==========  -->
            <div class="row">
                <div class="span12">
                    <div class="main-titles lined">
                        <h2 class="title">
                            <span class="light">محصولات</span> جدید فروشگاه</h2>
                    </div>
                </div>
            </div>
            <!-- /title -->
            <div class="row popup-products blocks-spacer" id="new_product" runat="server" clientidmode="Static">
                <!--  ==========  -->
                <!--  = Product =  -->
                <!--  ==========  -->
              <%-- generate new product--%>
                <!-- /product -->
            </div>
        </div>
    </div>
    <!-- /new products -->
    <!--  ==========  -->
    <!--  = Most Popular products =  -->
    <!--  ==========  -->
    <%--<div class="most-popular blocks-spacer">
    	<div class="container">
    	    
    	    <!--  ==========  -->
			<!--  = Title =  -->
			<!--  ==========  -->
    	    <div class="row">
    	    	<div class="span12">
    	    	    <div class="main-titles lined">
    	                <h2 class="title"><span class="light">محبوبترین</span>محصولات فروشگاه</h2>
    	            </div>
    	    	</div>
    	    </div> <!-- /title -->
    	    
	    	<div class="row popup-products">
	    	     
	    	     
	    	            
		        <!--  ==========  -->
				<!--  = Product =  -->
				<!--  ==========  -->
                <div class="span3">
                    <div class="product">
                        <div class="product-img">
                            <div class="picture">
                                <img src="images/dummy/most-popular-products/popular-1.jpg" alt="" width="540" height="412" />
                                <div class="img-overlay">
                                    <a href="#" class="btn more btn-primary">توضیحات بیشتر</a>
                                    <a href="#" class="btn buy btn-danger">اضافه به سبد خرید</a>
                                </div>
                            </div>
                        </div>
                        <div class="main-titles no-margin">
                            <h4 class="title">$32</h4>
                            <h5 class="no-margin">محصول ویژه 456</h5>
                        </div>
                        <p class="desc">توضیحاتی که در مورد محصول لازم است را در اینجا مینویسید</p>
                        <p class="center-align stars">
                            <span class="icon-star stars-clr"></span>
                            <span class="icon-star stars-clr"></span>
                            <span class="icon-star"></span>
                            <span class="icon-star"></span>
                            <span class="icon-star"></span>
                             
                        </p>
                    </div>
                </div> <!-- /product -->
                 
	    	     
	    	            
		        <!--  ==========  -->
				<!--  = Product =  -->
				<!--  ==========  -->
                <div class="span3">
                    <div class="product">
                        <div class="product-img">
                            <div class="picture">
                                <img src="images/dummy/most-popular-products/popular-2.jpg" alt="" width="540" height="412" />
                                <div class="img-overlay">
                                    <a href="#" class="btn more btn-primary">توضیحات بیشتر</a>
                                    <a href="#" class="btn buy btn-danger">اضافه به سبد خرید</a>
                                </div>
                            </div>
                        </div>
                        <div class="main-titles no-margin">
                            <h4 class="title">$32</h4>
                            <h5 class="no-margin">محصول ویژه 280</h5>
                        </div>
                        <p class="desc">توضیحاتی که در مورد محصول لازم است را در اینجا مینویسید</p>
                        <p class="center-align stars">
                            <span class="icon-star stars-clr"></span>
                            <span class="icon-star stars-clr"></span>
                            <span class="icon-star stars-clr"></span>
                            <span class="icon-star"></span>
                            <span class="icon-star"></span>
                             
                        </p>
                    </div>
                </div> <!-- /product -->
                 
	    	     
	    	            
		        <!--  ==========  -->
				<!--  = Product =  -->
				<!--  ==========  -->
                <div class="span3">
                    <div class="product">
                        <div class="product-img">
                            <div class="picture">
                                <img src="images/dummy/most-popular-products/popular-3.jpg" alt="" width="540" height="412" />
                                <div class="img-overlay">
                                    <a href="#" class="btn more btn-primary">توضیحات بیشتر</a>
                                    <a href="#" class="btn buy btn-danger">اضافه به سبد خرید</a>
                                </div>
                            </div>
                        </div>
                        <div class="main-titles no-margin">
                            <h4 class="title">$32</h4>
                            <h5 class="no-margin">محصول ویژه 158</h5>
                        </div>
                        <p class="desc">توضیحاتی که در مورد محصول لازم است را در اینجا مینویسید</p>
                        <p class="center-align stars">
                            <span class="icon-star stars-clr"></span>
                            <span class="icon-star"></span>
                            <span class="icon-star"></span>
                            <span class="icon-star"></span>
                            <span class="icon-star"></span>
                             
                        </p>
                    </div>
                </div> <!-- /product -->
                 
	    	     
	    	            
		        <!--  ==========  -->
				<!--  = Product =  -->
				<!--  ==========  -->
                <div class="span3">
                    <div class="product">
                        <div class="product-img">
                            <div class="picture">
                                <img src="images/dummy/most-popular-products/popular-4.jpg" alt="" width="540" height="412" />
                                <div class="img-overlay">
                                    <a href="#" class="btn more btn-primary">توضیحات بیشتر</a>
                                    <a href="#" class="btn buy btn-danger">اضافه به سبد خرید</a>
                                </div>
                            </div>
                        </div>
                        <div class="main-titles no-margin">
                            <h4 class="title">$32</h4>
                            <h5 class="no-margin">محصول ویژه 275</h5>
                        </div>
                        <p class="desc">توضیحاتی که در مورد محصول لازم است را در اینجا مینویسید</p>
                        <p class="center-align stars">
                            <span class="icon-star stars-clr"></span>
                            <span class="icon-star"></span>
                            <span class="icon-star"></span>
                            <span class="icon-star"></span>
                            <span class="icon-star"></span>
                             
                        </p>
                    </div>
                </div> <!-- /product -->
                    	    </div>
    	</div>
    </div>--%>
    <!-- /most popular -->
    <!--  ==========  -->
    <!--  = Lastest News =  -->
    <!--  ==========  -->
    <%--    <div class="darker-stripe blocks-spacer more-space latest-news with-shadows">
    	<div class="container">
    	    
    	    <!--  ==========  -->
			<!--  = Title =  -->
			<!--  ==========  -->
    		<div class="row">
    			<div class="span12">
    			    <div class="main-titles center-align">
    			        <h2 class="title">
    			            <span class="clickable icon-chevron-right" id="tweetsRight"></span> &nbsp;&nbsp;&nbsp;
    			            <span class="light">آخرین</span> خبر ها &nbsp;&nbsp;&nbsp;
    			            <span class="clickable icon-chevron-left" id="tweetsLeft"></span>
			            </h2>
    			    </div>
    			</div>
    		</div> <!-- /title -->
    		
    		<!--  ==========  -->
			<!--  = News content =  -->
			<!--  ==========  -->
    		<div class="row">
    		    <div class="span12">
    		        <div class="carouFredSel" data-nav="tweets" data-autoplay="false">
    		             
    		                
		                <!--  ==========  -->
						<!--  = Slide =  -->
						<!--  ==========  --> 
                        <div class="slide">
                        	<div class="row">
                        		<div class="span6">
                        		    <div class="news-item">
                        		        <div class="published">12 بهمن 1392</div>
                        		        <h6><a href="#">عنوان خبر شما</a></h6>
                        		        <p>در این قسمت میتوانید خبر خود را بنویسید. این یک نوشته ی آزمایشی است که صرفا برای پر کردن این بخش به کار رفته و جنبه ی دیگری ندارد. شما میتوانید این ناحیه را با محتوای دلخواه خود پر کنید.</p>
                        		    </div>
                        		</div>
                        		<div class="span6">
                        		    <div class="news-item">
                        		        <div class="published">15 بهمن 1392</div>
                        		        <h6><a href="#">یک خبر جالب دیگر</a></h6>
                        		        <p>در این قسمت میتوانید خبر خود را بنویسید. این یک نوشته ی آزمایشی است که صرفا برای پر کردن این بخش به کار رفته و جنبه ی دیگری ندارد. شما میتوانید این ناحیه را با محتوای دلخواه خود پر کنید.</p>
                        		    </div>
                        		</div>
                        	</div>
                        </div> <!-- /slide -->
                         
    		                
		                <!--  ==========  -->
						<!--  = Slide =  -->
						<!--  ==========  --> 
                        <div class="slide">
                        	<div class="row">
                        		<div class="span6">
                        		    <div class="news-item">
                        		        <div class="published">12 بهمن 1392</div>
                        		        <h6><a href="#">عنوان خبر شما</a></h6>
                        		        <p>در این قسمت میتوانید خبر خود را بنویسید. این یک نوشته ی آزمایشی است که صرفا برای پر کردن این بخش به کار رفته و جنبه ی دیگری ندارد. شما میتوانید این ناحیه را با محتوای دلخواه خود پر کنید.</p>
                        		    </div>
                        		</div>
                        		<div class="span6">
                        		    <div class="news-item">
                        		        <div class="published">15 بهمن 1392</div>
                        		        <h6><a href="#">یک خبر جالب دیگر</a></h6>
                        		        <p>در این قسمت میتوانید خبر خود را بنویسید. این یک نوشته ی آزمایشی است که صرفا برای پر کردن این بخش به کار رفته و جنبه ی دیگری ندارد. شما میتوانید این ناحیه را با محتوای دلخواه خود پر کنید.</p>
                        		    </div>
                        		</div>
                        	</div>
                        </div> <!-- /slide -->
                         
                    </div>
    		    </div>
    		</div> <!-- /news content -->
    	</div>
    </div> <!-- /latest news -->--%>
    <!--  = Brands Carousel =  -->
    <!--  ==========  -->
    <div class="darker-stripe blocks-spacer more-space latest-news with-shadows">
        <div class="container blocks-spacer-last">
            <!--  ==========  -->
            <!--  = Title =  -->
            <!--  ==========  -->
            <div class="row">
                <div class="span12">
                    <div class="main-titles lined">
                        <h2 class="title">
                            <span class="light">برند های</span> ما</h2>
                        <div class="arrows">
                            <a href="#" class="icon-chevron-right" id="brandsRight"></a><a href="#" class="icon-chevron-left"
                                id="brandsLeft"></a>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /title -->
            <!--  ==========  -->
            <!--  = Logos =  -->
            <!--  ==========  -->
            <div class="row">
                <div class="span12">
                    <div class="brands carouFredSel" data-nav="brands" data-autoplay="true">
                        <img src="images/dummy/brands/brands_01.jpg" alt="" width="203" height="104" />
                        <img src="images/dummy/brands/brands_02.jpg" alt="" width="203" height="104" />
                        <img src="images/dummy/brands/brands_03.jpg" alt="" width="203" height="104" />
                        <img src="images/dummy/brands/brands_04.jpg" alt="" width="203" height="104" />
                        <img src="images/dummy/brands/brands_05.jpg" alt="" width="203" height="104" />
                        <img src="images/dummy/brands/brands_06.jpg" alt="" width="203" height="104" />
                        <img src="images/dummy/brands/brands_07.jpg" alt="" width="203" height="104" />

                    </div>
                </div>
            </div>
            <!-- /logos -->
        </div>
        <!-- /brands carousel -->
    </div>
</asp:Content>
