using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMaster.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtlogin.Text;
            string pass = txtPass.Text;

            PIM4LINQDataContext db = new PIM4LINQDataContext();

            try
            {
                var login = (from f in db.Users
                             where f.Username.Equals(Convert.ToString(username))
                             select f).Single();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
                {
                    Response.Write(txtCode.Text = "Insira dados válidos!");
                    txtCode.Focus();
                    txtCode.Visible = true;
                    containerPopUp.Style.Add("Visibility", "Visible");
                    return;
                }
                if (pass == Convert.ToString(login.Password))
                {
                    Response.Write(txtCode.Text = "Usuário logado!!!");
                    txtCode.Focus();
                    txtCode.Visible = true;
                    containerPopUp.Style.Add("Visibility", "Visible");

                    LoggedUser.idUserLogged = login.IdUser;
                    Server.Transfer("/Pages/Home.aspx", true);
                    return;
                }
                else
                {
                    Response.Write(txtCode.Text = "Senha incorreta!!!");
                    txtCode.Focus();
                    txtCode.Visible = true;
                    containerPopUp.Style.Add("Visibility", "Visible");

                    return;
                }
            }
            catch (InvalidOperationException ex)
            {
                Response.Write(txtCode.Text = "Usuário inválido! Erro: " + ex.Message);
                txtCode.Focus();
                txtCode.Visible = true;
                containerPopUp.Style.Add("Visibility", "Visible");
                return;
            }
            
        }

        protected void ClosePopup_Click(object sender, EventArgs e)
        {
            txtCode.Visible = true;
            containerPopUp.Style.Add("Visibility", "hidden");
            return;
        }

    }


}