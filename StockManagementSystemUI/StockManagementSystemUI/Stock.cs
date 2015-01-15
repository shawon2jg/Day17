using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemUI
{
    public class Stock
    {
       
        public string ItemId { set; get; }
        public double Quantity { set; get; }

        public Stock(string itemId, double quantity): this()
        {
            ItemId = itemId;
            Quantity = quantity;
        }

        public Stock()
        {

        }

        public string AddStock(Stock stockToBeAdded, List<Stock> stocklList )
        {
            foreach (Stock existingStock in stocklList)
            {
                if (existingStock.ItemId == stockToBeAdded.ItemId)
                {
                    existingStock.Quantity += stockToBeAdded.Quantity;
                    return "More Stocks Added Successfully";
                }
            }
            stocklList.Add(stockToBeAdded);
            return "Successfully Added Stocks";
        }


        public string OutStock(Stock stockToBeOuted, List<Stock> stocklList)
        {
            foreach (Stock existingStock in stocklList)
            {
                if (existingStock.ItemId == stockToBeOuted.ItemId)
                {
                    if (existingStock.Quantity >= stockToBeOuted.Quantity)
                    {
                        existingStock.Quantity -= stockToBeOuted.Quantity;
                        return "Stocks Outed Successfully..";  
                    }
                    else if(existingStock.Quantity <= stockToBeOuted.Quantity)
                    {
                        return "Stocks Quantity Overflow..";
                    }
                }
            }
            return "There is no such Item ID in the Stocks";
        }
    }
}
