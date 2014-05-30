<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="checkout-step-4.aspx.cs" Inherits="checkout_step_4" %>

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
                            <a href="checkout-step-1.aspx">بازبینی سبد خرید</a>
                        </li>
                        <li><span class="icon-chevron-left"></span></li>
                        <li>
                            <a href="checkout-step-2.aspx">آدرس ارسال و پرداخت</a>
                        </li>
                         <li><span class="icon-chevron-left"></span></li>
                        <li>
                            <a href="checkout-step-3.aspx">شیوه پرداخت</a>
                        </li>
                        <li><span class="icon-chevron-left"></span></li>
                        <li>
                            <a href="checkout-step-4.aspx">تایید و پرداخت</a>
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
                
                <div class="checkout-container">
                    <div class="row">
                    	<div class="span10 offset1">
                    	    
                    	    <!--  ==========  -->
							<!--  = Header =  -->
							<!--  ==========  -->
                    		<header>
                    		    <div class="row">
                    		    	<div class="span2">
                    		    		<a href="index.aspx"><img src="images/logo-bw.png" alt="Webmarket Logo" width="48" height="48" /></a>
                    		    	</div>
                    		    	<div class="span6">
                    		    	    <div class="center-align">
                    		    	        <h1><span class="light">تاييد</span> و پرداخت</h1>
                    		    	    </div>
                    		    	</div>
                    		    	<div class="span2">
                    		    	    <div class="right-align">
                    		    	    	<img src="images/buttons/security.jpg" alt="Security Sign" width="92" height="65" />
                    		    	    </div>
                    		    	</div>
                    		    </div>
                    		</header>
                    		
                    		<!--  ==========  -->
							<!--  = Steps =  -->
							<!--  ==========  -->
                    		<div class="checkout-steps">
                    		    <div class="clearfix">
                    		    	<div class="step done">
                    		    	    <div class="step-badge"><i class="icon-ok"></i></div>
                    		    	    <a href="checkout-step-1.aspx">سبد خريد</a>
                    		    	</div>
                    		    	<div class="step done">
                                        <div class="step-badge"><i class="icon-ok"></i></div>
                                        <a href="checkout-step-2.aspx">آدرس ارسال</a>
                                    </div>
                    		    	<div class="step done">
                    		    	    <div class="step-badge"><i class="icon-ok"></i></div>
                    		    	    <a href="checkout-step-3.aspx">شيوه پرداخت</a>
                    		    	</div>
                    		    	<div class="step active">
                    		    	    <div class="step-badge">4</div>
                    		    	    تاييد و پرداخت
                    		    	</div>
                    		    </div>
                    		</div> <!-- /steps -->
                    		
                    		<!--  ==========  -->
							<!--  = Selected Items =  -->
							<!--  ==========  -->
							<table class="table table-items">
							    <thead>
							    	<tr>
							    		<th colspan="2">مشخصات محصول</th>
							    		<th><div class="align-center">تعداد</div></th>
							    		<th><div class="align-right">قيمت</div></th>
							    	</tr>
							    </thead>
							    <tbody>
							          <p id="table_body_final" runat="server">	
							       
                                     </p>
							        <tr>
							        	<td colspan="2" rowspan="2">
							        	    &nbsp;
							        	</td>
							        	<td class="stronger">هزينه ارسال :</td>
							        	<td class="stronger"><div class="align-right" id="send_price_final" runat="server">0</div></td>
							        </tr>
							        <tr>
							        	<td class="stronger">جمع کل :</td>
							        	<td class="stronger"><div class="size-16 align-right" id="total_price_final" runat="server">0</div></td>
							        </tr>
                                   
							    </tbody>
							</table>
							
							<p class="right-align">
							    <a href= "#" class="btn btn-primary higher bold" runat="server" onserverclick="Acceptfinal_Click">تاييد و پرداخت</a>
							</p>
                    	</div>
                    </div>
                </div>
                
                
            </section> <!-- /main content -->
        
        </div>
        </div>
    </div> <!-- /container -->
    
</asp:Content>

