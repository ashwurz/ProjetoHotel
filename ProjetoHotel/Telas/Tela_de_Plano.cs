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
            int q = les.daNumeroQuarto(escolhido);
            str.WriteLine(q);
            pessoa.setQuarto(q);
            int id = 0;
            str.WriteLine(id);
            pessoa.setId(id);
            les.insere(pessoa);
            str.Close();
            Tela_de_CadastraCliente cadastro = new Tela_de_CadastraCliente(les, lde, fec);
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
    }
}
