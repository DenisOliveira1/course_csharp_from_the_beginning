using System;

namespace _5___Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            string color;

            Console.WriteLine("Escreva uma cor!");
            color = Console.ReadLine();

            if (color.ToLower().Equals("azul")){
                Console.WriteLine("O céu está normal!");
            }
            else if (color.ToLower().Equals("vermelho")){
                Console.WriteLine("O céu está assustador!");
            }
            else{
                Console.WriteLine("O céu está diferente!");
            }

            switch (color) {
                case "azul":
                    Console.WriteLine("Bonito!");
                    break;
                case "vermelho":
                    Console.WriteLine("Assustador!");
                    break;
                default:
                    Console.WriteLine("Diferente!");
                    break;
            }

        }
    }


}
