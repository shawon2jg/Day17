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
    public partial class StockInUI : Form
    {
        private List<Stock> stocklList;

        private Stock aStock;
        public StockInUI(List<Stock> stocks)
        {
            InitializeComponent();
            stocklList = stocks;
        }

        private void inButton_Click(object sender, EventArgs e)
        {
            string itemId = itemIdInTextBox.Text;
            double quantity = Convert.ToDouble(quantityInTextBox.Text);
            aStock = new Stock(itemId, quantity);
            string msg = aStock.AddStock(aStock, stocklList);
            MessageBox.Show(msg);
        }
    }
}
