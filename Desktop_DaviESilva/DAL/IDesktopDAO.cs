using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_DaviESilva_F0450H6.BLL;

namespace Desktop_DaviESilva_F0450H6.DAL
{
    interface IDesktopDAO
    {
        bool Inserir(User user);
        bool Atualizar(User user);
        bool Excluir(int iduser);
        DataSet ListarTodos();
        //DataSet ListaPorMesAno(int mes, int ano);
    }
}

