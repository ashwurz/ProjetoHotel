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
        public Delete(LES les, LDE lde)
        {
            InitializeComponent();
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
            Form1 inicio = new Form1(les, lde);
            this.Hide();
            inicio.Show();
        }
    }
}
