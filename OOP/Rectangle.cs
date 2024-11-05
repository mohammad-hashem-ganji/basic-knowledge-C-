using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TodoList;

namespace OOP
{
    public class Rectangle
    {
        const int NumberOfSides = 4;// the naming of const variables start with capital letter. either public or private
        // consts must bee assigned a value at declaration;
        // consts must bee assigned compile-time constant value
        readonly int NumberOfSidesReadonly = 4;
        // readonly fields can also be assigned in the constructor
        // making it useful for defining constants or values that should not change after an object is created.
        public readonly int Width;
        public readonly int Height;
        // what if I want to make it possible to assign these to fields again, at least inside the Rectangle class?
        // I want to some Way to make those fields public for reading , but private for writing.( khodet test kon readonly biron az class chejori
        // mishe.
        // another way insted of readonly. => 108
        public Rectangle(int width, int height)
        {
            Width = GetLengthOrDefault(width, nameof(Width));
            Height = GetLengthOrDefault(height, nameof(Height));
        }

        private int GetLengthOrDefault(int length, string name)
        {
            const  int defaultValueIfNonPositive = 1;
            if (length <= 0)
            {
                Console.WriteLine($"{name} must be positive number.");
                return defaultValueIfNonPositive;
            }
            return length;
        }




        // Some notes for data hiding ****
        public void DataHiding() // this method is just for using the note of data hiding
        {
            List<int> numbers = new List<int> { 1, 3, 4 };
            int count = numbers.Count; //public for getting
                                       //numbers.Count = 6; private for setting

        }
        // StaticCalculator.Add(1,2);
        public int PublicThing;
        private int _privatThing;
        //const fields are implicitly static
        

        //a static property, belonging to the class as a whole
        // static fields and properties are used when we need to share a single member between all
        //class instances .

        public int CalculateCircumference() => 2 * Width + 2 * Height;
        public int CalculateArea() => Width * Height;




    }
}
