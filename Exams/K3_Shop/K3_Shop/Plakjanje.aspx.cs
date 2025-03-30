using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace K3_Shop
{
    public partial class Plakjanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int price = 0;
                List<ListItem> list = new List<ListItem>();

                list = (List<ListItem>)Session["ShoppingCart"];

                foreach (ListItem item in list)
                {
                    lstShoppingCart.Items.Add(item);
                    price += Convert.ToInt32(item.Value);
                }

                lblTotalPrice.Text = price.ToString();
            }
        }
    }
}