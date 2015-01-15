namespace StockManagementSystemUI
{
    partial class StockOutUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outButton = new System.Windows.Forms.Button();
            this.quantityOutTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemIdOutTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outButton);
            this.groupBox1.Controls.Add(this.quantityOutTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.itemIdOutTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Out Entry";
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(131, 135);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(69, 26);
            this.outButton.TabIndex = 2;
            this.outButton.Text = "Out";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // quantityOutTextBox
            // 
            this.quantityOutTextBox.Location = new System.Drawing.Point(67, 88);
            this.quantityOutTextBox.Name = "quantityOutTextBox";
            this.quantityOutTextBox.Size = new System.Drawing.Size(134, 20);
            this.quantityOutTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // itemIdOutTextBox
            // 
            this.itemIdOutTextBox.Location = new System.Drawing.Point(67, 49);
            this.itemIdOutTextBox.Name = "itemIdOutTextBox";
            this.itemIdOutTextBox.Size = new System.Drawing.Size(134, 20);
            this.itemIdOutTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID";
            // 
            // StockOutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 226);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockOutUI";
            this.Text = "StockOutUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.TextBox quantityOutTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemIdOutTextBox;
        private System.Windows.Forms.Label label1;
    }
}