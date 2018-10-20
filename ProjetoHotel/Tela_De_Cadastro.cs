using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public partial class Tela_De_Cadastro : Form
    { 
        public LES les;
        Stream st;
        StreamWriter str;
        public Tela_De_Cadastro(LES les)
        {
            InitializeComponent();
            this.les = les;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1(les);
            this.Hide();
            inicio.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            Funcionario funcionario = new Funcionario(usuario, senha);
            if(usuario == "" || senha == "")
            {
                string mensagem = "Campo de Usuário ou Senha não preenchido";
                string caption = "Erro detectado na inserção";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
            }
            st = File.Open(@"C:\Users\Helmuth\Documents\ListadeFuncionarios.txt", FileMode.Append);
            str = new StreamWriter(st);
            str.WriteLine(usuario);
            str.WriteLine(senha);
            txtUsuario.Clear();
            txtSenha.Clear();
            les.insere(funcionario);
            str.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Tela_De_Busca busca = new Tela_De_Busca(les);
            this.Hide();
            busca.Show();
        }

    }
}
