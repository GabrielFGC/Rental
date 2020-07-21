using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Locadora.Entities
{
    class Invoice
    {
        public double BasicPayment { get; private set; }
        public double Tax { get; private set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double totalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}\nTotal payment: {totalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
