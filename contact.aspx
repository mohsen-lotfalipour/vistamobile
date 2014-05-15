<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true"
    CodeFile="contact.aspx.cs" Inherits="contact" %>

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
                        <li><a href="contact.aspx">ارتباط با ما</a> </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="push-up top-equal blocks-spacer-last">
            <div class="row">
                <!--  ==========  -->
                <!--  = Main Title =  -->
                <!--  ==========  -->
                <div class="span12">
                    <div class="title-area">
                        <h1 class="inline">
                            <span class="light">با ما</span> ارتباط برقرار کنید.</h1>
                    </div>
                </div>
                <!--  ==========  -->
                <!--  = Main content =  -->
                <!--  ==========  -->
                <section class="span8 single single-page">
                    
                    <!--  ==========  -->
                    <!--  = Post =  -->
                    <!--  ==========  -->
                    <article class="post">
                        <div class="post-inner">
                            <p>
							نظرات و سوالات خود را با ما در میان بگذارید
                            </p>
                        </div>
                    </article>
                    
                    <hr />
                    
                    <!--  ==========  -->
                    <!--  = Contact Form =  -->
                    <!--  ==========  -->
                    <section class="contact-form-container">
                        
                        <h3 class="push-down-25"><span class="light">ارسال</span> پیام</h3>
                        
                        <form id="commentform" method="post" action="#" class="form form-inline form-contact">
                            <p class="push-down-20">
                                <input type="text" aria-required="true" tabindex="1" size="30" value="" id="author" name="author" required>
                                <label for="author">نام<span class="red-clr bold">*</span></label>
                            </p>
                            <p class="push-down-20">
                                <input type="email" aria-required="true" tabindex="2" size="30" value="" id="email" name="email" required>
                                <label for="email">ایمیل<span class="red-clr bold">*</span></label>
                            </p>
                            <p class="push-down-20">
                                <input type="text" tabindex="3" size="30" value="" id="url" name="url">
                                <label for="url">وبسایت</label>
                            </p>
    
                            <p class="push-down-20">
                                <textarea class="input-block-level" tabindex="4" rows="7" cols="70" id="comment" name="comment" placeholder="پیامتان را در اینجا بنویسید ..." required></textarea>
                            </p>
                            <p>
                                <button class="btn btn-primary bold" type="submit" tabindex="5" id="submit">ارسال پیام</button>
                            </p>
                        </form>
                    </section>
                    
                    <hr />
                    
                    <!--  ==========  -->
                    <!--  = Company Info with Google Maps =  -->
                    <!--  ==========  -->
                    <article class="company-info">
                        <div class="row">
                        	<div class="span3">
                        		<h3 class="push-down-30"><span class="light">اطلاعات</span> شرکت</h3>
                        		    
                        		<p>
                        		    <strong class="opensans dark-clr">فروشگاه آنلاین ویستا موبایل</strong>
                        		    <br />
                        		    <br />
                        		  فارس
                        		    <br />
                        		  شیراز،خیابان توحید(داریوش)
                        		
                                    پاساژ ایروانی، ورودی مجتمع تجاری شهر پلاک B42
                        		
                                </p>
                        		    
                        		<p>
                        		    <strong class="opensans dark-clr">شماره تماس 1:</strong> 2356733
                        		    <br />
                        		    <strong class="opensans dark-clr">شماره تماس 2:</strong> 2356735
                        		    <br />
                        		    <strong class="opensans dark-clr">فکس:</strong> 2356719
                        		    <br />
                        		    <strong class="opensans dark-clr">ایمیل:</strong> <a href="#">farmehdi2010@yahoo.com</a>
                        		</p>
                        	</div>
                        	<div class="span5">
                        	    <div class="add-googlemap" data-height="205" data-addr="shiraz,iran" data-title="vista mobile" data-zoom="14" data-type="roadmap"></div>
                        	</div>
                        </div>
    
                    </article>

                </section>
                <!-- /main content -->
                <!--  ==========  -->
                <!--  = Sidebar =  -->
                <!--  ==========  -->
                <aside class="span4">
                    
                    <!--  ==========  -->
                    <!--  = Opening Times Widget =  -->
                    <!--  ==========  -->
                    <div class="sidebar-item opening-time" id="opening_time-4">
                        <div class="underlined">
                            <h3><span class="light">ساعات</span> کاری</h3>
                        </div>
                        <div class="time-table">
                            <dl class="week-day">
                                <dt>
                                    شنبه
                                </dt>
                                <dd>
                                    9:00 - 21:00  
                                </dd>
                            </dl>
                            <dl class="week-day light-bg">
                                <dt>
                                    یکشنبه
                                </dt>
                                <dd>
                                    9:00 - 21:00  
                                </dd>
                            </dl>
                            <dl class="week-day">
                                <dt>
                                    دوشنبه
                                </dt>
                                <dd>
                                    9:00 - 21:00  
                                </dd>
                            </dl>
                            <dl class="week-day light-bg ">
                                <dt>
                                    سه شنبه
                                </dt>
                                <dd>
                                    9:00 - 21:00  
                                </dd>
                            </dl>
                            <dl class="week-day">
                                <dt>
                                    چهارشنبه
                                </dt>
                                <dd>
                                    9:00 - 21:00  
                                </dd>
                            </dl>
                            <dl class="week-day light-bg">
                                <dt>
                                    پنج شنبه
                                </dt>
                                <dd>
                                    9:00 - 21:00  
                                </dd>
                            </dl>
                            <dl class="week-day closed">
                                <dt>
                                    جمعه
                                </dt>
                                <dd>
                                    تعطیل
                                </dd>
                            </dl>
                        </div>
                    </div>
                    
                    <!--  ==========  -->
                    <!--  = Twitter Widget =  -->
                    <!--  ==========  -->
        <%--            <div class="sidebar-item widget_twitter">
                        <div class="underlined">
                            <h3><span class="light">فید</span> توییتر</h3>
                        </div>
                        
                        <a class="twitter-timeline"  href="https://twitter.com/primozدیوید"  data-widget-id="361435057526800385">Tweets by @primozدیوید</a>
<script>    !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + "://platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } } (document, "script", "twitter-wjs");</script>

                    </div>
                    --%>
                    
                </aside>
                <!-- /sidebar -->
            </div>
        </div>
    </div>
    <!-- /container -->
</asp:Content>
