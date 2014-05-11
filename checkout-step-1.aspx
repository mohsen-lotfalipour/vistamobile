<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true"
    CodeFile="checkout-step-1.aspx.cs" Inherits="checkout_step_1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
<script>
    function number2() {
        $(".numbered > .clickable").click(function (ev) {
            ev.preventDefault();
            var number = parseInt($(this).siblings('input[type="text"]').val(), 10);
            var totalprice = parseInt($(this).parent().parent().next().text(), 10);
            var unitprice = totalprice / number;
            var total = parseInt($("#total_price_review").text(), 10);
            if (isNaN(number)) {
                number = 1;
            }
            if ($(this).hasClass("add-one")) {
                $(this).siblings('input[type="text"]').val(number + 1);
                $(this).parent().parent().next().text(totalprice + unitprice + "  ریال  ");
                $("#total_price_review").text(total + unitprice + "  ریال  ");
            } else {
                number = number < 2 ? 2 : number;
                $(this).siblings('input[type="text"]').val(number - 1);
                unitprice = unitprice == totalprice ? 0 : unitprice;
                $(this).parent().parent().next().text(totalprice - unitprice + "  ریال  ");
                $("#total_price_review").text(total - unitprice + "  ریال  ");
            }
        });

    }
</script>
<script type="text/javascript">
//call click event
    $(function () {
        $('#accept_cart_step1').click(function () {
            var listoftxts = $('#table_body input[type="text"]');
            var values="";
            for (var i = 0; i < listoftxts.length; i++) {
                values += listoftxts[i].name + "=" + listoftxts[i].value+",";
            }
            $('#hdnfldVariable').val(values.toString());
        });
        });

</script>
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
                        <li><a href="checkout-step-1.aspx">بازبینی سبد خرید</a> </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="push-up top-equal blocks-spacer">
            <div class="row blocks-spacer">
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
                    		    	        <h1><span class="light">بازبینی</span> سبد خرید</h1>
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
                    		    	<div class="step active">
                    		    	    <div class="step-badge">1</div>
                    		    	    سبد خرید
                    		    	</div>
                    		    	<div class="step">
                    		    	    <div class="step-badge">3</div>
                    		    	    آدرس ارسال
                    		    	</div>
                    		    	<div class="step">
                                        <div class="step-badge">2</div>
                                        شیوه پرداخت
                                    </div>
                    		    	<div class="step">
                    		    	    <div class="step-badge">4</div>
                    		    	    تایید و پرداخت
                    		    	</div>
                    		    </div>
                    		</div> <!-- /steps -->
                    		
                    		<!--  ==========  -->
							<!--  = Selected Items =  -->
							<!--  ==========  -->
                              <asp:UpdatePanel id="panel_table" runat="server" ClientIDMode="Static" UpdateMode="Always" EnableViewState="true">
                              <ContentTemplate>
                              <script type="text/javascript" language="javascript">
                                  Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(number2);
                                  //Sys.Application.add_load(number2);
                                  //Sys.Application.add_load(AddRequestHandler);
                                  //Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(BeginRequestHandler);
                                  //Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(PageLoadedHandler);
                             </script>
							<table class="table table-items">
							    <thead>
							    	<tr>
							    		<th colspan="2">مشخصات محصول</th>
							    		<th><div class="align-center">تعداد</div></th>
							    		<th><div class="align-right">قیمت</div></th>
							    	</tr>
							    </thead>
                               
							    <tbody id="table_body" runat="server" ClientIDMode="Static">
                                  	       
							        <tr>
							        	<td class="image"><img src="images/dummy/cart-items/cart-item-5.jpg" alt="" width="124" height="124" /></td>
							        	<td class="desc">لباس ورزشی آدیداس &nbsp; <a title="Remove Item" class="icon-remove-sign" href="#"></a></td>
							        	<td class="qty">
							        	    <input type="text" class="tiny-size" value="4" />
					            	    </td>
							        	<td class="price">
							        	    $59
							        	</td>
							        </tr>                                    							                                        
							    </tbody> 
                                 <tr>                                     
							        	<td colspan="2" rowspan="2">
							        	    <div class="alert alert-info">
                                                <button data-dismiss="alert" class="close" type="button">×</button>
                                                هزینه ارسال بر اساس منطقه جغرافیایی محاسبه میشود. <a href="#">اطلاعات بیشتر</a>
                                            </div>
							        	</td>
							        	<td class="stronger">هزینه ارسال :</td>
							        	<td class="stronger"><div class="align-right" id="send_price_review" runat="server" ClientIDMode="Static">0 ریال</div></td>
							        </tr>
							        <tr>
							        	<td class="stronger">جمع کل :</td>
                                     
							        	<td class="stronger"><div class="size-16 align-right" id="total_price_review" runat="server" ClientIDMode="Static">0</div></td>
 
							        </tr>                                  
							</table>
                           </ContentTemplate>
                          </asp:UpdatePanel>  
							<hr />
							
							<p class="right-align">
							    در مرحله بعدی شما آدرس ارسال را انتخاب خواهید کرد. &nbsp; &nbsp;
							    <a href="#" class="btn btn-primary higher bold" onserverclick="Acceptcart_Click" id="accept_cart_step1" runat="server" clientidmode="Static">ادامه</a>
							</p>
                    	</div>
                    </div>
                </div>
                
              <asp:HiddenField ID="hdnfldVariable" runat="server" ClientIDMode="Static"/>  
            </section>
                <!-- /main content -->
            </div>
        </div>
    </div>
    <!-- /container -->
</asp:Content>
