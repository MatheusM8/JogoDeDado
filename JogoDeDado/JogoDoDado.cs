using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Matheus Moura Oliveira RA: 547735 SI 5° semestre
namespace JogoDeDado
{
    public partial class Form1 : Form
    {
        int rodada = 1;
        int vez = 1;

        int pontuacaoJ1 = 0;
        int pontuacaoJ2 = 0;

        int valorDadoJ1 = 0;
        int valorDadoJ2 = 0;

        public Form1()
        {
            InitializeComponent();

        }
        public int jogaDado()
        {
            int d;
            Random n = new Random();
            d = n.Next(1, 7);
            txtDado.Text = d.ToString();
            return d;          
        }

        public void resetar()
        {
            this.Controls.Clear();
            this.InitializeComponent();

            rodada = 1;
            vez = 1;

            pontuacaoJ1 = 0;
            pontuacaoJ2 = 0;

            valorDadoJ1 = 0;
            valorDadoJ2 = 0;
        }

        public void verificaVencedorJogo()
        {
            if(pontuacaoJ1 > pontuacaoJ2)
            {
                lblJ1result.Text = "Vitória"; lblJ1result.ForeColor = System.Drawing.Color.Green;
                lblJ1result.Visible = true;

                lblJ2result.Text = "Derrota"; lblJ2result.ForeColor = System.Drawing.Color.Red;
                lblJ2result.Visible = true;

                pictureBox1.Location = new Point(24, 253);
                pictureBox1.Size = new Size(166, 146);
                pictureBox1.Visible = true; 
                MessageBox.Show("O Jogador 1 Venceu!");
                resetar();
            }
            else if(pontuacaoJ2 > pontuacaoJ1)
            {
                lblJ1result.Text = "Derrota"; lblJ1result.ForeColor = System.Drawing.Color.Red;
                lblJ1result.Visible = true;

                lblJ2result.Text = "Vitória"; lblJ2result.ForeColor = System.Drawing.Color.Green;
                lblJ2result.Visible = true;

                pictureBox1.Location = new Point(587, 253);
                pictureBox1.Size = new Size(166, 146);
                pictureBox1.Visible = true;

                MessageBox.Show("O Jogador 2 Venceu!");
                
                resetar();
            }
            else if(pontuacaoJ1 == pontuacaoJ2)
            {
                
            }
        }

        public void verificaVencedorRodada()
        {
            if(valorDadoJ1 > valorDadoJ2)
            {
                pontuacaoJ1++;
                txtJogador1.Text = pontuacaoJ1.ToString();
            }
            else if(valorDadoJ2 > valorDadoJ1)
            {
                pontuacaoJ2++;
                txtJogador2.Text = pontuacaoJ2.ToString();
            }
            else
            {
                pontuacaoJ1++;
                pontuacaoJ2++;
                txtJogador1.Text = pontuacaoJ1.ToString();
                txtJogador2.Text = pontuacaoJ2.ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJogDado_Click(object sender, EventArgs e)
        {
            switch (vez%2)
            {
                case 1:
                    valorDadoJ1 = jogaDado();
                    lstBoxJ1.Items.Add(valorDadoJ1);
                    break;

                case 0:
                    valorDadoJ2 = jogaDado();
                    lstBoxJ2.Items.Add(valorDadoJ2);

                    verificaVencedorRodada();
                    rodada++;
                    break;
            }
            vez++;
            
            if ((pontuacaoJ1 != pontuacaoJ2 && rodada > 2) || (pontuacaoJ1 - pontuacaoJ2 == 2 || pontuacaoJ2 - pontuacaoJ1 == 2))
            {
                verificaVencedorJogo();
            }
            if (pontuacaoJ1 == 3 && pontuacaoJ2 == 3)
            {
                lblJ1result.Text = "Empate"; lblJ1result.ForeColor = System.Drawing.Color.Orange;
                lblJ2result.Visible = true;

                lblJ2result.Text = "Empate"; lblJ1result.ForeColor = System.Drawing.Color.Orange;
                lblJ2result.Visible = true;
                pictureBox1.Location = new Point(236, 103);
                pictureBox1.Size = new Size(294, 249);
                pictureBox1.Visible = true;

                MessageBox.Show("Empate!");
                resetar();
            }

            txtRodada.Text = rodada.ToString();
            if(vez%2 == 1)
                pictureBox2.Location = new Point(141, 116);
            else
                pictureBox2.Location = new Point(529, 116);


        }
    }
}
