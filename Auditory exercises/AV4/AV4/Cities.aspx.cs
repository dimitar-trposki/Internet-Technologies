﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AV4
{
    public partial class Cities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonLogIn_Click(object sender, EventArgs e)
        {
            labelValid.Text = "Успешна регистрација!";
        }
    }
}