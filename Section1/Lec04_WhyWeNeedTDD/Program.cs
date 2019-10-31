using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec04_WhyWeNeedTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            string empty = NaiveCanonicalizer.GetCanonicalForm("");
            Console.WriteLine(empty == "");
            empty = NaiveCanonicalizer.GetCanonicalForm(" ");
            Console.WriteLine(empty == " ");
            empty = NaiveCanonicalizer.GetCanonicalForm(" ");
            Console.WriteLine(empty == "       ");

            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("    ABC Song Martine Luther King      "));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("ABC Song          Luther KinG Martine"));

            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("ABC Song Martine Luther King"));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("ABC Song Luther KinG Martine"));
            Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Song Martine luther ABC King"));

            Console.ReadKey();
        }
    }
}
