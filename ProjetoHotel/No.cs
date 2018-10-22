using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel
{
    public unsafe class No
    {
        public Funcionario funcionario;
        public No proximo;
        public No(Funcionario funcionario)
        {
            this.funcionario = funcionario;
            this.proximo = null;
        }
    }
}
