using System;
using System.Collections.Generic;
using System.Text;

namespace _6___This_and_Base
{
    class Animal
    {
        public string name;

        public Animal()
        {
            this.name = "Bilu";
        }

        public Animal(string name) {
            this.name = name;
        }

        public virtual void Voice() {
            Console.WriteLine("Undefined");
        }
    }

    class Dog : Animal
    {
        public Dog() : base("Nick")
        {
        }

        public Dog(string name) : base("Joey")
        {
        }

        public override void Voice()
        {
            //Acessa função do pai
            base.Voice();
            Console.WriteLine("Woof");
        }
    }
}
