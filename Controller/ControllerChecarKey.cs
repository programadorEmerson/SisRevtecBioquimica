using Revtec_Bioquimica.DAO;
using Revtec_Bioquimica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Revtec_Bioquimica.Controller
{
    class ControllerChecarKey
    {
        public ChecarKey recuperarChave(String cliente)
        {
            DAOchecarKey dAOchecarKey = new DAOchecarKey();
            return dAOchecarKey.recuperarDAdosPeloCliente(cliente);
        }        
        
        public bool atualizarChaveController(ChecarKey dadosAtivacao)
        {
            DAOchecarKey dAOchecarKey = new DAOchecarKey();
            return dAOchecarKey.atualizarChaveDAO(dadosAtivacao);
        }
    }
}
