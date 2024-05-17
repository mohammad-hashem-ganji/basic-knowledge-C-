using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicKnowledge
{
    public class Variable
    {
        // Expilit type
        int number = 10;
        string name = "Mohammad hashem";

        // Implicit type
        // var a = 10; Severity	Code => error CS0825  The contextual keyword 'var'
        // may only appear within a local variable declaration or in script code
        // The main limit is that C# only lets you use var for local variables
        // (inside a function).
        // My class members must have explicit types
        // It is not allowed to use var as a field type in class level.
        public void Myfunction()
        {
            var a = 1; // I can use implicit type in function
        }
        // var ivalue = 20, a = 30; => invalid
        //  var value = null;   =>  invalid
    }
}
