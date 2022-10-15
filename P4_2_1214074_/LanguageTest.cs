using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214074_
{
    internal class LanguageTest
    {
        static void Main(string[] args)
        {
            // Language myLang = new Language();
            //myLang.MyType = "OOP";

            //Console.WriteLine(myLang.MyType);

            Go myLang = new Go("Go", "OOP", "Statis");
            Java myLang1 = new Java("Java", "OOP", "Statis");
            JavaScript myLang2 = new JavaScript("JavaScript", "OOP", "Statis");


            Console.WriteLine("{0} adalah bahasa pemrograman {1} dan merupakan bahasa pemrograman yang {2}\n", myLang.MyType, myLang.MyTitle, myLang.PageCount);
            Console.WriteLine("{0} adalah bahasa pemrograman {1} dan merupakan bahasa pemrograman yang {2}\n", myLang1.MyType, myLang1.MyTitle, myLang1.PageCount);
            Console.WriteLine("{0} adalah bahasa pemrograman {1} dan merupakan bahasa pemrograman yang {2}\n", myLang2.MyType, myLang2.MyTitle, myLang2.PageCount);

        }
    }
}
