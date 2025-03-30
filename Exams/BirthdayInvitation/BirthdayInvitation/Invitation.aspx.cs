using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BirthdayInvitation
{
    public partial class Invitation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] bgColors = { "Unbound", "White", "Red", "Green", "Blue", "Yellow" };
                string[] fontStyles = { "Unbound", "Times New Roman", "Arial", "Verdana", "Courier" };
                string[] fontColors = { "Unbound", "White", "Red", "Green", "Blue", "Yellow", "Black" };
                /*ListItemCollection borderStyle = new ListItemCollection();
                borderStyle.Add(new ListItem(BorderStyle.None.ToString(), ((int)BorderStyle.None).ToString()));
                borderStyle.Add(new ListItem(BorderStyle.Dotted.ToString(), ((int)BorderStyle.Dotted).ToString()));
                borderStyle.Add(new ListItem(BorderStyle.Double.ToString(), ((int)BorderStyle.Double).ToString()));*/

                dropBgColor.DataSource = bgColors;
                dropBgColor.DataBind();

                dropFontStyle.DataSource = fontStyles;
                dropFontStyle.DataBind();

                dropFontColor.DataSource = fontColors;
                dropFontColor.DataBind();

                ListItem item = new ListItem();
                item.Text = BorderStyle.None.ToString();
                item.Value = ((int)BorderStyle.None).ToString();
                listBorderStyle.Items.Add(item);

                item = new ListItem();
                item.Text = BorderStyle.Dotted.ToString();
                item.Value = ((int)BorderStyle.Dotted).ToString();
                listBorderStyle.Items.Add(item);

                item = new ListItem();
                item.Text = BorderStyle.Double.ToString();
                item.Value = ((int)BorderStyle.Double).ToString();
                listBorderStyle.Items.Add(item);
                /*listBorderStyle.DataSource = borderStyle;
                listBorderStyle.DataBind();*/

            }
        }

        protected void buttonCreate_Click(object sender, EventArgs e)
        {
            labelWish.Text = textWish.Text;
            panelWish.BackColor = Color.FromName(dropBgColor.SelectedItem.Text);
            labelWish.Font.Name = dropFontStyle.SelectedItem.Text;
            labelWish.ForeColor = Color.FromName(dropFontColor.SelectedItem.Text);

            if (textFontSize.Text.Length > 0)
            {
                labelWish.Font.Size = FontUnit.Point(Convert.ToInt32(textFontSize.Text));
            }

            int vrednost = Convert.ToInt32(listBorderStyle.SelectedItem.Value);
            panelWish.BorderStyle = (BorderStyle)vrednost;

            if (checkImage.Checked)
            {
                imageToShow.Visible = true;
            }

            textFontSize.Text = string.Empty;
            textWish.Text = string.Empty;
        }
    }
}