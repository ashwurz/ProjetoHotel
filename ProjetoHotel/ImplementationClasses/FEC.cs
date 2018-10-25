﻿using ProjetoHotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public unsafe class FEC
{

    //private int max = 11; //10 quartos de 1,7,14,21,30 dias de estadia totalizando 50 quartos de hotel,
                          // o max é 11 pois 1 espaço não pode ser usado.
    private int i; // inicio da fila.
    private int f; // fim da fila.
    private int n = 11;  //variavel para o maximo de quartos.
    private Pessoa[] v = new Pessoa[11]; //fila de tamanho do maximo de quartos.
    private int[] time = new int[11]; //Tempo da estadia de cada cliente.

    public FEC()
    {
        i = 0;
        f = 0;
    }

    // insere o valor na fila com seu devido tempo de estadia.
    /*public bool insere(Pessoa valor, int t)
    {
        if ((f + 1) % n == i)
        {
            Console.WriteLine("A lista esta cheia");
            return false;
        }
        v[f] = valor;
        time[f] = t;
        f = (f + 1) % n;
        return true;
    }
    //passa um dia.
    public bool passaTempo()
    {
        for (int i = this.i; i < f; i++)
        {
            time[i]--;
            if (time[i] == 0)
            {
                //remove();
                return true;
            }
        }
        return false;
    }
    /*
    // remove quem entrou primeiro em uma fila.
    public bool remove(T* confirma = null)
    {
        if (f == i)
        {
            return false;
        }
        if (confirma != null)
        {
            *confirma = v[i];
        }
        i = (i + 1) % n;
        return true;
    }*/
    // impressão para confirmação dos resultados e relatorio de quem ainda está no hotel.
    public void imprime()
    {
        for (int k = this.i; k != f; k = (k + 1) % n)
        {
            Console.WriteLine("{0} {1} com {2} Dias restando no Quarto {3}", v[k].getNome(), v[k].getUltimoSobrenome(), time[k], v[k].getQuarto());
        }
    }
}