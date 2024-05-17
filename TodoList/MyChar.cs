using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class MyChar
    {
        char ConvertPointToGrade(int points)
        {
            switch (points)
            {
                case 10:
                case 9:
                    return 'A';
                case 8:
                case 7:
                case 6:
                    return 'B';
                case 5:                
                case 4:
                case 3:
                    return 'C';
                case 2:
                case 1:
                    return 'D';
                case 0:
                    return 'E';
                default:
                    return '!';
                    break;
            }
        }
    }
}
