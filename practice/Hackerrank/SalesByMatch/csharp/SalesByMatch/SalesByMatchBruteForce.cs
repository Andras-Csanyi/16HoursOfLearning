using System.Collections.Generic;
using System.Linq;

namespace SalesByMatch
{
    /// <summary>
    /// In this solution we do not take any advantage of the library.
    /// We use only brute force to figure out everything.
    /// </summary>
    public class SalesByMatchBruteForce : ISockMerchant
    {
        public int SockMerchant(int[] socks)
        {
            List<int> uniqueItems = new List<int>();
            Dictionary<int, int> itemOccurences = new Dictionary<int, int>();
            int occurence = 0;

            if (socks.Any())
            {
                // get a list of unique items
                foreach (int sock in socks)
                {
                    if (!uniqueItems.Contains(sock))
                    {
                        uniqueItems.Add(sock);
                    }
                }

                // get occurence of each unique item in the input array
                foreach (int uniqueItem in uniqueItems)
                {
                    int counter = 0;
                    foreach (int sock in socks)
                    {
                        if (sock == uniqueItem)
                        {
                            counter++;
                        }
                    }

                    itemOccurences.Add(uniqueItem, counter);
                }

                // get the final occurence
                foreach (KeyValuePair<int, int> keyValuePair in itemOccurences)
                {
                    if (keyValuePair.Value != 0)
                    {
                        if (keyValuePair.Value % 2 != 0)
                        {
                            int occ = (keyValuePair.Value - 1) / 2;
                            occurence += occ;
                        }
                        else
                        {
                            occurence += keyValuePair.Value / 2;
                        }
                    }
                }

                return occurence;
            }

            return 0;
        }
    }
}