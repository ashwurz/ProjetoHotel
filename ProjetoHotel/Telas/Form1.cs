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
    public partial class Form1 : Form
    {
        public LES les;
        public LDE lde;
        public FEC[] fec;

        public Form1(LES les, LDE lde, FEC[] fec)
        {
            this.les = les;
            this.lde = lde;
            this.fec = fec;
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
                string caption = "Erro detectado no Login";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
            }
            Tela_de_CadastraCliente cadastraCliente= new Tela_de_CadastraCliente(les, lde, fec);
            if(lde.buscaValidacao(txtUsuario.Text, txtSenha.Text))
            {
                this.Hide();
                cadastraCliente.Show();
            }
            else
            {
                txtUsuario.Clear();
                txtSenha.Clear();
                string mensagem = "Usuário ou Senha incorretos";
                string caption = "Erro detectado no Login";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_Esqueci_Senha senha = new Tela_Esqueci_Senha(lde);
            senha.Show();
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
