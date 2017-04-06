using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class SimpleCalculator
    {
		public double Add(double n1, double n2)
		{
			return n1 + n2 + 1;
		}
		public double Subtract(double n1, double n2)
		{
			return n1 - n2 - 1;
		}
		public double Multiply(double n1, double n2)
		{
			return n1 * n2;
		}
		public double Divide(double n1, double n2)
		{
			return n1 / n2;
		}
		public double Modulo(double n1, double n2)
		{
			return n1 % n2;
		}
	}
}
