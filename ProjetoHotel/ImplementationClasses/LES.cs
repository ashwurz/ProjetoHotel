using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public class LES
    {
        private int quantidade;
        private Pessoa[] clientes = new Pessoa[100];
        Stream st;
        StreamWriter str;

        public LES()
        {
            quantidade = 0;
        }
        
        public int busca(string nome)
        {
            for(int i = 0; i < quantidade; i++)
            {
                if(clientes[i].getNome().ToString().Equals(nome))
                {
                    string mensagem = "O Cliente foi encontrado!";
                    string titulo = "Resultado da Busca";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(mensagem, titulo, boxButtons);
                    return i;
                }
            }
            string mensagem1 = "O Cliente NÃO esta cadastrado!";
            string titulo1 = "Erro no resultado da Busca";
            MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
            DialogResult result1;
            result1 = MessageBox.Show(mensagem1, titulo1, boxButtons1);
            return -1;
        }

        public void deletar(string f)
        {
            int posicao = busca(f);
            if(posicao == -1)
            {
                string mensagem = "O cliente não pode ser deletado, pois não consta nos registros";
                string titulo = "Erro detectado na remoção do cliente";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, titulo, boxButtons);
            }else
            {
                st = File.Open(@"C:\Users\User\Documents\GitHub\ProjetoHotel\ListadeClientes.txt", FileMode.Create);
                str = new StreamWriter(st);
                for (int i = posicao; i < quantidade; i++)
                {
                    clientes[i] = clientes[i + 1];
                }
                quantidade--;
                for(int i = 0; i < quantidade; i++)
                {
                    int membros = clientes[i].getFamilia();
                    str.WriteLine(clientes[i].getNome());
                    str.WriteLine(clientes[i].getUltimoSobrenome());
                    str.WriteLine(clientes[i].getNumero());
                    str.WriteLine(clientes[i].getEndereco());
                    str.WriteLine(clientes[i].getFamilia());
                    for (int j = 0; j < membros; j++)
                    {
                        str.WriteLine(clientes[i].getNomes(j));
                    }
                    str.WriteLine(clientes[i].getTempo());
                    str.WriteLine(clientes[i].getPlano());
                    str.WriteLine(clientes[i].getQuarto());
                }
                str.Close();
                string mensagem = "O Cliente foi excluído com sucesso dos registros";
                string titulo = "Remoção de Cliente";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, titulo, boxButtons);

            }
        }

        public bool insere(Pessoa f)
        {
            if(quantidade == 100)
            {
                string mensagem = "O Cliente não pode ser inserido nos registro, pois o limite já foi atingido";
                string titulo = "Erro detectado na inserção do Cliente";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, titulo, boxButtons);
                return false;
            }

            int i;
            for (i = 0; i < quantidade && !clientes[i].getNome().Equals(f.getNome()); i++);

            for(int j = quantidade; j >= i; j--)
            {
                clientes[j + 1] = clientes[j];
            }

            clientes[i] = f;
            quantidade++;

            /*string mensagem1 = "O Cliente foi inserido com sucesso nos registros";
            string titulo1 = "Inserção de Cliente";
            MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
            DialogResult result1;
            result1 = MessageBox.Show(mensagem1, titulo1, boxButtons1);*/

            return true;

        }
    }
}
