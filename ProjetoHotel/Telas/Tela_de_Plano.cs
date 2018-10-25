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
    public partial class Tela_de_Plano : Form
    {
        public LES les;
        public LDE lde;
        public FEC fec;
        public Pessoa pessoa;
        Stream st;
        StreamWriter str;
        public Tela_de_Plano(LES les, LDE lde, FEC fec, Pessoa p)
        {
            this.les = les;
            this.lde = lde;
            this.fec = fec;
            this.pessoa = p;
            InitializeComponent();
            rbtnComum.Visible = les.confirmaDisponivel(p, "Comum");
            rbtnDeluxe.Visible = les.confirmaDisponivel(p, "Deluxe");
            rbtnPremium.Visible = les.confirmaDisponivel(p, "Premium");
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            st = File.Open("ListadeClientes.txt", FileMode.Append);
            str = new StreamWriter(st);
            string escolhido;
            if (rbtnComum.Checked)
            {
                escolhido = "Comum";
            }
            else if (rbtnDeluxe.Checked)
            {
                escolhido = "Deluxe";
            }
            else
            {
                escolhido = "Premium";
            }
            str.WriteLine(escolhido);
            pessoa.setPlano(escolhido);
            Random randNum = new Random();
            int q = randNum.Next(1,50);
            str.WriteLine(q);
            pessoa.setQuarto(q);
            les.insere(pessoa);
            str.Close();
            Checkinout checkinout = new Checkinout(les, lde, fec);
            this.Hide();
            checkinout.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Checkinout checkinout = new Checkinout(les, lde, fec);
            this.Hide();
            checkinout.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_de_Tempo tempo = new Tela_de_Tempo(les, lde, fec, pessoa);
            this.Hide();
            tempo.Show();
        }
    }
}
