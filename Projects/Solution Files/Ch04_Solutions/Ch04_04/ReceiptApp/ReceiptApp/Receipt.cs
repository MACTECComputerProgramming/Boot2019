/* Receipt.cs
 * This class includes data member that could be used by an automobile 
 * parts store. Items included as data members are customer name, address,
 * phone, receipt number, item number purchased, description, 
 * unit price and quantity purchased. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptApp
{
    class Receipt
    {
        private string receiptNumber;
        private string dateOfPurchase;
        private string customerNumber;
        private string customerName;
        private string customerAddress;
        private string customerPhone;
        private string itemNumber;
        private string itemDesc;
        private double unitPrice;
        private int qtyPurchased;

        public Receipt()
        {
        }

        public Receipt (string rNum)
        {
            receiptNumber = rNum;
        }

        public Receipt(string rNum, string cNum)
        {
            receiptNumber = rNum;
            customerNumber = cNum;
        }

        public Receipt(string rNum, string cNum, string cName, string cAddress, string cPhone)
        {
            receiptNumber = rNum;
            customerNumber = cNum;
            customerName = cName;
            customerAddress = cAddress;
            customerPhone = cPhone;
        }
        
        public Receipt (string rNum, string iNum, string iDesc, double uPrice, int qty)
        {
            receiptNumber = rNum;
            itemNumber = iNum;
            itemDesc = iDesc;
            unitPrice = uPrice;
            qtyPurchased = qty;
        }
        public Receipt(string rNum, string cNum, string iNum, string iDesc, double uPrice, int qty)
        {
            receiptNumber = rNum;
            customerNumber = cNum;
            itemNumber = iNum;
            itemDesc = iDesc;
            unitPrice = uPrice;
            qtyPurchased = qty;
        }

        public Receipt(string rNum, string purchaseDate, string cNum, string cName, string cAddress, string cPhone,
                            string iNum, string iDesc, double uPrice, int qty)
        {
            receiptNumber = rNum;
            dateOfPurchase = purchaseDate;
            customerNumber = cNum;
            customerName = cName;
            customerAddress = cAddress;
            customerPhone = cPhone;
            itemNumber = iNum;
            itemDesc = iDesc;
            unitPrice = uPrice;
            qtyPurchased = qty;
        }

        public string ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                receiptNumber = value;
            }
        }

        public string DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }
            set
            {
                dateOfPurchase = value;
            }
        }

        public string CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                customerNumber = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }

        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }

        public string CustomerPhone
        {
            get
            {
                return customerPhone;
            }
            set
            {
                customerPhone = value;
            }
        }

 
        public string ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                itemNumber = value;
            }
        }

        public string ItemDesc
        {
            get
            {
                return itemDesc;
            }
            set
            {
                itemDesc = value;
            }

        }

        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }

        public int QtyPurchased
        {
            get
            {
                return qtyPurchased;
            }
            set
            {
                qtyPurchased = value;
            }
        }

        public double CalculateTotalCost()
        {
            return unitPrice * qtyPurchased;
        }

        public override string ToString()
        {
            return "Customer: " + CustomerName +
                   "\nTotal Purchases: " + CalculateTotalCost().ToString("C");

        }
    }
}
