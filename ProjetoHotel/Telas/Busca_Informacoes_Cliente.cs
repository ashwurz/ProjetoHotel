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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_De_Informacoes_Reserva reserva = new Tela_De_Informacoes_Reserva(les, lde, fec);
            this.Hide();
            reserva.Show();
        }
    }
}
