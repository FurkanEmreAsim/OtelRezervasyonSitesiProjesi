using PoseidonDeluxeBusiness.Abstract;
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
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["currentuser"]!=null)
            {
                Response.Redirect("index.aspx");
            }
            lblalertdanger.Visible = false;
            
            

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {


            Users newUser = new Users();

            UserManagement _userManagement = new UserManagement();

            newUser.Email = txtemail.Value.ToString();
            newUser.Password = txtpassword.Value.ToString();
            newUser.FirstName = txtfirstname.Value.ToString();
            newUser.LastName = txtlastname.Value.ToString();
            newUser.CreationDate = DateTime.Now.Date;
            newUser.LastModifiedDate = DateTime.Now.Date;
            //newUser.CreationDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            //newUser.LastModifiedDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            try
            {
                foreach (Users item in _userManagement.GetAll())
                {
                    if (newUser.Email == item.Email)
                    {
                        throw new Exception();
                    }
                }

                _userManagement.Add(newUser);
                Response.Redirect("Login.aspx", false);
            }
            catch (Exception)
            {
                lblalertdanger.Visible = true;
            }
        }

        

           
        

      
    }
}