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
    class ModelProdutoAcabado : ControllerProdutoAcabado
    {
        private int pro_id;
        private String pro_nome;
        private double prod_estoque;
        private String pro_observacao;
        private double pro_peso;


        public double Pro_peso
        {
            get { return pro_peso; }
            set { pro_peso = value; }
        }
        public int Pro_id
        {
            get { return pro_id; }
            set { pro_id = value; }
        }

        public String Pro_nome
        {
            get { return pro_nome; }
            set { pro_nome = value; }
        }

        public double Pro_estoque
        {
            get { return prod_estoque; }
            set { prod_estoque = value; }
        }

        public String Pro_observacao
        {
            get { return pro_observacao; }
            set { pro_observacao = value; }
        }
    }
}
