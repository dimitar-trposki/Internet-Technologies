using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AV2_3
{
    public partial class Destinations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void listDestinations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void buttonShowName_Click(object sender, EventArgs e)
        {
            ListItemCollection items = new ListItemCollection();
            items = listDestinations.Items;

            labelShowName.Text = "";
            labelDistance.Text = "";

            foreach (ListItem item in items)
            {
                if (item.Selected)
                {
                    labelShowName.Text += "<br/>";
                    labelShowName.Text += item.Text;
                    labelDistance.Text += "<br/>";
                    labelDistance.Text += item.Value;
                }
            }
        }
    }
}