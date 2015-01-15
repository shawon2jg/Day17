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
    public partial class StockManagementSystemUI : Form
    {
        private List<Stock> stockList = new List<Stock>(); 
        public StockManagementSystemUI()
        {
            InitializeComponent();
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            StockInUI stockInUI = new StockInUI(stockList);
            stockInUI.ShowDialog();
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            StockOutUI stockOutUI = new StockOutUI(stockList);
            stockOutUI.ShowDialog();
        }

        private void viewCurrentStockButton_Click(object sender, EventArgs e)
        {
            ShowCurrentStockUI showCurrentStockUI = new ShowCurrentStockUI(stockList);
            showCurrentStockUI.ShowDialog();
        }
    }
}
