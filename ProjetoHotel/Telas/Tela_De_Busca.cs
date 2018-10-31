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
        public LDE lde;
        public FEC[] fec;
        public Tela_De_Busca(LES les, LDE lde, FEC[] fec)
        {
            InitializeComponent();
            this.les = les;
            this.lde = lde;
            this.fec = fec;
        }

        //Função que faz com que se a pessoa clique no botão "X", o programa inteiro se encerra
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1(les, lde, fec);
            this.Hide();
            inicio.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tela_De_Cadastro cadastro = new Tela_De_Cadastro(les, lde, fec);
            this.Hide();
            cadastro.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            txtUsuario.Clear();
            lde.busca(usuario);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete deletar = new Delete(les, lde, fec);
            this.Hide();
            deletar.Show();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
