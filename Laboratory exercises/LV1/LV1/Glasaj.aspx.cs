using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LV1
{
    public partial class Glasaj : System.Web.UI.Page
    {

        private string[] subject = { "Интернет програмирање на клиентска страна", "Интернет технологии", "Визуелно програмирање" };
        private string[] credit = { "6", "5", "7" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (string s in subject)
                {
                    Subjects.Items.Add(s);
                }
                foreach (string c in credit)
                {
                    Credits.Items.Add(c);
                }
            }
        }

        protected void Subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Subjects.SelectedItem.Text == "Интернет програмирање на клиентска страна")
            {
                Professor.Text = "Проф. д-р Иван Китановски";
            }
            else if (Subjects.SelectedItem.Text == "Интернет технологии")
            {
                Professor.Text = "Проф. д-р Гоце Арменски";
            }
            else if (Subjects.SelectedItem.Text == "Визуелно програмирање")
            {
                Professor.Text = "Проф. д-р Дејан Ѓорѓевиќ";
            }
            else
            {
                Professor.Text = string.Empty;
            }
            Credits.SelectedIndex = Subjects.SelectedIndex;
        }

        protected void Vote_Click(object sender, EventArgs e)
        {
            if (Subjects.SelectedIndex >= 0 && Credits.SelectedIndex >= 0)
            {
                Response.Redirect("~/UspeshnoGlasanje.aspx");
            }
        }

        protected void Remove_Click(object sender, EventArgs e)
        {
            Subjects.Items.Remove(Subjects.SelectedItem);
            Credits.Items.Remove(Credits.SelectedItem);
            Professor.Text = "";
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            int flag = 0;
            WarningAddSubject.Text = string.Empty;
            WarningAddCredits.Text = "";
            Warning.Text = "";
            if (AddSubject.Text.Length == 0)
            {
                WarningAddSubject.Text = "Внесете име на предмет";
                WarningAddSubject.ForeColor = Color.Red;
            }
            if (AddSubject.Text.Length == 0 || !Regex.IsMatch(AddCredits.Text, @"\d+"))
            {
                WarningAddCredits.Text = "Внесете број на кредити";
                WarningAddCredits.ForeColor = Color.Red;
            }
            foreach (ListItem s in Subjects.Items)
            {
                if (s.Text == AddSubject.Text)
                {
                    flag = 1;
                }
            }
            if (AddSubject.Text.Length > 0 && AddCredits.Text.Length > 0 && flag == 1 && Regex.IsMatch(AddCredits.Text, @"\d+"))
            {
                Warning.Text = "Веќе постои во листата, обидете се повторно.";
                Warning.ForeColor = Color.Red;
                AddSubject.Text = string.Empty;
                AddCredits.Text = string.Empty;
            }
            if (AddSubject.Text.Length > 0 && AddCredits.Text.Length > 0 && flag == 0)
            {
                Subjects.Items.Add(AddSubject.Text);
                Credits.Items.Add(AddCredits.Text);
                AddSubject.Text = string.Empty;
                AddCredits.Text = string.Empty;
            }
        }
    }
}