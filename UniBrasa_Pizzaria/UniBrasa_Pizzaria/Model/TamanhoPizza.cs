using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBrasa_Pizzaria.Model
{
    class TamanhoPizza
    {
        public int idTamanhoPizza { get; set; }
        public string tamanho { get; set; }
        public double valor { get; set; }
        public Pedido Pedido { get; set; }
    }
}
