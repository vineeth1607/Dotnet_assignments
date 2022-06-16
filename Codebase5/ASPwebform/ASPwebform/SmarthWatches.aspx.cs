using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPwebform
{
    public partial class SmarthWatches : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {



                string[] str = new string[] { "Applewatch5", "Fossilwatch", "realmewatch", "Samsungwatch" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".JFIF";




            if (DropDownList1.Items.FindByText("Applewatch5").Selected == true)
            {
                Label1.Text = "Price: 70,000/-";
            }
            else if (DropDownList1.Items.FindByText("Fossilwatch").Selected == true)
            {
                Label1.Text = "Price: 12,000/-";
            }
            else if (DropDownList1.Items.FindByText("realmewatch").Selected == true)
            {
                Label1.Text = "Price: 5,000/-";
            }
            else if (DropDownList1.Items.FindByText("Samsungwatch").Selected == true)
            {
                Label1.Text = "Price: 34,000/-";
            }
            
        }
    }
}