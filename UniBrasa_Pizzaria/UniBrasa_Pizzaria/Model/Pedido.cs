using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBrasa_Pizzaria.Model
{
    class Pedido
    {

        public int idPedido { get; set; }
        public string nome { get; set; }
        public double valor { get; set; }
        public DateTime entrou { get; set; }
        List<TamanhoPizza> TamanhoPizza { get; set; }
        List<Cliente> Cliente { get; set; }
        List<Sabor> Sabor { get; set; }
        List<Bebida> Bebida { get; set; }
    }
}
