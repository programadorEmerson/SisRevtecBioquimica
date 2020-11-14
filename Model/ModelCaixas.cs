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
    class ModelCaixas : ControllerCaixas
    {
        private int caixas_id;
        private String caixas_nome;
        private int caixas_estoque;
        private String caixas_observacao;
        private double caixas_peso;
        private double caixas_altura;
        private double caixas_largura;
        private double caixas_comprimento;


        public double Caixas_peso
        {
            get { return caixas_peso; }
            set { caixas_peso = value; }
        }
        
        public double Caixas_altura {
            get { return caixas_altura; }
            set { caixas_altura = value; }
        }
        
        public double Caixas_largura {
            get { return caixas_largura; }
            set { caixas_largura = value; }
        }
        
        public double Caixas_comprimento {
            get { return caixas_comprimento; }
            set { caixas_comprimento = value; }
        }

        public int Caixas_id
        {
            get { return caixas_id; }
            set { caixas_id = value; }
        }

        public String Caixas_nome
        {
            get { return caixas_nome; }
            set { caixas_nome = value; }
        }

        public int Caixas_estoque
        {
            get { return caixas_estoque; }
            set { caixas_estoque = value; }
        }

        public String Caixas_observacao
        {
            get { return caixas_observacao; }
            set { caixas_observacao = value; }
        }
    }
}
