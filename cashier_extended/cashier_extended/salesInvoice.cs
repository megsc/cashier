using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_extended
{
    class salesInvoice
    {
        //class variables
        protected int saleInvNumber;
        protected string saleProdName;
        protected decimal sellPrice;
        protected int sellQuantity;
        protected decimal totalSale;
        protected decimal costPrice;
        protected decimal productCost;



        //null constructor
        public salesInvoice()
        {

        }

        //constructor - changed so that variables match
        public salesInvoice(int saleInvNumber, string saleProdName, decimal sellPrice, int sellQuantity, decimal totalSale)
        {
            this.saleInvNumber = saleInvNumber;
            this.saleProdName = saleProdName;
            this.sellPrice = sellPrice;
            this.sellQuantity = sellQuantity;
            this.totalSale = totalSale;

            //setSaleInvNumber(saleInvoice);
            //setSaleProdName(saleProdName);
            //setSellPrice(sellPrice);
            //setSellQuantity(saleQuantity);
            //setTotalSale(sellPrice, saleQuantity);
            //setCostPrice(productCost);

        }

        //getters and setters
        public int getSaleInvNumber()
        {
            return saleInvNumber;

        }

        public void setSaleInvNumber(int saleInvNumber)
        {
            this.saleInvNumber = saleInvNumber;
        }

        public string getSaleProdName()
        {
            return saleProdName;
        }

        public void setSaleProdName(string saleProdName)
        {
            this.saleProdName = saleProdName;
        }

        public decimal setCostPrice(decimal productCost)
        {
            return costPrice;
        }

        public decimal getCostPrice()
        {
            return costPrice;
        }

        public decimal getSellPrice()
        {
            return sellPrice;
        }

        public void setSellPrice(decimal costPrice)
        {
            sellPrice = costPrice * 1.6m;
        }

        public int getSellQuantity()
        {
            return sellQuantity;
        }

        public void setSellQuantity(int sellQuantity)
        {
            this.sellQuantity = sellQuantity;
        }

        public virtual decimal getTotalSale()
        {
            return totalSale;
        }

        public decimal setTotalSale(decimal sellPrice, int sellQuantity)
        {
            return totalSale = sellPrice * sellQuantity;
        }

        //method to write to text file
        public virtual string DailySalesReport()
        {
            return this.saleInvNumber.ToString() + ',' + this.saleProdName + ',' + this.sellPrice.ToString("c1") + ',' + this.sellQuantity.ToString() + ',' + this.totalSale.ToString("c1");
        }

    }


}

