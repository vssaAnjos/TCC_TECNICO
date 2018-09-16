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
    public partial class FrmT3 : Form
    {
        public FrmT3()
        {
            InitializeComponent();
        }
        // ESCALETA
        private void FrmT3_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer meuPlayer = new System.Media.SoundPlayer(@"C:\Timbre\escaleta.wav");
            meuPlayer.Play();

            int pontos = ContarPontosT.retornaPontos();
            if (pontos == 2)
            {
                PbBarra.BackgroundImage = EtapaTimbre1.Properties.Resources.b2;

            }
            else
            {
                PbBarra.BackgroundImage = EtapaTimbre1.Properties.Resources.b1;
            }
            if (pontos == 0)
            {
                PbBarra.BackgroundImage = EtapaTimbre1.Properties.Resources.b0;
            }
             

        }

        private void PbSom_Click(object sender, EventArgs e)
        {
            

        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            // acordeon
            PbSom.Image = EtapaTimbre1.Properties.Resources.acordeon;
            lbExibir.Text = "Ops,Você errou! É uma escaleta.";
            Bt2.Enabled = false;
            Bt1.Enabled = false;
            Bt3.Enabled = false;

            BtProx.Enabled = true;
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            // escaleta
            // ponto
            ContarPontosT.adcPontos();
            
            PbSom.Image = EtapaTimbre1.Properties.Resources.escaleta;
            lbExibir.Text = "Muito bem! Você acertou.";

            Bt2.Enabled = false;
            Bt1.Enabled = false;
            Bt3.Enabled = false;

            BtProx.Enabled = true;
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            // orgão

            PbSom.Image = EtapaTimbre1.Properties.Resources.orgao;
            lbExibir.Text = "Ops,Você errou! É uma escaleta.";
            Bt2.Enabled = false;
            Bt1.Enabled = false;
            Bt3.Enabled = false;

            BtProx.Enabled = true;
        }

        private void BtProx_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer meuPlayer = new System.Media.SoundPlayer(@"C:\Timbre\escaleta.wav");
            meuPlayer.Stop();

            FrmT4 frmt = new FrmT4();
            this.Hide();
            frmt.ShowDialog();
            
        }

        private void btOuvir_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer meuPlayer = new System.Media.SoundPlayer(@"C:\Timbre\escaleta.wav");
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
    }
}
