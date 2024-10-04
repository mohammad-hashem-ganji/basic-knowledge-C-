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
        public int Width;
        public int Height;
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
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
        public const int NumberOfSides = 4;

        //a static property, belonging to the class as a whole
        // static fields and properties are used when we need to share a single member between all
        //class instances .

        public int CalculateCircumference() => 2 * Width + 2 * Height;
        public int CalculateArea() => Width * Height;




    }
}
