using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AV4
{
    public partial class Exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void buttonValid_Click(object sender, EventArgs e)
        {
            labelValid.Text = "Успешна валидација!";
            textDate.Text = string.Empty;
            textGrade.Text = string.Empty;
            textName.Text = string.Empty;
            textPhone.Text = string.Empty;
            textEmail.Text = string.Empty;
        }
    }
}