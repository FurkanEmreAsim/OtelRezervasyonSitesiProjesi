using PoseidonDeluxeBusiness.Concrete;
using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


namespace PoseidonDeluxeUI
{
    public partial class Reservation : System.Web.UI.Page
    {

        ReservationManagement _reservationmanagement = new ReservationManagement();
        CustomerManagement _customermanagement = new CustomerManagement();
        ReservationTypeManagement _reservartiontypemanagement = new ReservationTypeManagement();
        RoomManagement _roommanagement = new RoomManagement();
        ReservationRoomCustomerManagement _reservationroomcustomermanagement = new ReservationRoomCustomerManagement();


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["currentuser"] == null)
            {
                Response.Redirect("Login.aspx");
            }




            if (!IsPostBack)
            {
                chkindate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                chkoutdate.Text = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");


                ddlreservationtype.DataSource = _reservartiontypemanagement.GetAll();
                ddlreservationtype.DataTextField = "ReservationType";
                ddlreservationtype.DataValueField = "ReservationTypeID";
                ddlreservationtype.DataBind();

                ddlGuestNumber.DataSource = _roommanagement.GetAll();
                ddlGuestNumber.DataTextField = "RoomNumber";
                ddlGuestNumber.DataValueField = "RoomNumber";
                ddlGuestNumber.DataBind();


            }
        }

        


        protected void ddltotalperson_SelectedIndexChanged(object sender, EventArgs e)
        {

            ContentPlaceHolder contentPlaceHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");

            int totalPeople = Convert.ToInt32(ddltotalperson.SelectedValue);

            string[] ptext = new string[] { "First Name", "Last Name", "Civilization Number", "Gender" };

            int countroom = 2;

            

            for (int i = 1; i < totalPeople; i++)
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                div.ID = string.Format("div{0}", i);
                div.Style.Add(HtmlTextWriterStyle.Display, "inline-block");




                for (int j = 0; j < 4; j++)
                {
                    if (j != 3)
                    {
                        HtmlGenericControl innerdiv = new HtmlGenericControl("div");
                        innerdiv.ID = string.Format("innerdiv{0}", i * 4 + j);
                        innerdiv.Attributes.Add("class", "name-agile");
                        innerdiv.Style.Add(HtmlTextWriterStyle.Width, "266.82px");

                        innerdiv.InnerHtml = string.Format("<p>{0}</p>", ptext[j]);

                        TextBox txt = new TextBox();
                        txt.ID = string.Format("Guest{0}{1}", i, ptext[j].Replace("  ", string.Empty));
                        txt.ClientIDMode = ClientIDMode.Static;
                        txt.Attributes.Add("name", txt.ClientID);
                        txt.Attributes.Add("placeholder", string.Format("{1}.Guest {0}", ptext[j], (i + 1)));

                        innerdiv.Controls.Add(txt);
                        div.Controls.Add(innerdiv);
                        guest.Controls.Add(div);
                    }
                    else
                    {
                        HtmlGenericControl innerdiv = new HtmlGenericControl("div");
                        innerdiv.ID = string.Format("innerdiv{0}", i * 4 + j);
                        innerdiv.Attributes.Add("class", "room-agile");
                        innerdiv.InnerHtml = string.Format("<p>{0}</p>", ptext[j]);

                        DropDownList ddl = new DropDownList();
                        ddl.ID = string.Format("Guest{0}{1}", i, ptext[j].Replace("  ", string.Empty));
                        ddl.ClientIDMode = ClientIDMode.Static;
                        ddl.Attributes.Add("name", ddl.ClientID);


                        var ddlmale = new ListItem();
                        ddlmale.Text = "Male";
                        ddlmale.Value = "Male";

                        var ddlfamale = new ListItem();
                        ddlfamale.Text = "Female";
                        ddlfamale.Value = "Female";

                        ddl.Items.Add(ddlfamale);
                        ddl.Items.Add(ddlmale);


                        innerdiv.Controls.Add(ddl);
                        div.Controls.Add(innerdiv);

                        guest.Controls.Add(div);



                    }



                }


                if ((i == 2 && totalPeople > 3) || (i == 5 && totalPeople > 6) || (i == 8 && totalPeople == 10))
                {
                    
                    HtmlGenericControl roomdiv = new HtmlGenericControl("div");
                    roomdiv.ID = string.Format("roomdiv{0}", i);
                    roomdiv.Attributes.Add("class", "room-agile");
                    roomdiv.InnerHtml = string.Format("<p>{0}Room Numbers</p>", countroom);
                    roomdiv.Style.Add(HtmlTextWriterStyle.MarginLeft, "-150px");
                    roomdiv.Style.Add(HtmlTextWriterStyle.MarginTop, "30px");


                    DropDownList ddl1 = new DropDownList();

                    ddl1.ID = string.Format("Guest{0}", i);
                    ddl1.ClientIDMode = ClientIDMode.Static;
                    ddl1.DataSource = _roommanagement.GetAll();
                    ddl1.DataTextField = "RoomNumber";
                    ddl1.DataValueField = "RoomNumber";              
                    ddl1.DataBind();
                    ddl1.Attributes.Add("name", ddl1.ClientID);


                    countroom += 1;


                    roomdiv.Controls.Add(ddl1);

                    div.Controls.Add(roomdiv);

                    guest.Controls.Add(div);

                
                }

            }

        }



        protected void btnReservation_Click(object sender, EventArgs e)
        {
            int index = 2;

            int indexone = 5;

            int indextwo = 8;

            string txtroomone = string.Format("ctl00$ContentPlaceHolder1$Guest{0}", index);

            string txtroomtwo = string.Format("ctl00$ContentPlaceHolder1$Guest{0}", indexone);

            string txtroomthree = string.Format("ctl00$ContentPlaceHolder1$Guest{0}", indextwo);

            string roomOne = Request.Form[txtroomone];

            string roomTwo = Request.Form[txtroomtwo];

            string roomThree = Request.Form[txtroomthree];

            int persons = Convert.ToInt32(ddltotalperson.SelectedValue);


            if (persons >= 4 && persons < 7)
            {
                if (ddlGuestNumber.SelectedValue == roomOne)
                {

                    Response.Write("<script>alert('The selected room quota is full. Please select an empty room!');</script>");


                    return;


                }
            }
            else if (persons >= 7 && persons < 10)
            {
                if (ddlGuestNumber.SelectedValue == roomOne || ddlGuestNumber.SelectedValue == roomTwo || roomOne == roomTwo)
                {
                    Response.Write("<script>alert('The selected room quota is full. Please select an empty room!');</script>");

                    return;
                }
            }

            else if (persons == 10)
            {
                if (ddlGuestNumber.SelectedValue == roomOne || ddlGuestNumber.SelectedValue == roomTwo || ddlGuestNumber.SelectedValue == roomThree || roomOne == roomThree || roomOne == roomTwo || roomTwo == roomThree)
                {
                    Response.Write("<script>alert('The selected room quota is full. Please select an empty room!');</script>");

                    return;
                }
            }

            Rooms ddlroom = _roommanagement.GetById(Convert.ToInt32(ddlGuestNumber.SelectedValue));

            ICollection<ReservationCustomerRoom> resCusRoom = null;

            resCusRoom = ddlroom.ReservationCustomerRoom.ToList();

            #region Reservations

            Reservations res;

            #endregion


            DateTime customerentrydate;

            DateTime customeroutdate;

            DateTime todaydate = DateTime.Now.Date;

            List<int> roomSelectList = new List<int>();


            ContentPlaceHolder contentPlaceHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");

            foreach (Control ctrl in contentPlaceHolder.Controls)
            {
                if(ctrl is DropDownList)

                    if (((DropDownList)ctrl).ID.ToString().Contains("Guest"))
               {
                   roomSelectList.Add(Convert.ToInt32(((DropDownList)ctrl).SelectedItem.Value));

               }
            }

            List<string> entryoutlist = new List<string>();

            foreach (var item in roomSelectList)
            {
                foreach (var rescusroom in _reservationroomcustomermanagement.GetReservationCustomerRoom(item).Select(x => new { x.Reservation, x.ReservationID }).Distinct())
                {
                    entryoutlist.Add("The room you want to make a reservation is closed " + rescusroom.Reservation.DateOfEntry.ToString() + "between " + rescusroom.Reservation.DateOfOut.ToString());

                }
            }

            if (resCusRoom.Count == 0)
            {

                customerentrydate = DateTime.Parse(chkindate.Text);

                customeroutdate = DateTime.Parse(chkoutdate.Text);

                int result5 = DateTime.Compare(customerentrydate, todaydate);

                int result6 = DateTime.Compare(customeroutdate, todaydate);


                if (result5 >= 0 && result6 >= 0)
                {

                    MakeReservation();

                    return;
                }

                //metod başı 


                else
                {
                    Response.Write("<script>alert('Selected dates are not eligible for reservation. Please try again');</script>");

                    return;
                }

                //metod sonu 

            }


            bool control = false;
            DateTime dbentrydate = DateTime.Now;
            DateTime dboutdate = DateTime.Now;


            foreach (var item in resCusRoom)
            {

                res = item.Reservation;

                dbentrydate = res.DateOfEntry;

                dboutdate = res.DateOfOut;

                customerentrydate = DateTime.Parse(chkindate.Text);

                customeroutdate = DateTime.Parse(chkoutdate.Text);



                int result = DateTime.Compare(customerentrydate, dbentrydate);

                int result2 = DateTime.Compare(customeroutdate, dbentrydate);

                int result3 = DateTime.Compare(customerentrydate, dboutdate);

                int result4 = DateTime.Compare(customeroutdate, customerentrydate);

                int result5 = DateTime.Compare(customerentrydate, todaydate);

                int result6 = DateTime.Compare(customeroutdate, todaydate);

                if (result5 < 0 && result6 < 0)
                {
                    Response.Write("<script>alert('Selected dates are not eligible for reservation. Please try again');</script>");

                    return;
                }


                if (!((result < 0 && result2 < 0 && result != 0 && result2 != 0) || (result3 > 0 && result4 > 0 && result3 != 0 && result4 != 0)))
                {
                    control = true;

                }

            }
            if (control)
            {

                entryoutlist.Add("The Selected Rooms are listed on this list. Please select the appropriate date range!");

                grdEntryOutList.DataSource = entryoutlist;

                grdEntryOutList.DataBind();

                btnReservation.Focus();
            }
            else
            {

                //metod başı 
                MakeReservation();
                // metod sonu 

            }

        }



        public void MakeReservation()
        {
            Reservations _newreservation = new Reservations();

            Customers _newcustomer = new Customers();

            ReservationCustomerRoom _reservationcustomerroom = new ReservationCustomerRoom();

            _newreservation.CreatedBy = Convert.ToInt32(Session["userID"]);
            _newreservation.CreatedDate = DateTime.Now.Date;
            _newreservation.ReservationTypeID = Convert.ToInt32(ddlreservationtype.SelectedValue);
            _newreservation.ReservationPrice = CalculateReservationPrice(Int32.Parse(ddltotalperson.SelectedValue), chkindate.Text, chkoutdate.Text);
            _newreservation.TotalPeople = Convert.ToInt16(ddltotalperson.Text);
            _newreservation.DateOfEntry = Convert.ToDateTime(chkindate.Text);
            _newreservation.DateOfOut = Convert.ToDateTime(chkoutdate.Text);
            _newreservation.LastModifiedDate = DateTime.Now.Date;
            _newreservation.IsActive = true;


            _newcustomer.CustomerName = txtfirstname.Value;
            _newcustomer.CustomerLastName = txtlastname.Value;
            _newcustomer.CustomerCivilization = txtcivilnumber.Value;
            _newcustomer.Gender = ddlgender.Text;
            _newcustomer.CreationDate = DateTime.Now.Date;
            _newcustomer.LastModifiedDate = DateTime.Now.Date;


            _reservationmanagement.Add(_newreservation);

            Session["ReservationID"] = "P08000" + _newreservation.ReservationID;

            _customermanagement.Add(_newcustomer);

            _reservationcustomerroom.ReservationID = _newreservation.ReservationID;
            _reservationcustomerroom.RoomID = Int32.Parse(ddlGuestNumber.SelectedValue);
            _reservationcustomerroom.CustomerID = _newcustomer.CustomerID;
            _reservationroomcustomermanagement.Add(_reservationcustomerroom);

            int index = 1;
            int roomindex = 0;
            int roomcounter = 0;
            int roomcounter2 = 0;


            Customers customer;
            ReservationCustomerRoom _reservationcustomerroomOtherC;

            int totalPeople = Convert.ToInt32(ddltotalperson.Text);


            string txtcustomername;

            string txtcustomerlastname;

            string txtcustomercivilization;

            string txtgender;

            string txtroomnumber;

            string txtroomnumber2;

            string txtroomnumber3;


            if (totalPeople < 4)
            {

                for (int i = 1; i <= totalPeople; i++)
                {
                    txtcustomername = string.Format("ctl00$ContentPlaceHolder1$Guest{0}First Name", index);

                    txtcustomerlastname = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Last Name", index);
                    txtcustomercivilization = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Civilization Number", index);
                    txtgender = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Gender", index);


                    if (Request.Form.AllKeys.Contains(txtcustomername) && Request.Form.AllKeys.Contains(txtcustomerlastname) &&
                        Request.Form.AllKeys.Contains(txtcustomercivilization) && Request.Form.AllKeys.Contains(txtgender))
                    {
                        txtcustomername = Request.Form[txtcustomername];
                        txtcustomerlastname = Request.Form[txtcustomerlastname];
                        txtcustomercivilization = Request.Form[txtcustomercivilization];
                        txtgender = Request.Form[txtgender];


                        customer = new Customers();
                        customer.CustomerName = txtcustomername;
                        customer.CustomerLastName = txtcustomerlastname;
                        customer.CustomerCivilization = txtcustomercivilization;
                        customer.Gender = txtgender;
                        customer.CreationDate = DateTime.Now.Date;
                        customer.LastModifiedDate = DateTime.Now.Date;

                        _customermanagement.Add(customer);


                        _reservationcustomerroomOtherC = new ReservationCustomerRoom();

                        _reservationcustomerroomOtherC.CustomerID = customer.CustomerID;
                        _reservationcustomerroomOtherC.ReservationID = _newreservation.ReservationID;
                        _reservationcustomerroomOtherC.RoomID = Int32.Parse(ddlGuestNumber.SelectedValue);
                        _reservationroomcustomermanagement.Add(_reservationcustomerroomOtherC);

                    }
                    index++;
                }

            }


            else if (totalPeople >= 4 && totalPeople < 7)
            {


                for (int i = 1; i < totalPeople; i++)
                {
                    //if(i == (totalPeople - 2))
                    //{
                    //    break;
                    //}


                    roomindex = 2;
                    txtcustomername = string.Format("ctl00$ContentPlaceHolder1$Guest{0}First Name", index);
                    txtcustomerlastname = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Last Name", index);
                    txtcustomercivilization = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Civilization Number", index);
                    txtgender = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Gender", index);

                    txtroomnumber = string.Format("ctl00$ContentPlaceHolder1$Guest{0}", roomindex);

                    if (Request.Form.AllKeys.Contains(txtcustomername) && Request.Form.AllKeys.Contains(txtcustomerlastname) &&
                        Request.Form.AllKeys.Contains(txtcustomercivilization) && Request.Form.AllKeys.Contains(txtgender) && Request.Form.AllKeys.Contains(txtroomnumber))
                    {
                        txtcustomername = Request.Form[txtcustomername];
                        txtcustomerlastname = Request.Form[txtcustomerlastname];
                        txtcustomercivilization = Request.Form[txtcustomercivilization];
                        txtgender = Request.Form[txtgender];
                        txtroomnumber = Request.Form[txtroomnumber];

                        customer = new Customers();
                        customer.CustomerName = txtcustomername;
                        customer.CustomerLastName = txtcustomerlastname;
                        customer.CustomerCivilization = txtcustomercivilization;
                        customer.Gender = txtgender;
                        customer.CreationDate = DateTime.Now.Date;
                        customer.LastModifiedDate = DateTime.Now.Date;



                        _customermanagement.Add(customer);


                        _reservationcustomerroomOtherC = new ReservationCustomerRoom();

                        _reservationcustomerroomOtherC.CustomerID = customer.CustomerID;
                        _reservationcustomerroomOtherC.ReservationID = _newreservation.ReservationID; _reservationcustomerroomOtherC.RoomID = Int32.Parse(ddlGuestNumber.SelectedValue);
                        if (i >= 3 && i <= 6)
                        {
                            _reservationcustomerroomOtherC.RoomID = Int32.Parse(txtroomnumber);
                        }
                        _reservationroomcustomermanagement.Add(_reservationcustomerroomOtherC);

                    }



                    index++;

                }

            }

            else if (totalPeople >= 7 && totalPeople < 10)
            {
                roomindex = 2;
                roomcounter = 5;



                for (int i = 1; i < totalPeople; i++)
                {


                    txtcustomername = string.Format("ctl00$ContentPlaceHolder1$Guest{0}First Name", index);
                    txtcustomerlastname = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Last Name", index);
                    txtcustomercivilization = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Civilization Number", index);
                    txtgender = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Gender", index);

                    txtroomnumber = string.Format("ctl00$ContentPlaceHolder1$Guest{0}", roomindex);

                    txtroomnumber2 = string.Format("ctl00$ContentPlaceHolder1$Guest{0}", roomcounter);



                    if (Request.Form.AllKeys.Contains(txtcustomername) && Request.Form.AllKeys.Contains(txtcustomerlastname) &&
                        Request.Form.AllKeys.Contains(txtcustomercivilization) && Request.Form.AllKeys.Contains(txtgender) && Request.Form.AllKeys.Contains(txtroomnumber) && Request.Form.AllKeys.Contains(txtroomnumber2))
                    {
                        txtcustomername = Request.Form[txtcustomername];
                        txtcustomerlastname = Request.Form[txtcustomerlastname];
                        txtcustomercivilization = Request.Form[txtcustomercivilization];
                        txtgender = Request.Form[txtgender];
                        txtroomnumber = Request.Form[txtroomnumber];
                        txtroomnumber2 = Request.Form[txtroomnumber2];

                        customer = new Customers();
                        customer.CustomerName = txtcustomername;
                        customer.CustomerLastName = txtcustomerlastname;
                        customer.CustomerCivilization = txtcustomercivilization;
                        customer.Gender = txtgender;
                        customer.CreationDate = DateTime.Now.Date;
                        customer.LastModifiedDate = DateTime.Now.Date;



                        _customermanagement.Add(customer);


                        _reservationcustomerroomOtherC = new ReservationCustomerRoom();

                        _reservationcustomerroomOtherC.CustomerID = customer.CustomerID;
                        _reservationcustomerroomOtherC.ReservationID = _newreservation.ReservationID;
                        _reservationcustomerroomOtherC.RoomID = Int32.Parse(ddlGuestNumber.SelectedValue);

                        if (i >= 3 && i <= 6)
                        {
                            _reservationcustomerroomOtherC.RoomID = Int32.Parse(txtroomnumber);
                        }

                        if (i >= 7 && i <= 9)
                        {
                            _reservationcustomerroomOtherC.RoomID = Int32.Parse(txtroomnumber);
                        }
                        _reservationroomcustomermanagement.Add(_reservationcustomerroomOtherC);

                    }

                    index++;

                    if (i == 5)
                    {

                        roomindex += 3;
                    }



                }

            }

            else if (totalPeople == 10)
            {
                roomindex = 2;
                roomcounter = 5;
                roomcounter2 = 8;
                for (int i = 1; i < totalPeople; i++)
                {


                    txtcustomername = string.Format("ctl00$ContentPlaceHolder1$Guest{0}First Name", index);
                    txtcustomerlastname = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Last Name", index);
                    txtcustomercivilization = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Civilization Number", index);
                    txtgender = string.Format("ctl00$ContentPlaceHolder1$Guest{0}Gender", index);

                    txtroomnumber = string.Format("ctl00$ContentPlaceHolder1$Guest{0}", roomindex);



                    txtroomnumber3 = string.Format("ctl00$ContentPlaceHolder1$Guest{0}", roomcounter2);

                    if (Request.Form.AllKeys.Contains(txtcustomername) && Request.Form.AllKeys.Contains(txtcustomerlastname) &&
                        Request.Form.AllKeys.Contains(txtcustomercivilization) && Request.Form.AllKeys.Contains(txtgender) && Request.Form.AllKeys.Contains(txtroomnumber))
                    {
                        txtcustomername = Request.Form[txtcustomername];
                        txtcustomerlastname = Request.Form[txtcustomerlastname];
                        txtcustomercivilization = Request.Form[txtcustomercivilization];
                        txtgender = Request.Form[txtgender];
                        txtroomnumber = Request.Form[txtroomnumber];

                        customer = new Customers();
                        customer.CustomerName = txtcustomername;
                        customer.CustomerLastName = txtcustomerlastname;
                        customer.CustomerCivilization = txtcustomercivilization;
                        customer.Gender = txtgender;
                        customer.CreationDate = DateTime.Now.Date;
                        customer.LastModifiedDate = DateTime.Now.Date;

                        _customermanagement.Add(customer);


                        _reservationcustomerroomOtherC = new ReservationCustomerRoom();

                        _reservationcustomerroomOtherC.CustomerID = customer.CustomerID;
                        _reservationcustomerroomOtherC.ReservationID = _newreservation.ReservationID;
                        _reservationcustomerroomOtherC.RoomID = Int32.Parse(ddlGuestNumber.SelectedValue);
                        if (i >= 3 && i <= 6)
                        {
                            _reservationcustomerroomOtherC.RoomID = Int32.Parse(txtroomnumber);
                        }

                        if (i >= 7 && i <= 9)
                        {
                            _reservationcustomerroomOtherC.RoomID = Int32.Parse(txtroomnumber);
                        }
                        if (i == 10)
                        {
                            _reservationcustomerroomOtherC.RoomID = Int32.Parse(txtroomnumber);
                        }

                        _reservationroomcustomermanagement.Add(_reservationcustomerroomOtherC);

                    }

                    index++;

                    if (i == 5)
                    {

                        roomindex += 3;
                    }

                    else if (i == 8)
                    {

                        roomindex += 3;
                    }



                }

            }

            Response.Redirect("PaymentPage.aspx", false);

        }



        public decimal CalculateReservationPrice(int totalPeople, string dateofEntry, string dateofOut)
        {

            PriceRateManagement _pricerateManagement = new PriceRateManagement();
            ReservationTypeManagement _reservationtypemanagement = new ReservationTypeManagement();
            ReservationTypes reservationtypeprice;
            PriceRates priteRates1;
            PriceRates priteRates2;

            DateTime entryDate = Convert.ToDateTime(dateofEntry);

            DateTime outDate = Convert.ToDateTime(dateofOut);

            int weekdays = 0;
            int weekend = 0;
            decimal totalReservationCost = 0;

            do
            {
                if (entryDate.DayOfWeek != DayOfWeek.Friday && entryDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    weekdays += 1;
                }
                else
                {
                    weekend += 1;
                }

                entryDate = entryDate.AddDays(1);
            } while (entryDate <= outDate);

            while (totalPeople > 0)
            {
                if (totalPeople % 3 == 1)
                {
                    if (totalPeople > 1)
                    {
                        priteRates1 = _pricerateManagement.GetById("ÜHİ");
                        priteRates2 = _pricerateManagement.GetById("ÜHS");

                        totalReservationCost += (priteRates1.Rate * weekdays) + (priteRates2.Rate * weekend);

                        priteRates1 = _pricerateManagement.GetById("THİ");
                        priteRates2 = _pricerateManagement.GetById("THS");

                        totalReservationCost += (priteRates1.Rate * weekdays) + (priteRates2.Rate * weekend);

                        totalPeople -= 4;
                    }
                    else if (totalPeople == 1)
                    {
                        priteRates1 = _pricerateManagement.GetById("THİ");
                        priteRates2 = _pricerateManagement.GetById("THS");
                        totalReservationCost += (priteRates1.Rate * weekdays) + (priteRates2.Rate * weekend);
                        totalPeople -= 1;
                        break;
                    }

                }

                if (totalPeople % 3 == 2)
                {
                    if (totalPeople != 2)
                    {
                        priteRates1 = _pricerateManagement.GetById("ÜHİ");
                        priteRates2 = _pricerateManagement.GetById("ÜHS");


                        totalReservationCost += (priteRates1.Rate * weekdays) + (priteRates2.Rate * weekend);


                        priteRates1 = _pricerateManagement.GetById("SHİ");
                        priteRates2 = _pricerateManagement.GetById("SHS");

                        totalReservationCost += (priteRates1.Rate * weekdays) + (priteRates2.Rate * weekend);

                        if (totalPeople == 5)
                        {
                            break;
                        }
                        totalPeople -= 5;



                    }
                    else if (totalPeople == 2)
                    {
                        priteRates1 = _pricerateManagement.GetById("SHİ");
                        priteRates2 = _pricerateManagement.GetById("SHS");
                        totalReservationCost += (priteRates1.Rate * weekdays) + (priteRates2.Rate * weekend);
                        totalPeople -= 2;
                        break;

                    }
                }

                if (totalPeople % 3 == 0)
                {
                    priteRates1 = _pricerateManagement.GetById("ÜHİ");
                    priteRates2 = _pricerateManagement.GetById("ÜHS");

                    totalReservationCost += (priteRates1.Rate * weekdays) + (priteRates2.Rate * weekend);

                    totalPeople -= 3;

                }


            }

            reservationtypeprice = _reservationtypemanagement.GetById(Convert.ToInt32(ddlreservationtype.SelectedValue));

            totalPeople = 0;

            Session["totalprice"] = (totalReservationCost + reservationtypeprice.ReservationTypePrice);

            return (totalReservationCost + reservationtypeprice.ReservationTypePrice);



        }

    }
}