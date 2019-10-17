using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBrasa_Pizzaria.Model
{
    class Bebida
    {
        public int idBebiba { get; set; }
        public string nome { get; set; }
        public double valor { get; set; }
        public DateTime CriadoEm { get; set; }
        public List<Pedido> Pedido { get; set; }
    }
}
