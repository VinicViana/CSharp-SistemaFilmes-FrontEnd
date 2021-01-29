using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SistemaFilmes_FrontEnd {
    public partial class frmTela : Form {
        public frmTela() {
            InitializeComponent();
            btnLancamentos.BackColor = PnPrincipal.BackColor;
            userControl11.BringToFront();         
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) {
            textBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e) {
            btnLancamentos.BackColor = PnPrincipal.BackColor;
            btnCalendario.BackColor = pnSuperior.BackColor;
            btnBiblioteca.BackColor = pnSuperior.BackColor;
            userControl11.BringToFront();
        }

        private void PnPrincipal_Paint(object sender, PaintEventArgs e) {

        }

        private void btnBiblioteca_Click(object sender, EventArgs e) {
            btnBiblioteca.BackColor = PnPrincipal.BackColor;
            btnCalendario.BackColor = pnSuperior.BackColor;
            btnLancamentos.BackColor = pnSuperior.BackColor;
            userControl21.BringToFront();
        }

        private void btnCalendario_Click(object sender, EventArgs e) {
            btnCalendario.BackColor = PnPrincipal.BackColor;
            btnBiblioteca.BackColor = pnSuperior.BackColor;
            btnLancamentos.BackColor = pnSuperior.BackColor;
            userControl31.BringToFront();
        }
    }
}
