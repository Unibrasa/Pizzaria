using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBrasa_Pizzaria.Model
{
    class Funcionario
    {

        public int idFuncionario { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public DateTime entrou { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public List<Cliente> cliente { get; set; }
    }
}
