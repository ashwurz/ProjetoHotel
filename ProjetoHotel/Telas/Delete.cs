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

        //Função que faz com que se a pessoa clique no botão "X", o programa inteiro se encerra
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {   
            lde.remove(txtbUsuario.Text, txtSenha.Text);
            txtbUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1(les, lde, fec);
            this.Hide();
            inicio.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Tela_De_Cadastro cadastro = new Tela_De_Cadastro(les, lde, fec);
            this.Hide();
            cadastro.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Tela_De_Busca busca = new Tela_De_Busca(les, lde, fec);
            this.Hide();
            busca.Show();
        }

    }
}
