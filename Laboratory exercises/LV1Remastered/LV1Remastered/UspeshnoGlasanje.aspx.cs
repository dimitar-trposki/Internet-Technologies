using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LV1Remastered
{
    public partial class UspeshnoGlasanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["email"];

                if (cookie.Value == null)
                {
                    //labelEmail.Text = string.Empty;
                    labelEmail.Text = string.Empty;
                }
                else
                {
                    //labelEmail.Text = (string)Session["email"];
                    labelEmail.Text = cookie.Value;
                }
            }
        }
    }
}