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
    public partial class Tela_De_Informacoes_Reserva : Form
    {
        LES les = new LES();
        LDE lde = new LDE();
        FEC fec = new FEC();
        public Tela_De_Informacoes_Reserva(LES les, LDE lde, FEC fec)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Checkinout checkinout = new Checkinout(les, lde, fec);
            this.Hide();
            checkinout.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Busca_Informacoes_Cliente buscaCliente = new Busca_Informacoes_Cliente(les, lde, fec);
            this.Hide();
            buscaCliente.Show();
        }
    }
}
