namespace Apresentacao
{
    partial class FrmCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrar));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.radioBM = new System.Windows.Forms.RadioButton();
            this.radioBF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTcadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.PBMin = new System.Windows.Forms.PictureBox();
            this.PBFechar = new System.Windows.Forms.PictureBox();
            this.PBVoltar = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNome.Location = new System.Drawing.Point(170, 322);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(531, 30);
            this.txtNome.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(50, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Insira os campos abaixo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSenha.Location = new System.Drawing.Point(170, 505);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 5;
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(531, 30);
            this.txtSenha.TabIndex = 15;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfSenha.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfSenha.Location = new System.Drawing.Point(275, 568);
            this.txtConfSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfSenha.MaxLength = 5;
            this.txtConfSenha.Multiline = true;
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(426, 30);
            this.txtConfSenha.TabIndex = 18;
            // 
            // radioBM
            // 
            this.radioBM.AutoSize = true;
            this.radioBM.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBM.Location = new System.Drawing.Point(439, 381);
            this.radioBM.Margin = new System.Windows.Forms.Padding(4);
            this.radioBM.Name = "radioBM";
            this.radioBM.Size = new System.Drawing.Size(129, 27);
            this.radioBM.TabIndex = 17;
            this.radioBM.TabStop = true;
            this.radioBM.Text = "Masculino";
            this.radioBM.UseVisualStyleBackColor = true;
            // 
            // radioBF
            // 
            this.radioBF.AutoSize = true;
            this.radioBF.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBF.Location = new System.Drawing.Point(181, 381);
            this.radioBF.Margin = new System.Windows.Forms.Padding(4);
            this.radioBF.Name = "radioBF";
            this.radioBF.Size = new System.Drawing.Size(119, 27);
            this.radioBF.TabIndex = 19;
            this.radioBF.TabStop = true;
            this.radioBF.Text = "Feminino";
            this.radioBF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 381);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sexo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 505);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 568);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Confirmar Senha:";
            // 
            // BTcadastrar
            // 
            this.BTcadastrar.BackColor = System.Drawing.Color.Orange;
            this.BTcadastrar.FlatAppearance.BorderSize = 0;
            this.BTcadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BTcadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTcadastrar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTcadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTcadastrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTcadastrar.Location = new System.Drawing.Point(369, 647);
            this.BTcadastrar.Name = "BTcadastrar";
            this.BTcadastrar.Size = new System.Drawing.Size(255, 80);
            this.BTcadastrar.TabIndex = 26;
            this.BTcadastrar.Text = "CADASTRAR";
            this.BTcadastrar.UseVisualStyleBackColor = false;
            this.BTcadastrar.Click += new System.EventHandler(this.BTcadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(708, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 14);
            this.label8.TabIndex = 27;
            this.label8.Text = "Insira até 5 caracteres*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(708, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 14);
            this.label9.TabIndex = 28;
            this.label9.Text = "Confirme a senha acima *";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 443);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdade.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdade.Location = new System.Drawing.Point(170, 443);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdade.MaxLength = 2;
            this.txtIdade.Multiline = true;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(185, 30);
            this.txtIdade.TabIndex = 29;
            this.txtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdade_KeyPress_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Apresentacao.Properties.Resources.hazul;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.PBMin);
            this.panel3.Controls.Add(this.PBFechar);
            this.panel3.Controls.Add(this.PBVoltar);
            this.panel3.Location = new System.Drawing.Point(-8, -3);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 178);
            this.panel3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(379, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 38);
            this.label7.TabIndex = 31;
            this.label7.Text = "Criar Conta";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Image = global::Apresentacao.Properties.Resources.nomesemfundo1;
            this.pictureBox6.Location = new System.Drawing.Point(18, 74);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(256, 88);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // PBMin
            // 
            this.PBMin.BackgroundImage = global::Apresentacao.Properties.Resources.Minimizar;
            this.PBMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBMin.Location = new System.Drawing.Point(952, 13);
            this.PBMin.Name = "PBMin";
            this.PBMin.Size = new System.Drawing.Size(30, 30);
            this.PBMin.TabIndex = 29;
            this.PBMin.TabStop = false;
            this.PBMin.Click += new System.EventHandler(this.PBMin_Click);
            // 
            // PBFechar
            // 
            this.PBFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBFechar.BackgroundImage")));
            this.PBFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBFechar.Location = new System.Drawing.Point(988, 13);
            this.PBFechar.Name = "PBFechar";
            this.PBFechar.Size = new System.Drawing.Size(30, 30);
            this.PBFechar.TabIndex = 28;
            this.PBFechar.TabStop = false;
            this.PBFechar.Click += new System.EventHandler(this.PBFechar_Click);
            // 
            // PBVoltar
            // 
            this.PBVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBVoltar.BackgroundImage")));
            this.PBVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBVoltar.Location = new System.Drawing.Point(19, 15);
            this.PBVoltar.Name = "PBVoltar";
            this.PBVoltar.Size = new System.Drawing.Size(55, 55);
            this.PBVoltar.TabIndex = 27;
            this.PBVoltar.TabStop = false;
            this.PBVoltar.Click += new System.EventHandler(this.PBVoltar_Click);
            // 
            // FrmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1024, 741);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTcadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioBF);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.radioBM);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadastrar_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.RadioButton radioBM;
        private System.Windows.Forms.RadioButton radioBF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTcadastrar;
        private System.Windows.Forms.PictureBox PBVoltar;
        private System.Windows.Forms.PictureBox PBMin;
        private System.Windows.Forms.PictureBox PBFechar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdade;
    }
}