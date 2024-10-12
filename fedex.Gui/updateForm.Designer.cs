namespace fedex.Gui
{
    partial class updateForm
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
            label1 = new Label();
            labelProductId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tbProductName = new TextBox();
            label6 = new Label();
            numericPrice = new NumericUpDown();
            tbDescription = new TextBox();
            numericStock = new NumericUpDown();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 31);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "ProductId";
            // 
            // labelProductId
            // 
            labelProductId.AutoSize = true;
            labelProductId.Location = new Point(152, 31);
            labelProductId.Name = "labelProductId";
            labelProductId.Size = new Size(38, 15);
            labelProductId.TabIndex = 1;
            labelProductId.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 76);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "ProductName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 146);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 181);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 4;
            label4.Text = "StockQuantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 222);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 5;
            label5.Text = "CreatedAt";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(152, 218);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(152, 71);
            tbProductName.Margin = new Padding(3, 2, 3, 2);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(110, 23);
            tbProductName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 115);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 8;
            label6.Text = "Price";
            // 
            // numericPrice
            // 
            numericPrice.Location = new Point(152, 110);
            numericPrice.Margin = new Padding(3, 2, 3, 2);
            numericPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(131, 23);
            numericPrice.TabIndex = 9;
            numericPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(152, 143);
            tbDescription.Margin = new Padding(3, 2, 3, 2);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(340, 23);
            tbDescription.TabIndex = 10;
            // 
            // numericStock
            // 
            numericStock.Location = new Point(152, 176);
            numericStock.Margin = new Padding(3, 2, 3, 2);
            numericStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericStock.Name = "numericStock";
            numericStock.Size = new Size(131, 23);
            numericStock.TabIndex = 11;
            numericStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.Location = new Point(519, 130);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 108);
            btnSave.TabIndex = 12;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // updateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 338);
            Controls.Add(btnSave);
            Controls.Add(numericStock);
            Controls.Add(tbDescription);
            Controls.Add(numericPrice);
            Controls.Add(label6);
            Controls.Add(tbProductName);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelProductId);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "updateForm";
            Text = "updateForm";
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelProductId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox tbProductName;
        private Label label6;
        private NumericUpDown numericPrice;
        private TextBox tbDescription;
        private NumericUpDown numericStock;
        private Button btnSave;
    }
}