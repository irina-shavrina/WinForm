using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormsApp1.Data;

namespace WinFormsApp1.Tools
{
    static class DataTool
    {
        static public void ExtractNumbersFromString(string input)
        {
                IEnumerable<int> result = input.Split(' ').Select(i => Convert.ToInt32(i));
                StaticData.Data = result;
                StaticData.Input = input;
        }
        static public void GetResult(string input)
        {
            StaticData.InputResult = input;
        }
    }

}
