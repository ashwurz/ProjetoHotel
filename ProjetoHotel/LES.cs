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
        private Funcionario[] funcionarios = new Funcionario[100];
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
                if(funcionarios[i].getUsuario().ToString().Equals(nome))
                {
                    string mensagem = "O usuário foi encontrado!";
                    string titulo = "Resultado da Busca";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(mensagem, titulo, boxButtons);
                    return i;
                }
            }
            string mensagem1 = "O usuário NÃO foi encontrado!";
            string titulo1 = "Erro no resultado da Busca";
            MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
            DialogResult result1;
            result1 = MessageBox.Show(mensagem1, titulo1, boxButtons1);
            return -1;
        }

        public void deletar(Funcionario f)
        {
            int posicao = busca(f.getUsuario());
            if(posicao == -1)
            {
                string mensagem = "O Funcionário não pode ser deletado, pois não consta nos registros";
                string titulo = "Erro detectado na remoção do Funcionário";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, titulo, boxButtons);
            }else
            {
                st = File.Open(@"C:\Users\Helmuth\Documents\ListadeFuncionarios.txt", FileMode.Create);
                str = new StreamWriter(st);
                for (int i = posicao; i < quantidade; i++)
                {
                    funcionarios[i] = funcionarios[i + 1];
                }
                quantidade--;
                for(int i = 0; i < quantidade; i++)
                {
                    str.WriteLine(funcionarios[i].getUsuario());
                    str.WriteLine(funcionarios[i].getSenha());
                }
                str.Close();
                string mensagem = "O Funcionário foi excluído com sucesso dos registros";
                string titulo = "Remoção de Funcionário";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, titulo, boxButtons);

            }
        }

        public bool insere(Funcionario f)
        {
            if(quantidade == 100)
            {
                string mensagem = "O Funcionário não pode ser inserido nos registro, pois o limite já foi atingido";
                string titulo = "Erro detectado na inserção do Funcionário";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, titulo, boxButtons);
                return false;
            }

            int i;
            for (i = 0; i < quantidade && !funcionarios[i].getUsuario().Equals(f.getUsuario()); i++);

            for(int j = quantidade; j >= i; j--)
            {
                funcionarios[j + 1] = funcionarios[j];
            }

            funcionarios[i] = f;
            quantidade++;
            /* necessita de tratamento posteriormente
            string mensagem1 = "O Funcionário foi inserido com sucesso nos registros";
            string titulo1 = "Inserção de Funcionário";
            MessageBoxButtons boxButtons1 = MessageBoxButtons.OK;
            DialogResult result1;
            result1 = MessageBox.Show(mensagem1, titulo1, boxButtons1);
            */
            return true;

        }
    }
}
