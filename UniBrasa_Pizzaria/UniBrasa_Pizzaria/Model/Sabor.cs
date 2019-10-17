using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBrasa_Pizzaria.Model
{
    class Sabor
    {

        public int idSabor { get; set; }
        public string nome { get; set; }
        public double valor { get; set; }
        public DateTime entrou { get; set; }

        public Pedido Pedido { get; set; }
    }
}
