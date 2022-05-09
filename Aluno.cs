using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao2
{
    public class Aluno
    {

        public Aluno(string nome, string cpf, int idade, string telefone, string serie, string endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.telefone = telefone;
            this.serie = serie; 
            this.endereco = endereco;
            this.cpf = cpf;
        }

        public Aluno()
        {

        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }


        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string serie;

        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

    }
}
