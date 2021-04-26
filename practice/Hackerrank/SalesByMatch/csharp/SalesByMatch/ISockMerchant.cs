namespace SalesByMatch
{
    /// <summary>
    /// StockMerchant exercise from Hackerrank.
    /// </summary>
    public interface ISockMerchant
    {
        /// <summary>
        /// The provided array of integers represent socks. The method counts how many pairs of socks
        /// are in the list. The purpose of this method to determine how many pair of socks can be found
        /// in a pile of socks.
        /// </summary>
        /// <param name="socks">Array of integers.</param>
        /// <returns>Returns pair of socks.</returns>
        int SockMerchant(int[] socks);
    }
}