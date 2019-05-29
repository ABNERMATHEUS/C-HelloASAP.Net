using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASP.NET
{
    public partial class Intervalo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TextBox1.Text);
            double y = Convert.ToDouble(TextBox2.Text);
            if (x > y)
            {
               
                while (x > y+1)
                {
                    
                    x = x - 1;
                    Label1.Text = Label1.Text+ " " + x.ToString();

                }

            }
            else
            {
                Label1.Text = "X e menor que Y ";
            }
        }
    }
}