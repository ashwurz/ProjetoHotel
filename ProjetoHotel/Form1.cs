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
    public partial class Form1 : Form
    {
        public LES les;
        public LDE lde;
        public FEC fec;
        public FileInfo fi = new FileInfo(@"C:\Users\Helmuth\Documents\ListadeFuncionarios.txt");
        Stream st;
        StreamReader str;
        public Form1(LES les, LDE lde, FEC fec)
        {
            this.les = les;
            this.lde = lde;
            this.fec = fec;
            if (fi.Exists)
            {
                st = File.Open(@"C:\Users\Helmuth\Documents\ListadeFuncionarios.txt", FileMode.Open);
                str = new StreamReader(st);
                Funcionario funcionario;
                string linha = str.ReadLine();
                string usuario = linha;
                linha = str.ReadLine();
                string senha = linha;
                while (linha != null)
                {
                    funcionario = new Funcionario(usuario, senha);
                    lde.insere(funcionario);
                    linha = str.ReadLine();
                    usuario = linha;
                    linha = str.ReadLine();
                    senha = linha;
                }
                str.Close();
            }
            else
            {
                FileStream fstr = fi.Create();
                fstr.Close();
            }
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
            Tela_De_Cadastro cadastro = new Tela_De_Cadastro(les,lde,fec);
            this.Hide();
            cadastro.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.TextLength == 0 || txtSenha.TextLength == 0)
            {
                string mensagem = "Campo de Usuário ou Senha não preenchido";
                string caption = "Erro detectado na inserção";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
            }
            Checkinout checkinout = new Checkinout(les, lde, fec);
            if(lde.busca(txtUsuario.Text, txtSenha.Text) != null)
            {
                this.Hide();
                checkinout.Show();
            }
        }
        /*
        public static void ThreadProc()
        {
            Application.Run(new Tela_De_Cadastro(les));
            this.CLose();
        }
        */
    }
}
