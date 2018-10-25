using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoHotel
{
    public unsafe class LDE
    {
        private int n;
        private No primeiro;
        Stream st;
        StreamWriter str;
        public LDE(){
            this.n = 0;
            this.primeiro = null;
        }
        public bool insere(Funcionario funcionario)
        {
            No novo = new No(funcionario);
            if (novo == null)
                return false;

            No anterior = null;
            No atual = primeiro;

            while (atual != null)
            {
                anterior = atual;
                atual = atual.proximo;
            }

            novo.proximo = atual;
            if (anterior != null)
            {
                anterior.proximo = novo;
            }
            else
            {
                primeiro = novo;
            }
            n++;
            return true;


        }

        public bool buscaValidacao(string usuario)
        {
            No atual = primeiro;
            while (atual != null)
            {
                if (atual.funcionario.getUsuario() == usuario)
                {
                    return true;
                }
                else
                {
                    atual = atual.proximo;
                }
            }
            return false;
        }

        public bool buscaValidacao(string usuario, string senha)
        {
            No atual = primeiro;
            while (atual != null)
            {
                if (atual.funcionario.getUsuario() == usuario && atual.funcionario.getSenha() == senha)
                {
                    return true;
                }
                else
                {
                    atual = atual.proximo;
                }
            }
            return false;
        }

        public bool busca(string usuario)
        {
            No atual = primeiro;
            while (atual != null)
            {
                if (atual.funcionario.getUsuario() == usuario)
                {
                    string mensagem = "O usuário foi encontrado!";
                    string titulo = "Resultado da Busca";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(mensagem, titulo, boxButtons);
                    return true;
                }
                else
                {
                    atual = atual.proximo;
                }
            }
            string mensagem1 = "O usuário NÃO foi encontrado!";
            string titulo1 = "Erro no resultado da Busca";
            MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
            DialogResult result1;
            result1 = MessageBox.Show(mensagem1, titulo1, boxButtons1);
            return false;
        }

        public bool busca(string usuario, string senha)
        {
            No atual = primeiro;
            while (atual != null)
            {
                if (atual.funcionario.getUsuario() == usuario && atual.funcionario.getSenha() == senha)
                {
                    return true;
                }
                else
                {
                    atual = atual.proximo;
                }
            }
            string mensagem1 = "O usuário NÃO foi encontrado!";
            string titulo1 = "Erro no resultado da Busca";
            MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
            DialogResult result1;
            result1 = MessageBox.Show(mensagem1, titulo1, boxButtons1);
            return false;
        }

        public void remove(string usuario, string senha)
        {
            No atual = primeiro;
            No anterior = null;
            while (atual != null)
            {
                if (atual.funcionario.getUsuario() == usuario && atual.funcionario.getSenha() == senha)
                {
                    break;
                }
                else
                {
                    anterior = atual;
                    atual = atual.proximo;
                }
            }
            if (atual != null)
            {
                if (anterior != null && atual.proximo != null)
                {
                    anterior.proximo = atual.proximo;
                }
                else if (anterior != null && atual.proximo == null)
                {
                    anterior.proximo = null;
                }
                else
                {
                    primeiro = atual.proximo;
                }
                atual = null;
                n--;
                st = File.Open(@"C:\Users\Helmuth\Documents\ListadeFuncionarios.txt", FileMode.Create);
                str = new StreamWriter(st);
                No arruma = primeiro;
                for (int i = 0; i < n ; i++)
                {
                    str.WriteLine(arruma.funcionario.getUsuario());
                    str.WriteLine(arruma.funcionario.getSenha());
                    arruma = arruma.proximo;
                }
                str.Close();
                //MessageBox que aparecerá quando o usuário for deletado
                string mensagem = "O Funcionário foi deletado com sucesso!";
                string titulo = "Sucesso!";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, titulo, boxButtons);
            }
            else
            {
                //MessageBox que aparecerá quando o usuário NÃO for deletado
                string mensagem = "O Funcionário não pode ser deletado, pois não consta nos registros";
                string titulo = "Erro detectado na remoção do Funcionário";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, titulo, boxButtons);
            }
        }

    }

}
