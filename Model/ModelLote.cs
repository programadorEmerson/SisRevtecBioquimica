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
    class ModelLote : ControllerLote
    {
        private int lote_id;
        private String lote_numero;
        private String lote_produto;
        private String lote_fabricacao;
        private String lote_validade;
        private double lote_litragem;
        private String lote_observacao;
        private String lote_status;
        private double lote_litragemFeita;
        private int lote_idAmostra;


        public int Lote_id {
            get { return lote_id; }
            set { lote_id = value; }
        }

        public String Lote_numero {
            get { return lote_numero; }
            set { lote_numero = value; }
        }

        public String Lote_produto {
            get { return lote_produto; }
            set { lote_produto = value; }
        }

        public String Lote_fabricacao {
            get { return lote_fabricacao; }
            set { lote_fabricacao = value; }
        }

        public String Lote_validade {
            get { return lote_validade; }
            set { lote_validade = value; }
        }

        public double Lote_litragem {
            get { return lote_litragem; }
            set { lote_litragem = value; }
        }

        public String Lote_observacao {
            get { return lote_observacao; }
            set { lote_observacao = value; }
        }        
        
        public String Lote_status {
            get { return lote_status; }
            set { lote_status = value; }
        }        
        
        public double Lote_litragemFeita {
            get { return lote_litragemFeita; }
            set { lote_litragemFeita = value; }
        }        
        public int Lote_idAmostra {
            get { return lote_idAmostra; }
            set { lote_idAmostra = value; }
        }

    }
}
