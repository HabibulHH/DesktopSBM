using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMApp.MODELS;

namespace SBMApp.BLL
{
    public class CashMemoManager
    {
        public  bool AddAmountToDailySells(CashMemo aCashMemo)
        {
            return true;
        }

        public bool AddSellsItemToSalesTable(CashMemo aCashMemo) /// that table keep product wise sells information
        {
            return true;
        }

        public bool AddSellsInformationToCustomerProfile()
        {
            return true;
        }

        public Product GetProductByName(string productName)
        {
            Product aProduct = new Product();
            aProduct.Name="4 INCH ANGEL";
            aProduct.Quantity = 56;
            return aProduct;
        }

    }
}
