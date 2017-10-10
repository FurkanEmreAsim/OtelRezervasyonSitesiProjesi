using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoseidonDeluxeUI
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkBtn_Click(object sender, EventArgs e)
        {
            Session.Remove("userName");
            Session.Remove("currentuser");
            Response.Redirect("index.aspx");
        }
    }
}