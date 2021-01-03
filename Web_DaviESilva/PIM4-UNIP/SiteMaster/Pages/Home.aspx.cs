using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMaster
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PIM4LINQDataContext db = new PIM4LINQDataContext();

                var userData = (from f in db.Users
                                where f.IdUser.Equals(Convert.ToString(LoggedUser.idUserLogged))
                                select f).Single();

                Response.Write(txtUsername.Text = Convert.ToString(userData.Username) + "!");

                Response.Write(txtBitcoin.Text = Convert.ToString("BTC " + userData.btcValue));
                Response.Write(txtBtcUsd.Text = Convert.ToString("R$ " + Convert.ToDouble(userData.btcValue) * 100251.01));

                Response.Write(txtEthereum.Text = Convert.ToString("ETH " + userData.ethValue));
                Response.Write(txtEthUsd.Text = Convert.ToString("R$ " + Convert.ToDouble(userData.ethValue) * 2383.09));


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