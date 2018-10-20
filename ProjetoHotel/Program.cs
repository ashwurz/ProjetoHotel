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
        //Instância do arquivos
        public static FileInfo fi = new FileInfo(@"C:\Users\Helmuth\Documents\ListadeFuncionarios.txt");
        [STAThread]
        static void Main()
        {
            //Instância da LES que vai ser usada para o gerenciamento de funcionários
            LES les = new LES();
            Stream st;
            StreamReader str;
            if (fi.Exists)
            {
                st = File.Open(@"C:\Users\Helmuth\Documents\ListadeFuncionarios.txt", FileMode.Open);
                str = new StreamReader(st);
                Funcionario funcionario;
                string linha = str.ReadLine();
                string usuario = linha;
                linha = str.ReadLine();
                string senha = linha;
                while (linha != null)
                {
                    funcionario = new Funcionario(usuario, senha);
                    les.insere(funcionario);
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(les));
        }
    }
}
