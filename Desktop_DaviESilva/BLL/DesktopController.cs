using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using Desktop_DaviESilva_F0450H6.DAL;
using Desktop_DaviESilva_F0450H6.BLL;


namespace Desktop_DaviESilva_F0450H6.BLL
{

    class DesktopController
    {
        private IDesktopDAO dao;

        public DesktopController()
        {
            dao = DAOFactory.CriarDesktopDAO();
        }

        public bool Salvar(User user)
        {
            if (user.IdUser == null)
                return dao.Inserir(user);
            return dao.Atualizar(user);
        }

        public bool Excluir(int iduser)
        {
            return dao.Excluir(iduser);
        }

        public DataSet ListarTodos()
        {
            return dao.ListarTodos();
        }

        //public DataSet ListaPorMesAno(int mes, int ano)
        //{
        //    return dao.ListaPorMesAno(mes, ano);
        //}
    }
}
