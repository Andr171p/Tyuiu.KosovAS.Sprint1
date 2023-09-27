using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KosovAS.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            if (x >= 1 | x <= -1)
            {
                return (double)Math.Round(Math.Sin(Math.Abs(x)) + (Math.Cos(x * x) / (3 * x * x * x)) - Math.Sin(Math.Sqrt(x * x - 1)), 3);
            }
            else
            {
                return 444;
            }

            
            
            
            
        }
    }
}
