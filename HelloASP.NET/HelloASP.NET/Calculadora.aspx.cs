using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASP.NET
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Calcular_Click(object sender, EventArgs e)
        {
            double OperadorOk1 = Convert.ToDouble(Operador1.Text);
            double OperadorOk2 = Convert.ToDouble(Operador2.Text);
            if (DropDownList1.SelectedValue == "Somar")
            {
                double somarSomar = OperadorOk1 + OperadorOk2;
                Label1.Text = Convert.ToString(somarSomar);
            
            }
            else if   (DropDownList1.SelectedValue == "Subtrair")
            {
                double somarSomar = OperadorOk1-OperadorOk2;
                Label1.Text = Convert.ToString(somarSomar);

            }
            else if  (DropDownList1.SelectedValue == "Dividir")
            {
                double somarSomar = OperadorOk1/ OperadorOk2;
                Label1.Text = Convert.ToString(somarSomar);

            }
            else if (DropDownList1.SelectedValue == "Multiplicar")
            {
                double somarSomar = OperadorOk1 * OperadorOk2;
                Label1.Text = Convert.ToString(somarSomar);

            }


        }
    }
}