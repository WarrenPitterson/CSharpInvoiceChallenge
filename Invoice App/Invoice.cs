using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_App
{

    public class Invoice
    {
        public int partNumber { get; set; }
        public string product { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public Invoice(int partnumber, string product, int quantity, double price)
        {
            this.partNumber = partNumber;
            this.product = product;
            this.quantity = quantity;
            this.price = price;
        }

        public double getInvoiceAmount()
        {
            if (quantity < 0)
                quantity = 0;

            if (price < 0)
                price = 0;
         
            return quantity * price;
        }

    }
}
