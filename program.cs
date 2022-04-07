using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class Numbers
    {
        private int x, y;
        public int FindMinimum(int number1,int number2)
        {
            return number1 < number2 ? number1 : number2;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            x = number1 < number3 ? number1 : (int)number3;
            y = number2 < number3 ? number2 : (int)number3;
            return number1 < number2 ? x : y;
        }
        public int FindMaximum(int number1, int number2)
        {
            return number1 < number2 ? number2 : number1;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            x = number1 < number3 ? (int)number3 : number1;
            y = number2 < number3 ? (int)number3 : (int)number2;
            return number1 < number2 ? y : x;
        }
    }
}
