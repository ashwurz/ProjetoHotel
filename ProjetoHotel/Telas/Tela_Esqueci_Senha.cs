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
    public partial class Tela_Esqueci_Senha : Form
    {
        LDE lde;
        public Tela_Esqueci_Senha(LDE lde)
        {
            InitializeComponent();
            this.lde = lde;
        }

        private void btnBuscarSenha_Click(object sender, EventArgs e)
        {
            lde.buscaValidacaoSenha(txtUsuario.Text);
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
