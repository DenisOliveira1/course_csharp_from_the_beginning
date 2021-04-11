using System;

namespace _1___Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tenta fazer algo
            try
            {
                Console.WriteLine(Divide(10, 0));
            }
            //Se o try gerar um erro executa o catch
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Stactrace: " + ex.StackTrace);
            }
            //Executa dando erro ou não
            finally {
                Console.WriteLine("Fim");
            }
        }

        static double Divide(double a, double b) {
            if (b == 0) throw new Exception("b is qual to 0");
            return a /b;
        }
    }
}
