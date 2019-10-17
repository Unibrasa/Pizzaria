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
    public partial class F_Pagamento : Form
    {
        /*
        public String Valor
        {
            get { return radioButton1.Text; }
            set { radioButton1.Text = value; }
        }
        */

        public F_Pagamento()
        {
            InitializeComponent();
        }

        private void btnAdicionarPagamento_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                MessageBox.Show("A forma de pagamento na hora da entrega será:" + radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("A forma de pagamento na hora da entrega será:" + radioButton2.Text);
            }
            else if(radioButton3.Checked == true)
            {
                MessageBox.Show("A forma de pagamento na hora da entrega será:" + radioButton3.Text);
            }
            else if (radioButton4.Checked == true)
            {
                MessageBox.Show("A forma de pagamento na hora da entrega será:" + radioButton4.Text);
            }
            else if (radioButton5.Checked == true)
            {
                MessageBox.Show("A forma de pagamento na hora da entrega será:" + radioButton5.Text);
            }
            else if (radioButton6.Checked == true)
            {
                MessageBox.Show("A forma de pagamento na hora da entrega será:" + radioButton6.Text);
            }
            else if (radioButton7.Checked == true)
            {
                MessageBox.Show("A forma de pagamento na hora da entrega será:" + radioButton7.Text);
            }
            else if (radioButton8.Checked == true)
            {
                MessageBox.Show("A forma de pagamento na hora da entrega será:" + radioButton8.Text);
            }
            else if (radioButton9.Checked == true)
            {
                MessageBox.Show("A forma de pagamento na hora da entrega será:" + radioButton9.Text);
            }
            else if (radioButton10.Checked == true)
            {
                MessageBox.Show("A forma de pagamento na hora da entrega será:" + radioButton10.Text);
            }
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento!");
            }


     

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void F_Pagamento_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
