using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormsApp1.Data;

namespace WinFormsApp1.Controller
{
    class CalculateController
    {
        public string Calculate(Operation operation)
        {
            return operation switch
            {
                Operation.Add => Add().ToString(),
                Operation.Divide => Divide().ToString(),
                Operation.Multiply => Multiply().ToString(),
                Operation.Subtract => Subtract().ToString()
            };
        }
        int Add()
        {
            int sum = StaticData.Data.Sum();
            return sum;
        }
        double Divide()
        {
            var dataAsList = StaticData.Data.ToList();
            double result = dataAsList[0];
            for (var index = 1; index < dataAsList.Count; ++index)
            {
                result /= (double)dataAsList[index];
            }
            return result;
        }
        int Multiply()
        {
            int mult = StaticData.Data.Aggregate((x, y) => x * y);
            return mult;
        }
        int Subtract()
        {
            int dif = StaticData.Data.Aggregate((x, y) => x - y);
            return dif;
        }
    }
}
