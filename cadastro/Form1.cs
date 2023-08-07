using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Produto> list = new List<Produto>();
            while (true)
            {
                Produto produto = new Produto();
                produto.codigo = textBox1.Text;
                produto.preco = Convert.ToDouble(textBox2.Text);
                produto.descricao = textBox4.Text;
                produto.lucro = Convert.ToDouble(textBox3);

                double res = ((produto.preco * produto.lucro)/100) + produto.preco;
                label7.Text = Convert.ToString(res);
                list.Add(produto);
            }
          
         /* List<string> list = new List<string>();
          string codigo = textBox1.Text;
          double preco =  Convert.ToDouble(textBox2);
          string descricao = textBox4.Text;
          double lucro = Convert.ToDouble(maskedTextBox1);
          double res = preco + (preco * lucro);
          label7.Text = Convert.ToString(res);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
           */
        }
    }
}
