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
    public partial class Tela_de_Check_out : Form
    {
        public LES les = new LES();
        public Tela_de_Check_out(LES les)
        {
            InitializeComponent();
            this.les = les;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Checkinout checkinout = new Checkinout(les);
            this.Hide();
            checkinout.Show();
        }
    }
}
