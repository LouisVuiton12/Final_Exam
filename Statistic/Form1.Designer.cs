namespace Statistic
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
            this.gridViewGoodInAndOut = new System.Windows.Forms.DataGridView();
            this.btnIncoming = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOutcoming = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewBestSelling = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridViewRevenue = new System.Windows.Forms.DataGridView();
            this.ItemsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItemsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItemsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGoodInAndOut)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBestSelling)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewGoodInAndOut
            // 
            this.gridViewGoodInAndOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewGoodInAndOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemsID,
            this.TotalItemsQuantity,
            this.TotalItemsPrice});
            this.gridViewGoodInAndOut.Location = new System.Drawing.Point(6, 21);
            this.gridViewGoodInAndOut.Name = "gridViewGoodInAndOut";
            this.gridViewGoodInAndOut.RowHeadersWidth = 51;
            this.gridViewGoodInAndOut.RowTemplate.Height = 24;
            this.gridViewGoodInAndOut.Size = new System.Drawing.Size(751, 165);
            this.gridViewGoodInAndOut.TabIndex = 0;
            // 
            // btnIncoming
            // 
            this.btnIncoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncoming.Location = new System.Drawing.Point(793, 21);
            this.btnIncoming.Name = "btnIncoming";
            this.btnIncoming.Size = new System.Drawing.Size(150, 47);
            this.btnIncoming.TabIndex = 1;
            this.btnIncoming.Text = "View Incoming Good";
            this.btnIncoming.UseVisualStyleBackColor = true;
            this.btnIncoming.Click += new System.EventHandler(this.btnIncoming_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOutcoming);
            this.groupBox1.Controls.Add(this.gridViewGoodInAndOut);
            this.groupBox1.Controls.Add(this.btnIncoming);
            this.groupBox1.Location = new System.Drawing.Point(1, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1173, 211);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incoming and Outcoming Goods";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistics";
            // 
            // btnOutcoming
            // 
            this.btnOutcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutcoming.Location = new System.Drawing.Point(793, 139);
            this.btnOutcoming.Name = "btnOutcoming";
            this.btnOutcoming.Size = new System.Drawing.Size(150, 47);
            this.btnOutcoming.TabIndex = 2;
            this.btnOutcoming.Text = "View Outcoming Good";
            this.btnOutcoming.UseVisualStyleBackColor = true;
            this.btnOutcoming.Click += new System.EventHandler(this.btnOutcoming_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViewBestSelling);
            this.groupBox2.Location = new System.Drawing.Point(4, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1170, 212);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Best Selling Items";
            // 
            // gridViewBestSelling
            // 
            this.gridViewBestSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBestSelling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemsID1,
            this.TotalProductQuantity,
            this.TotalProductPrice});
            this.gridViewBestSelling.Location = new System.Drawing.Point(3, 21);
            this.gridViewBestSelling.Name = "gridViewBestSelling";
            this.gridViewBestSelling.RowHeadersWidth = 51;
            this.gridViewBestSelling.RowTemplate.Height = 24;
            this.gridViewBestSelling.Size = new System.Drawing.Size(937, 174);
            this.gridViewBestSelling.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridViewRevenue);
            this.groupBox3.Location = new System.Drawing.Point(1, 534);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1173, 200);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monthly Revenue";
            // 
            // gridViewRevenue
            // 
            this.gridViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderedDate,
            this.TotalOrderPrice});
            this.gridViewRevenue.Location = new System.Drawing.Point(6, 22);
            this.gridViewRevenue.Name = "gridViewRevenue";
            this.gridViewRevenue.RowHeadersWidth = 51;
            this.gridViewRevenue.RowTemplate.Height = 24;
            this.gridViewRevenue.Size = new System.Drawing.Size(937, 166);
            this.gridViewRevenue.TabIndex = 0;
            // 
            // ItemsID
            // 
            this.ItemsID.HeaderText = "ItemsID";
            this.ItemsID.MinimumWidth = 6;
            this.ItemsID.Name = "ItemsID";
            this.ItemsID.Width = 125;
            // 
            // TotalItemsQuantity
            // 
            this.TotalItemsQuantity.HeaderText = "TotalItemsQuantity";
            this.TotalItemsQuantity.MinimumWidth = 6;
            this.TotalItemsQuantity.Name = "TotalItemsQuantity";
            this.TotalItemsQuantity.Width = 125;
            // 
            // TotalItemsPrice
            // 
            this.TotalItemsPrice.HeaderText = "TotalItemsPrice";
            this.TotalItemsPrice.MinimumWidth = 6;
            this.TotalItemsPrice.Name = "TotalItemsPrice";
            this.TotalItemsPrice.Width = 125;
            // 
            // ItemsID1
            // 
            this.ItemsID1.HeaderText = "ItemsID";
            this.ItemsID1.MinimumWidth = 6;
            this.ItemsID1.Name = "ItemsID1";
            this.ItemsID1.Width = 125;
            // 
            // TotalProductQuantity
            // 
            this.TotalProductQuantity.HeaderText = "TotalProductQuantity";
            this.TotalProductQuantity.MinimumWidth = 6;
            this.TotalProductQuantity.Name = "TotalProductQuantity";
            this.TotalProductQuantity.Width = 125;
            // 
            // TotalProductPrice
            // 
            this.TotalProductPrice.HeaderText = "TotalProductPrice";
            this.TotalProductPrice.MinimumWidth = 6;
            this.TotalProductPrice.Name = "TotalProductPrice";
            this.TotalProductPrice.Width = 125;
            // 
            // OrderedDate
            // 
            this.OrderedDate.HeaderText = "Month";
            this.OrderedDate.MinimumWidth = 6;
            this.OrderedDate.Name = "OrderedDate";
            this.OrderedDate.Width = 125;
            // 
            // TotalOrderPrice
            // 
            this.TotalOrderPrice.HeaderText = "TotalOrderPrice";
            this.TotalOrderPrice.MinimumWidth = 6;
            this.TotalOrderPrice.Name = "TotalOrderPrice";
            this.TotalOrderPrice.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 734);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGoodInAndOut)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBestSelling)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewGoodInAndOut;
        private System.Windows.Forms.Button btnIncoming;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOutcoming;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridViewBestSelling;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridViewRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItemsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItemsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrderPrice;
    }
}

