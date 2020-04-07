using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class MaxSellProfit
    {
        //N Transactions and find max Profit
        public int MaxProfit(int[] prices)
        {
            int max_profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {

                if (prices[i] > prices[i - 1])
                {
                    max_profit += prices[i] - prices[i - 1];
                }
            }

            return max_profit;
        }

        /// <summary>
        /// Only One Transaction is allowed
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit_OneTransaction(int[] prices)
        {
            if (prices.Length == 0)
                return 0;

            int max_profit = 0;

            int minSellingPrice = Int32.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minSellingPrice)
                {
                    minSellingPrice = prices[i];
                }
                else if (prices[i] - minSellingPrice > max_profit)
                {
                    max_profit = prices[i] - minSellingPrice;
                }


            }

            return max_profit;
        }
    }
}
