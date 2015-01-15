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
    public partial class ShowCurrentStockUI : Form
    {
        private List<Stock> stocklList; 
        public ShowCurrentStockUI(List<Stock> stocks)
        {
            InitializeComponent();
            stocklList = stocks;
        }

        private void ShowCurrentStockUI_Load(object sender, EventArgs e)
        {
            foreach (Stock aStock in stocklList)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aStock.ItemId;
                aListViewItem.SubItems.Add(aStock.Quantity.ToString());
                showListView.Items.Add(aListViewItem);
            }
        }
    }
}
