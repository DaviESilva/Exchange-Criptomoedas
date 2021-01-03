using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMaster
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PIM4LINQDataContext db = new PIM4LINQDataContext();

                var userData = (from f in db.Users
                                where f.IdUser.Equals(Convert.ToString(LoggedUser.idUserLogged))
                                select f).Single();

                Response.Write(txtUser.Text = Convert.ToString(userData.Username));
                Response.Write(txtDocument.Text = Convert.ToString(userData.Document));
                Response.Write(txtEmail.Text = Convert.ToString(userData.Email));
                Response.Write(txtPass.Text = Convert.ToString(userData.Password));
                Response.Write(txtBirthday.Text = Convert.ToString(userData.Birthday));

            }
            catch (Exception ex)
            {
                Response.Write(txtCode.Text = "Erro ao carregar os dados: " + ex.Message);
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

        //protected void changeData_Click(object sender, EventArgs e)
        //{
        //    PIM4LINQDataContext db = new PIM4LINQDataContext();
        //    try
        //    {
        //        var userData = (from f in db.Users
        //                        where f.IdUser.Equals(Convert.ToString(LoggedUser.idUserLogged))
        //                        select f).Single();

        //        userData.Username = txtUser.Text;
        //        userData.Password = txtPass.Text;
        //        userData.Birthday = txtBirthday.Text;

        //        db.SubmitChanges();
        //        Response.Write(txtCode.Text = "Dados alterados com sucesso!");
        //        txtCode.Focus();
        //        txtCode.Visible = true;
        //        containerPopUp.Style.Add("Visibility", "Visible");
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(txtCode.Text = "Erro ao carregar os dados: " + ex.Message);
        //        txtCode.Focus();
        //        txtCode.Visible = true;
        //        containerPopUp.Style.Add("Visibility", "Visible");
        //        return;
        //    }
        //}
    }
}