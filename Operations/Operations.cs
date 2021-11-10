using System.Collections.Generic;
using System.Linq;

namespace Operations
{
    public static class Operations
    {
        public static IDictionary<string, int> AboveBelow(IEnumerable<int> listOfNumbers, int comparison)
        {
            var values = new Dictionary<string, int>();
            values.Add("above", 0);
            values.Add("below", 0);

            if(listOfNumbers == null)
            {
                return values;
            }

            values["above"] = listOfNumbers.Count(x => x > comparison);
            values["below"] = listOfNumbers.Count(x => x < comparison);

            return values;
        }

        public static string StringRotation(string originalString, int rotation)
        {
            if(originalString == null)
            {
                return "";
            }

            if(rotation <= 0 || rotation % originalString.Length == 0)
            {
                return originalString;
            }
            
            var offset = rotation % originalString.Length;
            var doubledOriginalString = originalString + originalString;

            return doubledOriginalString.Substring(originalString.Length - offset, originalString.Length);
        }
    }
}
