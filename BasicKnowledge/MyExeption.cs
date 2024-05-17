using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicKnowledge
{
    // If there is an issue that the application can't manage 
    // an exeption is thrown
    public class MyExeption
    {
        public void Myexeption()
        {
            bool isParsingSuccessful;
            do
            {
                Console.WriteLine("provide a number .");
                isParsingSuccessful = int.TryParse(
                    Console.ReadLine(), out int number);
                Console.WriteLine((isParsingSuccessful) ? $"parsing worked , number is : {number}" : "parsing was not successful");
            } while (!isParsingSuccessful);
            

        }
    }
}
