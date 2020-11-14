using MySql.Data.MySqlClient;
using Revtec_Bioquimica.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.Model
{
    class ModelUsuarios : ControllerUsuarios
    {
        private int usuarios_id;
        private String usuarios_nome;
        private String usuarios_setor;
        private String usuarios_nivel;
        private String usuarios_login;
        private String usuarios_senha;
        private String usuario_empresa;


        public int Usuarios_id
        {
            get { return usuarios_id; }
            set { usuarios_id = value; }
        }

        public String Usuarios_nome
        {
            get { return usuarios_nome; }
            set { usuarios_nome = value; }
        }
        
        public String Usuario_empresa
        {
            get { return usuario_empresa; }
            set { usuario_empresa = value; }
        }

        public String Usuarios_setor
        {
            get { return usuarios_setor; }
            set { usuarios_setor = value; }
        }

        public String Usuarios_nivel
        {
            get { return usuarios_nivel; }
            set { usuarios_nivel = value; }
        }

        public String Usuarios_login
        {
            get { return usuarios_login; }
            set { usuarios_login = value; }
        }
        
        public String Usuarios_senha
        {
            get { return usuarios_senha; }
            set { usuarios_senha = value; }
        }
    }
}
