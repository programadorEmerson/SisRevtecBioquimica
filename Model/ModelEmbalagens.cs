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
    class ModelEmbalagens : ControllerEmbalagens
    {
        private int embalagens_id;
        private String embalagens_nome;
        private int embalagens_estoque;
        private String embalagens_observacao;
        private double embalagens_peso;


        public double Embalagens_peso
        {
            get { return embalagens_peso; }
            set { embalagens_peso = value; }
        }


        public int Embalagens_id
        {
            get { return embalagens_id; }
            set { embalagens_id = value; }
        }

        public String Embalagens_nome
        {
            get { return embalagens_nome; }
            set { embalagens_nome = value; }
        }

        public int Embalagens_estoque
        {
            get { return embalagens_estoque; }
            set { embalagens_estoque = value; }
        }

        public String Embalagens_observacao
        {
            get { return embalagens_observacao; }
            set { embalagens_observacao = value; }
        }
    }
}
