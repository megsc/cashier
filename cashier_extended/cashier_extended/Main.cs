using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using cashier_extended.Properties;

namespace cashier_extended
{
    //Megan Carlton 
    //03 Nov 2016
    //this program calculates and records sales and tracks stock quantities for Bingo Office Supplies

    public partial class Main : Form
    {

        //sale and bigspender objects
        
        salesInvoice[] salesReport = new salesInvoice[20];

        salesInvoice newSale;
        bigSpender newBigSpender;
        SpotPrize newSpotPrize;

        Product newProduct;
        Product[] theProduct = new Product[10];

        SpotPrize bingo = new SpotPrize();
        

        int addSale = 0;

        int invNum = 1000;

        int sumQuant = 0;

        decimal sumTotal = 0;


        public Main()
        {
            InitializeComponent();

            //reading products from txt file and storing into Product array
            string products;
            string file = @"../../../../Products.txt";
            StreamReader productsFile = new StreamReader(file);


            if (File.Exists(file))
            {
                productsFile = File.OpenText(file);

                int count = 0;

                while ((products = productsFile.ReadLine()) != null)
                {
                    string[] data = products.Split(',');

                    newProduct = new Product(data[0], data[1], int.Parse(data[2]), decimal.Parse(data[3]), data[4]);

                    theProduct[count] = newProduct;
                    count++;
                }


                //displaying product names in listbox
                for (count = 0; count < theProduct.Length; count++)
                {
                    lst_products.Items.Add(theProduct[count].getProductName());
                }

                //foreach (Product productName in theProduct)
                //{
                //    if (productName != null)
                //    {
                //        newProduct = (Product)productName;
                //        lst_products.Items.Add(newProduct.getProductName());
                //    }
                // }

                productsFile.Close();

                //setting SpotPrize product of the day and output message to user
                bingo.setProductOfTheDay(theProduct[1].getProductCode());
                string alert = bingo.getProductOfTheDay();
                bingo.setSaleProdName(theProduct[1].getProductName());
                string alertProd = bingo.getSaleProdName();
                MessageBox.Show("Product of the day is: " + alert + "  " + alertProd);

            }

            else
            {
                MessageBox.Show("File not found");
            }

        }

        

        private void lst_products_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //display sell price and product image 
            for (int count = 0; count < lst_products.SelectedItems.Count; count++)
            {
                newSale = new salesInvoice();
                newSale.setSellPrice(theProduct[lst_products.SelectedIndex].getProductCost());
                lbl_prodPrice.Text = newSale.getSellPrice().ToString("c1");
                string pic = theProduct[lst_products.SelectedIndex].getProductPicture();
                pictureBox1.Image = Image.FromFile(@"../../Resources/" + pic);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
          }

    

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btn_sellProduct_Click(object sender, EventArgs e)
        {
            //creation of invoice number after Sell Button click
            lbl_invoiceNum.Visible = true;
            lbl_Quantity.Visible = true;
            numericUpDown1.Visible = true;

            lbl_invoiceNum.Text = "Invoice Number: " + invNum.ToString();

            newSale.setSaleInvNumber(invNum++);

        }



        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
                //sale quantity input and total sale value calculation
            
