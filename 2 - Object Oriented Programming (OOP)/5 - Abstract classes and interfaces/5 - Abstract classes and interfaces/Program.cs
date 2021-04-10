using System;

namespace _5___Abstract_classes_and_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract
            MyPhone mp = new MyPhone();

            mp.getBrand();
            mp.getStatus();
            mp.Call("123");
            mp.SwitchOn();
            mp.getStatus();
            mp.Call("123");
            mp.SwitchOff();

            //Interface
        }
    }
}
