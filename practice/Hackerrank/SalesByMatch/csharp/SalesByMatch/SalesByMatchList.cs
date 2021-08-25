using System.Collections.Generic;
using System.Linq;

namespace SalesByMatch
{
    public class SalesByMatchList : ISockMerchant
    {
        public int SockMerchant(int[] socks)
        {
            int result = 0;
            Dictionary<int, int> occurenceDictionary = new Dictionary<int, int>();
            // get a distinct list of items from socks
            IEnumerable<int> uniqueItems = socks.Distinct();

            // get occurences
            foreach (int uniqueItem in uniqueItems)
            {
                int occurence = socks.Count(item => item == uniqueItem);
                occurenceDictionary.Add(uniqueItem, occurence);
            }

            // sum up the occurences
            foreach (KeyValuePair<int, int> keyValuePair in occurenceDictionary)
            {
                if (keyValuePair.Value % 2 != 0)
                {
                    result += (keyValuePair.Value - 1) / 2;
                }
                else
                {
                    result += keyValuePair.Value / 2;
                }
            }

            return result;
        }
    }
}