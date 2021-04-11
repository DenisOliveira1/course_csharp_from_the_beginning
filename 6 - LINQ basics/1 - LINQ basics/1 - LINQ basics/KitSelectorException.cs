using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deferredExecutionExample
{
    /// <summary>
    /// A class, that provides a special type of exceptions for KitSelector class
    /// </summary>
    [Serializable]
    class KitSelectorException : Exception
    {
        public KitSelectorException(string message) : base(message)
        {

        }
    }
}
