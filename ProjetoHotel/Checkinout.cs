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
    public partial class Checkinout : Form
    {
        public LES les;
        public Checkinout(LES les)
        {
            InitializeComponent();
            this.les = les;
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            Tela_de_Check_In checkinout = new Tela_de_Check_In(les);
            this.Hide();
            checkinout.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Tela_de_Check_out checkinout = new Tela_de_Check_out(les);
            this.Hide();
            checkinout.Show();
        }
    }
}
