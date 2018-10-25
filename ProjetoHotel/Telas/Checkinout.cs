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
    public partial class Checkinout : Form
    {
        public LES les;
        public LDE lde;
        public FEC fec;
        public Checkinout(LES les, LDE lde, FEC fec)
        {
            InitializeComponent();
            this.lde = lde;
            this.fec = fec;
            this.les = les;
        }
        //Função que faz com que se a pessoa clique no botão "X", o programa inteiro se encerra
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            Tela_de_Check_In checkinout = new Tela_de_Check_In(les, lde, fec);
            this.Hide();
            checkinout.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Tela_de_Check_out checkinout = new Tela_de_Check_out(les, lde, fec);
            this.Hide();
            checkinout.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1(les, lde, fec);
            this.Hide();
            inicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tela_De_Informacoes_Reserva reserva= new Tela_De_Informacoes_Reserva(les, lde, fec);
            this.Hide();
            reserva.Show();
        }
    }
}
