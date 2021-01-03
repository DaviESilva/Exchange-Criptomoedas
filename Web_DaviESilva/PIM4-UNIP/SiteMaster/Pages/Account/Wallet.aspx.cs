using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMaster.Pages.Account
{
    public partial class Wallet : System.Web.UI.Page
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
                Response.Write(txtBitcoin.Text = Convert.ToString("BTC " + userData.btcValue));
                Response.Write(txtEthereum.Text = Convert.ToString("ETH " + userData.ethValue));
                Response.Write(txtDoge.Text = Convert.ToString("DOGE " + userData.dogeValue));
                Response.Write(txtUSDT.Text = Convert.ToString("USDT " + userData.usdtValue));
                Response.Write(txtXRP.Text = Convert.ToString("XRP " + userData.xrpValue));

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
    }
}