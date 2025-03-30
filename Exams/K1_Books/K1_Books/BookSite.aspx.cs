using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace K1_Books
{
    public partial class BookSite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] books = { "Anna Karenina by Leo Tolstoy", "Madame Bovary by Gustave Flaubert", "The Great Gatsby by F. Scott Fitzgerald" };
                string[] bookPrices = { "30", "25", "20" };

                listBooks.DataSource = books;
                listBooks.DataBind();

                listPrices.DataSource = bookPrices;
                listPrices.DataBind();
            }
        }

        protected void buttonDelete_Click(object sender, EventArgs e)
        {

            if (textIndex.Text.Length > 0 && Regex.IsMatch(textIndex.Text, @"\d+"))
            {
                int index = Convert.ToInt32(textIndex.Text);
                if (index <= listBooks.Items.Count - 1)
                {
                    listBooks.Items.RemoveAt(index);
                    listPrices.Items.RemoveAt(index);
                }
            }
        }
    }
}