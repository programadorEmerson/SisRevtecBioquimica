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
    class ModelTampa : ControllerTampa
    {
        private int tampa_id;
        private String tampa_nome;
        private int tampa_estoque;
        private String tampa_observacao;
        private double tampa_peso;


        public double Tampa_peso
        {
            get { return tampa_peso; }
            set { tampa_peso = value; }
        }

        public int Tampa_id
        {
            get { return tampa_id; }
            set { tampa_id = value; }
        }

        public String Tampa_nome
        {
            get { return tampa_nome; }
            set { tampa_nome = value; }
        }

        public int Tampa_estoque
        {
            get { return tampa_estoque; }
            set { tampa_estoque = value; }
        }

        public String Tampa_observacao
        {
            get { return tampa_observacao; }
            set { tampa_observacao = value; }
        }
    }
}
