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
    class ModelExpedicao : ControllerExpedicao
        {
        public int Expedicao_id { get; set; }
        public int Expedicao_guia { get; set; }
        public String Expedicao_cliente { get; set; }
        public String Expedicao_dataEntrada { get; set; }
        public String Expedicao_dataEntrega { get; set; }
        public int Expedicao_volume { get; set; }
        public double Expedicao_peso { get; set; }
        public double Expedicao_cubagem { get; set; }
        public String Expedicao_status { get; set; }
        public DateTime Expedicao_entregaDate { get; set; }

    }
}
