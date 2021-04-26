using System.Collections.Generic;

namespace SalesByMatch
{
    public class SalesByMatchByIteration : ISockMerchant
    {
        public int SockMerchant(int[] socks)
        {
            Dictionary<int, int> occurenceDictionary = new Dictionary<int, int>();
            int result = 0;

            foreach (int sock in socks)
            {
                if (occurenceDictionary.ContainsKey(sock))
                {
                    int occurenceOfKey = occurenceDictionary[sock];
                    if ((occurenceOfKey + 1) % 2 == 0)
                    {
                        int occurenceOfKeyActual = occurenceDictionary[sock];
                        occurenceOfKeyActual += 1;
                        occurenceDictionary[sock] = occurenceOfKeyActual;
                        result += 1;
                    }
                }
                else
                {
                    occurenceDictionary.Add(sock, 1);
                }
            }

            return result;
        }
    }
}