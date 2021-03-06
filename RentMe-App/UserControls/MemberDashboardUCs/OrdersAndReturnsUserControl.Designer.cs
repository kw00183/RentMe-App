
namespace RentMe_App.UserControls.MemberDashboardUCs
{
    partial class OrdersAndReturnsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transactionIdTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pendingOrdersCheckbox = new System.Windows.Forms.CheckBox();
            this.yearsComboBox = new System.Windows.Forms.ComboBox();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.ViewAllButton = new System.Windows.Forms.Button();
            this.orderHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ViewButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.errorMsgLabel = new System.Windows.Forms.Label();
            this.topTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDataGridView)).BeginInit();
            this.bottomTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.ColumnCount = 6;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.62846F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.81028F));
            this.topTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.topTableLayoutPanel.Controls.Add(this.label3, 4, 1);
            this.topTableLayoutPanel.Controls.Add(this.transactionIdTextBox, 1, 1);
            this.topTableLayoutPanel.Controls.Add(this.SearchButton, 2, 1);
            this.topTableLayoutPanel.Controls.Add(this.pendingOrdersCheckbox, 5, 0);
            this.topTableLayoutPanel.Controls.Add(this.yearsComboBox, 5, 1);
            this.topTableLayoutPanel.Controls.Add(this.transactionLabel, 0, 1);
            this.topTableLayoutPanel.Controls.Add(this.ViewAllButton, 3, 1);
            this.topTableLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.topTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 2;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(799, 87);
            this.topTableLayoutPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.topTableLayoutPanel.SetColumnSpan(this.titleLabel, 2);
            this.titleLabel.Location = new System.Drawing.Point(1, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(99, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Orders and Returns";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Orders in";
            this.label3.Visible = false;
            // 
            // transactionIdTextBox
            // 
            this.transactionIdTextBox.Location = new System.Drawing.Point(134, 44);
            this.transactionIdTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.transactionIdTextBox.Name = "transactionIdTextBox";
            this.transactionIdTextBox.Size = new System.Drawing.Size(116, 20);
            this.transactionIdTextBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(267, 44);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(1);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(57, 22);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // pendingOrdersCheckbox
            // 
            this.pendingOrdersCheckbox.AutoSize = true;
            this.pendingOrdersCheckbox.Enabled = false;
            this.pendingOrdersCheckbox.Location = new System.Drawing.Point(673, 1);
            this.pendingOrdersCheckbox.Margin = new System.Windows.Forms.Padding(1);
            this.pendingOrdersCheckbox.Name = "pendingOrdersCheckbox";
            this.pendingOrdersCheckbox.Size = new System.Drawing.Size(123, 17);
            this.pendingOrdersCheckbox.TabIndex = 5;
            this.pendingOrdersCheckbox.Text = "Pending Orders Only";
            this.pendingOrdersCheckbox.UseVisualStyleBackColor = true;
            this.pendingOrdersCheckbox.Visible = false;
            // 
            // yearsComboBox
            // 
            this.yearsComboBox.Enabled = false;
            this.yearsComboBox.FormattingEnabled = true;
            this.yearsComboBox.Location = new System.Drawing.Point(673, 44);
            this.yearsComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.yearsComboBox.Name = "yearsComboBox";
            this.yearsComboBox.Size = new System.Drawing.Size(75, 21);
            this.yearsComboBox.TabIndex = 6;
            this.yearsComboBox.Visible = false;
            // 
            // transactionLabel
            // 
            this.transactionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(55, 43);
            this.transactionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(77, 13);
            this.transactionLabel.TabIndex = 1;
            this.transactionLabel.Text = "Transaction ID";
            // 
            // ViewAllButton
            // 
            this.ViewAllButton.BackColor = System.Drawing.Color.LightBlue;
            this.ViewAllButton.Location = new System.Drawing.Point(402, 46);
            this.ViewAllButton.Name = "ViewAllButton";
            this.ViewAllButton.Size = new System.Drawing.Size(127, 23);
            this.ViewAllButton.TabIndex = 7;
            this.ViewAllButton.Text = "View All Orders";
            this.ViewAllButton.UseVisualStyleBackColor = false;
            this.ViewAllButton.Click += new System.EventHandler(this.ViewAllButton_Click);
            // 
            // orderHistoryDataGridView
            // 
            this.orderHistoryDataGridView.AllowUserToAddRows = false;
            this.orderHistoryDataGridView.AllowUserToDeleteRows = false;
            this.orderHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type,
            this.OrderDate,
            this.DueDate,
            this.DateReturned,
            this.OrderTotal,
            this.Open});
            this.orderHistoryDataGridView.Location = new System.Drawing.Point(5, 90);
            this.orderHistoryDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.orderHistoryDataGridView.MultiSelect = false;
            this.orderHistoryDataGridView.Name = "orderHistoryDataGridView";
            this.orderHistoryDataGridView.ReadOnly = true;
            this.orderHistoryDataGridView.RowHeadersVisible = false;
            this.orderHistoryDataGridView.RowHeadersWidth = 123;
            this.orderHistoryDataGridView.RowTemplate.Height = 46;
            this.orderHistoryDataGridView.Size = new System.Drawing.Size(784, 355);
            this.orderHistoryDataGridView.TabIndex = 1;
            this.orderHistoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ToolTipText = "Transaction ID";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // DateReturned
            // 
            this.DateReturned.HeaderText = "Date Returned";
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.ReadOnly = true;
            this.DateReturned.Width = 160;
            // 
            // OrderTotal
            // 
            this.OrderTotal.HeaderText = "Order Total";
            this.OrderTotal.Name = "OrderTotal";
            this.OrderTotal.ReadOnly = true;
            this.OrderTotal.Width = 130;
            // 
            // Open
            // 
            this.Open.HeaderText = "Open";
            this.Open.Name = "Open";
            this.Open.ReadOnly = true;
            // 
            // bottomTableLayoutPanel
            // 
            this.bottomTableLayoutPanel.ColumnCount = 6;
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.bottomTableLayoutPanel.Controls.Add(this.ViewButton, 2, 1);
            this.bottomTableLayoutPanel.Controls.Add(this.ClearButton, 3, 1);
            this.bottomTableLayoutPanel.Controls.Add(this.errorMsgLabel, 2, 0);
            this.bottomTableLayoutPanel.Location = new System.Drawing.Point(1, 447);
            this.bottomTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.bottomTableLayoutPanel.Name = "bottomTableLayoutPanel";
            this.bottomTableLayoutPanel.RowCount = 2;
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTableLayoutPanel.Size = new System.Drawing.Size(798, 52);
            this.bottomTableLayoutPanel.TabIndex = 2;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(265, 27);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(1);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(57, 21);
            this.ViewButton.TabIndex = 0;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(397, 27);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(1);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(65, 21);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // errorMsgLabel
            // 
            this.errorMsgLabel.AutoSize = true;
            this.bottomTableLayoutPanel.SetColumnSpan(this.errorMsgLabel, 3);
            this.errorMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMsgLabel.Location = new System.Drawing.Point(265, 0);
            this.errorMsgLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.errorMsgLabel.Name = "errorMsgLabel";
            this.errorMsgLabel.Size = new System.Drawing.Size(13, 13);
            this.errorMsgLabel.TabIndex = 2;
            this.errorMsgLabel.Text = "  ";
            // 
            // OrdersAndReturnsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomTableLayoutPanel);
            this.Controls.Add(this.orderHistoryDataGridView);
            this.Controls.Add(this.topTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "OrdersAndReturnsUserControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDataGridView)).EndInit();
            this.bottomTableLayoutPanel.ResumeLayout(false);
            this.bottomTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transactionIdTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.CheckBox pendingOrdersCheckbox;
        private System.Windows.Forms.ComboBox yearsComboBox;
        private System.Windows.Forms.DataGridView orderHistoryDataGridView;
        private System.Windows.Forms.TableLayoutPanel bottomTableLayoutPanel;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label errorMsgLabel;
        private System.Windows.Forms.Button ViewAllButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Open;
    }
}
