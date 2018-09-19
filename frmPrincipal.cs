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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void PBfechar_Click(object sender, EventArgs e)
        {
            String mensagem = "Deseja fechar aplicação ?";
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

        private void PBMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            FrmCadastrar frmCadastrar = new FrmCadastrar();
            this.Hide();
            frmCadastrar.ShowDialog();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            // CRIAR O LOGAR
            FrmPerfilUsuario frmPerfilUsuario = new FrmPerfilUsuario();
            this.Hide();
            frmPerfilUsuario.ShowDialog();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
