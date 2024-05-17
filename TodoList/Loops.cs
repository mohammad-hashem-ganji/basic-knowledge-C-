using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class Loops
    {
        // initialize
        string userinput;
        public void MyDoWhile()
        {
            do
            {
                Console.WriteLine("Enter a leter longer than 10 .");
                userinput = Console.ReadLine();
            } while (userinput.Length <= 10);
            Console.WriteLine("The loop is finished");
            Console.ReadKey();
        }
        public void MyForLoop()
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine($"i is : {i}");
            }
        }
        public void Mybreake()
        {
            int userNumber;
            do
            {
                Console.WriteLine("Enter a number larger than 10");
                var userInput = Console.ReadLine();
                if (userinput == "stop")
                {
                    break;
                }
                bool isparsableToInt = userInput.All(char.IsDigit);
                if (!isparsableToInt)
                {
                    userNumber = 0;
                    continue;
                }

                userNumber = int.Parse(userInput);
            } while (userNumber <= 10);
            Console.WriteLine("The loop is finished .");
            Console.ReadKey();
        }
    }
}
