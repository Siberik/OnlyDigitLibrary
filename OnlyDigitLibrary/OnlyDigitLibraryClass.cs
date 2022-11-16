using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyDigitLibrary
{
    public class OnlyDigitLibraryClass
    {
        /// <summary>
        /// Возвращение списка всех цифр, подходящих условиям
        /// </summary>
        /// <param name="textString">
        /// Текстовая переменная со всеми цифрами
        /// </param>
        /// <returns>
        /// Возвращает отсортированный список
        /// </returns>
        public static List<char> GetDigit(string textString)
        {
            var text = textString.Split(' ');
            var text2 = Array.ConvertAll(text, s => int.Parse(s)).Where(x => (x==5));
            text2 = text2.ToArray();
           var arr=text2.OfType<int>().ToList();
            var arr2=arr.OfType<char>().ToList();
            List<char> result=new List<char>(arr2);
           var res= result.Distinct().OrderBy(x => x).ToList();
            return res;
            

            

        }
    }
}
