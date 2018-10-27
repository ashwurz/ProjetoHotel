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
        LES les = new LES();
        LDE lde = new LDE();
        FEC fec = new FEC();
        public Busca_Informacoes_Cliente(LES les, LDE lde, FEC fec)
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
    }
}
