﻿using System;
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
        public FEC[] fec;
        public Pessoa pessoa;
        Stream st;
        StreamWriter str;
        public Tela_de_Plano(LES les, LDE lde, FEC[] fec, Pessoa p)
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
        //Função que faz com que se a pessoa clique no botão "X", o programa inteiro se encerra
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {

            st = File.Open("ListadeClientes.txt", FileMode.Append);
            str = new StreamWriter(st);
            str.WriteLine(pessoa.getNome());
            str.WriteLine(pessoa.getUltimoSobrenome());
            str.WriteLine(pessoa.getNumero());
            str.WriteLine(pessoa.getEndereco());
            str.WriteLine(pessoa.getFamilia());
            for (int i = 0; i < pessoa.getFamilia(); i++)
            {
                str.WriteLine(pessoa.getNomes(i));
            }
            str.WriteLine(pessoa.getTempo());
            string escolhido;
            //resolvido
            if (rbtnComum.Checked)
            {
                escolhido = "Comum";
            }
            else if (rbtnDeluxe.Checked)
            {
                escolhido = "Deluxe";
            }
            else if (rbtnPremium.Checked)
            {
                escolhido = "Premium";
            }
            else
            {
                string mensagem1 = "Nenhuma Opção Escolhida, Favor escolher";
                string titulo1 = "Erro de Seleção!";
                MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
                DialogResult result1;
                result1 = MessageBox.Show(mensagem1, titulo1, boxButtons1);
                str.Close();
                return;
            }
            str.WriteLine(escolhido);
            pessoa.setPlano(escolhido);
            int q = les.daNumeroQuarto(escolhido);
            str.WriteLine(q);
            pessoa.setQuarto(q);
            int id = les.daID();
            str.WriteLine(id);
            pessoa.setId(id);
            les.insere(pessoa);
            str.Close();
            Tela_de_CadastraCliente cadastro = new Tela_de_CadastraCliente(les, lde, fec);
            string mensagem = "O SEU ID É: " + pessoa.getId();
            string caption = "Atenção! Guarde o seguinte número de ID";
            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensagem, caption, boxButtons);
            this.Hide();
            cadastro.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Tela_de_CadastraCliente cadastro = new Tela_de_CadastraCliente(les, lde, fec);
            this.Hide();
            cadastro.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_de_Tempo tempo = new Tela_de_Tempo(les, lde, fec, pessoa);
            this.Hide();
            tempo.Show();
        }

        private void rbtnPremium_VisibleChanged(object sender, EventArgs e)
        {
            txtIndisponivel3.Visible = true;
        }

        private void rbtnDeluxe_VisibleChanged(object sender, EventArgs e)
        {
            txtIndisponivel2.Visible = true;
        }

        private void rbtnComum_CheckedChanged(object sender, EventArgs e)
        {
            txtIndisponivel1.Visible = true;
        }
    }
}
