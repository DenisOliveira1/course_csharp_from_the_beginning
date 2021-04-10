using System;
using System.Collections.Generic;
using System.Text;

namespace _5___Abstract_classes_and_interfaces
{
    //Em Java e C# Abstract tem ao menos um método abstract e Interface tem todos os métodos abstract
    abstract class AbstractPhone
    {

        abstract public void SwitchOn();
        abstract public void SwitchOff();
        abstract public void Call(string phoneNumber);

        public void getBrand() {
            Console.WriteLine("Xiaomi");
        }
        
    }

    class MyPhone : AbstractPhone
    {
        private bool isOn = false;

        public override void Call(string phoneNumber)
        {
            if (isOn)
            {
                Console.WriteLine("Calling... " + phoneNumber);
            }
            else
            {
                Console.WriteLine("Phone is off! Cannot call!");
            }
        }

        public override void SwitchOff()
        {
            if (!isOn)
            {
                Console.WriteLine("Phone is already off!");
            }
            else
            {
                isOn = !isOn;
                Console.WriteLine("Phone is off!");
            }
        }

        public override void SwitchOn()
        {
            if (isOn)
            {
                Console.WriteLine("Phone is already on!");
            }
            else
            {
                isOn = !isOn;
                Console.WriteLine("Phone is on!");
            }
        }
        public void getStatus()
        {
            Console.WriteLine(isOn ? "On" : "Off");
        }
    }
}
