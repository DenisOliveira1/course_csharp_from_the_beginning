using System;
using System.Collections.Generic;

namespace _1___Object_Oriented_Programming__OOP_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Encapsulation");

            // Encapsulation
            Rectangle2 r = new Rectangle2();
            r.Acceptdetails();
            r.Display();
            r.Width = 5;
            r.Length = 5;
            r.Display();
            r.setWidth(6);
            r.setLength(6);
            r.Display();


            Console.WriteLine("----------------------");
            Console.WriteLine("Polymorphism");

            // Polymorphism
            var shapes = new List<Shape>{
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            //Inheritance
            // Create an instance of WorkItem by using the constructor in the
            // base class that takes three arguments.
            WorkItem item = new WorkItem("Fix Bugs",
                                        "Fix all bugs in my code branch",
                                        new TimeSpan(3, 4, 0, 0));

            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.
            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                    "Add members to the class",
                                                    new TimeSpan(4, 0, 0),
                                                    1);

            // Use the ToString method defined in WorkItem.
            Console.WriteLine(item.ToString());

            // Use the inherited Update method to change the title of the
            // ChangeRequest object.
            change.Update("Change the Design of the Base Class",
                new TimeSpan(4, 0, 0));

            // ChangeRequest inherits WorkItem's override of ToString.
            Console.WriteLine(change.ToString());
            /* Output:
                1 - Fix Bugs
                2 - Change the Design of the Base Class
            */

        }
    }
}
