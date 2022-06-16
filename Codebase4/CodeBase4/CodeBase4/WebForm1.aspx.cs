using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeBase4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select", "Dell", "HP", "Mackbook", "Aspire" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Image/" + str + ".jfif";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Dell")
            {
                TextBox1.Text = "Rs. 50k";
            }
            else if (DropDownList1.Text == "HP")
            {
                TextBox1.Text = "50k";
            }
            else if (DropDownList1.Text == "Mackbook")
            {
                TextBox1.Text = "Rs80k";
            }
            else if (DropDownList1.Text == "Aspire")
            {
                TextBox1.Text = "Rs. 10k";
            }
            else
            {
                TextBox1.Text = " ";
            }
        }
    }
}