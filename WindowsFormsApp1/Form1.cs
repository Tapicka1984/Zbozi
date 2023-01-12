using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Zbozi zbozi;
        Produkt produkt;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string jmeno = textBox1.Text;
                int cena = int.Parse(textBox3.Text);
                DateTime Datum_výroby = dateTimePicker1.Value;
                zbozi = new Zbozi(jmeno, cena, Datum_výroby);
                produkt = new Produkt(jmeno, cena, Datum_výroby);
            }
            catch
            {
                MessageBox.Show("zkontrolujte INPUT");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = produkt.ToString();
        }
    }
}
