<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="404.aspx.cs" Inherits="_404" %>

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
                            <a href="404.aspx">خطای 404</a>
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
                <!--  = Main content =  -->
                <!--  ==========  -->
                <section class="span12">
                    
                    <p class="container-404">
                        <img src="images/404.png" alt="404 Error" width="394" height="161" />
                    </p>
                	
                	<hr />
                	
                	<p class="center-align size-16">
                	    به نظر می آید مشکلی پیش آمده! این صفحه  که به دنبال آن میگردید در اینجا نیست. 
                	</p>
                	<p class="center-align size-16 push-down-50">
                	    به <a href="index.aspx">خانه</a> باز گردید 
                	</p>
                	
                	
                	
                </section> <!-- /main content -->
            </div>
        </div>
    </div> <!-- /container -->
</asp:Content>

