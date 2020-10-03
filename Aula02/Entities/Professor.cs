using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Entities
{
    public class Professor
    {
        public string nome; // atributo 
        public int idade;
        public string disciplina;
        public string endereco;

        public void MostraDadosNaTela()
        {
            Console.WriteLine("O nome do professor é: " + nome);
            Console.WriteLine("O idade do professor é: " + idade);
            Console.WriteLine("O disciplina do professor é: " + disciplina);
            Console.WriteLine("O endereco do professor é: " + endereco);
        }
    }
}
