using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationLibrary
{

        public class Calculator
        {
            public int add(int a, int b)
            {
                return a + b;
            }

            public int subtract(int a, int b)
            {
                return a - b;
            }

            public int multiply(int a, int b)
            {
                return a * b;
            }

            public int divide(int a, int b)
            {
                if (b == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");
                return a / b;
            }

            public bool isEven(int number)
            {
                return number % 2 == 0;
            }
        }
    

}
