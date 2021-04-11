using System;

namespace _2___Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass d = new DemoClass();
            d.Demo();
        }
    }

    public class DemoClass {
        public string Demo()
        {
            try
            {
                Console.WriteLine("Demo(): try");
                throw new Exception("Error!"); //Gera um erro forçando rodar o catch
            }
            catch (Exception ex) {
                Console.WriteLine("Demo(): catch");
            }
            finally
            {
                Console.WriteLine("Demo(): finally");
            }

            return string.Empty;
        }
    }
}
