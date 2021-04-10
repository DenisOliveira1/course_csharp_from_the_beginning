using System;
using System.Collections.Generic;
using System.Text;

namespace _1___How_to_create_a_generic_class
{
    class GenericQueue<T>
    {
        private T[] array = null;

        public GenericQueue()
        {
            //Iniciasliza o Array com o tipo tamanho 0
            array = new T[0];
        }

        public void Push(T element) {
            if (element == null) return;

            Array.Resize<T>(ref array, array.Length + 1);
            array[array.Length - 1] = element;
        }

        public T Pop() {
            //Default retorna o valor padrão de um tipo, para T[]~é null
            if (array.Length == 0) return default(T);

            var lastElement = array[array.Length - 1];
            Array.Resize<T>(ref array, array.Length - 1);
            return lastElement;
        }

    }
}
