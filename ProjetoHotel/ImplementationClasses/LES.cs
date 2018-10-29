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
        private Pessoa[] clientes = new Pessoa[50];
        Stream st;
        StreamWriter str;

        public LES()
        {
            quantidade = 0;
        }

        public int busca(string nome, string sobrenome, int id, int quarto)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if(clientes[i].getNome() == nome && clientes[i].getUltimoSobrenome() == sobrenome && clientes[i].getId() == id  && clientes[i].getQuarto() == quarto)
                {
                    /*string mensagem = "O Cliente foi encontrado!";
                    string titulo = "Resultado da Busca";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(mensagem, titulo, boxButtons);*/
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

        public Pessoa busca(string nome, string sobreNome, int ID)
        {
            for(int i = 0; i < quantidade; i++)
            {
                if(clientes[i].getNome().ToString().Equals(nome) && clientes[i].getUltimoSobrenome().ToString().Equals(sobreNome) && clientes[i].getId() == ID)
                {
                    return clientes[i];
                }
            }
            return null;
        }
        public Pessoa busca(int quarto)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (clientes[i].getQuarto() == quarto)
                {
                    return clientes[i];
                }
            }
            return null;

        }
        public Pessoa busca(string nome, string sobrenome)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (clientes[i].getNome().ToString().Equals(nome))
                {
                    return clientes[i];
                }
            }
            return null;
        }

        public void deletar(Pessoa p)
        {
            int posicao = busca(p.getNome(), p.getUltimoSobrenome(), p.getId(), p.getQuarto());
            if (posicao == -1)
            {
                string mensagem = "O cliente não pode ser deletado, pois não consta nos registros";
                string titulo = "Erro detectado na remoção do cliente";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensagem, titulo, boxButtons);
            }
            else
            {
                st = File.Open("ListadeClientes.txt", FileMode.Create);
                str = new StreamWriter(st);
                for (int i = posicao; i < quantidade; i++)
                {
                    clientes[i] = clientes[i + 1];
                }
                quantidade--;
                for (int i = 0; i < quantidade; i++)
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
            if (quantidade == 100)
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

            for (int j = quantidade; j >= i; j--)
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
        public bool confirmaDisponivel(Pessoa p, string plano)
        {
            int contC1 = 0;
            int contD1 = 0;
            int contP1 = 0;
            int contC7 = 0;
            int contD7 = 0;
            int contP7 = 0;
            int contC14 = 0;
            int contD14 = 0;
            int contP14 = 0;
            int contC21 = 0;
            int contD21 = 0;
            int contP21 = 0;
            int contC30 = 0;
            int contD30 = 0;
            int contP30 = 0;
            for (int i = 0; i < quantidade; i++)
            {
                if (plano == "Comum")
                {
                    if (clientes[i].getTempo() == 1)
                    {
                        if (clientes[i].getPlano() == "Comum")
                        {
                            contC1 += 1;
                        }
                    }
                    else if (clientes[i].getTempo() == 7)
                    {
                        if (clientes[i].getPlano() == "Comum")
                        {
                            contC7 += 1;
                        }
                    }
                    else if (clientes[i].getTempo() == 14)
                    {
                        if (clientes[i].getPlano() == "Comum")
                        {
                            contC14 += 1;
                        }
                    }
                    else if (clientes[i].getTempo() == 21)
                    {
                        if (clientes[i].getPlano() == "Comum")
                        {
                            contC21 += 1;
                        }
                    }
                    else
                    {
                        if (clientes[i].getPlano() == "Comum")
                        {
                            contC30 += 1;
                        }
                    }
                }
                else if (plano == "Deluxe")
                {
                    if (clientes[i].getTempo() == 1)
                    {
                        if (clientes[i].getPlano() == "Deluxe")
                        {
                            contD1 += 1;
                        }
                    }
                    else if (clientes[i].getTempo() == 7)
                    {
                        if (clientes[i].getPlano() == "Deluxe")
                        {
                            contD7 += 1;
                        }
                    }
                    else if (clientes[i].getTempo() == 14)
                    {
                        if (clientes[i].getPlano() == "Deluxe")
                        {
                            contD14 += 1;
                        }
                    }
                    else if (clientes[i].getTempo() == 21)
                    {
                        if (clientes[i].getPlano() == "Deluxe")
                        {
                            contD21 += 1;
                        }
                    }
                    else
                    {
                        if (clientes[i].getPlano() == "Deluxe")
                        {
                            contD30 += 1;
                        }
                    }
                }
                else
                {
                    if (clientes[i].getTempo() == 1)
                    {
                        if (clientes[i].getPlano() == "Premium")
                        {
                            contP1 += 1;
                        }
                    }
                    else if (clientes[i].getTempo() == 7)
                    {
                        if (clientes[i].getPlano() == "Premium")
                        {
                            contP7 += 1;
                        }
                    }
                    else if (clientes[i].getTempo() == 14)
                    {
                        if (clientes[i].getPlano() == "Premium")
                        {
                            contP14 += 1;
                        }
                    }
                    else if (clientes[i].getTempo() == 21)
                    {
                        if (clientes[i].getPlano() == "Premium")
                        {
                            contP21 += 1;
                        }
                    }
                    else
                    {
                        if (clientes[i].getPlano() == "Premium")
                        {
                            contP30 += 1;
                        }
                    }
                }
            }
            if (p.getTempo() == 1)
            {
                if(plano == "Comum" && contC1 == 4 || plano == "Deluxe" && contD1 == 3 || plano == "Premium" && contP1 == 3)
                {
                    return false;
                }
            }
            else if (p.getTempo() == 7)
            {
                if (plano == "Comum" && contC7 == 4 || plano == "Deluxe" && contD7 == 3 || plano == "Premium" && contP7 == 3)
                {
                    return false;
                }
            }
            else if (p.getTempo() == 14)
            {
                if (plano == "Comum" && contC14 == 4 || plano == "Deluxe" && contD14 == 3 || plano == "Premium" && contP14 == 3)
                {
                    return false;
                }
            }
            else if (p.getTempo() == 21)
            {
                if (plano == "Comum" && contC21 == 4 || plano == "Deluxe" && contD21 == 3 || plano == "Premium" && contP21 == 3)
                {
                    return false;
                }
            }
            else
            {
                if (plano == "Comum" && contC30 == 4 || plano == "Deluxe" && contD30 == 3 || plano == "Premium" && contP30 == 3)
                {
                    return false;
                }
            }
            return true;
        }

        public int daNumeroQuarto(string escolha)
        {
            int tem = 0;
            int quarto = 0;
            if (escolha == "Comum")
            {
                for (int i = 1; i <= 20; i++)
                {
                    for (int j = 0; j < quantidade; j++)
                    {
                        if (clientes[j].getQuarto() == i)
                        {
                            tem = i;
                            break;
                        }
                        tem = 0;
                    }
                    if (tem == 0)
                    {
                        quarto = i;
                        break;
                    }
                }
                return quarto;
            }
            else if (escolha == "Deluxe")
            {
                for (int i = 21; i <= 35; i++)
                {
                    for (int j = 0; j < quantidade; j++)
                    {
                        if (clientes[j].getQuarto() == i)
                        {
                            tem = i;
                            break;
                        }
                        tem = 0;
                    }
                    if (tem == 0)
                    {
                        quarto = i;
                        break;
                    }
                }
                return quarto;
            }
            else
            {
                for (int i = 36; i <= 50; i++)
                {
                    for (int j = 0; j < quantidade; j++)
                    {
                        if (clientes[j].getQuarto() == i)
                        {
                            tem = i;
                            break;
                        }
                        tem = 0;
                    }
                    if (tem == 0)
                    {
                        quarto = i;
                        break;
                    }
                }
                return quarto;
            }
        }
        public int daID()
        {
            int tem = 0;
            int id = 0;
            for (int i = 1; i <= 50; i++)
            {
                for (int j = 0; j < quantidade; j++)
                {
                    if (clientes[j].getId() == i)
                    {
                        tem = i;
                        break;
                    }
                    tem = 0;
                }
                if (tem == 0)
                {
                    id = i;
                    break;
                }
            }
            return id;
        }
    }
}