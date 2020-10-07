using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    public class Funcionario
    {
        private string nome;
        private string sobrenome;
        private string email;
        private int idade;

        public Funcionario() //construtor default
        {

        }

        public Funcionario(string nome, string sobrenome, string email, int idade) //overloading
        {
            this.nome = nome;
            this.Sobrenome = sobrenome;
            this.Email = email;
            this.Idade = idade;
        }

        //setters e getters --> método acessores!
        public void SetNome(string nome) //setter
        { 
            if(nome.Length > 30)
            {
                Console.WriteLine("O nome deve ter no máximo 30 caracteres");
            } else
            {
                this.nome = nome;
            }
            
        }

        public string GetNome() //getter
        { return nome; }

        //Lambda
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Email { get => email; set => email = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}
