using ProjetoHotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class FEC
{

    //private int max = 11; //10 quartos de 1,7,14,21,30 dias de estadia totalizando 50 quartos de hotel,
                          // o max é 11 pois 1 espaço não pode ser usado.
    private int i; // inicio da fila.
    private int f; // fim da fila.
    private int n = 11;  //variavel para o maximo de quartos.
    private Pessoa[] v = new Pessoa[11]; //fila de tamanho do maximo de quartos.
    private bool[] checkout = new bool[11];//se o cliente fez ou não checkout no tempo certo

    public FEC()
    {
        i = 0;
        f = 0;
    }

    // insere o valor na fila com seu devido tempo de estadia.
    public bool insere(Pessoa valor)
    {
        if ((f + 1) % n == i)
        {
            Console.WriteLine("A lista esta cheia");
            return false;
        }
        v[f] = valor;
        checkout[f] = false;
        f = (f + 1) % n;
        return true;
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
            i = (i + 1) % n;
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
}
