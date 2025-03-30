using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LV1Remastered
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonLogIn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("email");
            cookie.Value = textEmail.Text;
            Response.Cookies.Add(cookie);
            //Session["email"] = textEmail.Text;
            Response.Redirect("Glasaj.aspx");
        }
    }
}