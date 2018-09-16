using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EtapaTimbre1
{
    public partial class FrmT2 : Form
    {
        public FrmT2()
        {
            InitializeComponent();
        }
        // CLARINETE CERTO

        private void Bt3_Click(object sender, EventArgs e)
        {
            //  clarinete
            ContarPontosT.adcPontos();
            PbSom.Image = EtapaTimbre1.Properties.Resources.clariete;
            lbExibir.Text = "Muito bem! Você acertou.";
           
            Bt2.Enabled = false;
            Bt1.Enabled = false;
            Bt3.Enabled = false;

            BtProx.Enabled = true;
            // ponto

        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            // flauta
            PbSom.Image = EtapaTimbre1.Properties.Resources.flauta;
            lbExibir.Text = "Ops,Você errou! É um clarinete.";
            Bt2.Enabled = false;
            Bt1.Enabled = false;
            Bt3.Enabled = false;

            BtProx.Enabled = true;
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            // sax
            PbSom.Image = EtapaTimbre1.Properties.Resources.sexophone;
            lbExibir.Text = "Ops,Você errou! É um clarinete.";
            Bt2.Enabled = false;
            Bt1.Enabled = false;
            Bt3.Enabled = false;

            BtProx.Enabled = true;
        }

        private void PbSom_Click(object sender, EventArgs e)
        {
            

        }

        private void BtProx_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer meuPlayer = new System.Media.SoundPlayer(@"C:\Timbre\clarinete.wav");
            meuPlayer.Stop();
            
            FrmT3 frm3 = new FrmT3();
            this.Hide();
            frm3.ShowDialog();
           
        }

        private void FrmT2_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer meuPlayer = new System.Media.SoundPlayer(@"C:\Timbre\clarinete.wav");
            meuPlayer.Play();

            int pontos = ContarPontosT.retornaPontos();
            if (pontos == 1)
            {
                PbBarra.BackgroundImage = EtapaTimbre1.Properties.Resources.b1;
               
            }
           if (pontos == 0)
            {
                PbBarra.Image = EtapaTimbre1.Properties.Resources.b0;
            }
           
        }

        private void btOuvir_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer meuPlayer = new System.Media.SoundPlayer(@"C:\Timbre\clarinete.wav");
            meuPlayer.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String mensagem = "Tem certeza que deseja sair do aplicativo?";
            String titulo = "Ei!";

            MessageBoxButtons botao = MessageBoxButtons.YesNo;

            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbExibir_Click(object sender, EventArgs e)
        {

        }
    }
}
