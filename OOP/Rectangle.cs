using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList;

namespace OOP
{
    public class Rectangle
    {
        StaticCalculator.Add(1,2);

            //const fields are implicitly static
            public const int NumberOfSides = 4;

            //a static property, belonging to the class as a whole
            // static fields and properties are used when we need to share a single member between all
            //class instances .
            public static int CountOfInstances { get; private set; }
            //never use static fiels or property . it is bad practice and risky . I don't know why it is risky
            //a static field
            private static DateTime _firstUsed;

            //a static constructor
            static Rectangle()
            {
                _firstUsed = DateTime.Now;
            }

            public Rectangle(int width, int height)
            {
                Width = GetLengthOrDefault(width, nameof(Width));
                _height = GetLengthOrDefault(height, nameof(_height));
                ++CountOfInstances;
            }

            //readonly property - can only be set in the constructor
            public int Width { get; }

            //achieving a similar behavior as properties give with using methods
            private int _height;
            public int GetHeight() => _height;

            public void SetHeight(int value)
            {
                if (value > 0)
                {
                    _height = value;
                }
            }

            private int GetLengthOrDefault(int length, string name)
            {
                const int defaultValueIfNonPositive = 1;
                if (length <= 0)
                {
                    Console.WriteLine($"{name} must be a positive number.");
                    return defaultValueIfNonPositive;
                }
                return length;
            }

            //expression-bodied methods
            //could not be made static as they use the state of an instance (width and height)
            public int CalculateCircumference() => 2 * Width + 2 * _height;

            public int CalculateArea() => Width * _height;

            //a get-only, expression-bodied property
            //properties should never be performance heavy
            //don't use computed properties
            public string Description => $"A rectangle with width {Width} " +
                $"and height {_height}";

            //a static method, not using any state of an instance
            public static string DescribeGenerally() =>
                $"A plane figure with four straight sides and four right angles.";
        //Compile time errore
        //public static string DescribeGenerallyWithFields() => $"Sides are : {Width}, {_height} {CalculateArea}";
        //An object reference is required for the non-static field, method, or property 'member'

        //can be made static
        public string NotUsingAnyState() => "abc";
        


    }
}
