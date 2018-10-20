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
        public Delete(LES les)
        {
            InitializeComponent();
            this.les = les;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string nome = txtbUsuario.Text;
            les.deletar(nome);
        }
    }
}
