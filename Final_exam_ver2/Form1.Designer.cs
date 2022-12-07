namespace Final_exam_ver2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.managerID = new System.Windows.Forms.ComboBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBenefit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd_Receipt_ID = new System.Windows.Forms.Button();
            this.btnAdd_Item = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gridViewItem = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Benefit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPriceItem = new System.Windows.Forms.TextBox();
            this.txtQuantityItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Goods Received Note";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.managerID);
            this.groupBox1.Controls.Add(this.txtManagerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Checker Information";
            // 
            // managerID
            // 
            this.managerID.FormattingEnabled = true;
            this.managerID.Location = new System.Drawing.Point(106, 41);
            this.managerID.Name = "managerID";
            this.managerID.Size = new System.Drawing.Size(215, 24);
            this.managerID.TabIndex = 3;
            this.managerID.SelectedIndexChanged += new System.EventHandler(this.managerID_SelectedIndexChanged);
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(106, 113);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.ReadOnly = true;
            this.txtManagerName.Size = new System.Drawing.Size(215, 22);
            this.txtManagerName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manager \'s ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBenefit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd_Receipt_ID);
            this.groupBox2.Controls.Add(this.btnAdd_Item);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.gridViewItem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPriceItem);
            this.groupBox2.Controls.Add(this.txtQuantityItem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtItemID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(0, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 566);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information about items";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtBenefit
            // 
            this.txtBenefit.Location = new System.Drawing.Point(546, 207);
            this.txtBenefit.Name = "txtBenefit";
            this.txtBenefit.Size = new System.Drawing.Size(215, 22);
            this.txtBenefit.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(479, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Benefit";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(627, 467);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 38);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove Item ";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd_Receipt_ID
            // 
            this.btnAdd_Receipt_ID.Location = new System.Drawing.Point(419, 467);
            this.btnAdd_Receipt_ID.Name = "btnAdd_Receipt_ID";
            this.btnAdd_Receipt_ID.Size = new System.Drawing.Size(126, 38);
            this.btnAdd_Receipt_ID.TabIndex = 15;
            this.btnAdd_Receipt_ID.Text = "Add Receipt_ID";
            this.btnAdd_Receipt_ID.UseVisualStyleBackColor = true;
            this.btnAdd_Receipt_ID.Click += new System.EventHandler(this.btnAdd_Receipt_ID_Click);
            // 
            // btnAdd_Item
            // 
            this.btnAdd_Item.Location = new System.Drawing.Point(106, 467);
            this.btnAdd_Item.Name = "btnAdd_Item";
            this.btnAdd_Item.Size = new System.Drawing.Size(91, 38);
            this.btnAdd_Item.TabIndex = 14;
            this.btnAdd_Item.Text = "Add Item";
            this.btnAdd_Item.UseVisualStyleBackColor = true;
            this.btnAdd_Item.Click += new System.EventHandler(this.btnAdd_Item_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Location = new System.Drawing.Point(266, 467);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 38);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gridViewItem
            // 
            this.gridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Item_Name,
            this.Item_Quantity,
            this.Item_Price,
            this.Benefit});
            this.gridViewItem.Location = new System.Drawing.Point(106, 262);
            this.gridViewItem.Name = "gridViewItem";
            this.gridViewItem.ReadOnly = true;
            this.gridViewItem.RowHeadersWidth = 51;
            this.gridViewItem.RowTemplate.Height = 24;
            this.gridViewItem.Size = new System.Drawing.Size(677, 166);
            this.gridViewItem.TabIndex = 11;
            this.gridViewItem.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridViewItem_RowsAdded);
            // 
            // Item_ID
            // 
            this.Item_ID.HeaderText = "Item_ID";
            this.Item_ID.MinimumWidth = 6;
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.ReadOnly = true;
            this.Item_ID.Width = 125;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.MinimumWidth = 6;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            this.Item_Name.Width = 125;
            // 
            // Item_Quantity
            // 
            this.Item_Quantity.HeaderText = "Item Quantity";
            this.Item_Quantity.MinimumWidth = 6;
            this.Item_Quantity.Name = "Item_Quantity";
            this.Item_Quantity.ReadOnly = true;
            this.Item_Quantity.Width = 125;
            // 
            // Item_Price
            // 
            this.Item_Price.HeaderText = "Item Price";
            this.Item_Price.MinimumWidth = 6;
            this.Item_Price.Name = "Item_Price";
            this.Item_Price.ReadOnly = true;
            this.Item_Price.Width = 125;
            // 
            // Benefit
            // 
            this.Benefit.HeaderText = "Benefit";
            this.Benefit.MinimumWidth = 6;
            this.Benefit.Name = "Benefit";
            this.Benefit.ReadOnly = true;
            this.Benefit.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(453, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Item Quantity";
            // 
            // txtPriceItem
            // 
            this.txtPriceItem.Location = new System.Drawing.Point(546, 140);
            this.txtPriceItem.Name = "txtPriceItem";
            this.txtPriceItem.Size = new System.Drawing.Size(215, 22);
            this.txtPriceItem.TabIndex = 9;
            this.txtPriceItem.TextChanged += new System.EventHandler(this.txtPriceItem_TextChanged);
            // 
            // txtQuantityItem
            // 
            this.txtQuantityItem.Location = new System.Drawing.Point(546, 70);
            this.txtQuantityItem.Name = "txtQuantityItem";
            this.txtQuantityItem.Size = new System.Drawing.Size(215, 22);
            this.txtQuantityItem.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(470, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Item Price";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(106, 137);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(215, 22);
            this.txtItemName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Item Name";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(106, 70);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(215, 22);
            this.txtItemID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(26, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(543, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "(eg. 10, 20, 30)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(543, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "(eg. 10000, 20000, 30000)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox managerID;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        protected internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView gridViewItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPriceItem;
        private System.Windows.Forms.TextBox txtQuantityItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd_Item;
        private System.Windows.Forms.Button btnAdd_Receipt_ID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtBenefit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Benefit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

