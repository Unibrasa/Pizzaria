using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniBrasa_Pizzaria.Model;
using UniBrasa_Pizzaria.View.Cadastro;
using UniBrasa_Pizzaria.View.Pedido;

namespace UniBrasa_Pizzaria
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            //Form Form1
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
            //Form Cadastrar Cliente
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CadastrarCliente());
           

            //Form Forma de Pagamento - Felipe 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F_Pagamento());
            */

            //Form Pedido - Felipe (Vai inicializar o programa com esse form)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F_Pedido());
            
        }
    }
}
