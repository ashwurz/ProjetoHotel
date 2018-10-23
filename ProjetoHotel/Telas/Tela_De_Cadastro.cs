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

namespace ProjetoHotel
{
    public partial class Tela_De_Cadastro : Form
    {
        public LES les;
        public LDE lde;
        public FEC fec;
        Stream st;
        StreamWriter str;
        public Tela_De_Cadastro(LES les, LDE lde, FEC fec)
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
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            if (usuario == "" || senha == "")
            {
                string mensagem = "Campo de Usuário ou Senha não preenchido";
                string caption = "Erro detectado na inserção";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
            }
            else
            {
                Funcionario funcionario = new Funcionario(usuario, senha);
                lde.insere(funcionario);
                st = File.Open(@"C:\Users\Helmuth\Documents\ListadeFuncionarios.txt", FileMode.Append);
                str = new StreamWriter(st);
                str.WriteLine(usuario);
                str.WriteLine(senha);
                txtUsuario.Clear();
                txtSenha.Clear();
                str.Close();
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            Tela_De_Busca busca = new Tela_De_Busca(les, lde, fec);
            this.Hide();
            busca.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete deletar = new Delete(les, lde, fec);
            this.Hide();
            deletar.Show();
        }

    }
}
