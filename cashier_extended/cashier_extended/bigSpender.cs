using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_extended
{
    class bigSpender : salesInvoice
    {
        //class variables
        protected string bigSpenderName;
        protected string bigSpenderPhone;
        protected int sellBSQuantity;
        protected decimal sellBSPrice;
        protected decimal disc;

        //null constructor
        public bigSpender()
        {


        }

        //constructor
        public bigSpender(string bsCustomerName, string bsCustomerPhone, decimal totalSale)
        {
            setBigSpenderName(bsCustomerName);
            setBigSpenderPhone(bsCustomerPhone);
            setTotalSale(sellBSPrice, sellBSQuantity, disc);

        }

        //getters and setters
        public string getBigSpenderName()
        {
            return bigSpenderName;
        }

        public void setBigSpenderName(string bsCustomerName)
        {
            bigSpenderName = bsCustomerName;
        }

        public string getBigSpenderPhone()
        {
            return bigSpenderPhone;
        }

        public void setBigSpenderPhone(string bsCustomerPhone)
        {
            bigSpenderPhone = bsCustomerPhone;
        }

        public override decimal getTotalSale()
        {
            return totalSale;
        }

        public void setTotalSale(decimal sellBSPrice, int sellBSQuantity, decimal disc)
        {
            totalSale = sellBSPrice * sellBSQuantity * disc;

        }

        //method to write to text file
        public override string DailySalesReport()
        {
            return this.saleInvNumber.ToString() + ',' + this.saleProdName + ',' + this.sellPrice.ToString("c1") + ',' + this.sellQuantity.ToString() + ',' + this.totalSale.ToString("c1") + ',' + this.bigSpenderName + ',' + this.bigSpenderPhone ;
        }


    }

}

