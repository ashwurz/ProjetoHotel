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
        //Função que faz com que se a pessoa clique no botão "X", o programa inteiro se encerra
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Tela_de_CadastraCliente cadastroCliente = new Tela_de_CadastraCliente(les, lde, fec);
            this.Hide();
            cadastroCliente.Show();
        }

        private void btnPlano_Click(object sender, EventArgs e)
        {
            st = File.Open("ListadeClientes.txt", FileMode.Append);
            str = new StreamWriter(st);
            int escolhido;
            if (rbtnD1.Checked)
            {
                escolhido = 1;
            }
            else if (rbtnD7.Checked)
            {
                escolhido = 7;
            }
            else if (rbtnD14.Checked)
            {
                escolhido = 14;
            }
            else if (rbtnD21.Checked)
            {
                escolhido = 21;
            }
            else
            {
                escolhido = 30;
            }
            int tempo = escolhido;
            str.WriteLine(tempo);
            pessoa.setTempo(tempo);
            str.Close();
            Tela_de_Plano plano = new Tela_de_Plano(les, lde, fec, pessoa);
            this.Hide();
            plano.Show();
        }
    }
}