using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{

    public static class StaticCalculator
    {
        // زمانی که فقت عملیات در یک کلاس دارم بهتر است از استاتیک استفاده کنم
        //static classes can only contain static methods .
        //non-static classes can have static mehtods

        // statless(has no states - fields)

        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        //public void NonStaticMethod() { }
        //## compile time errore => cannot declare instance members in a static class
        //This error occurs if you declare a non-static member in a class that is declared static.
        //It is not possible to create instances of static classes,
        //so instance variables would not be meaningful.
        //The static keyword should be applied to all members of static classes.
        //----------------------------------------------------------------
        //if aprivate method doesn't use instance data , make it static
        //I didn't undrestnd the usage of private static .
    }
}
