using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    static class Program
    {
        public static FileInfo fi = new FileInfo(@"C:\Users\Helmuth\Documents\ListadeFuncionarios.txt");
        [STAThread]
        static void Main()
        {
            Stream st;
            StreamReader str;
            LES les = new LES();
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
