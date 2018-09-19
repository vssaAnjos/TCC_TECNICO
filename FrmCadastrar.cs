using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObjetoTransferencia;
using Apresentacao;

namespace Apresentacao
{
    public partial class FrmCadastrar : Form
    {
        TipoDaAcao tipoDaAcaoGlobal;
        TipoDaAcao tipoDaAcao;

        public FrmCadastrar()
        {
            InitializeComponent();
           
            this.tipoDaAcaoGlobal = tipoDaAcao; // declarando parametro

            if (tipoDaAcao == TipoDaAcao.Inserir) // chamar o INSERIR
            {
                this.Text = "Inserir cadastro";
            }

        }

        private void BTcadastrar_Click(object sender, EventArgs e)
        {
            Cadastro usuario = new Cadastro();

            usuario.Nome_Usuario = txtNome.Text;
            usuario.Idade = txtIdade.Text;
            usuario.Senha = txtSenha.Text;
            usuario.ConfSenha = txtConfSenha.Text;


            if (radioBF.Checked == true)
            {
                usuario.Sexo = "F";
            }
            else if (radioBM.Checked == true)
            {
                usuario.Sexo = "M";
            }

            if (txtNome.Text == "" || txtIdade.Text == "" || txtSenha.Text == "" || txtConfSenha.Text == "" || radioBF.Checked == false & radioBM.Checked == false)
            {
                string erro = "Preencha o campo em branco!";
                MessageBox.Show(erro);
                txtIdade.Clear();

            }
            else
            {
                if (txtConfSenha.Text == txtSenha.Text)
                {
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                    if (tipoDaAcaoGlobal == TipoDaAcao.Inserir)
                    {
                        string retorno = usuarioNegocio.CadastroInserir(usuario);

                        try
                        {
                            // int num = Convert.ToInt32(retorno);
                            MessageBox.Show("Registro inserido com sucesso!", "Inserir registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            this.DialogResult = System.Windows.Forms.DialogResult.Yes;

                            FrmPerfilUsuario frmPerfil = new FrmPerfilUsuario();
                            this.Hide();
                            frmPerfil.Show();
                        }
                        catch
                        {
                            MessageBox.Show("Erro ao inserir o registro! \n", "Inserir registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.DialogResult = System.Windows.Forms.DialogResult.No;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Senhas não correspondem, Digite Novamente");
                }
            }
        }
            // enviar dados ao perfil do usuario, limpar tela, chamar perfil do usuario

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            txtNome.Focus();
        }

        private void PBMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PBFechar_Click(object sender, EventArgs e)
        {

            String mensagem = "Ao sair seus dados serão descartados! Deseja Sair?";
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void PBVoltar_Click(object sender, EventArgs e)
        {
            String mensagem = "Ao voltar seus dados serão descartados! Deseja voltar?";
            String titulo = "Ei!";

            MessageBoxButtons botao = MessageBoxButtons.YesNo;

            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);

            if (resultado == DialogResult.Yes)
            {
                frmPrincipal frmPric = new frmPrincipal();
                frmPric.Show();
                this.Hide();
            }
            else
            {
            } 
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void txtIdade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
               if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

       
        }

    }

