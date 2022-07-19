using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class ShopFacade : IShopFacade
    {
        Shop shop = new();
        InvoiceGenerator invoiceGenerator = new();
        DeliveryService deliveryService = new();
        
        public void Buy(string productId)
        {
            shop.CheckProductInWarehouse(productId);
            shop.GetProductFromWarehouse(productId);
            deliveryService.SendPackage();
            invoiceGenerator.GenerateInvoice(productId);
        }
    }
}
