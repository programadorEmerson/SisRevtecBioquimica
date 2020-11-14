using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revtec_Bioquimica.Model
{
    class ModelOrdemDeProducao
    {
        public int OrdemId { get; set; }
        public String OrdemProduto { get; set; }
        public double OrdemQuantidade { get; set; }
        public String OrdemDataSaida { get; set; }
        public String OrdemLoteNumero { get; set; }
        public String OrdemDataSolicitacao { get; set; }

    }
}
