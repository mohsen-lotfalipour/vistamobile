<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true"
    CodeFile="userpanel.aspx.cs" Inherits="userpanel" %>

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
                        <li><a href="userpanel.aspx">مدیریت حساب</a> </li>
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
                        	<h3><span class="light"></span> مدیریت حساب</h3>
                        </div>
                        
                        <!--  ==========  -->
                        <!--  = Menu (affix) =  -->
                        <!--  ==========  -->
                        <div class="row">
                        	<div class="span3" id="spyMenu">
		                    	<ul class="nav nav-pills nav-stacked">
		                    	    <li><a href="userpanel.aspx">تغییر مشخصات<i class="icon-caret-right pull-right"></i></a></li>
                                     <li><a href="#" onserverclick="Edit_Pass_show" runat="server">تغییر نام کاربری و رمز عبور<i class="icon-caret-right pull-right"></i></a></li>
		                    	    <li><a href="#" onserverclick="order_detail_show" runat="server">پیگیری سفارشات<i class="icon-caret-right pull-right"></i></a></li>
		                    	    
		                    	</ul>
                        	</div>
                        </div>
                        
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
                        <h3><span class="light"></span> مدیریت حساب</h3>
                        <label id="edit_error_label" runat="server">
                                <%-- error message--%>
                        </label>
                     </div> <!-- /title -->
                        <div id="edit_user" runat="server">
                         <form action="#" method="post" class="form-horizontal form-checkout">
                                <div class="control-group">
                                    <label class="control-label" for="firstName">نام<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                               <input type="text" id="firstName" class="span4" runat="server" required="true"  oninvalid="InvalidMsg(this,'لطفا از کاراکترهای مجاز استفاده کنید','لطفا نام خود را وارد کنید');" oninput="setCustomValidity('')" pattern="[a-zA-Z]+" name="firstName" clientidmode="Static">
                                     <%--   <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                                                ControlToValidate="firstName"
                                                ErrorMessage="لطفا نام خود را وارد کنید"
                                                ForeColor="Red">
                                        </asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" for="lastName">نام خانوادگی<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                                        <input type="text" id="lastName"  class="span4" runat="server" required="true" oninvalid="InvalidMsg(this,'لطفا از کاراکترهای مجاز استفاده کنید','لطفا نام خانوادگی خود را وارد کنید');" oninput="setCustomValidity('')" pattern="[a-zA-Z]+" name="lastName">
                                        <%--<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                                                ControlToValidate="lastName"
                                                ErrorMessage="لطفا نام خانوادگی خود را وارد کنید"
                                                ForeColor="Red">
                                        </asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" for="telephone">تلفن<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                                        <input type="text" id="telephone" class="span4" runat="server"  required="true"  oninvalid="InvalidMsg(this,'شماره تلفن شامل حروف نمیباشد','لطفا تلفن خود را وارد کنید');" oninput="setCustomValidity('')" pattern="[0-9]+" name="telephone">
                                       <%--  <asp:RequiredFieldValidator id="RequiredFieldValidatortel" runat="server"
                                                ControlToValidate="telephone"
                                                ErrorMessage="لطفا تلفن خود را وارد کنید"
                                                ForeColor="Red">
                                        </asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                                 <div class="control-group">
                                    <label class="control-label" for="mobile">موبایل<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                                        <input type="text" id="mobile" class="span4" runat="server"  required="true"  oninvalid="InvalidMsg(this,'شماره موبایل شامل حروف نمیباشد','لطفا موبایل خود را وارد کنید');" oninput="setCustomValidity('')" pattern="[0-9]+" name="mobile">
                                       <%--  <asp:RequiredFieldValidator id="RequiredFieldValidatortel" runat="server"
                                                ControlToValidate="telephone"
                                                ErrorMessage="لطفا تلفن خود را وارد کنید"
                                                ForeColor="Red">
                                        </asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" for="email">ایمیل<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                                        <input type="text" id="email" class="span4" runat="server" required="true"  oninvalid="InvalidMsg(this,'ایمیل وارد شده معتبر نمیباشد','لطفا ایمیل خود را وارد کنید');"
                                                        oninput="setCustomValidity('')" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$" name="email">
                                         <%--     <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server"
                                                ControlToValidate="email"
                                                ErrorMessage="لطفا ایمیل خود را وارد کنید"
                                                ForeColor="Red">
                                        </asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                                 <div class="control-group">
                                    <label class="control-label" for="city">استان<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                                     <select runat="server" name="Ostan" id="ostan_id" onchange="city_selected(this.value);" clientidmode="Static">
                        <option value="">لطفا استان خود را انتخاب کنید</option>
                        <option value="41">آذربايجان شرقي</option>
                        <option value="44">آذربايجان غربي</option>
                        <option value="45">اردبيل</option>
                        <option value="31">اصفهان</option>
                        <option value="26">البرز</option>
                        <option value="84">ايلام</option>
                        <option value="77">بوشهر</option>
                        <option value="21">تهران</option>
                        <option value="38">چهارمحال بختياري</option>
                        <option value="56">خراسان جنوبي</option>
                        <option value="51">خراسان رضوي</option>
                        <option value="58">خراسان شمالي</option>
                        <option value="61">خوزستان</option>
                        <option value="24">زنجان</option>
                        <option value="23">سمنان</option>
                        <option value="54">سيستان و بلوچستان</option>
                        <option value="71" selected="selected">فارس</option>
                        <option value="28">قزوين</option>
                        <option value="25">قم</option>
                        <option value="87">كردستان</option>
                        <option value="34">كرمان</option>
                        <option value="83">كرمانشاه</option>
                        <option value="74">كهكيلويه و بويراحمد</option>
                        <option value="17">گلستان</option>
                        <option value="13">گيلان</option>
                        <option value="66">لرستان</option>
                        <option value="15">مازندران</option>
                        <option value="86">مركزي</option>
                        <option value="76">هرمزگان</option>
                        <option value="81">همدان</option>
                        <option value="35">يزد</option>
                    </select>
                    <label class="control-label" for="shahrestan">شهرستان<span class="red-clr bold">*</span></label>
                    <select  runat="server"  name="city" id="city_id" clientidmode="Static">
                        <%--<option value="-1">لطفا شهر خود را  انتخاب کنید</option>--%>
                    </select>
                      <%-- <script>city_selected("71");</script>--%>
                                       </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="addr1">ادرس 1<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                                        <input type="text" id="addr1" class="span4" runat="server"  required="true" oninvalid="setCustomValidity('لطفا آدرس خود را وارد کنید')" oninput="setCustomValidity('')" name="addr1">
                                            <%--  <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server"
                                                ControlToValidate="addr1"
                                                ErrorMessage="لطفا آدرس خود را وارد کنید"
                                                ForeColor="Red">
                                        </asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" for="zip">کد پستی<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                                        <input type="text" id="zip" class="span4" runat="server"   required="true"  oninvalid="InvalidMsg(this,'کد پستی شامل حروف نمیباشد','لطفا کد پستی خود را وارد کنید');" oninput="setCustomValidity('')" pattern="[0-9]+" name="zip">
                                           <%--   <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server"
                                                ControlToValidate="zip"
                                                ErrorMessage="لطفا کد پستی خود را وارد کنید"
                                                ForeColor="Red">
                                        </asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" for="company">شرکت یا فروشگاه</label>
                                    <div class="controls">
                                        <input type="text" id="company" class="span4" runat="server" name="company">
                                            <%--  <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server"
                                                ControlToValidate="addr1"
                                                ErrorMessage="لطفا آدرس خود را وارد کنید"
                                                ForeColor="Red">
                                        </asp:RequiredFieldValidator>--%>
                                    </div>
                                </div>
                            
                                      <hr />
						    <p class="right-align">
						        
                                <input type="submit"  class="btn btn-primary higher bold" onserverclick="Edit_Click" id="edit_user_click" runat="server" clientidmode="Static"  value="ویرایش اطلاعات" />
						    </p>
                                
                            </form>
                            </div>
                    
                    <div id="edit_pass" class="blocks-spacer" runat="server">
                      <form action="#" method="post" class="form-horizontal form-checkout">  
                     <div class="control-group">
                                    <label class="control-label" for="user_name">نام کاربری<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                                        <input type="text" id="user_name"  class="span4" runat="server" required="true" oninvalid="InvalidMsg(this,'لطفا از کاراکترهای مجاز استفاده کنید','لطفا نام کاربری خود را وارد کنید');" oninput="setCustomValidity('')" pattern="[a-zA-Z0-9@._-]+" name="user_name"/>
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" for="pass">رمز عبور قدیم<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                                        <input type="password" id="pass"  class="span4" runat="server" required="true" oninvalid="InvalidMsg(this,'لطفا از کاراکترهای مجاز استفاده کنید','لطفا رمز عبور خود را وارد کنید');" oninput="setCustomValidity('')" pattern="[a-zA-Z0-9]+" name="pass"/>
                                    </div>
                                </div>
                                <div class="control-group">
                                    <label class="control-label" for="new_pass"> رمز عبور جدید<span class="red-clr bold">*</span></label>
                                    <div class="controls">
                                        <input type="password" id="new_pass"  class="span4" runat="server" required="true" oninvalid="InvalidMsg(this,'لطفا از کاراکترهای مجاز استفاده کنید','لطفا رمز عبور خود را وارد کنید');" oninput="setCustomValidity('')" pattern="[a-zA-Z0-9]+" name="new_pass"/>
                                    </div>
                                </div>
                                      <hr />
						    <p class="right-align">
						        
                                <input type="submit"  class="btn btn-primary higher bold" onserverclick="Edit_Pass_Click" id="Submit1" runat="server" clientidmode="Static"  value="ویرایش اطلاعات" />
						    </p>
                                
                            </form>
                	</div>
                    <div id="order_detail" runat="server" clientidmode="Static">
                    
                      <section id="toggles">
                	    <h3 class="push-down-20"><span class="light"></span> سفارشات</h3>
                         <div class="accordion" id="order_detail_toggle" runat="server" clientidmode="Static">
                           <!-- /generate order -->
                         </div>
                	   </section>
                    </div>
                    
        </section>
                <!-- /main content -->
            </div>
        </div>
    </div>
    <!-- /container -->
</asp:Content>
