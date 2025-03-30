using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LV1Remastered
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] subject = { "Интернет програмирање на клиентска страна", "Интернет технологии", "Визуелно програмирање" };
                string[] credit = { "6", "5", "7" };

                listSubjects.DataSource = subject;
                listSubjects.DataBind();

                listCredits.DataSource = credit;
                listCredits.DataBind();
            }
        }

        protected void buttonVote_Click(object sender, EventArgs e)
        {
            Response.Redirect("UspeshnoGlasanje.aspx");
        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            int flag = 0;

            foreach (ListItem item in listSubjects.Items)
            {
                if (item.Text == textSubject.Text)
                {
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                listSubjects.Items.Add(new ListItem(textSubject.Text));
                listCredits.Items.Add(new ListItem(textCredit.Text));
                textSubject.Text = string.Empty;
                textCredit.Text = string.Empty;
            }
        }

        protected void buttonRemove_Click(object sender, EventArgs e)
        {
            listSubjects.Items.Remove(listSubjects.SelectedItem);
            listCredits.Items.Remove(listCredits.SelectedItem);
            labelProf.Text = string.Empty;
        }

        protected void listSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCredits.SelectedIndex = listSubjects.SelectedIndex;

            if (listSubjects.SelectedItem.Text == "Интернет програмирање на клиентска страна")
            {
                labelProf.Text = "Проф. д-р Иван Китановски";
            }
            else if (listSubjects.SelectedItem.Text == "Интернет технологии")
            {
                labelProf.Text = "Проф. д-р Гоце Арменски";
            }
            else if (listSubjects.SelectedItem.Text == "Визуелно програмирање")
            {
                labelProf.Text = "Проф. д-р Дејан Ѓорѓевиќ";
            }
            else
            {
                labelProf.Text = string.Empty;
            }
        }
    }
}