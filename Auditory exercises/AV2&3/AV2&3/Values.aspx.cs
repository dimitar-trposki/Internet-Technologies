using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AV2_3
{
    public partial class Values : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            ListItem item = new ListItem(textName.Text, textValue.Text);
            int flag = 0;
            foreach (ListItem inner in listValues.Items)
            {
                if (inner.Text == textName.Text)
                {
                    flag = 1;
                }
            }
            if (flag == 0 && textName.Text.Length > 0 && textValue.Text.Length > 0)
            {
                listValues.Items.Add(item);
                labelCounter.Text = Convert.ToString(listValues.Items.Count);
            }
            textName.Text = "";
            textValue.Text = "";
        }

        protected void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listValues.SelectedIndex >= 0)
            {
                if (labelToConvert.Text == listValues.SelectedItem.Text)
                {
                    labelToConvert.Text = " (избрана валута) ";
                }
                listValues.Items.Remove(listValues.SelectedItem);
                labelCounter.Text = Convert.ToString(listValues.Items.Count);
            }
        }

        protected void listValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelToConvert.Text = listValues.SelectedItem.Text;
            labelConverted.Text = Convert.ToString(Convert.ToDouble(listValues.SelectedItem.Value) * Convert.ToDouble(textValueToConvert.Text));
        }
    }
}