using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.Email = "luana@gmailcom";
            f1.SetNome("Luana"); //set --> setter
            f1.Sobrenome = "Fernandes"; // método setter

            Console.WriteLine("Email do Funcionario: " + f1.Email);
            Console.WriteLine("Nome do Funcionario: " + f1.GetNome()); //get --> getter
            Console.WriteLine("Sobrenome do Funcionario: " + f1.Sobrenome); //método getter
        }
    }
}
