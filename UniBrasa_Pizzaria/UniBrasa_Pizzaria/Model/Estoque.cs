using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBrasa_Pizzaria.Model
{
    class Estoque
    {

        public int idEstoque { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public double valor { get; set; }
        public List<Fornecedor> Fornecedor { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
