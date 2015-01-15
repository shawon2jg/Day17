using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp
{
    public partial class ShopUI : Form
    {
        public ShopUI()
        {
            InitializeComponent();
        }

        private Shop aShop;

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string info = "";
            foreach (Product aProduct in aShop.GetProducts())
            {
                string aRow = aProduct.Id + " " + aProduct.Quantity + "\n";
                info += aRow;
            }
            MessageBox.Show(info);
        }

        private void saveShopButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop();
            aShop.Name = shopNameTextBox.Text;
            aShop.Address = shopAddressTextBox.Text;
            MessageBox.Show("Saved");
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product();
            aProduct.Id = itemIdTextBox.Text;
            aProduct.Quantity = Convert.ToInt32(itemQuantityTextBox.Text);
            string msg = aShop.AddProduct(aProduct);
            MessageBox.Show(msg);

        }
    }
}
