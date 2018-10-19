using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel
{
    public class Funcionario
    {
        protected string usuario;
        protected string senha;

        public Funcionario(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }

        public string getUsuario()
        {
            return this.usuario;
        }

        public string getSenha()
        {
            return this.senha;
        }

        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }
    }
}
