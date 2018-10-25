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

        public Form1(LES les, LDE lde, FEC fec)
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
