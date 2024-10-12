namespace fedex.Gui
{
    partial class createForm
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCreate = new Button();
            numericStock = new NumericUpDown();
            tbDescription = new TextBox();
            numericPrice = new NumericUpDown();
            tbProductName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 132);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 14;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 239);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 13;
            label5.Text = "CreatedAt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 198);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 12;
            label4.Text = "StockQuantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 163);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 11;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 93);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 10;
            label2.Text = "ProductName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "ProductId";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(517, 113);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(183, 108);
            btnCreate.TabIndex = 20;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // numericStock
            // 
            numericStock.Location = new Point(144, 190);
            numericStock.Margin = new Padding(3, 2, 3, 2);
            numericStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericStock.Name = "numericStock";
            numericStock.Size = new Size(131, 23);
            numericStock.TabIndex = 19;
            numericStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(144, 157);
            tbDescription.Margin = new Padding(3, 2, 3, 2);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(340, 23);
            tbDescription.TabIndex = 18;
            // 
            // numericPrice
            // 
            numericPrice.Location = new Point(144, 124);
            numericPrice.Margin = new Padding(3, 2, 3, 2);
            numericPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(131, 23);
            numericPrice.TabIndex = 17;
            numericPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(144, 85);
            tbProductName.Margin = new Padding(3, 2, 3, 2);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(110, 23);
            tbProductName.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(144, 232);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // createForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(numericStock);
            Controls.Add(tbDescription);
            Controls.Add(numericPrice);
            Controls.Add(tbProductName);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "createForm";
            Text = "createForm";
            ((System.ComponentModel.ISupportInitialize)numericStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCreate;
        private NumericUpDown numericStock;
        private TextBox tbDescription;
        private NumericUpDown numericPrice;
        private TextBox tbProductName;
        private DateTimePicker dateTimePicker1;
    }
}