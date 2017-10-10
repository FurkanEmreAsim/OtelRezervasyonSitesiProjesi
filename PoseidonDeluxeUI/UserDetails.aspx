<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"   CodeBehind="UserDetails.aspx.cs"  Inherits="PoseidonDeluxeUI.UserDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/flexslider.css" rel="stylesheet" />
    <link href="css/font-awesome.css" rel="stylesheet" />
    <link href="css/jquery-ui.css" rel="stylesheet" />
    <link href="css/lightbox.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/zoomslider.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/signup.css" type="text/css" rel="stylesheet" />
    <!-- main -->
     <div class="w3_breadcrumb">
	<div class="breadcrumb-inner">	
			<ul>
				<li><a href="index.aspx">Home</a> <i>/</i></li>
				
				<li>User Details</li>
			</ul>
		</div>
	</div>
	<div class="w3layouts-main"> 
		<h1>User Details</h1>
		<div class="agilesign-form">  
			<div class="agileits-top">
				
					
					<div class="styled-input w3ls-text">
						<input type="email" id="email" runat="server" name="email" required=""/>
						<label>Email ID</label>
						<span></span>
					</div>
					<div class="styled-input w3ls-text">
						<input type="password" id="password" name="Password" runat="server" required=""/> 
						<label>Password</label>
						<span></span>
					</div> 
                    <div class="styled-input w3ls-text">
                        <input type="text" name="User Name" id="username" runat="server" required="" />
                        <label>User Name</label>
                        <span></span>
                    </div>
                    <div class="styled-input w3ls-text">
                        <input type="text" name="Last Name" id="lastname" runat="server" required="" />
                        <label>Last Name</label>
                        <span></span>
                    </div>
					
					
					<div class="agileits-bottom"> 
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
					</div>	
                   
                 <div class="alert alert-success" role="alert" style="margin-top: 10px; visibility: hidden;">
                    <strong>Registration Successful!</strong>
                </div>
                <div class="alert alert-danger" role="alert" style="visibility: hidden;">
                    <strong>No registration</strong> Please check your information
					  
                </div>

				
			</div> 
			
		</div>	
	</div>	
	<!-- //main -->
</asp:Content>
