<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="PoseidonDeluxeUI.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Resort Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
		function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- //for-mobile-apps -->
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" />

    <link rel="stylesheet" type="text/css" href="css/zoomslider.css" />
    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <link href="css/font-awesome.css" rel="stylesheet" />
    <script type="text/javascript" src="js/modernizr-2.6.2.min.js"></script>
    <!--/web-fonts-->
    <link href="//fonts.googleapis.com/css?family=Dosis:200,300,400,500,600" rel="stylesheet" />
    <link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i" rel="stylesheet" />
    <!--//web-fonts-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/signup.css" type="text/css" rel="stylesheet" />
    <div class="w3_breadcrumb">
        <div class="breadcrumb-inner">
            <ul>
                <li><a href="index.aspx">Home</a> <i>/</i></li>

                <li>Login</li>
            </ul>
        </div>
    </div>
    <div class="w3layouts-main">
        <h1>Login </h1>
        <div class="agilesign-form">
            <div class="agileits-top">


                <div class="styled-input w3ls-text">
                    <input type="email" name="email" id="email" required="" runat="server" />
                    <%--  <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>--%>
                    <label>Email ID</label>
                    <span></span>
                </div>
                <div class="styled-input w3ls-text">
                    <input type="password" name="Password" id="password" runat="server" required="" />
                    <%--  <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>--%>
                    <label>Password</label>
                    <span></span>
                </div>



                <div class="agileits-bottom">
                    <%--<input type="submit"  value="Login" id="btnsubmit" runat="server" />--%>
                    <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" />

                </div>
                <div style="margin-top: 30px; margin-left: 100px;">
                    <asp:Label ID="lblalertsuccess" runat="server" class="alert alert-success" role="alert">Login Successful!</asp:Label>
                </div>

                <div style="margin-top: -5px; margin-left: 10px;">
                    <asp:Label ID="lblalertdanger" runat="server" class="alert alert-danger" role="alert">No registration Please check your information</asp:Label>
                </div>




            </div>
            <div class="w3agile-btm">
                <p>Are not you a member yet?<a href="SignUp.aspx">Sign Up</a> </p>
            </div>
        </div>
    </div>
</asp:Content>
