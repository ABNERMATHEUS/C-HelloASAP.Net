using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASP.NET
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        
            
        }

        protected void btEntrar_Click(object sender, EventArgs e)
        {
            string nome;
            string senha;
            nome = TxtLogin.Text;
            senha = TxtSenha.Text;
            if (nome == "Abner.matheus" &&  senha == "4321") 
            {
                lblStatus.Text = "Correto!";

            }
            else {
                lblStatus.Text = ("Usuario ou Senha Incorreto");
            }




        }
    }
}