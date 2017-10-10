<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ReservationDetails.aspx.cs" Inherits="PoseidonDeluxeUI.ReservationDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Resort Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
		function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- //for-mobile-apps -->
<link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
<link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" property="" />
<link rel="stylesheet" type="text/css" href="css/zoomslider.css" />
<link rel="stylesheet" type="text/css" href="css/style.css" />
<link href="css/font-awesome.css" rel="stylesheet"/ />
<script type="text/javascript" src="js/modernizr-2.6.2.min.js"></script>
<!--/web-fonts-->
<link href="//fonts.googleapis.com/css?family=Dosis:200,300,400,500,600" rel="stylesheet" />
<link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i" rel="stylesheet" />
<!--//web-fonts-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="css/rdstyle.css" rel="stylesheet" type="text/css" media="all"/>
<link rel="stylesheet" href="css/font-awesome.css"/> <!-- Font-Awesome-Icons-CSS -->
<!-- //css files -->
<!-- online-fonts -->
<link href="//fonts.googleapis.com/css?family=Pinyon+Script" rel="stylesheet"/>
<link href="//fonts.googleapis.com/css?family=Lato:100,100i,300,300i,400,400i,700,700i,900,900i&amp;subset=latin-ext" rel="stylesheet"/>
<!--//online-fonts -->
     <div class="w3_breadcrumb">
	<div class="breadcrumb-inner">	
			<ul>
				<li><a href="index.aspx">Home</a> <i>/</i><a href="Reservation.aspx">Reservation</a><i>/</i>
                    
				</li>
				
				<li><i>/</i><a href="PaymentPage.aspx">Payment</a> </li>
                <li>ReservationDetails</li>
			</ul>
		</div>
	</div>   
<div class="header">
	<h1></h1>
</div>
<div class="w3-main">
	<div class="agile-info">
	
                                    
		<h3> Booking Successful</h3>
        <hr />
		<p style="    padding-left: 70px;
    padding-right: 70px;">Reservation information numbered "<b style="font-weight:bold"><%=Session["ReservationID"] %></b>" has been sent to your e-mail address.</p>
        <p>Good Holidays</p>
		<a href="PaymentPage.aspx"><i class="fa fa-angle-double-left" aria-hidden="true"></i>go back</a>
	</div>
</div>
<div class="footer-w3l">
	
</div>
    

</asp:Content>
