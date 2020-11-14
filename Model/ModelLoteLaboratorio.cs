using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revtec_Bioquimica.Model
{
    class ModelLoteLaboratorio
    {
        public int Id_lote { get; set; }
        public String Numero_lote { get; set; }
        public String Data_lote { get; set; }
        public String Produto_lote { get; set; }
        public double Litragem_lote { get; set; }
        public String Cliente_lote { get; set; }
    }
}
