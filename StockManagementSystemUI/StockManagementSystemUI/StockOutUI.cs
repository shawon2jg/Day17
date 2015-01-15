using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemUI
{
    public partial class StockOutUI : Form
    {
        private List<Stock> stocklList;
        public StockOutUI(List<Stock> stocks)
        {
            InitializeComponent();
            stocklList = stocks;
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            string itemId = itemIdOutTextBox.Text;
            double quantity = Convert.ToDouble(quantityOutTextBox.Text);
            Stock aStock = new Stock(itemId, quantity);
            string msg = aStock.OutStock(aStock, stocklList);
            MessageBox.Show(msg);
        }
    }
}
