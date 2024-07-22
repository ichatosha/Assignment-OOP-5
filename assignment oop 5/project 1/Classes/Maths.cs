using assignment_oop_5.project_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_5.project_1.Classes
{
    internal class Maths : IMaths
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public double Divide(int a, int b) => b != 0 ? (double)a / b : throw new DivideByZeroException();
    }
}
