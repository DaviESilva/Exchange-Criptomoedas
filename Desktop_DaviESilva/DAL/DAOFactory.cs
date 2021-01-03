using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Desktop_DaviESilva_F0450H6.BLL;

namespace Desktop_DaviESilva_F0450H6.DAL
{
    class DAOFactory
    {
        public static IDesktopDAO CriarDesktopDAO()
        {
            return new DesktopDAODB();
        }
    }
}
