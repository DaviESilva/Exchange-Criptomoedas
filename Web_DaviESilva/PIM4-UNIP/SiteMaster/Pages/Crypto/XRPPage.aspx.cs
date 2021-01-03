using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMaster.Pages.Crypto
{
    public partial class XRPPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // INICIO DAS CARTEIRAS 
            try
            {
                PIM4LINQDataContext db = new PIM4LINQDataContext();

                var userData = (from f in db.Users
                                where f.IdUser.Equals(Convert.ToString(LoggedUser.idUserLogged))
                                select f).Single();

                Response.Write(WalletBalance1.Text = Convert.ToString(userData.xrpValue));
                Response.Write(WalletBalance2.Text = Convert.ToString(userData.xrpValue));

            }
            catch (Exception ex)
            {
                Response.Write(txtCode.Text = "Erro ao carregar os dados: " + ex.Message);
                txtCode.Focus();
                txtCode.Visible = true;
                containerPopUp.Style.Add("Visibility", "Visible");
                return;
            }
            // FIM DAS CARTEIRAS
        }

        //INICIO CARD COMPRAR
        protected void BuySend_Click(object sender, EventArgs e)
        {
            try
            {
                decimal userInputBuy = Convert.ToDecimal(InputBuy.Text);

                PIM4LINQDataContext db = new PIM4LINQDataContext();

                var userData = (from f in db.Users
                                where f.IdUser.Equals(Convert.ToString(LoggedUser.idUserLogged))
                                select f).Single();

                userData.xrpValue = userData.xrpValue + userInputBuy;

                db.SubmitChanges();

                Response.Write(txtCode.Text = "Compra realizada com sucesso!");
                txtCode.Focus();
                txtCode.Visible = true;
                containerPopUp.Style.Add("Visibility", "Visible");
                return;
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

        protected void BuyClear_Click(object sender, EventArgs e)
        {
            Response.Write(InputBuy.Text = "");
        }

        //FIM CARD COMPRAR

        //INICIO CARD VENDER

        protected void SellSend_Click(object sender, EventArgs e)
        {
            decimal userInputSell = Convert.ToDecimal(InputSell.Text);
            try
            {
                PIM4LINQDataContext db = new PIM4LINQDataContext();

                var userData = (from f in db.Users
                                where f.IdUser.Equals(Convert.ToString(LoggedUser.idUserLogged))
                                select f).Single();

                if (userInputSell <= userData.xrpValue)
                {
                    userData.xrpValue = userData.xrpValue - userInputSell;

                    db.SubmitChanges();

                    Response.Write(txtCode.Text = "Venda realizada com sucesso!");
                    txtCode.Focus();
                    txtCode.Visible = true;
                    containerPopUp.Style.Add("Visibility", "Visible");
                    return;
                }
                else
                {
                    Response.Write(txtCode.Text = "Fundos insuficientes para venda");
                    txtCode.Focus();
                    txtCode.Visible = true;
                    containerPopUp.Style.Add("Visibility", "Visible");
                    return;
                }
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

        protected void SellClear_Click(object sender, EventArgs e)
        {
            Response.Write(InputSell.Text = "");
        }

        //FIM CARD VENDER


        protected void ClosePopup_Click(object sender, EventArgs e)
        {
            txtCode.Visible = true;
            containerPopUp.Style.Add("Visibility", "hidden");
            return;
        }
    }
}