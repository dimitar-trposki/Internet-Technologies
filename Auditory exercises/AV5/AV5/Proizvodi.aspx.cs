using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AV5
{
    public partial class Proizvodi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                labelHeader.Text = Request.QueryString.Get("name");

                string[] carModels = { "Mercedes-AMG GT Black Series", "Mercedes-Benz SLS AMG Black Series", "BMW M-4" };
                string[] carPrices = { "150000", "130000", "100000" };

                string[] books = { "Anna Karenina by Leo Tolstoy", "Madame Bovary by Gustave Flaubert", "The Great Gatsby by F. Scott Fitzgerald" };
                string[] bookPrices = { "30", "25", "20" };

                string[] laptops = { "Macbook Air M3", "Acer Swift Go 14", "Dell XPS 15 (9530)" };
                string[] laptopPrices = { "999", "749", "800" };

                switch (Convert.ToInt32(Request.QueryString.Get("catID")))
                {
                    case 0:
                        listObjects.DataSource = carModels;
                        listPrices.DataSource = carPrices;
                        break;
                    case 1:
                        listObjects.DataSource = books;
                        listPrices.DataSource = bookPrices;
                        break;
                    case 2:
                        listObjects.DataSource = laptops;
                        listPrices.DataSource = laptopPrices;
                        break;
                }

                listObjects.DataBind();
                listPrices.DataBind();

                /*int ID = Convert.ToInt32(Request.QueryString.Get("catID"));

                if (ID == 0)
                {
                    foreach (var item in carModels)
                    {
                        listSubjects.Items.Add(item);
                    }
                    foreach (var item in carPrices)
                    {
                        listPrices.Items.Add(item);
                    }
                }
                else if (ID == 1)
                {
                    foreach (var item in books)
                    {
                        listSubjects.Items.Add(item);
                    }
                    foreach (var item in bookPrices)
                    {
                        listPrices.Items.Add(item);
                    }
                }
                else if (ID == 2)
                {
                    foreach (var item in laptops)
                    {
                        listSubjects.Items.Add(item);
                    }
                    foreach (var item in laptopPrices)
                    {
                        listPrices.Items.Add(item);
                    }
                }*/
            }
        }

        protected void listObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPrices.SelectedIndex = listObjects.SelectedIndex;

            if (ViewState["labelTotal"] == null)
            {
                ViewState["labelTotal"] = 1;
            }
            else
            {
                ViewState["labelTotal"] = Convert.ToInt32(ViewState["labelTotal"]) + 1;
            }

            labelTotal.Text = ViewState["labelTotal"].ToString();
        }

        protected void linkKatalog_Click(object sender, EventArgs e)
        {
            Response.Redirect("Katalog.aspx");
        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            ArrayList list;

            if (Session["shoppingCart"] == null)
            {
                list = new ArrayList();
            }
            else
            {
                list = (ArrayList)Session["shoppingCart"];
            }

            list.Add(new ListItem(listObjects.SelectedItem.Text, listPrices.SelectedItem.Text));

            listAddedObjects.DataTextField = "Text";
            listAddedObjects.DataValueField = "Value";

            listAddedObjects.DataSource = list;
            listAddedObjects.DataBind();

            Session["shoppingCart"] = list;
        }

        protected void buttonPay_Click(object sender, EventArgs e)
        {
            Response.Redirect("Plakjanje.aspx");
        }
    }
}