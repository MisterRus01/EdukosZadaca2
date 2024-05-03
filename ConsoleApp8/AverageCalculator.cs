using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class AverageCalculator
    {
        List<double> ExtractAverages(List<double[]> numbers)
        {
            List<double> averages = new List<double>();
            foreach (double[] number in numbers)
            {
                averages.Add(CalculateAverage(number));
            }
            return averages;
        }
        double CalculateAverage(double[] number)
        {
            double average = 0;
            for (int index = 0; index < number.Length; index++)
            {
                average += number[index];
            }
            return average / number.Length;
        }
    }
}
