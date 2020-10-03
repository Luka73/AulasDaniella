using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Entities
{
    public class Calculos
    {
        public int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public double Soma(double n1, double n2) //assinatura
        {
            return n1 + n2;
        }

        //overloading --> sobrecarga
        public int Soma(int n1, int n2, int n3) //assinatura
        { //scope
            return n1 + n2 + n3;
        }
    }
}
