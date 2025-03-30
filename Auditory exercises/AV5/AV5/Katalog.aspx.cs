using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AV5
{
    public partial class Katalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Автомобили -> 0
        //Книги -> 1
        //Лаптопи -> 2

        protected void linkCars_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proizvodi.aspx?name=Автомобили&catID=0");
        }

        protected void linkBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proizvodi.aspx?name=Книги&catID=1");
        }

        protected void linkLaptops_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proizvodi.aspx?name=Лаптопи&catID=2");
        }
    }
}