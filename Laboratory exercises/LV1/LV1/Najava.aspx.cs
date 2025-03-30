using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services.Protocols;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LV1
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogIn_Click1(object sender, EventArgs e)
        {
            EmailAddressAttribute email = new EmailAddressAttribute();
            NameWarning.Text = "";
            PasswordWarning.Text = "";
            EmailWarning.Text = "";
            int flag = 0;
            if (Name.Text.Length == 0)
            {
                NameWarning.Text = "Внесете име";
                NameWarning.ForeColor = System.Drawing.Color.Red;
                flag = 1;
            }
            if (Password.Text.Length == 0)
            {
                PasswordWarning.Text = "Внесете лозинка";
                PasswordWarning.ForeColor = System.Drawing.Color.Red;
                flag = 1;
            }
            if (!email.IsValid(Email.Text))
            {
                flag = 1;
                EmailWarning.Text = "Невалиден формат";
                EmailWarning.ForeColor = System.Drawing.Color.Red;

            }
            /*if (!Regex.IsMatch(Email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                flag = 1;
                EmailWarning.Text = "Невалиден формат";
                EmailWarning.ForeColor = System.Drawing.Color.Red;

            }*/
            if (flag == 0)
            {
                Response.Redirect("~/Glasaj.aspx");
            }
        }

    }
}