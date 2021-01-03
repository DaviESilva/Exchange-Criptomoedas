using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMaster
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void btnLogOut_Click(object sender, EventArgs e)
        {
            LoggedUser.idUserLogged = 0;
            Server.Transfer("/Pages/UnloggedHome.aspx", true);
            return;
        }
    }

    public class LoggedUser
    {
        private static int _idUserLogged;
        public static int idUserLogged
        {
            get { return _idUserLogged; }
            set { _idUserLogged = value; }
        }
    }


}