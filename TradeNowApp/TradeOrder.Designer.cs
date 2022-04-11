namespace TradeNow
{
    partial class TradeOrder
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
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traderClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Routes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolBox = new System.Windows.Forms.TextBox();
            this.symbolbs = new System.Windows.Forms.Label();
            this.quantitybs = new System.Windows.Forms.Label();
            this.pricebs = new System.Windows.Forms.Label();
            this.routebs = new System.Windows.Forms.Label();
            this.orderbs = new System.Windows.Forms.Label();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.routeBox = new System.Windows.Forms.ComboBox();
            this.createOrder = new System.Windows.Forms.Button();
            this.ordertypebs = new System.Windows.Forms.Label();
            this.tifbs = new System.Windows.Forms.Label();
            this.ordertypeBox = new System.Windows.Forms.ComboBox();
            this.tifBox = new System.Windows.Forms.ComboBox();
            this.orderIDbox = new System.Windows.Forms.TextBox();
            this.NewOrder = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.dateView = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.NoteforReq = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn,
            this.symbolDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.routeDataGridViewTextBoxColumn,
            this.orderTypeDataGridViewTextBoxColumn,
            this.tifDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.traderClassBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 433);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            this.orderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            this.symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            this.symbolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            this.routeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            this.orderTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tifDataGridViewTextBoxColumn
            // 
            this.tifDataGridViewTextBoxColumn.DataPropertyName = "Tif";
            this.tifDataGridViewTextBoxColumn.HeaderText = "Tif";
            this.tifDataGridViewTextBoxColumn.Name = "tifDataGridViewTextBoxColumn";
            this.tifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // traderClassBindingSource
            // 
            this.traderClassBindingSource.DataSource = typeof(TradeNowLibrary.TraderTicket);
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Account
            // 
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            // 
            // TiF
            // 
            this.TiF.HeaderText = "TiF";
            this.TiF.Name = "TiF";
            // 
            // Routes
            // 
            this.Routes.HeaderText = "Routes";
            this.Routes.Name = "Routes";
            // 
            // symbolBox
            // 
            this.symbolBox.Location = new System.Drawing.Point(269, 162);
            this.symbolBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.symbolBox.Name = "symbolBox";
            this.symbolBox.Size = new System.Drawing.Size(146, 29);
            this.symbolBox.TabIndex = 2;
            // 
            // symbolbs
            // 
            this.symbolbs.AutoSize = true;
            this.symbolbs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.symbolbs.Location = new System.Drawing.Point(88, 165);
            this.symbolbs.Name = "symbolbs";
            this.symbolbs.Size = new System.Drawing.Size(71, 23);
            this.symbolbs.TabIndex = 6;
            this.symbolbs.Text = "Symbol *";
            // 
            // quantitybs
            // 
            this.quantitybs.AutoSize = true;
            this.quantitybs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantitybs.Location = new System.Drawing.Point(88, 225);
            this.quantitybs.Name = "quantitybs";
            this.quantitybs.Size = new System.Drawing.Size(75, 23);
            this.quantitybs.TabIndex = 7;
            this.quantitybs.Text = "Quantity *";
            // 
            // pricebs
            // 
            this.pricebs.AutoSize = true;
            this.pricebs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pricebs.Location = new System.Drawing.Point(88, 286);
            this.pricebs.Name = "pricebs";
            this.pricebs.Size = new System.Drawing.Size(55, 23);
            this.pricebs.TabIndex = 8;
            this.pricebs.Text = "Price *";
            // 
            // routebs
            // 
            this.routebs.AutoSize = true;
            this.routebs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.routebs.Location = new System.Drawing.Point(88, 346);
            this.routebs.Name = "routebs";
            this.routebs.Size = new System.Drawing.Size(61, 23);
            this.routebs.TabIndex = 9;
            this.routebs.Text = "Route *";
            // 
            // orderbs
            // 
            this.orderbs.AutoSize = true;
            this.orderbs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderbs.Location = new System.Drawing.Point(88, 109);
            this.orderbs.Name = "orderbs";
            this.orderbs.Size = new System.Drawing.Size(60, 23);
            this.orderbs.TabIndex = 14;
            this.orderbs.Text = "Order *";
            // 
            // orderBox
            // 
            this.orderBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Items.AddRange(new object[] {
            "Select Order...",
            "BUY",
            "SELL",
            "SHORT"});
            this.orderBox.Location = new System.Drawing.Point(269, 106);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(146, 30);
            this.orderBox.TabIndex = 1;
            // 
            // routeBox
            // 
            this.routeBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.routeBox.FormattingEnabled = true;
            this.routeBox.Items.AddRange(new object[] {
            "ARCA",
            "NYSE",
            "NASDAQ",
            "ATS",
            "KSE",
            "PSEX"});
            this.routeBox.Location = new System.Drawing.Point(269, 344);
            this.routeBox.Name = "routeBox";
            this.routeBox.Size = new System.Drawing.Size(146, 30);
            this.routeBox.TabIndex = 5;
            // 
            // createOrder
            // 
            this.createOrder.Location = new System.Drawing.Point(567, 288);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(146, 41);
            this.createOrder.TabIndex = 8;
            this.createOrder.Text = "Create Order";
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // ordertypebs
            // 
            this.ordertypebs.AutoSize = true;
            this.ordertypebs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordertypebs.Location = new System.Drawing.Point(567, 107);
            this.ordertypebs.Name = "ordertypebs";
            this.ordertypebs.Size = new System.Drawing.Size(88, 23);
            this.ordertypebs.TabIndex = 10;
            this.ordertypebs.Text = "Order Type";
            // 
            // tifbs
            // 
            this.tifbs.AutoSize = true;
            this.tifbs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tifbs.Location = new System.Drawing.Point(567, 162);
            this.tifbs.Name = "tifbs";
            this.tifbs.Size = new System.Drawing.Size(32, 23);
            this.tifbs.TabIndex = 12;
            this.tifbs.Text = "TiF";
            // 
            // ordertypeBox
            // 
            this.ordertypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ordertypeBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordertypeBox.FormattingEnabled = true;
            this.ordertypeBox.Items.AddRange(new object[] {
            "MKT",
            "LMT",
            "STOP LMT",
            "BUY LMT",
            "SEL LMT"});
            this.ordertypeBox.Location = new System.Drawing.Point(748, 105);
            this.ordertypeBox.Name = "ordertypeBox";
            this.ordertypeBox.Size = new System.Drawing.Size(146, 30);
            this.ordertypeBox.TabIndex = 6;
            // 
            // tifBox
            // 
            this.tifBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tifBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tifBox.FormattingEnabled = true;
            this.tifBox.Items.AddRange(new object[] {
            "DAY",
            "GTC"});
            this.tifBox.Location = new System.Drawing.Point(748, 158);
            this.tifBox.Name = "tifBox";
            this.tifBox.Size = new System.Drawing.Size(146, 30);
            this.tifBox.TabIndex = 7;
            // 
            // orderIDbox
            // 
            this.orderIDbox.Location = new System.Drawing.Point(900, 105);
            this.orderIDbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderIDbox.Name = "orderIDbox";
            this.orderIDbox.ReadOnly = true;
            this.orderIDbox.Size = new System.Drawing.Size(43, 29);
            this.orderIDbox.TabIndex = 21;
            this.orderIDbox.Visible = false;
            // 
            // NewOrder
            // 
            this.NewOrder.Location = new System.Drawing.Point(748, 288);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(146, 41);
            this.NewOrder.TabIndex = 10;
            this.NewOrder.Text = "New Order";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(938, 27);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(94, 34);
            this.logout.TabIndex = 15;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(269, 223);
            this.quantityBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(146, 29);
            this.quantityBox.TabIndex = 3;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(269, 284);
            this.priceBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(146, 29);
            this.priceBox.TabIndex = 4;
            // 
            // dateView
            // 
            this.dateView.AutoSize = true;
            this.dateView.Location = new System.Drawing.Point(735, 223);
            this.dateView.Name = "dateView";
            this.dateView.Size = new System.Drawing.Size(80, 23);
            this.dateView.TabIndex = 22;
            this.dateView.Text = "Date Here";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(567, 223);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(42, 23);
            this.DateLabel.TabIndex = 23;
            this.DateLabel.Text = "Date";
            // 
            // NoteforReq
            // 
            this.NoteforReq.AutoSize = true;
            this.NoteforReq.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NoteforReq.Location = new System.Drawing.Point(269, 397);
            this.NoteforReq.Name = "NoteforReq";
            this.NoteforReq.Size = new System.Drawing.Size(138, 17);
            this.NoteforReq.TabIndex = 24;
            this.NoteforReq.Text = "*Required Attributes";
            // 
            // StartTime
            // 
            this.StartTime.Enabled = true;
            this.StartTime.Tick += new System.EventHandler(this.StartTime_Tick);
            // 
            // TradeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 827);
            this.Controls.Add(this.NoteforReq);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.dateView);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.NewOrder);
            this.Controls.Add(this.orderIDbox);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.routeBox);
            this.Controls.Add(this.tifBox);
            this.Controls.Add(this.ordertypeBox);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.orderbs);
            this.Controls.Add(this.tifbs);
            this.Controls.Add(this.ordertypebs);
            this.Controls.Add(this.routebs);
            this.Controls.Add(this.pricebs);
            this.Controls.Add(this.quantitybs);
            this.Controls.Add(this.symbolbs);
            this.Controls.Add(this.symbolBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TradeOrder";
            this.Text = "TradeOrder";
            this.Load += new System.EventHandler(this.TradeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traderClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Routes;
        private System.Windows.Forms.TextBox symbolBox;
        private System.Windows.Forms.Label symbolbs;
        private System.Windows.Forms.Label quantitybs;
        private System.Windows.Forms.Label pricebs;
        private System.Windows.Forms.Label routebs;
        private System.Windows.Forms.Label orderbs;
        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.ComboBox routeBox;
        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.Label ordertypebs;
        private System.Windows.Forms.Label tifbs;
        private System.Windows.Forms.ComboBox ordertypeBox;
        private System.Windows.Forms.ComboBox tifBox;
        private System.Windows.Forms.TextBox orderIDbox;
        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.Label dateView;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label NoteforReq;
        private System.Windows.Forms.BindingSource traderClassBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer StartTime;
    }
}