using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObjetoTransferencia;
using EtapaSom;

namespace Apresentacao
{
    public partial class FrmTreino : Form
    {
        public FrmTreino()
        {
            InitializeComponent();
        }

       

        private void pbModulo4_Click(object sender, EventArgs e)
        {

        }

        private void pbModulo2_Click(object sender, EventArgs e)
        {

        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
             // EXIBIR Total do teste ( ou não)

            txtExibir.Text = ResultadoTeste.RetornarResultado().ToString();
            int total = ResultadoTeste.RetornarResultado();

            /* o a 4 = inicia
             * 5 a 7 = 2º modulo
             * 8 a 10 = 3º modulo
             * 11 a 12 = 4º modulo
             * 13 a 14 = 5º modulo
             * 15 a 16 = 6 º modulo
             * 17 a 18 = 7º modulo
             * 19 a 20 = 8 º 
             * > 21 = 9 º 
              */
         
         if (total > 4 && total < 8)
         {
            /* FrmTreino treino = new FrmTreino();
             treino.
             */
             btFase1.Enabled = true;
         }
         if (total > 7 && total < 11)
         {
             /*FrmTreino treino = new FrmTreino();
             treino.pbModulo3.Enabled = true;
              * */
             btFase1.Enabled = true;
             btfase2.Enabled = true;
         }
         if (total > 10 && total < 13)
         {
           /*  FrmTreino treino = new FrmTreino();
             treino.pbModulo4.Enabled = true;
            * */
             btFase1.Enabled = true;
             btfase2.Enabled = true;
             btfase3.Enabled = true;
         }
         if (total > 12 && total < 15)
         {
            /* FrmTreino treino = new FrmTreino();
             treino.pbModulo5.Enabled = true;
             * */
             btFase1.Enabled = true;
             btfase2.Enabled = true;
             btfase3.Enabled = true;
             btFase4.Enabled = true;
         }
         if (total > 14 && total < 17)
         {
            /* FrmTreino treino = new FrmTreino();
             treino.pbModulo6.Enabled = true;
             */
             btFase1.Enabled = true;
             btfase2.Enabled = true;
             btfase3.Enabled = true;
             btFase4.Enabled = true;
             btFase5.Enabled = true;
         }
         if (total > 16 && total < 19)
         {
             /*FrmTreino treino = new FrmTreino();
             treino.pbModulo7.Enabled = true;
              */
             btFase1.Enabled = true;
             btfase2.Enabled = true;
             btfase3.Enabled = true;
             btFase4.Enabled = true;
             btFase5.Enabled = true;
             btFase6.Enabled = true;
         }
         if (total > 18 && total < 21)
         {
            /* FrmTreino treino = new FrmTreino();
             treino.pbModulo8.Enabled = true;
             */
             btFase1.Enabled = true;
             btfase2.Enabled = true;
             btfase3.Enabled = true;
             btFase4.Enabled = true;
             btFase5.Enabled = true;
             btFase6.Enabled = true;
             btFase7.Enabled = true;
         }
         if (total > 20 && total < 25)
         {
            /* FrmTreino treino = new FrmTreino();
             treino.pbModulo9.Enabled = true;
             */
             btFase1.Enabled = true;
             btfase2.Enabled = true;
             btfase3.Enabled = true;
             btFase4.Enabled = true;
             btFase5.Enabled = true;
             btFase6.Enabled = true;
             btFase7.Enabled = true;
             btfase8.Enabled = true;
         }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmPerfilUsuario frmPerfil = new FrmPerfilUsuario();
            frmPerfil.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmTreino frmTreino = new FrmTreino();
            frmTreino.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
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

        private void btFase1_Click(object sender, EventArgs e)
        {
            FrmExplicacao frmEx = new FrmExplicacao();
            frmEx.Show();
            this.Hide();

        }

        }
    }

