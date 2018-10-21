using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel
{
    public unsafe class No<T>
    {
        private Pessoa valor;
        No<T>* proximo;
        No(Pessoa valor) {
            this.valor = valor;
            proximo = null;
        }

    }
}
