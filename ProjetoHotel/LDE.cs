using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public unsafe class LDE<T>
    {
        private int n;
        private No<T>* primeiro;
        public LDE(){
            this.n = 0;
            this.primeiro = null;
        }
        public bool insere(int valor)
        {
            No<T>* novo = new No<T>(valor);
            if (novo == null)
                return false;

            No<T>* anterior = null;
            No<T>* atual = primeiro;

            while (atual && valor > atual->valor)
            {
                anterior = atual;
                atual = atual->proximo;
            }

            novo->proximo = atual;
            if (anterior != null)
            {
                anterior->proximo = novo;
            }
            else
            {
                primeiro = novo;
            }
            n++;
            return true;


        }

        public No<T>* busca(int valor)
        {
            No<T>* atual = primeiro;
            while (atual)
            {
                if (atual->valor == valor)
                {
                    string mensagem = "O usuário foi encontrado!";
                    string titulo = "Resultado da Busca";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(mensagem, titulo, boxButtons);
                    return atual;
                }
                else
                {
                    atual = atual->proximo;
                }
            }
            string mensagem1 = "O usuário NÃO foi encontrado!";
            string titulo1 = "Erro no resultado da Busca";
            MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
            DialogResult result1;
            result1 = MessageBox.Show(mensagem1, titulo1, boxButtons1);
            return null;
        }

        public void remove(int valor)
        {
            No<T>* atual = primeiro;
            No<T>* anterior = nullptr;
            while (atual)
            {
                if (atual->valor == valor)
                {
                    break;
                }
                else
                {
                    anterior = atual;
                    atual = atual->proximo;
                }
            }
            if (anterior != null && atual->proximo != null)
            {
                anterior->proximo = atual->proximo;
            }
            else if (anterior != null && atual->proximo == null)
            {
                anterior->proximo = null;
            }
            else
            {
                primeiro = atual->proximo;
            }
            delete(atual);
            n--;

        }

    }

}
