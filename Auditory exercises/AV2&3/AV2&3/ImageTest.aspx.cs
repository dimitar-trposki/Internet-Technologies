using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AV2_3
{
    public partial class ImageTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label1.Text = string.Empty;
            Label1.Text += "x: ";
            Label1.Text += Convert.ToString(e.X);
            Label1.Text += " y: ";
            Label1.Text += Convert.ToString(e.Y);
        }
    }
}