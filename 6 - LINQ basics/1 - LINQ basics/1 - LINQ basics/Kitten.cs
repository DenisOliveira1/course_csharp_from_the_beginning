using System;

namespace deferredExecutionExample
{
    /// <summary>
    /// This class defines main attributes for kittens
    /// </summary>
    class Kitten
    {
        public enum KitGender
        {
            MALE,
            FEMALE
        }

        public Kitten( float age, KitGender gender, string color, string name )
        {
            Age = age;
            Gender = gender;
            Color = color;
            Name = name;
        }

        /// <summary>
        /// Age in mounths
        /// </summary>
        public float Age { get; private set; }
        public KitGender Gender { get; private set; }
        public string Color { get; private set; }
        public string Name { get; private set; }

        /// <summary>
        /// Outputs an info about a kitten j a readable form
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return String.Format("Name: {0} Gender: {1} Age: {2} Color: {3}",
                Name, Gender, Age, Color);
        }
    }
}
