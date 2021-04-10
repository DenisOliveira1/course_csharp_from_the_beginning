using System;

namespace _4___Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classes
            //Pais e filhos se convertem, porém irmãos não (Polimorfismo)

            Animal a1;
            Tiger t1;

            //Implicit casting
            t1 = new Tiger();
            a1 = t1;

            Animal a2;
            Tiger t2;
            //Explicit casting
            t2 = new Tiger();
            a2 = (Animal)t2;

            //Variáveis
            int a = int.Parse("100");
            string b = Convert.ToString(a);
            double c = (double)a;
            int d = (int)c;
        }
    }

    class Animal{
    }

    class Tiger : Animal { 
    }
}
