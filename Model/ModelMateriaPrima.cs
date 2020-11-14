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
    class ModelMateriaPrima : ControllerMateriaPrima
    {
        private int materiaprima_id;
        private String materiaprima_nome;
        private double materiaprima_estoque;
        private String materiaprima_observacao;


        public int MateriaPrima_id
        {
            get { return materiaprima_id; }
            set { materiaprima_id = value; }
        }

        public String MateriaPrima_nome
        {
            get { return materiaprima_nome; }
            set { materiaprima_nome = value; }
        }

        public double MateriaPrima_estoque
        {
            get { return materiaprima_estoque; }
            set { materiaprima_estoque = value; }
        }

        public String MateriaPrima_observacao
        {
            get { return materiaprima_observacao; }
            set { materiaprima_observacao = value; }
        }
    }
}
