using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator
{
    public class Calculator
    {
        public int Add(string text)
        {
            int total = 0;
            if (text != "")
            {
                string[] parts = text.Split(',', '\n'); // ["123", "10"]
                foreach (string part in parts)
                {
                    int num = int.Parse(part);
                    if (num < 0) throw new Exception("Negative numbers not allowed");
                    total = total + num;
                }
            }
            return total;
        }

        public int Divide(String n1)
        {
            int result = -9999;
            char separator = ',';
            // if doesn't contain a comma call this
            if (!n1.Contains(","))
                separator = Utils.ValidSeperator(n1);    // slows down test
            String[] numbers = n1.Split(separator);
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) / Utils.ToNumber(numbers[1]);
            return result;
        }

        public int Multiply(String n1)
        {
            int result = -9999;
            String[] numbers = n1.Split(',');
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) * Utils.ToNumber(numbers[1]);
            return result;
        }

        public int Subtract(String n1)
        {
            int result = -9999;

            String[] numbers = n1.Split(',');
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) - Utils.ToNumber(numbers[1]);
            return result;
        }
    }
}
