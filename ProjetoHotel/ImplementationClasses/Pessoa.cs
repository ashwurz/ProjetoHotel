using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel
{
    public class Pessoa
    {
        private string nome;
        private string ultimoSobrenome;
        private int numero;
        private string endereco;
        private int quarto;
        private int id;
        private int tempo;
        private string plano;
        private int familia;
        private string[] nomes = new string[5]; // cabem no maximo 6 pessoas em um unico quarto.

        public Pessoa(string nome, string ultimoSobrenome, int numero, string endereco, int familia)
        {
            setNome(nome);
            setUltimoSobrenome(ultimoSobrenome);
            setNumero(numero);
            setEndereco(endereco);
            setFamilia(familia);
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
        public void setFamilia(int familia)
        {
            this.familia = familia;
        }
        public void setNomes(string nomes, int i)
        {
            this.nomes[i] = nomes;
        }
        public void setPlano(string plano)
        {
            this.plano = plano;
        }
        public void setTempo(int tempo)
        {
            this.tempo = tempo;
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
        public int getFamilia()
        {
            return familia;
        }
        public string getNomes(int i)
        {
            if(nomes[i] != null)
            {
                return nomes[i];
            }
            return "";
        }
        public string getPlano()
        {
            return plano;
        }
        public int getTempo()
        {
            return tempo;
        }
    }
}