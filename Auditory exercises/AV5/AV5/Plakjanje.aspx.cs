using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AV5
{
    public partial class Plakjanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                listItemsToPay.DataTextField = "Text";
                listItemsToPay.DataValueField = "Value";
                listItemsToPay.DataSource = (ArrayList)Session["shoppingCart"];
                listItemsToPay.DataBind();
                int totalValue = 0;

                foreach(ListItem item in listItemsToPay.Items)
                {
                    totalValue += Convert.ToInt32(item.Value);
                }

                labelSumPrices.Text = totalValue.ToString();
            }
        }

    }
}