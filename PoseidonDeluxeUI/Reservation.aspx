<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="PoseidonDeluxeUI.Reservation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/zoomslider.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/flexslider.css" rel="stylesheet" />
    <link href="css/font-awesome.css" rel="stylesheet" />
    <link href="css/jquery-ui.css" rel="stylesheet" />
    <link href="css/lightbox.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <script src="js/jquery-2.1.4.min.js"></script>

    <script type="text/javascript" src="js/modernizr-2.6.2.min.js"></script>

    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
		function hideURLbar(){ window.scrollTo(0,1); } </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Majestic hotel booking form Widget a Flat Responsive Widget,Login form widgets, Sign up Web forms , Login signup Responsive web form,Flat Pricing table,Flat Drop downs,Registration Forms,News letter Forms,Elements" />
    <!-- Meta tag Keywords -->

    <!--fontawesome-css-->
    <link href="css/rejquery-ui.css" rel="stylesheet" />
    <link href="//fonts.googleapis.com/css?family=Poiret+One" rel="stylesheet" />
    <link href="//fonts.googleapis.com/css?family=Raleway" rel="stylesheet" />

    <link href="css/restyle.css" rel="stylesheet" type="text/css" media="all" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <div class="w3_breadcrumb">
        <div class="breadcrumb-inner">
            <ul>
                <li><a href="index.aspx">Home</a> <i>/</i></li>

                <li>Reservation</li>
            </ul>
        </div>
    </div>
    <section class="booking-agile">
        <h1 style="margin-right: 400px;">Reservation form </h1>

        <div class="headbooking-agile">
            <div class="bookingleft-agile">
                <h2>make a reservation</h2>

                <div class="arrival-agile">
                    <p>check-in date</p>
                    <%--<input placeholder="Check in" class="date" id="datepicker" type="text" value="" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}" required=""  />--%>
                    <asp:TextBox ID="chkindate" runat="server" TextMode="Date" AutoPostBack="true" Width="245px" Style="background-color: transparent; color: white;"></asp:TextBox>
                </div>
                <div class="departure-agile">
                    <p>check-out date</p>
                    <%--<input placeholder="Check in" class="date" id="datepicker1" type="text" value="" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '';}" required=""  />--%>
                    <asp:TextBox ID="chkoutdate" runat="server" TextMode="Date" AutoPostBack="true" Width="245px" Style="background-color: transparent; color: white;" ></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="guest-agile">
                    <p>guest</p>
                    <asp:DropDownList ID="ddltotalperson" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddltotalperson_SelectedIndexChanged">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="room-agile">
                    <p>Reservation Type</p>
                    <asp:DropDownList ID="ddlreservationtype" runat="server">
                    </asp:DropDownList>
                    <div class="clear"></div>
                </div>

                <div class="room-agile" style="margin-left:25%">
                    <p>Room Numbers</p>
                    <asp:DropDownList ID="ddlGuestNumber" runat="server">
                    </asp:DropDownList>
                    <div class="clear"></div>
                </div>




                <div class="clear"></div>
                <div class="name-agile">
                    <p>First name</p>
                     <input type="text" id="txtfirstname" name="text" required="" runat="server" placeholder="First Name" />
                    <%--<asp:TextBox ID="txtfirstname" placeholder="First Name" runat="server"></asp:TextBox>--%>
                </div>
                <div class="last-agile">
                    <p>last name	</p>
                    <input type="text" id="txtlastname" name="text" required="" runat="server" placeholder="Last Name" />
                    <%--<asp:TextBox ID="txtlastname" placeholder="Last Name" runat="server"></asp:TextBox>--%>
                </div>

                <div class="name-agile">
                    <p>CivilizationNumber</p>
                     <input type="text" id="txtcivilnumber" name="text" required="" runat="server" placeholder="CivilizationNumber" />
                   <%-- <asp:TextBox ID="txtcivilnumber" placeholder="CivilizationNumber" runat="server"></asp:TextBox>--%>
                </div>
                <div class="room-agile" style="height: 114.188px; padding-top: 3px;">
                    <p>Gender </p>
                    <asp:DropDownList ID="ddlgender" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                    <div class="clear"></div>
                </div>

                <div id="guest" runat="server"></div>







                <div class="clear"></div>
                <div class="submit-agile">
                    <asp:Button ID="btnReservation" runat="server" Text="Check Availability" OnClick="btnReservation_Click" />
                    <br />

                    <asp:GridView ID="grdEntryOutList" AutoGenerateColumns="true" runat="server">
                    </asp:GridView>

                    <asp:DataList ID="dtlEntrOutList" runat="server"></asp:DataList>



                </div>
                <div style="margin-top: 30px; margin-left: 165px">
                    <asp:Label ID="lblalertsuccess" runat="server" class="alert alert-success" role="alert" Style="visibility: hidden">Registration Successful!</asp:Label>
                </div>

                <div style="margin-top: -25px; margin-left: 80px;">
                    <asp:Label ID="lblalertdanger" runat="server" class="alert alert-danger" role="alert" Style="visibility: hidden">No registration Please check your information</asp:Label>
                </div>

                <div class="clear"></div>



            </div>


            <h1 style="margin-right: -200px; font-size: 40px;">Reservation Type  </h1>
            <div class="plans-section">

                <div class="container">
                    <%--<h3 class="w3l-inner-h-title">Rates and Booking</h3>--%>
                    <div class="priceing-table-main">



                        <div class="col-md-3 price-grid" style="margin-left: 150px;">
                            <div class="price-block agile" style="margin-top: -100px;">
                                <button class="btnstndrt" style="font-size: 1.8em; color: #fff; padding: 0.4em 1em; background: #0e99ce; font-weight: 300; height: 54px; width: 255.19px; border-color: #0e99ce;">
                                    STANDART</button>
                                <div class="s" style="display: none">
                                    <div class="price-gd-top pric-clr1">
                                        <%-- <h4>STANDART</h4>--%>


                                        <h3><span>$</span>50</h3>
                                        <h6 class="bed two"><i class="fa fa-bed" aria-hidden="true"></i></h6>
                                        <h5 style="margin-right: 45px;">1 Night</h5>

                                    </div>
                                    <div class="price-gd-bottom">
                                        <div class="price-list">

                                            <ul>
                                                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star-o" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star-o" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star-o" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star-o" aria-hidden="true"></i></li>

                                            </ul>

                                        </div>
                                        <div class="price-selet pric-sclr1">
                                            <a href="Reservation.aspx" class="scroll">Book Now</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="col-md-3 price-grid " style="margin-top: 30px; margin-left: 150px;">
                            <div class="price-block agile">
                                <button class="btnfull" style="font-size: 1.8em; color: #fff; padding: 0.4em 1em; background: #fbbe09; font-weight: 300; height: 54px; width: 255.19px; border-color: #fbbe09;">
                                    FULL</button>
                                <div class="f" style="display: none">
                                    <div class="price-gd-top pric-clr2">
                                        <%--<h4>FULL</h4>--%>


                                        <h3><span>$</span>100</h3>
                                        <h6 class="bed"><i class="fa fa-bed" aria-hidden="true"></i></h6>
                                        <h5 style="margin-right: 45px;">1 Night</h5>
                                    </div>
                                    <div class="price-gd-bottom">
                                        <div class="price-list">

                                            <ul>
                                                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star-o" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star-o" aria-hidden="true"></i></li>

                                            </ul>


                                        </div>
                                        <div class="price-selet pric-sclr2" style="margin-top: 20px">
                                            <a href="index.aspx" class="scroll">Book Now</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="col-md-3 price-grid lost" style="margin-top: 50px; margin-left: 150px;">
                            <div class="price-block agile">
                                <button class="btnff" style="font-size: 1.8em; color: #fff; padding: 0.4em 1em; background: #209a20; font-weight: 300; height: 54px; width: 255.19px; border-color: #209a20;">
                                    FULL + FULL</button>
                                <div class="ff" style="display: none">
                                    <div class="price-gd-top pric-clr3">
                                        <%--<h4>FULL + FULL</h4>--%>

                                        <h3><span>$</span>150</h3>
                                        <h6 class="bed four"><i class="fa fa-bed" aria-hidden="true"></i></h6>
                                        <h5 style="margin-right: 45px;">1 Night</h5>
                                    </div>
                                    <div class="price-gd-bottom">
                                        <div class="price-list">
                                            <ul>
                                                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                <li><i class="fa fa-star" aria-hidden="true"></i></li>

                                            </ul>

                                        </div>
                                        <div class="price-selet pric-sclr3">
                                            <a href="Reservation.aspx" class="scroll">Book Now</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>

            <div class="clear"></div>
        </div>

    </section>
    <!--start-date-piker-->
    <link rel="stylesheet" href="css/jquery-ui.css" />
    <script src="js/jquery-ui.js"></script>
    <script>
        $(function () {
            $("#datepicker,#datepicker1").datepicker();
        });
    </script>
    <!-- /End-date-piker -->

    <script type="text/javascript">

        $(function () {

            $(".btnstndrt").hover(function () {

                $(".s").slideToggle(1000);

            });

        });

        $(function () {

            $(".btnfull").hover(function () {

                $(".f").slideToggle(1000);

            });

        });
        $(function () {

            $(".btnff").hover(function () {

                $(".ff").slideToggle(1000);

            });

        });
    </script>
</asp:Content>
