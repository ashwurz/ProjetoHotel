using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public partial class Tela_de_Check_In : Form
    {
        public LES les;
        public LDE lde;
        public FEC fec;
        public Tela_de_Check_In(LES les, LDE lde, FEC fec)
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
    }
}
