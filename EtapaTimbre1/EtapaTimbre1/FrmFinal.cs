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
    public partial class FrmFinal : Form
    {
        public FrmFinal()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            int pontos = ContarPontosT.retornaPontos();
            if (pontos == 9)
            {
                PbBarra.BackgroundImage = EtapaTimbre1.Properties.Resources.b5;

            }
            if (pontos == 6)
            {
                PbBarra.BackgroundImage = EtapaTimbre1.Properties.Resources.b4;
            }
            if (pontos == 3)
            {
                PbBarra.BackgroundImage = EtapaTimbre1.Properties.Resources.b3;
            }
            if (pontos == 2)
            {
                PbBarra.BackgroundImage = EtapaTimbre1.Properties.Resources.b2;
            }
            if (pontos == 1)
            {
                PbBarra.BackgroundImage = EtapaTimbre1.Properties.Resources.b1;
            }
            if (pontos == 0)
            {
                PbBarra.BackgroundImage = EtapaTimbre1.Properties.Resources.b0;
            }
        }

        private void FrmFinal_Load(object sender, EventArgs e)
        {

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

