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
    public partial class UserDetails : System.Web.UI.Page
    {

        UserManagement _usermanagement = new UserManagement();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["userName"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Users user = (Users)Session["currentuser"];

                    email.Value = user.Email;
                    password.Value = user.Password;
                    username.Value = user.FirstName;
                    lastname.Value = user.LastName;

                }

            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Users UpdateUser = (Users)Session["currentuser"];

            UpdateUser.Email = email.Value;
            UpdateUser.Password = password.Value;
            UpdateUser.FirstName = username.Value;
            UpdateUser.LastName = lastname.Value;

            _usermanagement.Update(UpdateUser);


        }

     

     
    }
}