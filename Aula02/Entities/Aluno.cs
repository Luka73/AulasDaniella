using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Entities
{
    public class Aluno //abstracao
    {
        public string nome; // atributo 
        public int idade;
        public string matricula;
        public string endereco;

        public Aluno() //construtor default
        {

        }

        public Aluno(string nome, int idade, string matricula, string endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.matricula = matricula;
            this.endereco = endereco;
            this.MostraDadosNaTela();
        }

        public void MostraDadosNaTela()
        {   //escopo
            Console.WriteLine("O nome do aluno é: " + nome);
            Console.WriteLine("O idade do aluno é: " + idade);
            Console.WriteLine("O matricula do aluno é: " + matricula);
            Console.WriteLine("O endereco do aluno é: " + endereco);
        }

        public double CalculaMedia(double n1, double n2)
        {
            return (n1 + n2) / 2;
        }

        public double CalculaMediaPonderada(double n1, double n2, double p1, double p2)
        {
            return ((n1 * p1) + (n2 * p2)) / (p1 + p2);
        }
    }
}
