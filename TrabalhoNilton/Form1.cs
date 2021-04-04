using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoNilton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMedia_Click(object sender, EventArgs e)
        {
            Decimal segunda, terca, quarta, quinta, sexta;

            segunda = Convert.ToDecimal(txtSeg.Text);
            terca = Convert.ToDecimal(txtTer.Text);
            quarta = Convert.ToDecimal(txtQua.Text);
            quinta = Convert.ToDecimal(txtQui.Text);
            sexta = Convert.ToDecimal(txtSex.Text);

            decimal resultado = (segunda + terca + quarta + quinta + sexta)/ 5;
            MessageBox.Show(resultado.ToString());
        }  
    }
}

