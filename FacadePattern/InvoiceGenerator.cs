using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class InvoiceGenerator
    {
        public void GenerateInvoice(string productId)
        {
            Console.WriteLine($"Generating invoice for product: {productId}");
        }
    }
}
