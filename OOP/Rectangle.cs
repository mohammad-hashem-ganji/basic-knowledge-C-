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
        public static int NumberOfInstances { get; private set; }
        private static DateTime _firstUsed;
        // readonly fields can also be assigned in the constructor or at the declaration.
        // making it useful for defining constants or values that should not change after an object is created.
        // # this is declaration phase #
        //public readonly int Width;
        //private int _height;
        // what if I want to make it possible to assign these to fields again, at least inside the Rectangle class?
        // I want to some Way to make those fields public for reading , but private for writing.( khodet test kon readonly biron az class chejori
        // mishe.
        // another way insted of readonly. => 108
        //public Rectangle(int width, int height)
        //{
        //    Width = GetLengthOrDefault(width, nameof(Width));
        //    _height = GetLengthOrDefault(height, nameof(_height));
        //    ++NumberOfInstances ;
        //}

        //public int GetHeight() => _height;

        //public void SetHeight(int value)
        //{
        //    if (value >0)
        //    {
        //        _height = value;
        //    }
        //}
        //private int _width; // it is a backing field
        //// the property doesn't do anything more than getting or setting the value of backing field
        //public int Width
        //{
        //    // get and set are accessors (check the spell!)
        //    get
        //    {
        //        return _width;
        //    }
        //    private set
        //    {// I can set Width just in the current class.
        //        if (value > 0)
        //        {
        //            _width = value;

        //        }
        //    }
        //    // the role of getter and setter is the same as GetHeight and SetHeight .
        //}
        public int Width { get; private set; } // the compiler translate this line to the code that I wrote above .
        // also generating the backing field.
        // scince the backing field is generated behind the scense and not declarated explicitly so I can't use the backing 
        // field here anymore.
        private int _height;
        private int GetLengthOrDefault(int length, string name)
        {
            const int DefaultValueIfNonPositive = 1;
            if (length <= 0)
            {
                Console.WriteLine($"{name} must be positive number.");
                return DefaultValueIfNonPositive;
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

        //public int CalculateCircumference() => 2 * Width + 2 * _height;
        //public int CalculateArea() => Width * _height;
        public string Description => $"A rectangle with width {Width}" +
            $"and height{_height}";
        public string LongDescription
        {
            get
            {
                var result = "";
                for (int i = 0; i < 1000; ++i)
                {
                    result += i;
                }
                return result;
            }// **** Role => Properties should be performanced-heavy
            // in run time if have an error it is difficault to handle it . this property is complex and slow
        }
        public static string DescribeGenerally() =>
            $"this is a rectangle .";
        public const int NumberOfFields = 4; // all const fields are implicitly static .


    }
}
