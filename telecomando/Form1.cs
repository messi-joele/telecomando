using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telecomando
{

    public partial class Form1 : Form
    {
        private Telecomando T;
        int a = 0;
        public Form1()
        {
            
            InitializeComponent();
            T = new Telecomando("SAMSUNG", "G300", "INFRAROSSI");
        }
        
        private void button6_Click(object sender, EventArgs e)
        {

            textBoxCORR.Text =$"{ T.getcanale()}";
        }

        private void accensione_Click(object sender, EventArgs e)
        {
            bool b=false;
            if (laccensione.Text == "SPENTO") {  b = false; }
            if (laccensione.Text == "ACCESO") {  b = true; }
            if(b == false) { 
                laccensione.Text = "ACCESO"; 
            
            }
            else
            {
                laccensione.Text = "SPENTO";
            }

        }

        private void PROD_Click(object sender, EventArgs e)
        {
            textBoxProd.Text = T.getproduttore();
        }

        private void modello_Click(object sender, EventArgs e)
        {
            textBoxmodello.Text = T.getmodello();
        }

        private void funz_Click(object sender, EventArgs e)
        {
            textBoxfunz.Text = T.getfunzionamento();
        }

        private void canale_Click(object sender, EventArgs e)
        {
            T.setCanale(int.Parse(textBoxcanale.Text));

        }

        private void alza_Click(object sender, EventArgs e)
        {
            if(a<100)
            a++;
            volume.Text = $"{a}";
        }

        private void abbassa_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                a--;
                volume.Text = $"{a}";
            }
        }
    }
}
