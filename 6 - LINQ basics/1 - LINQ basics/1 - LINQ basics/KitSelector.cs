using System;
using System.Collections.Generic;
using System.Linq;

namespace deferredExecutionExample
{
    class KitSelector
    {
        private List<Kitten> kittens = null; // a collection of kittens

        public KitSelector(List<Kitten> inputKittens)
        {
            Init(inputKittens);  
        }

        /// <summary>
        /// Initializaion
        /// </summary>
        /// <param name="inputKittens"></param>
        public void Init(List<Kitten> inputKittens)
        {
            // checking an input data...
            if (inputKittens == null)
                throw new KitSelectorException("No collection on input!");

            kittens = inputKittens;
        }

        /// <summary>
        /// Returns an IEnumerable object, that after enumeration
        /// will give us all kittens with age between (ageFrom and ageTo)
        /// </summary>
        /// <param name="ageFrom"></param>
        /// <param name="ageTo"></param>
        /// <returns></returns>
        public IEnumerable<Kitten> SelectByAge( float ageFrom, float ageTo )
        {
            IEnumerable<Kitten> query = from kit in kittens
                                        where kit.Age >= ageFrom &&
                                        kit.Age <= ageTo
                                        select kit; // No execution here!

            return query;
        }

        /// <summary>
        /// Returns an IEnumerable object, that after enumeration
        /// will give us all kittens with a given gender
        /// </summary>
        /// <param name="gender">MALE/FEMALE</param>
        /// <returns></returns>
        public IEnumerable<Kitten> SelectByGender(Kitten.KitGender gender)
        {
            IEnumerable<Kitten> query = from kit in kittens
                                        where kit.Gender == gender
                                        select kit; // No execution here!

            return query;
        }
        
        /// <summary>
        /// Returns an IEnumerable object, that after enumeration
        /// will give us all kittens with a given color
        /// </summary>
        /// <param name="color">A color</param>
        /// <returns></returns>
        public IEnumerable<Kitten> SelectByColor(string color)
        {
            IEnumerable<Kitten> query = from kit in kittens
                                        where kit.Color.ToLower() == color.ToLower()
                                        select kit; // No execution here!

            return query;
        }
    }
}
