using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoHotel.Telas
{
    public partial class Tela_de_CadastraCliente : Form
    {
        public LES les;
        public LDE lde;
        public FEC fec;
        Stream st;
        StreamWriter str;
        public Tela_de_CadastraCliente(LES les, LDE lde, FEC fec)
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

        private int numeroDeAcompanhantes()
        {
            if (rbtn1.Checked)
            {
                return 1;
            }
            else if (rbtn2.Checked)
            {
                return 2;
            }
            else if (rbtn3.Checked)
            {
                return 3;
            }
            else if (rbtn4.Checked)
            {
                return 4;
            }
            else if (rbtn5.Checked)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = edtNome.Text;
            string sobrenome = edtSobrenome.Text;
            int numero = Convert.ToInt32(edtNumero.Text);
            string endereco = edtEndereco.Text;
            int acompanhantes = numeroDeAcompanhantes();
            int i = acompanhantes;
            string acompanhante1 = edtAC1.Text;
            string acompanhante2 = edtAC2.Text;
            string acompanhante3 = edtAC3.Text;
            string acompanhante4 = edtAC4.Text;
            string acompanhante5 = edtAC5.Text;
            if (nome == "" || sobrenome == "" || numero.ToString() == "" || endereco == "" || acompanhantes.ToString() == "")
            {
                string mensagem = "Algum campo não preenchido favor prestar atençao nos campos de acompanhastes";
                string caption = "Erro detectado na inserção";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
            }
            else
            {
                Pessoa pessoa = new Pessoa(nome, sobrenome, numero, endereco, acompanhantes);
                st = File.Open("ListadeClientes.txt", FileMode.Append);
                str = new StreamWriter(st);
                str.WriteLine(nome);
                str.WriteLine(sobrenome);
                str.WriteLine(numero);
                str.WriteLine(endereco);
                str.WriteLine(acompanhantes);
                if (i >= 1)
                {
                    pessoa.setNomes(acompanhante1, 0);
                    str.WriteLine(acompanhante1);
                }
                if (i >= 2)
                {
                    pessoa.setNomes(acompanhante2, 1);
                    str.WriteLine(acompanhante2);
                }
                if (i >= 3)
                {
                    pessoa.setNomes(acompanhante3, 2);
                    str.WriteLine(acompanhante3);
                }
                if (i >= 4)
                {
                    pessoa.setNomes(acompanhante4, 3);
                    str.WriteLine(acompanhante4);
                }
                if (i == 5)
                {
                    pessoa.setNomes(acompanhante5, 4);
                    str.WriteLine(acompanhante5);
                }
                /*edtNome.Clear();
                edtSobrenome.Clear();
                edtNumero.Clear();
                edtEndereco.Clear();
                edtAC1.Clear();
                edtAC2.Clear();
                edtAC3.Clear();
                edtAC4.Clear();
                edtAC5.Clear();*/
                str.Close();
                //proxima tela levando pessoa
                Tela_de_Tempo tempo = new Tela_de_Tempo(les, lde, fec, pessoa);
                this.Hide();
                tempo.Show();
            }
        }

        private void rbtn0_Click(object sender, EventArgs e)
        {
            if (rbtn1.Checked)
            {
                txtAC1.Visible = true;
                edtAC1.Visible = true;
                txtAC2.Visible = false;
                edtAC2.Visible = false;
                txtAC3.Visible = false;
                edtAC3.Visible = false;
                txtAC4.Visible = false;
                edtAC4.Visible = false;
                txtAC5.Visible = false;
                edtAC5.Visible = false;
            }
            else if (rbtn2.Checked)
            {
                txtAC1.Visible = true;
                edtAC1.Visible = true;
                txtAC2.Visible = true;
                edtAC2.Visible = true;
                txtAC3.Visible = false;
                edtAC3.Visible = false;
                txtAC4.Visible = false;
                edtAC4.Visible = false;
                txtAC5.Visible = false;
                edtAC5.Visible = false;
            }
            else if (rbtn3.Checked)
            {
                txtAC1.Visible = true;
                edtAC1.Visible = true;
                txtAC2.Visible = true;
                edtAC2.Visible = true;
                txtAC3.Visible = true;
                edtAC3.Visible = true;
                txtAC4.Visible = false;
                edtAC4.Visible = false;
                txtAC5.Visible = false;
                edtAC5.Visible = false;
            }
            else if (rbtn4.Checked)
            {
                txtAC1.Visible = true;
                edtAC1.Visible = true;
                txtAC2.Visible = true;
                edtAC2.Visible = true;
                txtAC3.Visible = true;
                edtAC3.Visible = true;
                txtAC4.Visible = true;
                edtAC4.Visible = true;
                txtAC5.Visible = false;
                edtAC5.Visible = false;
            }
            else if (rbtn5.Checked)
            {
                txtAC1.Visible = true;
                edtAC1.Visible = true;
                txtAC2.Visible = true;
                edtAC2.Visible = true;
                txtAC3.Visible = true;
                edtAC3.Visible = true;
                txtAC4.Visible = true;
                edtAC4.Visible = true;
                txtAC5.Visible = true;
                edtAC5.Visible = true;
            }
            else
            {
                txtAC1.Visible = false;
                edtAC1.Visible = false;
                txtAC2.Visible = false;
                edtAC2.Visible = false;
                txtAC3.Visible = false;
                edtAC3.Visible = false;
                txtAC4.Visible = false;
                edtAC4.Visible = false;
                txtAC5.Visible = false;
                edtAC5.Visible = false;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string mensagem = "Essa tela já está aberta";
            string caption = "Erro detectado na abertura e uma nova janela";
            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensagem, caption, boxButtons);
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

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1(les, lde, fec);
            this.Hide();
            login.Show();
        }
    }
}