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
    public partial class Busca_Informacoes_Cliente : Form
    {
        public LES les;
        public LDE lde;
        public FEC[] fec;
        public Busca_Informacoes_Cliente(LES les, LDE lde, FEC[] fec)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text.Equals("") || txtSobrenome.Text.Equals("") || txtID.Text.Equals(""))
                {
                    string mensagem = "Todos os campos devem estar preenchidos para se buscar o cliente!!";
                    string caption = "Erro detectado na procura por cliente";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(mensagem, caption, boxButtons);
                    txtNome.Clear();
                    txtSobrenome.Clear();
                    txtID.Clear();
                    return;
                }
                if (Convert.ToInt16(txtID.Text) > 50)
                {
                    string mensagem = "O ID tem que ser menor que 50!!";
                    string caption = "Erro detectado na procura por cliente";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(mensagem, caption, boxButtons);
                    txtNome.Clear();
                    txtSobrenome.Clear();
                    txtID.Clear();
                    return;
                }
                Pessoa cliente = les.busca(txtNome.Text, txtSobrenome.Text, Convert.ToInt16(txtID.Text));
                if (cliente == null)
                {
                    string mensagem = "Esse cliente não consta nos registros";
                    string caption = "Erro detectado na procura por cliente";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(mensagem, caption, boxButtons);
                    txtNome.Clear();
                    txtSobrenome.Clear();
                    txtID.Clear();
                    return;
                }
                txtTelefone.Text = cliente.getNumero().ToString();
                txtQuarto.Text = cliente.getQuarto().ToString();
                txtEndereco.Text = cliente.getEndereco().ToString();
                txtTempo.Text = cliente.getTempo().ToString() + " dias";
                txtPlano.Text = cliente.getPlano().ToString();
                txtNome.Clear();
                txtSobrenome.Clear();
                txtID.Clear();
                panelResult.Visible = true;
            }
            catch(FormatException ex)
            {
                string mensagem = "Por favor, insira SOMENTE número no campo do ID!";
                string caption = "Erro detectado no cadastro";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
                txtNome.Clear();
                txtSobrenome.Clear();
                txtID.Clear();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Tela_de_Check_In check_In = new Tela_de_Check_In(les, lde, fec);
            this.Hide();
            check_In.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Tela_de_Check_out check_out = new Tela_de_Check_out(les, lde, fec);
            this.Hide();
            check_out.Show();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            string mensagem = "Essa tela já está aberta";
            string caption = "Erro detectado na abertura e uma nova janela";
            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensagem, caption, boxButtons);
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1(les, lde, fec);
            this.Hide();
            login.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            panelResult.Visible = false;
        }

        private void btnBuscaQuarto_Click(object sender, EventArgs e)
        {
            Busca_Informacoes_Quarto buscaQuarto = new Busca_Informacoes_Quarto(les, lde, fec);
            this.Hide();
            buscaQuarto.Show();
        }

        private void linkEsqueciID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_Esqueci_ID esqueci = new Tela_Esqueci_ID(les);
            esqueci.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tela_de_CadastraCliente cadastraCliente = new Tela_de_CadastraCliente(les, lde, fec);
            this.Hide();
            cadastraCliente.Show();
        }
    }
}
