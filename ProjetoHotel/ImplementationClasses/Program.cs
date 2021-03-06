﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoHotel
{
    static class Program
    {
        //Files funcionario
        public static FileInfo fi = new FileInfo("ListadeFuncionarios.txt");
        //File cliente
        public static FileInfo fi1 = new FileInfo("ListadeClientes.txt");
        //Files de filas
        public static FileInfo fi2 = new FileInfo("Fila1Dia.txt");
        public static FileInfo fi3 = new FileInfo("Fila7Dia.txt");
        public static FileInfo fi4 = new FileInfo("Fila14Dia.txt");
        public static FileInfo fi5 = new FileInfo("Fila21Dia.txt");
        public static FileInfo fi6 = new FileInfo("Fila30Dia.txt");
        [STAThread]
        static void Main()
        {
            LES les = new LES();
            LDE lde = new LDE();
            FEC[] fec = new FEC[5];
            fec[0] = new FEC();
            fec[1] = new FEC();
            fec[2] = new FEC();
            fec[3] = new FEC();
            fec[4] = new FEC();
            Stream st;
            StreamReader str;
            Stream st1;
            StreamReader str1;
            Stream st2;
            StreamReader str2;
            Stream st3;
            StreamReader str3;
            Stream st4;
            StreamReader str4;
            Stream st5;
            StreamReader str5;
            Stream st6;
            StreamReader str6;
            if (fi.Exists)
            {
                st = File.Open("ListadeFuncionarios.txt", FileMode.Open);
                str = new StreamReader(st);
                Funcionario funcionario;
                string linha = str.ReadLine();
                string usuario = linha;
                linha = str.ReadLine();
                string senha = linha;
                while (linha != null)
                {
                    funcionario = new Funcionario(usuario, senha);
                    lde.insere(funcionario);
                    linha = str.ReadLine();
                    usuario = linha;
                    linha = str.ReadLine();
                    senha = linha;
                }
                str.Close();
            }
            else
            {
                FileStream fstr = fi.Create();
                fstr.Close();
            }
            if (fi1.Exists)
            {
                st1 = File.Open("ListadeClientes.txt", FileMode.Open);
                str1 = new StreamReader(st1);
                Pessoa pessoa;
                string linha = str1.ReadLine();
                string nome = linha;
                linha = str1.ReadLine();
                string sobrenome = linha;
                linha = str1.ReadLine();
                int numero = Convert.ToInt32(linha);
                linha = str1.ReadLine();
                string endereco = linha;
                linha = str1.ReadLine();
                int acompanhantes = Convert.ToInt32(linha);
                int i = acompanhantes;
                string acompanhante1 = null;
                string acompanhante2 = null;
                string acompanhante3 = null;
                string acompanhante4 = null;
                string acompanhante5 = null;
                if (i >= 1)
                {
                    linha = str1.ReadLine();
                    acompanhante1 = linha;
                }
                if (i >= 2)
                {
                    linha = str1.ReadLine();
                    acompanhante2 = linha;
                }
                if (i >= 3)
                {
                    linha = str1.ReadLine();
                    acompanhante3 = linha;
                }
                if (i >= 4)
                {
                    linha = str1.ReadLine();
                    acompanhante4 = linha;
                }
                if (i == 5)
                {
                    linha = str1.ReadLine();
                    acompanhante5 = linha;
                }
                linha = str1.ReadLine();
                int tempo = Convert.ToInt32(linha);
                linha = str1.ReadLine();
                string plano = linha;
                linha = str1.ReadLine();
                int quarto = Convert.ToInt32(linha);
                linha = str1.ReadLine();
                int id = Convert.ToInt32(linha);
                while (linha != null)
                {
                    pessoa = new Pessoa(nome, sobrenome, numero, endereco, acompanhantes);
                    pessoa.setTempo(tempo);
                    pessoa.setPlano(plano);
                    pessoa.setQuarto(quarto);
                    pessoa.setId(id);
                    if (i >= 1)
                    {
                        pessoa.setNomes(acompanhante1, 0);
                    }
                    if (i >= 2)
                    {
                        pessoa.setNomes(acompanhante2, 1);
                    }
                    if (i >= 3)
                    {
                        pessoa.setNomes(acompanhante3, 2);
                    }
                    if (i >= 4)
                    {
                        pessoa.setNomes(acompanhante4, 3);
                    }
                    if (i == 5)
                    {
                        pessoa.setNomes(acompanhante5, 4);
                    }
                    les.insere(pessoa);
                    linha = str1.ReadLine();
                    nome = linha;
                    linha = str1.ReadLine();
                    sobrenome = linha;
                    linha = str1.ReadLine();
                    numero = Convert.ToInt32(linha);
                    linha = str1.ReadLine();
                    endereco = linha;
                    linha = str1.ReadLine();
                    acompanhantes = Convert.ToInt32(linha);
                    i = acompanhantes;
                    acompanhante1 = "";
                    acompanhante2 = "";
                    acompanhante3 = "";
                    acompanhante4 = "";
                    acompanhante5 = "";
                    if (i >= 1)
                    {
                        linha = str1.ReadLine();
                        acompanhante1 = linha;
                    }
                    if (i >= 2)
                    {
                        linha = str1.ReadLine();
                        acompanhante2 = linha;
                    }
                    if (i >= 3)
                    {
                        linha = str1.ReadLine();
                        acompanhante3 = linha;
                    }
                    if (i >= 4)
                    {
                        linha = str1.ReadLine();
                        acompanhante4 = linha;
                    }
                    if (i == 5)
                    {
                        linha = str1.ReadLine();
                        acompanhante5 = linha;
                    }
                    linha = str1.ReadLine();
                    tempo = Convert.ToInt32(linha);
                    linha = str1.ReadLine();
                    plano = linha;
                    linha = str1.ReadLine();
                    quarto = Convert.ToInt32(linha);
                    linha = str1.ReadLine();
                    id = Convert.ToInt32(linha);
                }
                str1.Close();
            }
            else
            {
                FileStream fstr1 = fi1.Create();
                fstr1.Close();
            }
            if (fi2.Exists)
            {
                st2 = File.Open("Fila1Dia.txt", FileMode.Open);
                str2 = new StreamReader(st2);
                string linha = str2.ReadLine();
                string nome = linha;
                linha = str2.ReadLine();
                string sobrenome = linha;
                linha = str2.ReadLine();
                bool checkout = Convert.ToBoolean(linha);
                Pessoa pessoa = les.busca(nome, sobrenome);
                while (linha != null)
                {
                    fec[0].setCheckout(checkout);
                    fec[0].insereFile(pessoa);
                    linha = str2.ReadLine();
                    nome = linha;
                    linha = str2.ReadLine();
                    sobrenome = linha;
                    linha = str2.ReadLine();
                    checkout = Convert.ToBoolean(linha);
                    pessoa = les.busca(nome, sobrenome);
                }
                str2.Close();
            }
            else
            {
                FileStream fstr2 = fi2.Create();
                fstr2.Close();
            }
            if (fi3.Exists)
            {
                st3 = File.Open("Fila7Dia.txt", FileMode.Open);
                str3 = new StreamReader(st3);
                string linha = str3.ReadLine();
                string nome = linha;
                linha = str3.ReadLine();
                string sobrenome = linha;
                linha = str3.ReadLine();
                bool checkout = Convert.ToBoolean(linha);
                Pessoa pessoa = les.busca(nome, sobrenome);
                while (linha != null)
                {
                    fec[1].setCheckout(checkout);
                    fec[1].insereFile(pessoa);
                    linha = str3.ReadLine();
                    nome = linha;
                    linha = str3.ReadLine();
                    sobrenome = linha;
                    linha = str3.ReadLine();
                    checkout = Convert.ToBoolean(linha);
                    pessoa = les.busca(nome, sobrenome);
                }
                str3.Close();
            }
            else
            {
                FileStream fstr3 = fi3.Create();
                fstr3.Close();
            }
            if (fi4.Exists)
            {
                st4 = File.Open("Fila14Dia.txt", FileMode.Open);
                str4 = new StreamReader(st4);
                string linha = str4.ReadLine();
                string nome = linha;
                linha = str4.ReadLine();
                string sobrenome = linha;
                linha = str4.ReadLine();
                bool checkout = Convert.ToBoolean(linha);
                Pessoa pessoa = les.busca(nome, sobrenome);
                while (linha != null)
                {
                    fec[2].setCheckout(checkout);
                    fec[2].insereFile(pessoa);
                    linha = str4.ReadLine();
                    nome = linha;
                    linha = str4.ReadLine();
                    sobrenome = linha;
                    linha = str4.ReadLine();
                    checkout = Convert.ToBoolean(linha);
                    pessoa = les.busca(nome, sobrenome);
                }
                str4.Close();
            }
            else
            {
                FileStream fstr4 = fi4.Create();
                fstr4.Close();
            }
            if (fi5.Exists)
            {
                st5 = File.Open("Fila21Dia.txt", FileMode.Open);
                str5 = new StreamReader(st5);
                string linha = str5.ReadLine();
                string nome = linha;
                linha = str5.ReadLine();
                string sobrenome = linha;
                linha = str5.ReadLine();
                bool checkout = Convert.ToBoolean(linha);
                Pessoa pessoa = les.busca(nome, sobrenome);
                while (linha != null)
                {
                    fec[3].setCheckout(checkout);
                    fec[3].insereFile(pessoa);
                    linha = str5.ReadLine();
                    nome = linha;
                    linha = str5.ReadLine();
                    sobrenome = linha;
                    linha = str5.ReadLine();
                    checkout = Convert.ToBoolean(linha);
                    pessoa = les.busca(nome, sobrenome);
                }
                str5.Close();
            }
            else
            {
                FileStream fstr5 = fi5.Create();
                fstr5.Close();
            }
            if (fi6.Exists)
            {
                st6 = File.Open("Fila30Dia.txt", FileMode.Open);
                str6 = new StreamReader(st6);
                string linha = str6.ReadLine();
                string nome = linha;
                linha = str6.ReadLine();
                string sobrenome = linha;
                linha = str6.ReadLine();
                bool checkout = Convert.ToBoolean(linha);
                Pessoa pessoa = les.busca(nome, sobrenome);
                while (linha != null)
                {
                    fec[4].setCheckout(checkout);
                    fec[4].insereFile(pessoa);
                    linha = str6.ReadLine();
                    nome = linha;
                    linha = str6.ReadLine();
                    sobrenome = linha;
                    linha = str6.ReadLine();
                    checkout = Convert.ToBoolean(linha);
                    pessoa = les.busca(nome, sobrenome);
                }
                str6.Close();
            }
            else
            {
                FileStream fstr6 = fi6.Create();
                fstr6.Close();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(les, lde, fec));
        }
    }
}