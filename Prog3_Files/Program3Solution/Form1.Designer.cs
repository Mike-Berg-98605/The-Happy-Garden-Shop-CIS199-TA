namespace Program3Solution
{
    partial class Form1
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
            this.gardenComboBox = new System.Windows.Forms.ComboBox();
            this.gardenLabel = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.flowerCostLabel = new System.Windows.Forms.Label();
            this.flowerCostTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.adjustedLabel = new System.Windows.Forms.Label();
            this.discountRateTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.baseAdjustedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gardenComboBox
            // 
            this.gardenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gardenComboBox.FormattingEnabled = true;
            this.gardenComboBox.Items.AddRange(new object[] {
            "Premium",
            "Standard",
            "Discount"});
            this.gardenComboBox.Location = new System.Drawing.Point(161, 44);
            this.gardenComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.gardenComboBox.Name = "gardenComboBox";
            this.gardenComboBox.Size = new System.Drawing.Size(160, 24);
            this.gardenComboBox.TabIndex = 0;
            // 
            // gardenLabel
            // 
            this.gardenLabel.AutoSize = true;
            this.gardenLabel.Location = new System.Drawing.Point(104, 47);
            this.gardenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gardenLabel.Name = "gardenLabel";
            this.gardenLabel.Size = new System.Drawing.Size(60, 17);
            this.gardenLabel.TabIndex = 1;
            this.gardenLabel.Text = "Garden:";
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(161, 79);
            this.itemTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(160, 22);
            this.itemTextBox.TabIndex = 2;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(21, 82);
            this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(138, 17);
            this.productLabel.TabIndex = 3;
            this.productLabel.Text = "Entree/Item Number:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(93, 111);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(65, 17);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(161, 111);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(160, 22);
            this.quantityTextBox.TabIndex = 4;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(51, 296);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(80, 17);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Total Price:";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(161, 296);
            this.totalPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalPriceTextBox.TabIndex = 6;
            // 
            // flowerCostLabel
            // 
            this.flowerCostLabel.AutoSize = true;
            this.flowerCostLabel.Location = new System.Drawing.Point(43, 204);
            this.flowerCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flowerCostLabel.Name = "flowerCostLabel";
            this.flowerCostLabel.Size = new System.Drawing.Size(92, 17);
            this.flowerCostLabel.TabIndex = 11;
            this.flowerCostLabel.Text = "Flowers Cost:";
            // 
            // flowerCostTextBox
            // 
            this.flowerCostTextBox.Location = new System.Drawing.Point(161, 201);
            this.flowerCostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.flowerCostTextBox.Name = "flowerCostTextBox";
            this.flowerCostTextBox.ReadOnly = true;
            this.flowerCostTextBox.Size = new System.Drawing.Size(160, 22);
            this.flowerCostTextBox.TabIndex = 10;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(191, 154);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 28);
            this.calcButton.TabIndex = 12;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // adjustedLabel
            // 
            this.adjustedLabel.AutoSize = true;
            this.adjustedLabel.Location = new System.Drawing.Point(0, 238);
            this.adjustedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adjustedLabel.Name = "adjustedLabel";
            this.adjustedLabel.Size = new System.Drawing.Size(135, 17);
            this.adjustedLabel.TabIndex = 14;
            this.adjustedLabel.Text = "Base Adjusted Cost:";
            // 
            // discountRateTextBox
            // 
            this.discountRateTextBox.Location = new System.Drawing.Point(161, 268);
            this.discountRateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountRateTextBox.Name = "discountRateTextBox";
            this.discountRateTextBox.ReadOnly = true;
            this.discountRateTextBox.Size = new System.Drawing.Size(160, 22);
            this.discountRateTextBox.TabIndex = 13;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(14, 271);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(120, 17);
            this.discountLabel.TabIndex = 15;
            this.discountLabel.Text = "Discount Percent:";
            // 
            // baseAdjustedTextBox
            // 
            this.baseAdjustedTextBox.Location = new System.Drawing.Point(161, 238);
            this.baseAdjustedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.baseAdjustedTextBox.Name = "baseAdjustedTextBox";
            this.baseAdjustedTextBox.ReadOnly = true;
            this.baseAdjustedTextBox.Size = new System.Drawing.Size(160, 22);
            this.baseAdjustedTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 402);
            this.Controls.Add(this.baseAdjustedTextBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.adjustedLabel);
            this.Controls.Add(this.discountRateTextBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.flowerCostLabel);
            this.Controls.Add(this.flowerCostTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.gardenLabel);
            this.Controls.Add(this.gardenComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "The Happy Garden Shop";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gardenComboBox;
        private System.Windows.Forms.Label gardenLabel;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Label flowerCostLabel;
        private System.Windows.Forms.TextBox flowerCostTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label adjustedLabel;
        private System.Windows.Forms.TextBox discountRateTextBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox baseAdjustedTextBox;
    }
}

