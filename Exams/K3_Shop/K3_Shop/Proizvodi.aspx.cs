using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace K3_Shop
{
    public partial class Proizvodi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstItems.Items.Add(new ListItem { Text = "Car", Value = "120" });
                lstItems.Items.Add(new ListItem { Text = "Plane", Value = "290" });
                lstItems.Items.Add(new ListItem { Text = "Bike", Value = "330" });
                lstItems.Items.Add(new ListItem { Text = "Motor Bike", Value = "470" });

                lstItems.DataTextField = "Text";
                lstItems.DataValueField = "Value";
                lstItems.DataBind();

                Session["ShoppingCart"] = null;
            }
        }

        protected void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrice.Text = lstItems.SelectedItem.Value;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lblPrice.Text = "(цена)";
            lstShoppingCart.Items.Add(new ListItem(lstItems.SelectedItem.Text, lstItems.SelectedItem.Value));
            lstItems.Items.Remove(lstItems.SelectedItem);
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            List<ListItem> cart = new List<ListItem>();
            foreach (ListItem item in lstShoppingCart.Items)
            {
                cart.Add(item);
            }
            Session["ShoppingCart"] = cart;
            Response.Redirect("Plakjanje.aspx");
        }
    }
}