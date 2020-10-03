using Aula02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(); //objeto
            a1.nome = "Daniella"; //setter
            a1.idade = 30;
            a1.matricula = "12342";
            a1.endereco = "Rua x, 54";

            Aluno a2 = new Aluno("Thiago", 37, "291019", "Rua y, 98"); //objeto

            a1.MostraDadosNaTela(); //Daniella
            Console.WriteLine("****************************");
            Console.WriteLine("Média: " + a1.CalculaMedia(7.2, 4.2));
            Console.WriteLine("Média Ponderada: " + a1.CalculaMediaPonderada(5.2, 7.1, 2, 3));

            Console.WriteLine("****************************");

            Professor p1 = new Professor();
            p1.nome = "Pedro";
            p1.idade = 42;
            p1.disciplina = "Química";
            p1.endereco = "Rua z, 78";

            a1.MostraDadosNaTela(); //Daniella
            Console.WriteLine("****************************");
            a2.MostraDadosNaTela(); //Thiago
            Console.WriteLine("****************************");
            p1.MostraDadosNaTela(); //Pedro

            //Console.WriteLine("O nome do professor é: " + p1.nome); //getter
            Console.ReadKey();
        }
    }
}
