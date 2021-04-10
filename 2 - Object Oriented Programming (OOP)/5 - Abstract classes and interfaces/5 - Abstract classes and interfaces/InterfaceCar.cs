using System;
using System.Collections.Generic;
using System.Text;

namespace _5___Abstract_classes_and_interfaces
{
    interface ICar
    {
        void Start();
        void Stop();

    }

    class myCart : ICar
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
