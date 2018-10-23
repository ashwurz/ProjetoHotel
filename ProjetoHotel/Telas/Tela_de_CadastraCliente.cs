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
    public partial class Tela_de_CadastraCliente : Form
    {
        public LES les;
        public LDE lde;
        public FEC fec;
        Stream st;
        StreamWriter str;
        public Tela_de_CadastraCliente(LES les, LDE lde, FEC fec)
        {
            InitializeComponent();
            this.les = les;
            this.lde = lde;
            this.fec = fec;
        }

        private void edtAC_TextChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(edtAC.Text);
            if (i >= 1)
            {
                txtAC1.Visible = true;
                edtAC1.Visible = true;
            }
            if (i >= 2)
            {
                txtAC2.Visible = true;
                edtAC2.Visible = true;
            }
            if (i >= 3)
            {
                txtAC3.Visible = true;
                edtAC3.Visible = true;
            }
            if (i >= 4)
            {
                txtAC4.Visible = true;
                edtAC4.Visible = true;
            }
            if (i == 5)
            {
                txtAC5.Visible = true;
                edtAC5.Visible = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = edtNome.Text;
            string sobrenome = edtSobrenome.Text;
            int numero = Convert.ToInt32(edtNumero.Text);
            string endereco = edtEndereco.Text;
            int acompanhantes = Convert.ToInt32(edtAC.Text);
            int i = acompanhantes;
            string acompanhante1 = edtAC1.Text;
            string acompanhante2 = edtAC2.Text;
            string acompanhante3 = edtAC3.Text;
            string acompanhante4 = edtAC4.Text;
            string acompanhante5 = edtAC5.Text;
            if (nome == "" || sobrenome == "" || numero.ToString() == "" || endereco == "" || acompanhantes.ToString() == "")
            {
                string mensagem = "Algum campo não preenchido favor prestar atençao nos campos de acompanhastes";
                string caption = "Erro detectado na inserção";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, caption, boxButtons);
            }
            else
            {
                Pessoa pessoa = new Pessoa(nome, sobrenome, numero, endereco, acompanhantes);
                st = File.Open(@"C:\Users\Helmuth\Documents\ListadeClientes.txt", FileMode.Append);
                str = new StreamWriter(st);
                str.WriteLine(nome);
                str.WriteLine(sobrenome);
                str.WriteLine(numero);
                str.WriteLine(endereco);
                str.WriteLine(acompanhantes);
                if (i >= 1)
                {
                    str.WriteLine(acompanhante1);
                }
                if (i >= 2)
                {
                    str.WriteLine(acompanhante2);
                }
                if (i >= 3)
                {
                    str.WriteLine(acompanhante3);
                }
                if (i >= 4)
                {
                    str.WriteLine(acompanhante4);
                }
                if (i == 5)
                {
                    str.WriteLine(acompanhante5);
                }
                edtNome.Clear();
                edtSobrenome.Clear();
                edtNumero.Clear();
                edtEndereco.Clear();
                edtAC.Clear();
                edtAC1.Clear();
                edtAC2.Clear();
                edtAC3.Clear();
                edtAC4.Clear();
                edtAC5.Clear();
                str.Close();
                //proxima tela
            }
        }
    }
}
