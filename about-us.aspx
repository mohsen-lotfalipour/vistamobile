<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="about-us.aspx.cs" Inherits="about_us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

 
    <!--  ==========  -->
    <!--  = Breadcrumbs =  -->
    <!--  ==========  -->
    <div class="darker-stripe">
        <div class="container">
            <div class="row">
                <div class="span12">
                    <ul class="breadcrumb">
                        <li>
                            <a href="index.aspx">صفحه اصلی</a>
                        </li>
                        <li><span class="icon-chevron-left"></span></li>
                        <li>
                            <a href="about-us.aspx">درباره ما</a>
                        </li>
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
                <aside class="span3">
                    <div class="sidebar-item">
                        
                        <!--  ==========  -->
                        <!--  = Sidebar Title =  -->
                        <!--  ==========  -->
                        <div class="underlined">
                        	<h3><span class="light">تیم</span> ما</h3>
                        </div>
                        
                        <!--  ==========  -->
                        <!--  = Menu (affix) =  -->
                        <!--  ==========  -->
                        <div class="row">
                        	<div class="span3" id="spyMenu">
		                    	<ul class="nav nav-pills nav-stacked">
		                    	    <li><a href="#jaka">مهدی فروزان <i class="icon-caret-right pull-right"></i></a></li>
		                    	    <li><a href="#primoz">شرکت های چینی <i class="icon-caret-right pull-right"></i></a></li>
		                    	    <li><a href="#ana">خدمات <i class="icon-caret-right pull-right"></i></a></li>
		                    	    <li><a href="#andre">فروشگاه <i class="icon-caret-right pull-right"></i></a></li>
		                    	</ul>
                        	</div>
                        </div>
                        
                    </div>
                </aside> <!-- /sidebar -->
                
                <!--  ==========  -->
                <!--  = Main content =  -->
                <!--  ==========  -->
                <section class="span9">
                    
                    <!--  ==========  -->
                    <!--  = Title =  -->
                    <!--  ==========  -->
                    <div class="underlined push-down-20">
                        <h3><span class="light">چند کلمه</span> درباره ما</h3>
                    </div> <!-- /title -->
                    
                    <!--  ==========  -->
                    <!--  = Description=  -->
                    <!--  ==========  -->
                    <section class="blocks-spacer">
                        <h5><span class="light">چطور</span> همه چیز شروع شد</h5>
                        <p>لورم ایپسوم متنی است که ساختگی برای طراحی و چاپ آن مورد است. صنعت چاپ زمانی لازم بود شرایطی شما باید فکر ثبت نام و طراحی، لازمه خروج می باشد. در ضمن قاعده همفکری ها جوابگوی سئوالات زیاد شاید باشد، آنچنان که لازم بود طراحی گرافیکی خوب بود. کتابهای زیادی شرایط سخت ، دشوار و کمی در سالهای دور لازم است. هدف از این نسخه فرهنگ پس از آن و دستاوردهای خوب شاید باشد. حروفچینی لازم در شرایط فعلی لازمه تکنولوژی بود که گذشته، حال و آینده را شامل گردد. سی و پنج درصد از طراحان در قرن پانزدهم میبایست پرینتر در ستون و سطر حروف لازم است، بلکه شناخت این ابزار گاه اساسا بدون هدف بود و سئوالهای زیادی در گذشته بوجود می آید، تنها لازمه آن بود.  </p>
                        
                        <h5><span class="light">چه</span> جریاناتی در پیش است</h5>
                        <p>لورم ایپسوم متنی است که ساختگی برای طراحی و چاپ آن مورد است. صنعت چاپ زمانی لازم بود شرایطی شما باید فکر ثبت نام و طراحی، لازمه خروج می باشد. در ضمن قاعده همفکری ها جوابگوی سئوالات زیاد شاید باشد، آنچنان که لازم بود طراحی گرافیکی خوب بود. کتابهای زیادی شرایط سخت ، دشوار و کمی در سالهای دور لازم است. هدف از این نسخه فرهنگ پس از آن و دستاوردهای خوب شاید باشد. حروفچینی لازم در شرایط فعلی لازمه تکنولوژی بود که گذشته، حال و آینده را شامل گردد. سی و پنج درصد از طراحان در قرن پانزدهم میبایست پرینتر در ستون و سطر حروف لازم است، بلکه شناخت این ابزار گاه اساسا بدون هدف بود و سئوالهای زیادی در گذشته بوجود می آید، تنها لازمه آن بود.  </p>
                        
                        <h5><span class="light">و</span> امروز ما که هستیم!</h5>
                        <p>لورم ایپسوم متنی است که ساختگی برای طراحی و چاپ آن مورد است. صنعت چاپ زمانی لازم بود شرایطی شما باید فکر ثبت نام و طراحی، لازمه خروج می باشد. در ضمن قاعده همفکری ها جوابگوی سئوالات زیاد شاید باشد، آنچنان که لازم بود طراحی گرافیکی خوب بود. کتابهای زیادی شرایط سخت ، دشوار و کمی در سالهای دور لازم است. هدف از این نسخه فرهنگ پس از آن و دستاوردهای خوب شاید باشد. حروفچینی لازم در شرایط فعلی لازمه تکنولوژی بود که گذشته، حال و آینده را شامل گردد. سی و پنج درصد از طراحان در قرن پانزدهم میبایست پرینتر در ستون و سطر حروف لازم است، بلکه شناخت این ابزار گاه اساسا بدون هدف بود و سئوالهای زیادی در گذشته بوجود می آید، تنها لازمه آن بود.  </p>
                	</section>
        </section> <!-- /main content -->
            </div>
        </div>
        </div> <!-- /container -->
</asp:Content>

