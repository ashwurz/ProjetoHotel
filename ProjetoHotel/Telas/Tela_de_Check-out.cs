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
    public partial class Tela_de_Check_out : Form
    {
        public LES les;
        public LDE lde;
        public FEC[] fec;
        public Tela_de_Check_out(LES les, LDE lde, FEC[] fec)
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Tela_de_Check_In checkin = new Tela_de_Check_In(les, lde, fec);
            this.Hide();
            checkin.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string mensagem = "Essa tela já está aberta";
            string caption = "Erro detectado na abertura e uma nova janela";
            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensagem, caption, boxButtons);
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            Busca_Informacoes_Cliente buscaCliente = new Busca_Informacoes_Cliente(les, lde, fec);
            this.Hide();
            buscaCliente.Show();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1(les, lde, fec);
            this.Hide();
            login.Show();
        }

        private void btnBuscaQuarto_Click(object sender, EventArgs e)
        {
            Busca_Informacoes_Quarto buscaQuarto = new Busca_Informacoes_Quarto(les, lde, fec);
            this.Hide();
            buscaQuarto.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (int k = 0; k < 5; k++)
            {
                i = fec[k].buscaFec(txtbNome.Text, txtbSobrenome.Text);
                if (i != -1)
                {
                    break;
                }
            }
            bool validacao = fec[i].fezCheckout(txtbNome.Text, txtbSobrenome.Text);
            if(validacao == false)
            {
                string mensagem1 = "Não existe ninguem com este nome na fila de checkout, favor confirmar letras maiusculas e nomes e tente novamente";
                string caption1 = "Erro detectado na inserção";
                MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
                DialogResult result1;
                result1 = MessageBox.Show(mensagem1, caption1, boxButtons1);
            }
            btnCheckout.Visible = false;
            if(fec[i].remove(les) == false)
            {
                string mensagem1 = "Vai bobao!";
                string caption1 = "Check-out";
                MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
                DialogResult result1;
                result1 = MessageBox.Show(mensagem1, caption1, boxButtons1);
            }
            fec[i].remove(les);
            txtbNome.Clear();
            txtbSobrenome.Clear();
            string mensagem = "Check-out realizado com sucesso";
            string caption = "Check-out";
            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensagem, caption, boxButtons);
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtbNome.Text == "" || txtbSobrenome.Text == "")
            {
                string mensagem = "Preencha todos os campos";
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
            else if (fec[0].busca(txtbNome.Text, txtbSobrenome.Text) == false && fec[1].busca(txtbNome.Text, txtbSobrenome.Text) == false &&
                fec[2].busca(txtbNome.Text, txtbSobrenome.Text) == false && fec[3].busca(txtbNome.Text, txtbSobrenome.Text) == false &&
                fec[4].busca(txtbNome.Text, txtbSobrenome.Text) == false)
            {
                string mensagem = "Cliente ainda não fez Check-in";
                string caption = "Erro na busca";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
            }
            else
            {
                string mensagem = "Cliente já pode realizar o Check-out";
                string caption = "Confirmação concluida";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
                btnCheckout.Visible = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tela_de_CadastraCliente cadastraCliente = new Tela_de_CadastraCliente(les, lde, fec);
            this.Hide();
            cadastraCliente.Show();
        }
    }
}
