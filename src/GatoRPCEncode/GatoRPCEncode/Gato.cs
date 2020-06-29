using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GatoRPCEncode
{
    public partial class Gato : Form
    {
        private ECCI.ECCI_B77519_B72097_GatoPortClient gato;
        public Gato()
        {
            InitializeComponent();
            gato = new ECCI.ECCI_B77519_B72097_GatoPortClient();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_jugar_Click(object sender, EventArgs e)
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
            btn_jugar.Hide();
            textBox1.Hide();
            label3.Hide();

        }

        private void Jugar(int jugada)
        {
            switch (jugada)
            {
                case 0:
                    Casilla1.Text = "O";
                    break;
                case 1:
                    Casilla2.Text = "O";
                    break;
                case 2:
                    Casilla3.Text = "O";
                    break;
                case 3:
                    Casilla4.Text = "O";
                    break;
                case 4:
                    Casilla5.Text = "O";
                    break;
                case 5:
                    Casilla6.Text = "O";
                    break;
                case 6:
                    Casilla7.Text = "O";
                    break;
                case 7:
                    Casilla8.Text = "O";
                    break;
                case 8:
                    Casilla9.Text = "O";
                    break;

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

 
        private void Casilla1_Click(object sender, EventArgs e)
        {
            if (Casilla1.Text.Equals("")) {
                Casilla1.Text = "X";
                gato.jugar(0); // se marca la jugada en el arreglo del php
                

                //Si gano con la jugada
                if (gato.checkWin(0,"X"))
                {
                  
                    MessageBox.Show("FELICIDADES, HAS GANADO");
                    //Guardar resultados en el ranking
                    this.Close();
                    

                }
                else
                {
                    //Si ya no hay jugadas disponibles
                    if (gato.getCasillasRestantes() == 0)
                    {
                        MessageBox.Show("Has empatado, mas suerte la proxima");
                        //Guardar resultads
                        this.Close();
                    }
                    //Si no, juega la maquina
                    else {
                        int jugada = gato.juegaMaquina();
                        //Se marca la letra en el tablero
                        Jugar(jugada);
                        if (gato.checkWin(jugada, "O"))
                        {
                            MessageBox.Show("Has perdido");
                            this.Close();
                        }
                        else {
                            if(gato.getCasillasRestantes() == 0)
                            {
                                MessageBox.Show("Has empatado, mas suerte la proxima");
                                this.Close();
                            }
                        }
                    }

                }
                
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
