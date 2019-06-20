using Microsoft.VisualStudio.TestTools.UnitTesting;
using Invoice_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_App.Tests
{
    [TestClass()]
    public class InvoiceTest
    {
        [TestMethod()]
        public void getInvoiceAmountTest()
        {
            Invoice invoice = new Invoice(1,"saw", 2, 10.00);

            var expected = 2 * 10;

            var actual = invoice.getInvoiceAmount();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void quantityCantBeNegative()
        {
            Invoice invoice = new Invoice(1, "saw", -3, 10.00);

            var expected = 0;

            var actual = invoice.getInvoiceAmount();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void priceCantBeNegative()
        {
            Invoice invoice = new Invoice(1, "saw", 5, -10.00);

            var expected = 0;

            var actual = invoice.getInvoiceAmount();

            Assert.AreEqual(expected, actual);
        }
    }
}