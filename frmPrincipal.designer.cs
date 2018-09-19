namespace Apresentacao
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btLogar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.PBMin = new System.Windows.Forms.PictureBox();
            this.PBfechar = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btEntrar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBfechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUsuario.Location = new System.Drawing.Point(685, 258);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(301, 60);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "  Usuário";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // btLogar
            // 
            this.btLogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogar.FlatAppearance.BorderSize = 0;
            this.btLogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogar.Location = new System.Drawing.Point(757, 28);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(152, 53);
            this.btLogar.TabIndex = 3;
            this.btLogar.Text = "CRIAR CONTA";
            this.btLogar.UseVisualStyleBackColor = false;
            this.btLogar.Click += new System.EventHandler(this.btLogar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.PBMin);
            this.panel3.Controls.Add(this.btLogar);
            this.panel3.Controls.Add(this.PBfechar);
            this.panel3.Location = new System.Drawing.Point(-5, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 117);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Image = global::Apresentacao.Properties.Resources.nomesemfundo1;
            this.pictureBox6.Location = new System.Drawing.Point(15, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(299, 107);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // PBMin
            // 
            this.PBMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBMin.BackgroundImage = global::Apresentacao.Properties.Resources.Minimizar;
            this.PBMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBMin.Location = new System.Drawing.Point(952, 13);
            this.PBMin.Name = "PBMin";
            this.PBMin.Size = new System.Drawing.Size(30, 30);
            this.PBMin.TabIndex = 1;
            this.PBMin.TabStop = false;
            this.PBMin.Click += new System.EventHandler(this.PBMin_Click);
            // 
            // PBfechar
            // 
            this.PBfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBfechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBfechar.BackgroundImage")));
            this.PBfechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBfechar.Location = new System.Drawing.Point(988, 13);
            this.PBfechar.Name = "PBfechar";
            this.PBfechar.Size = new System.Drawing.Size(30, 30);
            this.PBfechar.TabIndex = 0;
            this.PBfechar.TabStop = false;
            this.PBfechar.Click += new System.EventHandler(this.PBfechar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSenha.Location = new System.Drawing.Point(685, 328);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(301, 60);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.Text = "  Senha";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(706, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entre com seu ID de\r\nusuário e senha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btEntrar
            // 
            this.btEntrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btEntrar.BackColor = System.Drawing.Color.Orange;
            this.btEntrar.FlatAppearance.BorderSize = 0;
            this.btEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntrar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrar.Location = new System.Drawing.Point(685, 419);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(301, 64);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "ENTRAR";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(29, 153);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(613, 511);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-5, 691);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 80);
            this.panel1.TabIndex = 32;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.hazul;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBfechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btLogar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PBMin;
        private System.Windows.Forms.PictureBox PBfechar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
    }
}