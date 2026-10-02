using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    // Q6
    internal class Engineer : Person
    {

        public string Field { get; set; }
        public int YearsOfExperience { get; set; }

        public new void Greet()
        {
            Console.WriteLine("I am an Engineer.");
        }

        public override void Display()
        {
            Console.WriteLine(
                $"ID = {ID}, Name = {Name}, Age = {Age}, " +
                $"Field = {Field}, YearsOfExperience = {YearsOfExperience}"
            );
        }
    }
}
