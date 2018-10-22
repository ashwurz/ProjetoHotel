using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public partial class Delete : Form
    {
        public LES les;
        public LDE lde;
        public FEC fec;
        public Delete(LES les, LDE lde, FEC fec)
        {
            InitializeComponent();
            this.fec = fec;
            this.lde = lde;
            this.les = les;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string nome = txtbUsuario.Text;
            lde.remove(nome);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1(les, lde, fec);
            this.Hide();
            inicio.Show();
        }
    }
}
