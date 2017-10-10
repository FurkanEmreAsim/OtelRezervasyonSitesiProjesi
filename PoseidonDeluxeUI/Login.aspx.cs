using PoseidonDeluxeBusiness.Concrete;
using PoseiodonDeluxeModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoseidonDeluxeUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            email.Focus();
            lblalertdanger.Visible = false;
            lblalertsuccess.Visible = false;
            
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            UserManagement _userManagement = new UserManagement();

            string emaill = email.Value;
            string passwordd =password.Value;

            if (_userManagement.GetByEmailandPassword(emaill, passwordd) == null)
            {


                lblalertdanger.Visible = true;


            }
            else
            {
                Users currentUser = _userManagement.GetByEmailandPassword(emaill, passwordd);

                Session["userName"] = currentUser.FirstName + " " + currentUser.LastName;

                Session["currentuser"] = currentUser;

                Session["userID"] = currentUser.UserID;

                


                Label lbl = new Label();

                lbl = (Label)this.Master.FindControl("lbluserdetail");

                Response.Redirect("index.aspx");

               
            }
        }
    }
}