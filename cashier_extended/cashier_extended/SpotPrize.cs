using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_extended
{
    class SpotPrize : bigSpender
    {
        //class variables
        protected string productOfTheDay;
        

        //null constructor
        public SpotPrize()
        {


        }

        //constructor
        public SpotPrize(string dailyBingo)
        {
            setProductOfTheDay(dailyBingo);
 
        }

        //getters and setters
        public string getProductOfTheDay()
        {
            return productOfTheDay;
        }

        public void setProductOfTheDay(string dailyBingo)
        {
            productOfTheDay = dailyBingo;
        }

        public override decimal getTotalSale()
        {
            return totalSale;
        }

        public void setTotalSale(decimal sellBSPrice, int sellBSQuantity, decimal disc, decimal spotPrizeDisc)
        {
            totalSale = ((sellBSPrice * 1 * spotPrizeDisc) + ((sellBSQuantity - 1) * sellBSPrice)) * disc;

        }

        //method to write to text file
        public override string DailySalesReport()
        {
            return this.saleInvNumber.ToString() + ',' + this.saleProdName + ',' + this.sellPrice.ToString("c1") + ',' + this.sellQuantity.ToString() + ',' + this.totalSale.ToString("c1") + ',' + this.bigSpenderName + ',' + this.bigSpenderPhone + ',' + this.productOfTheDay;
        }

    }
}
