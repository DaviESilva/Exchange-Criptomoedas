using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMaster.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {

            string pass1 = txtPass.Text;
            string pass2 = txtPassConfirm.Text;

            if (string.IsNullOrEmpty(txtUser.Text) ||
                     string.IsNullOrEmpty(txtEmail.Text) ||
                     string.IsNullOrEmpty(txtDocument.Text) ||
                     string.IsNullOrEmpty(txtBirthday.Text) ||
                     string.IsNullOrEmpty(txtPass.Text) ||
                     string.IsNullOrEmpty(txtPassConfirm.Text))
            {
                Response.Write(txtCode.Text = "Insira todos os dados para continuar!");
                txtCode.Focus();
                txtCode.Visible = true;
                containerPopUp.Style.Add("Visibility", "Visible");
                return;
            }
         
            if (pass1 == pass2 && !string.IsNullOrEmpty(txtPass.Text))
            {
                //iniciando o data context

                PIM4LINQDataContext db = new PIM4LINQDataContext();
                User user = new User();
                user.Username = txtUser.Text;
                user.Email = txtEmail.Text;
                user.Birthday = txtBirthday.Text;
                user.Password = txtPass.Text;
                user.Document = txtDocument.Text;

                //Instancia as carteiras garantindo que elas estejam vazias
                user.btcValue = Convert.ToDecimal(0.00000000);
                user.ethValue = Convert.ToDecimal(0.00000000);
                user.dogeValue = Convert.ToDecimal(0.00000000);
                user.usdtValue = Convert.ToDecimal(0.00000000);
                user.xrpValue = Convert.ToDecimal(0.00000000);

                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();


                Response.Write(txtCode.Text = "Usuário cadastrado com sucesso!");
                txtCode.Focus();
                txtCode.BackColor = Color.LightPink;
                txtCode.Visible = true;
                containerPopUp.Style.Add("Visibility", "Visible");
                return;
            }
            if (pass1 != pass2)
            {
                Response.Write(txtCode.Text = "As senhas não coincidem!");
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