using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniBrasa_Pizzaria.View.Pedido
{
    public partial class F_Pedido : Form
    {
        public F_Pedido()
        {
            InitializeComponent();
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            //interação form1 com form2
            F_Pagamento Forma_Pagamento = new F_Pagamento();
            Forma_Pagamento.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            F_Pagamento Pag = new F_Pagamento();
            Pag.ShowDialog();
           
            richTextBox1.AppendText(Pag.Valor);
            */
        }
    }
}
