using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoHotel.Telas
{
    public partial class Tela_de_Tempo : Form
    {
        public LES les;
        public LDE lde;
        public FEC fec;
        Pessoa pessoa;
        Stream st;
        StreamWriter str;
        public Tela_de_Tempo(LES les, LDE lde, FEC fec, Pessoa p)
        {
            this.les = les;
            this.lde = lde;
            this.fec = fec;
            this.pessoa = p;
            InitializeComponent();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Checkinout checkinout = new Checkinout(les, lde, fec);
            this.Hide();
            checkinout.Show();
        }

        private void btnPlano_Click(object sender, EventArgs e)
        {
            st = File.Open(@"C:\Users\Helmuth\Documents\ListadeFuncionarios.txt", FileMode.Append);
            str = new StreamWriter(st);
            int escolhido;
            if (rbtnD1.Checked)
            {
                escolhido = 1;
            }
            else if (rbtnD1.Checked)
            {
                escolhido = 7;
            }
            else if (rbtnD1.Checked)
            {
                escolhido = 14;
            }
            else if (rbtnD1.Checked)
            {
                escolhido = 21;
            }
            else
            {
                escolhido = 30;
            }
            int tempo = Convert.ToInt32(escolhido);
            str.WriteLine(tempo);
            pessoa.setTempo(tempo);
            Tela_de_Plano plano = new Tela_de_Plano(les, lde, fec, pessoa);
            this.Hide();
            plano.Show();
        }
    }
}
