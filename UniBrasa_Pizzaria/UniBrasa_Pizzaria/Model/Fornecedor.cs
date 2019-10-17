using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBrasa_Pizzaria.Model
{
    class Fornecedor
    {

        public int idFornecedor { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public DateTime CriadoEm { get; set; }
        public List<Estoque> estoques { get; set; }

    }
}
