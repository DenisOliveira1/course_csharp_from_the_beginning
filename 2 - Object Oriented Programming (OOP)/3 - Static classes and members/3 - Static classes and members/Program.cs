using System;

namespace _3___Static_classes_and_members
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;

            Console.WriteLine("count = " + Calculator.countContasFeitas);
            result = Calculator.Calcular(2, 3, '+');
            Console.WriteLine(result);
            Console.WriteLine("count = " + Calculator.countContasFeitas);
        }
    }

    //Classe Estática
    //Não pode ser instanciada
    //Ela é sealed: não pode ser herdada
    //Todos os atributos, métodos e construtores têm de ser estáticos
    static class Calculator
    {

        //Construtor Estático
        //Em toda classe estática, os atributos têm de ser estáticos
        //Sem parâmetros
        //Sem modificador de acesso
        public static int countContasFeitas;

        //Em toda classe estática, os métodos têm de ser estáticos
        public static int Calcular(int a, int b, char op)
        {
            countContasFeitas++;
            if (op.Equals('+')) return a + b;
            if (op.Equals('-')) return a - b;
            if (op.Equals('*')) return a * b;
            if (op.Equals('/')) return a / b;

            return 0;
        }
    }
}
