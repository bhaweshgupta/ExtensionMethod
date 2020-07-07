using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {


            string str = "hello world";
            //string result = str.ChangeFirstLetterCase();
            string result=StringHelper.ChangeFirstLetterCase(str);
            string newresult = str.ChangeFirstLetterCase();

          //  Console.WriteLine(result);
        //    Console.WriteLine(newresult);



            List<int> number = new List<int> { 1, 2, 3,4,5};
            IEnumerable<int> s=number.Where(n => n % 2 == 0);
            //this can be written as
            IEnumerable<int> ss=Enumerable.Where(number,n => n % 2 == 0);



            foreach(var i in s)
                Console.WriteLine(i);

            var x=number.Select(n => n > 2);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

        }
    }
}
