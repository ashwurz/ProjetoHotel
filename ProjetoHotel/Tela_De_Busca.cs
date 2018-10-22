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
    public partial class Tela_De_Busca : Form
    {
        public LES les;
        public Tela_De_Busca(LES les)
        {
            this.les = les;
            InitializeComponent();
        }
        //Função que faz com que se a pessoa clique no botão "X", o programa inteiro se encerra
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tela_De_Cadastro cadastro = new Tela_De_Cadastro(les);
            this.Hide();
            cadastro.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1(les);
            this.Hide();
            inicio.Show();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            txtUsuario.Clear();
            les.busca(usuario);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(les);
            this.Hide();
            delete.Show();
        }
    }
}
