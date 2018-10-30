using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel.Telas
{
    public partial class Tela_Esqueci_ID : Form
    {
        private LES les;
        public Tela_Esqueci_ID(LES les)
        {
            InitializeComponent();
            this.les = les;
        }

        private void btnBuscaID_Click(object sender, EventArgs e)
        {
            les.buscaID(txtNome.Text, txtSobrenome.Text);
        }
    }
}
