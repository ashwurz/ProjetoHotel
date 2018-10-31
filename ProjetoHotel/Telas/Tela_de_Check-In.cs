using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoHotel.Telas;

namespace ProjetoHotel
{
    public partial class Tela_de_Check_In : Form
    {
        public LES les;
        public LDE lde;
        public FEC[] fec;
        public Pessoa pessoa;
        public Tela_de_Check_In(LES les, LDE lde, FEC[] fec)
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

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Form1 login= new Form1(les, lde, fec);
            this.Hide();
            login.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string mensagem = "Essa tela já está aberta";
            string caption = "Erro detectado na abertura e uma nova janela";
            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensagem, caption, boxButtons);

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tela_de_CadastraCliente cadastroCliente = new Tela_de_CadastraCliente(les, lde, fec);
            this.Hide();
            cadastroCliente.Show();
        }

        private void btnBuscaQuarto_Click(object sender, EventArgs e)
        {
            Busca_Informacoes_Quarto buscaQuarto = new Busca_Informacoes_Quarto(les, lde, fec);
            this.Hide();
            buscaQuarto.Show();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            int i;
            if (pessoa.getTempo() == 1)
            {
                i = 0;
            }
            else if (pessoa.getTempo() == 7)
            {
                i = 1;
            }
            else if (pessoa.getTempo() == 14)
            {
                i = 2;
            }
            else if (pessoa.getTempo() == 21)
            {
                i = 3;
            }
            else
            {
                i = 4;
            }
            fec[i].insere(pessoa);
            string mensagem = "Check-in realizado com sucesso";
            string caption = "Check-in";
            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensagem, caption, boxButtons);
            btnCheckin.Visible = false;
            txtbNome.Clear();
            txtbSobrenome.Clear();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtbNome.Text == "" || txtbSobrenome.Text == "")
            {
                string mensagem = "Cliente não encontrado";
                string caption = "Erro na busca";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
            }
            else if (les.busca(txtbNome.Text, txtbSobrenome.Text) == null)
            {
                string mensagem = "O Cliente não existe";
                string titulo = "Erro na busca";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, titulo, boxButtons);
            }
            else if (fec[0].busca(txtbNome.Text, txtbSobrenome.Text) == true || fec[1].busca(txtbNome.Text, txtbSobrenome.Text) == true ||
                fec[2].busca(txtbNome.Text, txtbSobrenome.Text) == true || fec[3].busca(txtbNome.Text, txtbSobrenome.Text) == true ||
                fec[4].busca(txtbNome.Text, txtbSobrenome.Text) == true)
            {
                string mensagem = "Cliente ja fez Check-in";
                string caption = "Erro na busca";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
            }
            else
            {
                string mensagem = "Cliente já pode realizar o Check-in";
                string caption = "Confirmação concluida";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
                btnCheckin.Visible = true;
                pessoa = les.busca(txtbNome.Text, txtbSobrenome.Text);
            }
        }

        private void Tela_de_Check_In_Load(object sender, EventArgs e)
        {

        }

        private void txtbSobrenome_Click(object sender, EventArgs e)
        {
            txtSobrenome.Visible = false;
        }

        private void txtbNome_Click(object sender, EventArgs e)
        {
            txtNome.Visible = false;
        }
    }
}