                int quant = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));

                if (newProduct.StockAvailable(theProduct[lst_products.SelectedIndex].getProductStockNumber(), quant)) 
                {
                    btn_confirmSale.Visible = true;
                    btn_cancelSale.Visible = true;
                    lbl_totalSale.Visible = true;

                    newSale.setSellQuantity(quant);
                    int quantity = newSale.getSellQuantity();
                    decimal sale = newSale.getSellPrice();
                    newSale.setTotalSale(sale, quantity);
                    decimal totalSale = newSale.getTotalSale();

                    lbl_totalSale.Text = ("Total Sale Price: " + totalSale.ToString("c1"));

                }

                //error message if quantity of products unavailable. available quantity is displayed. 
                else 
                {
                    MessageBox.Show("Insufficent stock for order. " + theProduct[lst_products.SelectedIndex].getProductStockNumber() + " in stock. ");
                }

            
        }

        private void btn_cancelSale_Click_1(object sender, EventArgs e)
        {
            //sale is cancelled. all fields cleared and invoice number discarded.
            numericUpDown1.Value = 0;
            lst_products.ClearSelected();
            btn_confirmSale.Visible = false;
            btn_cancelSale.Visible = false;
            lbl_totalSale.Visible = false;
            lbl_invoiceNum.Visible = false;
            lbl_Quantity.Visible = false;
            numericUpDown1.Visible = false;

            invNum--;

        }

        private void btn_confirmSale_Click_1(object sender, EventArgs e)
        {

                //sale is confirmed
                btn_confirmSale.Visible = false;
                btn_cancelSale.Visible = false;
                lbl_totalSale.Visible = false;
                lbl_invoiceNum.Visible = false;
                lbl_Quantity.Visible = false;
                numericUpDown1.Visible = false;

                //get sale details 

                int saleInv = newSale.getSaleInvNumber();
                newSale.setSaleProdName(theProduct[lst_products.SelectedIndex].getProductName());
                string saleProduct = newSale.getSaleProdName();
                newSale.setSellQuantity(Convert.ToInt32(Math.Round(numericUpDown1.Value, 0)));
                int quant = newSale.getSellQuantity();
                newSale.setSellPrice(theProduct[lst_products.SelectedIndex].getProductCost());
                decimal sale = newSale.getSellPrice();
                newSale.setTotalSale(sale, quant);
                decimal totalSale = newSale.getTotalSale();



                //sale stored if total sale is < 20
                if (totalSale < 20)
                    {

                        salesReport[addSale] = newSale;
                            
                        addSale++;

                        sumQuant += quant;

                        sumTotal += totalSale;

                    }

                //big spender discount applied if >= 20
                else if (totalSale >= 20)
                {
                    MessageBox.Show("Big Spender Alert! 5% discount applies to total sale price!");

                    lbl_discTotalSale.Visible = true;
                    lbl_cusName.Visible = true;
                    txt_cusName.Visible = true;
                    txt_cusName.MaxLength = 15;
                    lbl_cusPhone.Visible = true;
                    txt_cusPhone.Visible = true;
                    txt_cusPhone.MaxLength = 10;
                    btn_SaveDetails.Visible = true;
                    label2_bs.Visible = true;


                    //if else statement to calculate total sale price 
                    if (saleProduct == bingo.getSaleProdName())
                    {
                        newSpotPrize = new SpotPrize();
                        newSpotPrize.setTotalSale(sale, quant, 0.95m, 0.5m);
                        decimal spotPrizeTotalSale = newSpotPrize.getTotalSale();

                        lbl_discTotalSale.Text = ("Discounted Total Sale: " + spotPrizeTotalSale.ToString("c1"));

                        MessageBox.Show("BINGO! 50% discount has also been applied to 1 Product of the day!");

                    }

                    else
                    {
                        newBigSpender = new bigSpender();
                        newBigSpender.setTotalSale(sale, quant, 0.95m);
                        decimal discTotalSale = newBigSpender.getTotalSale();

                        lbl_discTotalSale.Text = ("Discounted Total Sale: " + discTotalSale.ToString("c1"));
                    }



                }

            

                //quantity of sale is reduced from available stock quantity

                int newStock = newProduct.MakeSale(theProduct[lst_products.SelectedIndex].getProductStockNumber(),quant);
                theProduct[lst_products.SelectedIndex].setProductStockNumber(newStock);
                //MessageBox.Show("new quantity: " + theProduct[lst_products.SelectedIndex].getProductStockNumber().ToString());

            }



        private void btn_SaveDetails_Click_1(object sender, EventArgs e)
        {
            //customer name and phone number fields for discount to apply
            string name = txt_cusName.Text;
            string phone = txt_cusPhone.Text;


            if (String.IsNullOrEmpty(txt_cusName.Text) || (String.IsNullOrEmpty(txt_cusPhone.Text)))
            {

                MessageBox.Show("Customer Name and Phone must be entered for discount to apply");

            }

            //sale stored with big spender discount applied
            else
            {

                string saleProduct = newSale.getSaleProdName();

                //if else statement to determine if either bigSpender or SpotPrize object is stored
                if (saleProduct == bingo.getSaleProdName())
                {

                    newSpotPrize.setSaleInvNumber(newSale.getSaleInvNumber());
                    int saleInv = newSpotPrize.getSaleInvNumber();
                    newSpotPrize.setSaleProdName(theProduct[lst_products.SelectedIndex].getProductName());
                    string saleProd = newSpotPrize.getSaleProdName();
                    newSpotPrize.setSellQuantity(newSale.getSellQuantity());
                    int quant = newSpotPrize.getSellQuantity();
                    newSpotPrize.setSellPrice(newSale.getSellPrice());
                    decimal sale = newSpotPrize.getSellPrice();
                    decimal spotPrizeTotalSale = newSpotPrize.getTotalSale();
                    newSpotPrize.setBigSpenderName(name);
                    string nameSP = newSpotPrize.getBigSpenderName();
                    newSpotPrize.setBigSpenderPhone(phone);
                    string phoneSP = newSpotPrize.getBigSpenderPhone();
                    newSpotPrize.setProductOfTheDay(bingo.getProductOfTheDay());
                    string dailyPrize = newSpotPrize.getProductOfTheDay();

                    salesReport[addSale] = newSpotPrize;
             
                    addSale++;

                    sumQuant += quant;

                    sumTotal += spotPrizeTotalSale;


                }

                else
                {
                    newBigSpender.setSaleInvNumber(newSale.getSaleInvNumber());
                    int saleInv = newBigSpender.getSaleInvNumber();
                    newBigSpender.setSaleProdName(theProduct[lst_products.SelectedIndex].getProductName());
                    string saleProd = newBigSpender.getSaleProdName();
                    newBigSpender.setSellQuantity(newSale.getSellQuantity());
                    int quant = newBigSpender.getSellQuantity();
                    newBigSpender.setSellPrice(newSale.getSellPrice());
                    decimal sale = newBigSpender.getSellPrice();
                    decimal discTotalSale = newBigSpender.getTotalSale();
                    newBigSpender.setBigSpenderName(name);
                    string nameBS = newBigSpender.getBigSpenderName();
                    newBigSpender.setBigSpenderPhone(phone);
                    string phoneBS = newBigSpender.getBigSpenderPhone();

                    salesReport[addSale] = newBigSpender;
                    
                    addSale++;

                    sumQuant += quant;

                    sumTotal += discTotalSale;

                }


                lbl_cusName.Visible = false;
                lbl_cusPhone.Visible = false;
                txt_cusName.Visible = false;
                txt_cusPhone.Visible = false;
                btn_SaveDetails.Visible = false;
                lbl_discTotalSale.Visible = false;
                label2_bs.Visible = false;
                txt_cusName.Text = String.Empty;
                txt_cusPhone.Text = String.Empty;


            }

        }



        private void btn_closeOfBusiness_Click_1(object sender, EventArgs e)
        {
            //cob object created and output to txt file
            salesInvoice cob = new salesInvoice();

            cob.setSaleInvNumber(999);
            int resetInv = cob.getSaleInvNumber();

            cob.setSaleProdName("Total sales for: " + DateTime.Now);
            string salesDate = cob.getSaleProdName();

            cob.setSellPrice(0);
            decimal resetSellPrice = cob.getSellPrice();
           
            cob.setSellQuantity(sumQuant);
            int numberOfProd = cob.getSellQuantity();

            cob.setTotalSale(sumTotal, 1);
            decimal dailyTotal = cob.getTotalSale();



            //output updated products less sales made

            StreamWriter products = new StreamWriter(@"../../../../Products_new.txt");

            for (int count = 0; count < 10; count++)
            {
                products.WriteLine(theProduct[count].updatingProducts());

            }

            products.Close();



            //output all individual daily sales and total daily sales details

            StreamWriter dailySalesDetails = new StreamWriter(@"../../../../Daily_Sales.txt");

            for (int count = 0; count < addSale; count++)
            {
                dailySalesDetails.WriteLine(salesReport[count].DailySalesReport());
            }

            dailySalesDetails.WriteLine(resetInv.ToString() + ',' + salesDate + ',' + resetSellPrice.ToString() + ',' + numberOfProd.ToString() + ',' + dailyTotal.ToString("c1"));
            dailySalesDetails.Close();


        }

    }
}
