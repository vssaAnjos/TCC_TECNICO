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
    public partial class FrmAbertura : Form
    {

        // private int count = 0;



        public FrmAbertura()
        {
            InitializeComponent();
        }



        private void TelaDeAbertura_Load(object sender, EventArgs e)
        {


        }

        private void tempoBase_Tick(object sender, EventArgs e)
        {
            frmPrincipal fmp = new frmPrincipal();
            fmp.Show();
            this.Hide();
            tempoBase.Enabled = false;
   }



    }
}





