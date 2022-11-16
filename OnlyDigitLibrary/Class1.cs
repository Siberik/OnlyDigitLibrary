using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyDigitLibrary
{
    public class Class1
    {
        public static List<char> GetDigit(string textString)
        {
            var text = textString.Split(' ');
            var text2 = Array.ConvertAll(text, s => int.Parse(s));
            text2 = text2.Where(x => x > 5).ToArray();
           List<int> arr=text2.OfType<int>().ToList();
            arr.Distinct().OrderBy(x => x);

            

        }
    }
}
