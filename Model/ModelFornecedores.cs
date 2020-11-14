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
    class ModelFornecedores : ControllerFornecedores
    {
        private int fornecedor_id;
        private String fornecedor_nome;
        private String fornecedor_telefone;
        private String fornecedor_observacao;


        public int Fornecedores_id
        {
            get { return fornecedor_id; }
            set { fornecedor_id = value; }
        }

        public String Fornecedores_nome
        {
            get { return fornecedor_nome; }
            set { fornecedor_nome = value; }
        }

        public String Fornecedores_telefone
        {
            get { return fornecedor_telefone; }
            set { fornecedor_telefone = value; }
        }

        public String Fornecedores_observacao
        {
            get { return fornecedor_observacao; }
            set { fornecedor_observacao = value; }
        }
    }
}
