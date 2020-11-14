using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revtec_Bioquimica.Model
{
    class Registro
    {
        public int Registro_id { get; set; }
        public String Registro_serial { get; set; }
        public DateTime Registro_dataRegistro { get; set; }
        public DateTime Registro_dataExpira { get; set; }
    }
}
