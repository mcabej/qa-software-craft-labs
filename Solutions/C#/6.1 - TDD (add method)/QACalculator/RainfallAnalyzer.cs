using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator
{
    public class RainfallAnalyzer
    {
        public double CalculateAverageRainfall(int[] readings)
        {
            double total = 0;
            int count = 0;
            foreach (int reading in readings)
            {
                if (reading >= 0)
                {
                    total = total + reading;
                    count++;
                }
            }
            return (count > 0) ? total / count : 0;
        }
    }
}
