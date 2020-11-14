using Revtec_Bioquimica.DAO;
using Revtec_Bioquimica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revtec_Bioquimica.Controller
{
    class ControllerRegistro
    {
        public Registro verificarChaveDeRegistro()
        {
            DAORegistro registro = new DAORegistro();
            return registro.recuperarRegistro();
        }
        
        public bool atualizarChave(Registro registroRecuperado)
        {
            DAORegistro registro = new DAORegistro();
            return registro.atualizarUsuariosDAO(registroRecuperado);
        }
    }
}
