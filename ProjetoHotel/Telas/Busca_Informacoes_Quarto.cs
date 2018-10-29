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
    public partial class Busca_Informacoes_Quarto : Form
    {
        LES les = new LES();
        LDE lde = new LDE();
        FEC fec = new FEC();
        public Busca_Informacoes_Quarto(LES les, LDE lde, FEC fec)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tela_de_CadastraCliente cadastroCliente = new Tela_de_CadastraCliente(les, lde, fec);
            this.Hide();
            cadastroCliente.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Tela_de_Check_In checkin = new Tela_de_Check_In(les, lde, fec);
            this.Hide();
            checkin.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Tela_de_Check_out checkout = new Tela_de_Check_out(les, lde, fec);
            this.Hide();
            checkout.Show();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            Busca_Informacoes_Cliente buscaCliente = new Busca_Informacoes_Cliente(les, lde, fec);
            this.Hide();
            buscaCliente.Show();
        }

        private void btnBuscaQuarto_Click(object sender, EventArgs e)
        {
            string mensagem = "Essa tela já está aberta";
            string caption = "Erro detectado na abertura e uma nova janela";
            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensagem, caption, boxButtons);
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1(les, lde, fec);
            this.Hide();
            logout.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtQuarto.Text.Equals(""))
            {
                string mensagem = "Todos os campos devem estar preenchidos para se buscar o cliente!!";
                string caption = "Erro detectado na procura por cliente";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
                txtQuarto.Clear();
                return;
            }
            Pessoa cliente = les.busca(Convert.ToInt16(txtQuarto.Text));
            if (cliente == null)
            {
                string mensagem = "Esse cliente não consta nos registros";
                string caption = "Erro detectado na procura por cliente";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
                txtQuarto.Clear();
                return;
            }

            txtNome.Text = cliente.getNome().ToString();
            txtSobrenome.Text = cliente.getUltimoSobrenome().ToString();
            txtTelefone.Text = cliente.getNumero().ToString();
            txtEndereco.Text = cliente.getEndereco().ToString();
            txtTempo.Text = cliente.getTempo().ToString() + " dias";
            txtPlano.Text = cliente.getPlano().ToString();
            txtQuarto.Clear();
            panelResult.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            panelResult.Visible = false;
        }
    }
}
