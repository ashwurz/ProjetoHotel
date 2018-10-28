using System;
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
        [STAThread]
        static void Main()
        {
            LES les = new LES();
            LDE lde = new LDE();
            FEC fec = new FEC();
            Stream st;
            StreamReader str;
            Stream st1;
            StreamReader str1;
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
                while (linha != null)
                {
                    pessoa = new Pessoa(nome, sobrenome, numero, endereco, acompanhantes);
                    pessoa.setTempo(tempo);
                    pessoa.setPlano(plano);
                    pessoa.setQuarto(quarto);
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
                    acompanhante1 = null;
                    acompanhante2 = null;
                    acompanhante3 = null;
                    acompanhante4 = null;
                    acompanhante5 = null;
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
                }
                str1.Close();
            }
            else
            {
                FileStream fstr1 = fi1.Create();
                fstr1.Close();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(les, lde, fec));
        }
    }
}