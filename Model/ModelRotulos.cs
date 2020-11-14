using Revtec_Bioquimica.Controller;
using System;

namespace Revtec_Bioquimica.Model
{
    class ModelRotulos : ControllerRotulos
    {
        public int Rotulo_id { get; set; }
        public String Rotulo_produto { get; set; }
        public int Rotulo_guia { get; set; }
        public int Rotulo_idProduto { get; set; }
        public String Rotulo_cliente { get; set; }
        public String Rotulo_lote { get; set; }
        public String Rotulo_fabricacao { get; set; }
        public String Rotulo_validade { get; set; }
        public int Rotulo_quantidade { get; set; }
        public String Rotulo_litragem { get; set; }
        public String Rotulo_status { get; set; }
        public String Rotulo_observacao { get; set; }
    }
}
