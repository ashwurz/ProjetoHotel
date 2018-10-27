﻿using System;
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

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Form1 login= new Form1(les, lde, fec);
            this.Hide();
            login.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string mensagem = "Essa tela já está aberta";
            string caption = "Erro detectado na abertura e uma nova janela";
            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensagem, caption, boxButtons);

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Tela_de_Check_out checkout = new Tela_de_Check_out(les, lde, fec);
            this.Hide();
            checkout.Show();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            Busca_Informacoes_Cliente buscaCliente = new Busca_Informacoes_Cliente(les, lde, fec);
            this.Hide();
            buscaCliente.Show();
        }
    }
}
