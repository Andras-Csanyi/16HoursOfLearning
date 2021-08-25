using System.Collections.Generic;

namespace SalesByMatch
{
    public class SalesByMatchBySingleIterationV2 : ISockMerchant
    {
        public int SockMerchant(int[] socks)
        {
            if (socks.Length == 0)
            {
                return 0;
            }

            Dictionary<int, int> occurenceDictionary = new Dictionary<int, int>();
            int result = 0;

            foreach (int sock in socks)
            {
                occurenceDictionary.TryGetValue(sock, out int occurences);
                if ((occurences + 1) % 2 == 0)
                {
                    CountOccurences(ref occurences, occurenceDictionary, sock, ref result);
                }

                if (occurences == 0)
                {
                    occurenceDictionary.Add(sock, 1);
                }
            }

            return result;
        }

        private void CountOccurences(ref int occurences, Dictionary<int, int> occurenceDictionary, int sock,
            ref int result)
        {
            occurences += 1;
            occurenceDictionary[sock] = occurences;
            result += 1;
        }
    }
}