namespace Apresentacao
{
    partial class FrmAbertura
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
            this.components = new System.ComponentModel.Container();
            this.tempoBase = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tempoBase
            // 
            this.tempoBase.Enabled = true;
            this.tempoBase.Interval = 5000;
            this.tempoBase.Tick += new System.EventHandler(this.tempoBase_Tick);
            // 
            // FrmAbertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apresentacao.Properties.Resources.FundoPassaCOMNOME;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAbertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaDeAbertura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaDeAbertura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tempoBase;
    }
}