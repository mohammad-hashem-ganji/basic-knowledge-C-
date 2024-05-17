using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicKnowledge
{
    public class Scope
    {
        string input = Console.ReadLine();
        //        if (input.length == 0) 
        //Error CS1519  Invalid token 'if' in class, record, struct, or interface
        //member declaration BasicKnowledge  .
        public void Myfunction()
        {
            if (input.Length == 0)
            {
                Console.WriteLine("The input is empity !");
                var number = 10;
                var word = "ABCD";
                if (word.Length >3)
                {
                    Console.WriteLine(word);
                    Console.WriteLine(input); // it doesn't have a problem. .
                }
            }
            else
            {
                Console.WriteLine($"non-input choice{input}");
                // number = 11; => It is not in the else scope (block)
                //Error CS0103  The name 'number' does not exist in the current
                //context BasicKnowledge  
                var number = 12; // it does not have an error !!
            }
        }
    }
}

