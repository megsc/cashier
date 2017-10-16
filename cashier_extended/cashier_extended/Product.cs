using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_extended
{
    class Product
    {
        //class variables
        string productCode;
        string productName;
        int productStockNumber;
        decimal productCost;
        string productPicture;

        //null constructor
        public Product()
        {
            productCode = "";
            productName = "";
            productStockNumber = 0;
            productCost = 0;
            productPicture = "";
        }

        //constructor
        public Product(string productCode, string productName, int productStockNumber, decimal productCost, string productPicture)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.productStockNumber = productStockNumber;
            this.productCost = productCost;
            this.productPicture = productPicture;

            //setProductCode(productCode);
            //setProductName(productName);
            //setProductStockNumber(productStockNumber);
            //setProductCost(productCost);
            //productPicture = "";
        }

        //getters and setters
        public void setProductCode(string prodCode)
        {
            productCode = prodCode;
        }

        public string getProductCode()
        {
            return productCode;
        }

        public void setProductName(string prodName)
        {
            productName = prodName;
        }

        public string getProductName()
        {
            return productName;
        }

        public void setProductStockNumber(int prodStockNum)
        {
            productStockNumber = prodStockNum;
        }

        public int getProductStockNumber()
        {
            return productStockNumber;
        }

        public void setProductCost(decimal prodCost)
        {
            productCost = prodCost;
        }

        public decimal getProductCost()
        {
            return productCost;
        }

        public string getProductPicture()
        {
            return this.productPicture;
        }

        //method to check stock availability
        public bool StockAvailable(int productStockNumber, int sellQuantity)
        {
            if (productStockNumber >= sellQuantity )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //method to deduct sale quantity from stock availability 
        public int MakeSale(int productStockNumber, int sellQuantity)
        {
            productStockNumber = productStockNumber - sellQuantity;
            return productStockNumber;
        }

        //method to write to text file
        public string updatingProducts()
        {
            return getProductCode() + ',' + getProductName() + ',' + getProductStockNumber() + ',' + getProductCost() + ',' + getProductPicture();
        }

    }


}

