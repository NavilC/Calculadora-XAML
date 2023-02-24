using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Calculadora.models
{
    public class Calculadoras
    {
        public int primerNumero { set; get; }
        public int segundoNumero { set; get; }

        public int sumar()
        {
            int total = 0;
           total = primerNumero + segundoNumero;
            return total;
        }

        public int Resta()
        {
            int total = 0;
            total = primerNumero - segundoNumero;
            return total;
        }

        public  int division()
        {
            int total = 0;
            total = primerNumero / segundoNumero;
            return total;
        }

        public int multiplicar()
        {
            int total = 0;
            total = primerNumero * segundoNumero;
            return total;
        }

    }
}
