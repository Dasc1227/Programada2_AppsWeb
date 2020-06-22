using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatoRPCEncode
{
    public partial class Gato : Form
    {
        public Gato()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Jugar()
        {
            //gato.jugar();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Casilla1.Show();
            Casilla2.Show();
            Casilla3.Show();
            Casilla4.Show();
            Casilla5.Show();
            Casilla6.Show();
            Casilla7.Show();
            Casilla8.Show();
            Casilla9.Show();
            Jugar.Hide();
        }

        private void Casilla1_Click(object sender, EventArgs e)
        {
            if (Casilla1.Text.Equals("")) {
                Casilla1.Text = "X";
                //gato.jugar(0);
          
            }
        }

        private void Casilla2_Click(object sender, EventArgs e)
        {
            if (Casilla2.Text.Equals(""))
            {
                Casilla2.Text = "X";
                //gato.jugar(1);
                
            }
        }

        private void Casilla3_Click(object sender, EventArgs e)
        {
            if (Casilla3.Text.Equals(""))
            {
                Casilla3.Text = "X";
                //gato.jugar(2);
              
            }
        }

        private void Casilla4_Click(object sender, EventArgs e)
        {
            if (Casilla4.Text.Equals(""))
            {
                Casilla4.Text = "X";
                //gato.jugar(3);

            }
        }

        private void Casilla5_Click(object sender, EventArgs e)
        {
            if (Casilla5.Text.Equals(""))
            {
                Casilla5.Text = "X";
                //gato.jugar(4);
             
            }
        }

        private void Casilla6_Click(object sender, EventArgs e)
        {
            if (Casilla6.Text.Equals(""))
            {
                Casilla6.Text = "X";
                //gato.jugar(5);
          
            }
        }

        private void Casilla7_Click(object sender, EventArgs e)
        {
            if (Casilla7.Text.Equals(""))
            {
                Casilla7.Text = "X";
                //gato.jugar(6);
          
            }
        }

        private void Casilla8_Click(object sender, EventArgs e)
        {
            if (Casilla8.Text.Equals(""))
            {
                Casilla8.Text = "X";
                //gato.jugar(7);
         
            }
        }

        private void Casilla9_Click(object sender, EventArgs e)
        {
            if (Casilla9.Text.Equals(""))
            {
                Casilla9.Text = "X";
                //gato.jugar(8);
              
            }
        }
    }
}
