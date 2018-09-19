using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmPerfilUsuario : Form
    {
        public FrmPerfilUsuario()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FrmTreino frmTreino = new FrmTreino();
            frmTreino.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            questao1 Nquestao = new questao1();
            this.Hide();
            Nquestao.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrinci = new frmPrincipal();
            frmPrinci.Show();
            this.Hide();
        }
    }
}
