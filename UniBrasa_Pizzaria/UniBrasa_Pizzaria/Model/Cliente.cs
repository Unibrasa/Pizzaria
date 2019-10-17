using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBrasa_Pizzaria.Model
{
    class Cliente
    {
        public int idCliente { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public int telefone { get; set; }
        public string endereco { get; set; }
        public DateTime entrou { get; set; }
        public List<Pedido> Pedido { get; set; }
        public List<Funcionario> Funcionario { get; set; }

    }
}
