using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revtec_Bioquimica.Model
{
    class ChecarKey
    {
        public int Cliente_id { get; set; }
        public String Cliente_nome { get; set; }
        public DateTime Cliente_dataCadastro { get; set; }
        public DateTime Cliente_dataExpira { get; set; }
        public String Cliente_serial { get; set; }
    }
}
