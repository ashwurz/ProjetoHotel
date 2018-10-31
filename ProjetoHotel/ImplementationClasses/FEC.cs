using ProjetoHotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

public class FEC
{

    //private int max = 11; //10 quartos de 1,7,14,21,30 dias de estadia totalizando 50 quartos de hotel,
                          // o max é 11 pois 1 espaço não pode ser usado.
    private int i; // inicio da fila.
    private int f; // fim da fila.
    private int n = 11;  //variavel para o maximo de quartos.
    private Pessoa[] v = new Pessoa[11]; //fila de tamanho do maximo de quartos.
    private bool[] checkout = new bool[11];//se o cliente fez ou não checkout no tempo certo

    Stream st;
    StreamWriter str;

    public FEC()
    {
        for (int k = 0; k < n; k++)
        {
            checkout[k] = false;
        }
        i = 0;
        f = 0;
    }

    // insere o valor na fila com seu devido tempo de estadia.
    public void insere(Pessoa valor)
    {
        if ((f + 1) % n == i)
        {
            string mensagem1 = "A lista esta cheia";
            string titulo1 = "Problemas amigo";
            MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
            DialogResult result1;
            result1 = MessageBox.Show(mensagem1, titulo1, boxButtons1);
            return;
        }
        if (valor.getTempo() == 1)
        {
            st = File.Open("Fila1Dia.txt", FileMode.Append);
            str = new StreamWriter(st);
            str.WriteLine(valor.getNome());
            str.WriteLine(valor.getUltimoSobrenome());
            str.WriteLine(checkout[f]);
            v[f] = valor;
            f = (f + 1) % n;
            str.Close();
            return;
        }
        else if(valor.getTempo() == 7)
        {
            st = File.Open("Fila7Dia.txt", FileMode.Append);
            str = new StreamWriter(st);
            str.WriteLine(valor.getNome());
            str.WriteLine(valor.getUltimoSobrenome());
            str.WriteLine(checkout[f]);
            v[f] = valor;
            f = (f + 1) % n;
            str.Close();
            return;
        }
        else if (valor.getTempo() == 14)
        {
            st = File.Open("Fila14Dia.txt", FileMode.Append);
            str = new StreamWriter(st);
            str.WriteLine(valor.getNome());
            str.WriteLine(valor.getUltimoSobrenome());
            str.WriteLine(checkout[f]);
            v[f] = valor;
            f = (f + 1) % n;
            str.Close();
            return;
        }
        else if (valor.getTempo() == 21)
        {
            st = File.Open("Fila21Dia.txt", FileMode.Append);
            str = new StreamWriter(st);
            str.WriteLine(valor.getNome());
            str.WriteLine(valor.getUltimoSobrenome());
            str.WriteLine(checkout[f]);
            v[f] = valor;
            f = (f + 1) % n;
            str.Close();
            return;
        }
        else
        {
            st = File.Open("Fila30Dia.txt", FileMode.Append);
            str = new StreamWriter(st);
            str.WriteLine(valor.getNome());
            str.WriteLine(valor.getUltimoSobrenome());
            str.WriteLine(checkout[f]);
            v[f] = valor;
            f = (f + 1) % n;
            str.Close();
            return;
        }/*
        str.WriteLine(valor.getNome());
        str.WriteLine(valor.getUltimoSobrenome());
        str.WriteLine(checkout[f]);
        v[f] = valor;
        f = (f + 1) % n;
        str.Close();
        return true;*/
    }    
    // remove quem entrou primeiro em uma fila.
    public bool remove(LES les)
    {
        if (f == i || checkout[i] == false)
        {
            return false;
        }
        else
        {
            les.deletar(v[i]);
            if (v[i].getTempo() == 1)
            {
                st = File.Open("Fila1Dia.txt", FileMode.Create);
                str = new StreamWriter(st);
            }
            else if (v[i].getTempo() == 7)
            {
                st = File.Open("Fila7Dia.txt", FileMode.Create);
                str = new StreamWriter(st);
            }
            else if (v[i].getTempo() == 14)
            {
                st = File.Open("Fila14Dia.txt", FileMode.Create);
                str = new StreamWriter(st);
            }
            else if (v[i].getTempo() == 21)
            {
                st = File.Open("Fila21Dia.txt", FileMode.Create);
                str = new StreamWriter(st);
            }
            else
            {
                st = File.Open("Fila30Dia.txt", FileMode.Create);
                str = new StreamWriter(st);
            }
            i = (i + 1) % n;
            for (int k = this.i; k != f; k = (k + 1) % n)
            {
                str.WriteLine(v[k].getNome());
                str.WriteLine(v[k].getUltimoSobrenome());
                str.WriteLine(checkout[k]);
            }
            str.Close();
            remove(les);
            return true;
        }
    }
    // impressão para confirmação dos resultados e relatorio de quem ainda está no hotel.
    public bool fezCheckout(string nome, string sobrenome)
    {
        for (int k = this.i; k !=f; k = (k + 1) % n)
        {
            if (v[k].getNome() == nome && v[k].getUltimoSobrenome() == sobrenome)
            {
                checkout[k] = true;
                if (v[k].getTempo() == 1)
                {
                    st = File.Open("Fila1Dia.txt", FileMode.Create);
                    str = new StreamWriter(st);
                }
                else if (v[k].getTempo() == 7)
                {
                    st = File.Open("Fila7Dia.txt", FileMode.Create);
                    str = new StreamWriter(st);
                }
                else if (v[k].getTempo() == 14)
                {
                    st = File.Open("Fila14Dia.txt", FileMode.Create);
                    str = new StreamWriter(st);
                }
                else if (v[k].getTempo() == 21)
                {
                    st = File.Open("Fila21Dia.txt", FileMode.Create);
                    str = new StreamWriter(st);
                }
                else
                {
                    st = File.Open("Fila30Dia.txt", FileMode.Create);
                    str = new StreamWriter(st);
                }
                for (int l = this.i; l != f; l = (l + 1) % n)
                {
                    str.WriteLine(v[l].getNome());
                    str.WriteLine(v[l].getUltimoSobrenome());
                    str.WriteLine(checkout[l]);
                }
                str.Close();
                return true;
            }
        }
        return false;
    }

    public bool busca(string nome, string sobrenome)
    {
        for (int k = this.i; k != f; k = (k + 1) % n)
        {
            if (v[k].getNome() == nome && v[k].getUltimoSobrenome() == sobrenome)
            {
                return true;
            }
        }
        return false;
    }
    public bool buscaFec(string nome, string sobrenome)
    {
        for (int k = this.i; k != f; k = (k + 1) % n)
        {
            if (v[k].getNome() == nome && v[k].getUltimoSobrenome() == sobrenome)
            {
                return true;
            }
        }
        return false;
    }

    public void setCheckout(bool checkout)
    {
        this.checkout[f] = checkout;
    }
}
