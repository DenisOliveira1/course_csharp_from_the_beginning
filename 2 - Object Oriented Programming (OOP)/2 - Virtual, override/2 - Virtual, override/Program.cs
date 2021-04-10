using System;

namespace _2___Virtual__override
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a, b;
            Dog c;

            Console.WriteLine("Animal - Animal");
            b = new Animal();
            b.Voice1();//Animal
            b.Voice2();//Animal
            Console.WriteLine("--------------------------");

            Console.WriteLine("Animal - Dog");
            a = new Dog();
            a.Voice1();//Animal, pois é do tipo Animal. Sem nada funciona como o new
            a.Voice2();//Dog, por causa do virtual/override
            Console.WriteLine("-------------");

            Console.WriteLine("Dog - Dog");
            c = new Dog();
            c.Voice1();//Dog, pois é do tipo Dog
            c.Voice2();//Dog, pois é do tipo Dog
            Console.WriteLine("------------- new");

            Base ba = new Derived();
            Derived de = new Derived();

            Console.WriteLine("Base - Derived");
            ba.DoIt(); // Calls Base.DoIt
            Console.WriteLine("-------------");
            Console.WriteLine("Derived - Derived");
            de.DoIt(); // Calls Derived.DoIt

            // new faz
        }
    }

    class Animal {
        public Animal() { 
        }

        public void Voice1() {
            Console.WriteLine("Undefined1");
        }

        public virtual void Voice2()
        {
            Console.WriteLine("Undefined2 - virtual");
        }
    }

    //Sealed faz com que a classe nunca possa ser herdada por outra classe, x : Dog
    //Classes Sealed não podem ter métodos virtuais
    sealed class Dog : Animal
    {
        public Dog()
        {
        }

        public void Voice1()
        {
            Console.WriteLine("Woof1");
        }

        public override void Voice2()
        {
            Console.WriteLine("Woof2 - override");
        }
    }

    public class Base
    {
        public virtual void DoIt()
        {
            Console.WriteLine("Base.DoIt");
        }
    }

    public class Derived : Base
    {
        public new void DoIt()
        {
            Console.WriteLine("Derived.DoIt");
        }
    }
}
