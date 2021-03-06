﻿﻿using System;
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
    public partial class Tela_de_CadastraCliente : Form
    {
        public LES les;
        public LDE lde;
        public FEC[] fec;
        public Tela_de_CadastraCliente(LES les, LDE lde, FEC[] fec)
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
            try
            {
                //nome
                string nome = edtNome.Text;
                //sobrenome
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
                if (nome == "" || sobrenome == "" || numero.ToString() == "" || endereco == "" || (i >= 1 && acompanhante1 == "") || (i >= 2 && acompanhante2 == "")
                    || (i >= 3 && acompanhante3 == "") || (i >= 4 && acompanhante4 == "") || (i >= 5 && acompanhante5 == ""))
                {
                    string mensagem = "Algum campo não preenchido favor prestar atençao nos campos de acompanhastes";
                    string caption = "Erro detectado no cadastro";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(mensagem, caption, boxButtons);
                    return;
                }
                else if (les.busca(nome, sobrenome) != null)
                {
                    string mensagem = "Essa pessoa já está cadastrada no sistema!!!!";
                    string caption = "Erro detectado no cadastro";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(mensagem, caption, boxButtons);
                    edtNome.Clear();
                    edtSobrenome.Clear();
                    edtNumero.Clear();
                    edtEndereco.Clear();
                    edtAC1.Clear();
                    edtAC2.Clear();
                    edtAC3.Clear();
                    edtAC4.Clear();
                    edtAC5.Clear();
                    return;
                }
                else
                {
                    Pessoa pessoa = new Pessoa(nome, sobrenome, numero, endereco, acompanhantes);
                    if (i >= 1)
                    {
                        pessoa.setNomes(acompanhante1, 0);
                    }
                    if (i >= 2)
                    {
                        pessoa.setNomes(acompanhante2, 1);
                    }
                    if (i >= 3)
                    {
                        pessoa.setNomes(acompanhante3, 2);
                    }
                    if (i >= 4)
                    {
                        pessoa.setNomes(acompanhante4, 3);
                    }
                    if (i == 5)
                    {
                        pessoa.setNomes(acompanhante5, 4);
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
                    //proxima tela levando pessoa
                    Tela_de_Tempo tempo = new Tela_de_Tempo(les, lde, fec, pessoa);
                    this.Hide();
                    tempo.Show();
                }
            }
            catch (FormatException ex)
            {
                string mensagem = "Por favor, insira SOMENTE número no campo do Telefone!";
                string caption = "Erro detectado no cadastro";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
                edtNome.Clear();
                edtSobrenome.Clear();
                edtNumero.Clear();
                edtEndereco.Clear();
                edtAC1.Clear();
                edtAC2.Clear();
                edtAC3.Clear();
                edtAC4.Clear();
                edtAC5.Clear();
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

        private void btnBuscaQuarto_Click(object sender, EventArgs e)
        {
            Busca_Informacoes_Quarto buscaQuarto = new Busca_Informacoes_Quarto(les, lde, fec);
            this.Hide();
            buscaQuarto.Show();
        }

        private void edtNome_Click(object sender, EventArgs e)
        {
            txtNome.Visible = false;
        }

        private void edtSobrenome_Click(object sender, EventArgs e)
        {
            txtSobrenome.Visible = false;
        }

        private void edtNumero_Click(object sender, EventArgs e)
        {
            txtNumero.Visible = false;
        }

        private void edtEndereco_Click(object sender, EventArgs e)
        {
            txtEndereco.Visible = false;
        }

        private void edtAC1_Click(object sender, EventArgs e)
        {
            txtAC1.Visible = false;
        }

        private void edtAC2_Click(object sender, EventArgs e)
        {
            txtAC2.Visible = false;
        }

        private void edtAC3_Click(object sender, EventArgs e)
        {
            txtAC3.Visible = false;
        }

        private void edtAC4_Click(object sender, EventArgs e)
        {
            txtAC4.Visible = false;
        }

        private void edtAC5_Click(object sender, EventArgs e)
        {
            txtAC5.Visible = false;
        }
    }
}
