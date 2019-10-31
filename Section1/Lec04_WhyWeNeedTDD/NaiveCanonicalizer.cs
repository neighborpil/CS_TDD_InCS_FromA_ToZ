using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lec04_WhyWeNeedTDD
{
    public class NaiveCanonicalizer
    {
        public static string GetCanonicalForm(String searchTerm)
        {
            if (searchTerm == null)
            {
                throw new ArgumentNullException("searchTerm");
            }
            return searchTerm.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToUpper())
                .OrderBy(x => x)
                .Aggregate("", (x, y) => x + " " + y)
                .Trim();
        }
    }
}