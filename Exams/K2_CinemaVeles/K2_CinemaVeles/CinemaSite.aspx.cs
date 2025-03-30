using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace K2_CinemaVeles
{
    public partial class CinemaSite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] genres = { "Драма", "Комедија", "Акција" };
                lstGenres.DataSource = genres;
                lstGenres.DataBind();

                ViewState["price"] = null;
            }
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        protected void lstGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] dramaS = { "Forrest Gump", "Good Will Hunting", "A Beautiful Mind" };
            string[] dramaSP = { "150", "130", "100" };
            string[] comedyS = { "Keeping up with the Joneses", "Masterminds", "Ted2" };
            string[] comedySP = { "120", "170", "180" };
            string[] actionS = { "Batman vs Superman 3D", "Deadpool 3D", "The Accountant" };
            string[] actionSP = { "350", "300", "200" };

            int counter = 0;
            foreach (ListItem item in chkMovies.Items)
            {
                if (item.Selected)
                {
                    if (counter == 0)
                    {
                        requiredNum1.Enabled = true;
                    }
                    else if (counter == 1)
                    {
                        requiredNum2.Enabled = true;
                    }
                    else if (counter == 2)
                    {
                        requiredNum3.Enabled = true;
                    }
                }
                counter++;
            }

            counter = 0;
            foreach (ListItem item in chkMovies.Items)
            {
                if (item.Selected)
                {
                    if (counter == 0)
                    {
                        ViewState["price"] = Convert.ToInt32(ViewState["price"]) + Convert.ToInt32(item.Value) * Convert.ToInt32(txtNum1.Text);
                    }
                    else if (counter == 1)
                    {
                        ViewState["price"] = Convert.ToInt32(ViewState["price"]) + Convert.ToInt32(item.Value) * Convert.ToInt32(txtNum2.Text);
                    }
                    else if (counter == 2)
                    {
                        ViewState["price"] = Convert.ToInt32(ViewState["price"]) + Convert.ToInt32(item.Value) * Convert.ToInt32(txtNum3.Text);
                    }
                }
                counter++;
            }

            List<ListItem> drama = new List<ListItem>();
            drama.Add(new ListItem { Text = "Forrest Gump", Value = "150" });
            drama.Add(new ListItem{Text = "Good Will Hunting", Value = "130"});
            drama.Add(new ListItem { Text = "A Beautiful Mind", Value = "100" });

            ListItemCollection comedy = new ListItemCollection();
            comedy.Add(new ListItem { Text = "Keeping up with the Joneses", Value = "120" });
            comedy.Add(new ListItem { Text = "Masterminds", Value = "170" });
            comedy.Add(new ListItem { Text = "Ted2", Value = "180" });

            ListItemCollection action = new ListItemCollection();
            action.Add(new ListItem{ Text = "Batman vs Superman 3D", Value = "350" });
            action.Add(new ListItem{ Text = "Deadpool 3D", Value = "300" });
            action.Add(new ListItem{ Text = "The Accountant", Value = "200" });

            ArrayList listOfStrings = new ArrayList();
            listOfStrings.Add(drama);
            listOfStrings.Add(comedy);
            listOfStrings.Add(action);

            chkMovies.DataSource = listOfStrings[lstGenres.SelectedIndex];
            chkMovies.DataTextField = "Text";
            chkMovies.DataValueField = "Value";
            chkMovies.DataBind();

            txtNum1.Text = string.Empty;
            txtNum2.Text = string.Empty;
            txtNum3.Text = string.Empty;

            requiredNum1.Enabled = false;
            requiredNum2.Enabled = false;
            requiredNum3.Enabled = false;

            if (Convert.ToInt32(ViewState["price"]) > 0)
            {
                btnBuy.Enabled = true;
            }
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (ListItem item in chkMovies.Items)
            {
                if (item.Selected)
                {
                    if (counter == 0)
                    {
                        requiredNum1.Enabled = true;
                        ViewState["price"] = Convert.ToInt32(ViewState["price"]) + Convert.ToInt32(item.Value) * Convert.ToInt32(txtNum1.Text);
                    }
                    else if (counter == 1)
                    {
                        requiredNum2.Enabled = true;
                        ViewState["price"] = Convert.ToInt32(ViewState["price"]) + Convert.ToInt32(item.Value) * Convert.ToInt32(txtNum2.Text);
                    }
                    else if (counter == 2)
                    {
                        requiredNum3.Enabled = true;
                        ViewState["price"] = Convert.ToInt32(ViewState["price"]) + Convert.ToInt32(item.Value) * Convert.ToInt32(txtNum3.Text);
                    }
                }
                counter++;
            }
            lblPrice.Text = ViewState["price"].ToString();
        }

        protected void chkMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (ListItem item in chkMovies.Items)
            {
                if (item.Selected)
                {
                    if (counter == 0)
                    {
                        requiredNum1.Enabled = true;
                    }
                    else if (counter == 1)
                    {
                        requiredNum2.Enabled = true;
                    }
                    else if (counter == 2)
                    {
                        requiredNum3.Enabled = true;
                    }
                }
                counter++;
            }
        }

        protected void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if (chkMovies.SelectedIndex == 0 && txtNum1.Text.Length > 0 && Convert.ToInt32(ViewState["price"]) == 0)
            {
                btnBuy.Enabled = true;
            }
        }

        protected void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if (chkMovies.SelectedIndex == 1 && txtNum2.Text.Length > 0 && Convert.ToInt32(ViewState["price"]) == 0)
            {
                btnBuy.Enabled = true;
            }
        }

        protected void txtNum3_TextChanged(object sender, EventArgs e)
        {
            if (chkMovies.SelectedIndex == 2 && txtNum3.Text.Length > 0 && Convert.ToInt32(ViewState["price"]) == 0)
            {
                btnBuy.Enabled = true;
            }
        }
    }
}