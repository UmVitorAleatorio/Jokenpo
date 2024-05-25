using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Jokenpo
{
    public partial class Form1 : Form
    {
        SoundPlayer MeuPlayer = new SoundPlayer("som.wav");
        public Form1()
        {
            InitializeComponent();
            MeuPlayer.Play();
        }

        private void jPapel_Click(object sender, EventArgs e)
        {
            jPedra.Visible = false;
            jTesoura.Visible = false;
            verificar();
        }

        private void jPedra_Click(object sender, EventArgs e)
        {
            jPapel.Visible = false;
            jTesoura.Visible = false;
            verificar();
        }

        private void jTesoura_Click(object sender, EventArgs e)
        {
            jPapel.Visible = false;
            jPedra.Visible = false;
            verificar();
        }

        int tempo = 60, totj = 0, totc = 0;

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (tempo <= 0)
            {
                lblTempo.Enabled = false;
                gameTimer.Enabled = false;
                MessageBox.Show("Tempo esgotado", "alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                jPapel.Enabled = false;
                jPedra.Enabled = false;
                jTesoura.Enabled = false;
                if (totj > totc)
                {
                    MessageBox.Show("Parabéns, Você venceu!!!");
                }else if(totj < totc)
                {
                    MessageBox.Show("Parabéns, Você Perdeu!!!");
                }
                else
                {
                    MessageBox.Show("Ih rapaix empatou");
                }
            }
            else
            {
                tempo--;
                lblTempo.Text = "Tempo: " + tempo.ToString();
            }
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            jPedra.Enabled = true;
            jPapel.Enabled = true;
            jTesoura.Enabled = true;
            tempo = 60;
            groupBox1.Text = "Jogador";
            groupBox2.Text = "Computador";
            gameTimer.Enabled = true;
            totj = 0;
            totc = 0;
            limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void verificar()
        {
            Random r = new Random();
            int x = r.Next(3) + 1;
            switch (x) { 
                case 1:
                cPapel.Visible = true;
                break;
                case 2:
                    cPedra.Visible = true;
                break;
                case 3:
                    cTesoura.Visible = true;
                break;
            }
                
            //verificando quem ganhou
            if ((jPapel.Visible == true && cPedra.Visible == true) ||
                (jPedra.Visible == true && cTesoura.Visible == true) ||
                (jTesoura.Visible == true && cPapel.Visible == true))
            {
                totj++;
                groupBox1.Text = "Jogador: " + totj.ToString();
                MessageBox.Show("Parabéns, você ganhou");
            }
            else if ((cPapel.Visible == true && jPedra.Visible == true) ||
                (cPedra.Visible == true && jTesoura.Visible == true) ||
                (cTesoura.Visible == true && jPapel.Visible == true))
            {
                totc++;
                groupBox2.Text = "Computador: " + totc.ToString();
                MessageBox.Show("Que pena, computador ganhou");
            }
            else
                MessageBox.Show("Houve Empate kkkkk");
            limpar();
        }

        public void limpar()

        {
            jPapel.Visible = true;
            jPedra.Visible = true;
            jTesoura.Visible = true;
            cPapel.Visible = false;
            cPedra.Visible = false;
            cTesoura.Visible = false;
        }
    }
}