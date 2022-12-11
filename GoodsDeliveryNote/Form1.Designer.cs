namespace GoodsDeliveryNote
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewDetailOrder = new System.Windows.Forms.DataGridView();
            this.OrderIdDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetailOrder)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.TotalOrderPrice,
            this.TotalOrderQuantity,
            this.OrderedDate,
            this.Status,
            this.AgentID});
            this.dataGridView1.Location = new System.Drawing.Point(18, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 125;
            // 
            // TotalOrderPrice
            // 
            this.TotalOrderPrice.HeaderText = "TotalOrderPrice";
            this.TotalOrderPrice.MinimumWidth = 6;
            this.TotalOrderPrice.Name = "TotalOrderPrice";
            this.TotalOrderPrice.ReadOnly = true;
            this.TotalOrderPrice.Width = 125;
            // 
            // TotalOrderQuantity
            // 
            this.TotalOrderQuantity.HeaderText = "TotalOrderQuantity";
            this.TotalOrderQuantity.MinimumWidth = 6;
            this.TotalOrderQuantity.Name = "TotalOrderQuantity";
            this.TotalOrderQuantity.ReadOnly = true;
            this.TotalOrderQuantity.Width = 125;
            // 
            // OrderedDate
            // 
            this.OrderedDate.HeaderText = "OrderedDate";
            this.OrderedDate.MinimumWidth = 6;
            this.OrderedDate.Name = "OrderedDate";
            this.OrderedDate.ReadOnly = true;
            this.OrderedDate.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // AgentID
            // 
            this.AgentID.HeaderText = "AgentID";
            this.AgentID.MinimumWidth = 6;
            this.AgentID.Name = "AgentID";
            this.AgentID.ReadOnly = true;
            this.AgentID.Width = 125;
            // 
            // gridViewDetailOrder
            // 
            this.gridViewDetailOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDetailOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderIdDetail,
            this.ItemsID,
            this.TotalProductQuantity,
            this.TotalProductPrice});
            this.gridViewDetailOrder.Location = new System.Drawing.Point(6, 497);
            this.gridViewDetailOrder.Name = "gridViewDetailOrder";
            this.gridViewDetailOrder.ReadOnly = true;
            this.gridViewDetailOrder.RowHeadersWidth = 51;
            this.gridViewDetailOrder.RowTemplate.Height = 24;
            this.gridViewDetailOrder.Size = new System.Drawing.Size(706, 200);
            this.gridViewDetailOrder.TabIndex = 1;
            // 
            // OrderIdDetail
            // 
            this.OrderIdDetail.HeaderText = "OrderID";
            this.OrderIdDetail.MinimumWidth = 6;
            this.OrderIdDetail.Name = "OrderIdDetail";
            this.OrderIdDetail.ReadOnly = true;
            this.OrderIdDetail.Width = 125;
            // 
            // ItemsID
            // 
            this.ItemsID.HeaderText = "ItemsID";
            this.ItemsID.MinimumWidth = 6;
            this.ItemsID.Name = "ItemsID";
            this.ItemsID.ReadOnly = true;
            this.ItemsID.Width = 125;
            // 
            // TotalProductQuantity
            // 
            this.TotalProductQuantity.HeaderText = "TotalProductQuantity";
            this.TotalProductQuantity.MinimumWidth = 6;
            this.TotalProductQuantity.Name = "TotalProductQuantity";
            this.TotalProductQuantity.ReadOnly = true;
            this.TotalProductQuantity.Width = 125;
            // 
            // TotalProductPrice
            // 
            this.TotalProductPrice.HeaderText = "TotalProductPrice";
            this.TotalProductPrice.MinimumWidth = 6;
            this.TotalProductPrice.Name = "TotalProductPrice";
            this.TotalProductPrice.ReadOnly = true;
            this.TotalProductPrice.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Good Delivery Note";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1078, 240);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPayment);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(404, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 92);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Functionality";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(148, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 42);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Status";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(355, 29);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(205, 42);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment success";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(GoodsDeliveryNote.Program);
            // 
            // programBindingSource1
            // 
            this.programBindingSource1.DataSource = typeof(GoodsDeliveryNote.Program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1080, 728);
            this.Controls.Add(this.gridViewDetailOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetailOrder)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentID;
        private System.Windows.Forms.DataGridView gridViewDetailOrder;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIdDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProductPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPayment;
    }
}

