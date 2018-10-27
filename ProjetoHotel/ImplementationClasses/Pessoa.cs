using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel
{
    class Pessoa
    {
        //nome
        private string nome;
        //sobrenome
        private string ultimoSobrenome;
        //Numero de telefone
        private int numero;
        private string endereco;
        private int quarto;
        private int id;

        public Pessoa(string nome, string ultimoSobrenome, int numero, string endereco)
        {
            setNome(nome);
            setUltimoSobrenome(ultimoSobrenome);
            setNumero(numero);
            setEndereco(endereco);
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setUltimoSobrenome(string ultimoSobrenome)
        {
            this.ultimoSobrenome = ultimoSobrenome;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public void setQuarto(int quarto)
        {
            this.quarto = quarto;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getNome()
        {
            return nome;
        }
        public string getUltimoSobrenome()
        {
            return ultimoSobrenome;
        }
        public int getNumero()
        {
            return numero;
        }
        public string getEndereco()
        {
            return endereco;
        }
        public int getQuarto()
        {
            return quarto;
        }
        public int getId()
        {
            return id;
        }
    }
}
