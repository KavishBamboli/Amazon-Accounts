namespace Amazon_Accounts
{
    partial class CancelledOrderUserControl
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
            this.CancelledOrderHeadLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.OrderIdTxt = new System.Windows.Forms.TextBox();
            this.OrderIdLbl = new System.Windows.Forms.Label();
            this.SalesDetailsView = new System.Windows.Forms.DataGridView();
            this.CancelOrderBtn = new System.Windows.Forms.Button();
            this.ShowReportBtn = new System.Windows.Forms.Button();
            this.FromDtPicker = new System.Windows.Forms.DateTimePicker();
            this.FromLbl = new System.Windows.Forms.Label();
            this.ToLbl = new System.Windows.Forms.Label();
            this.ToDtPicker = new System.Windows.Forms.DateTimePicker();
            this.GoBtn = new System.Windows.Forms.Button();
            this.CancelledOrderView = new System.Windows.Forms.DataGridView();
            this.PrintBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDetailsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelledOrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelledOrderHeadLbl
            // 
            this.CancelledOrderHeadLbl.AutoSize = true;
            this.CancelledOrderHeadLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CancelledOrderHeadLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelledOrderHeadLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.CancelledOrderHeadLbl.Location = new System.Drawing.Point(288, 24);
            this.CancelledOrderHeadLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CancelledOrderHeadLbl.Name = "CancelledOrderHeadLbl";
            this.CancelledOrderHeadLbl.Size = new System.Drawing.Size(546, 72);
            this.CancelledOrderHeadLbl.TabIndex = 10;
            this.CancelledOrderHeadLbl.Text = "Cancelled Orders";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.SearchBtn.Location = new System.Drawing.Point(600, 127);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(109, 37);
            this.SearchBtn.TabIndex = 15;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // OrderIdTxt
            // 
            this.OrderIdTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdTxt.Location = new System.Drawing.Point(288, 130);
            this.OrderIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderIdTxt.Multiline = true;
            this.OrderIdTxt.Name = "OrderIdTxt";
            this.OrderIdTxt.Size = new System.Drawing.Size(263, 32);
            this.OrderIdTxt.TabIndex = 13;
            this.OrderIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderIdTxt_KeyPress);
            // 
            // OrderIdLbl
            // 
            this.OrderIdLbl.AutoSize = true;
            this.OrderIdLbl.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.OrderIdLbl.Location = new System.Drawing.Point(77, 123);
            this.OrderIdLbl.Name = "OrderIdLbl";
            this.OrderIdLbl.Size = new System.Drawing.Size(151, 39);
            this.OrderIdLbl.TabIndex = 14;
            this.OrderIdLbl.Text = "Order ID";
            // 
            // SalesDetailsView
            // 
            this.SalesDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDetailsView.Location = new System.Drawing.Point(76, 193);
            this.SalesDetailsView.Name = "SalesDetailsView";
            this.SalesDetailsView.RowHeadersWidth = 51;
            this.SalesDetailsView.RowTemplate.Height = 24;
            this.SalesDetailsView.Size = new System.Drawing.Size(1018, 97);
            this.SalesDetailsView.TabIndex = 16;
            // 
            // CancelOrderBtn
            // 
            this.CancelOrderBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelOrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.CancelOrderBtn.Location = new System.Drawing.Point(452, 311);
            this.CancelOrderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelOrderBtn.Name = "CancelOrderBtn";
            this.CancelOrderBtn.Size = new System.Drawing.Size(257, 58);
            this.CancelOrderBtn.TabIndex = 17;
            this.CancelOrderBtn.Text = "Cancel Order";
            this.CancelOrderBtn.UseVisualStyleBackColor = true;
            this.CancelOrderBtn.Click += new System.EventHandler(this.CancelOrderBtn_Click);
            // 
            // ShowReportBtn
            // 
            this.ShowReportBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.ShowReportBtn.Location = new System.Drawing.Point(76, 386);
            this.ShowReportBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowReportBtn.Name = "ShowReportBtn";
            this.ShowReportBtn.Size = new System.Drawing.Size(314, 50);
            this.ShowReportBtn.TabIndex = 18;
            this.ShowReportBtn.Text = "Show Cancel Report";
            this.ShowReportBtn.UseVisualStyleBackColor = true;
            this.ShowReportBtn.Click += new System.EventHandler(this.ShowReportBtn_Click);
            // 
            // FromDtPicker
            // 
            this.FromDtPicker.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDtPicker.Location = new System.Drawing.Point(532, 397);
            this.FromDtPicker.Name = "FromDtPicker";
            this.FromDtPicker.Size = new System.Drawing.Size(177, 38);
            this.FromDtPicker.TabIndex = 19;
            this.FromDtPicker.Value = new System.DateTime(2020, 9, 18, 20, 22, 14, 0);
            this.FromDtPicker.ValueChanged += new System.EventHandler(this.FromDtPicker_ValueChanged);
            this.FromDtPicker.Enter += new System.EventHandler(this.FromDtPicker_Enter);
            // 
            // FromLbl
            // 
            this.FromLbl.AutoSize = true;
            this.FromLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.FromLbl.Location = new System.Drawing.Point(437, 401);
            this.FromLbl.Name = "FromLbl";
            this.FromLbl.Size = new System.Drawing.Size(89, 34);
            this.FromLbl.TabIndex = 20;
            this.FromLbl.Text = "From:";
            this.FromLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToLbl
            // 
            this.ToLbl.AutoSize = true;
            this.ToLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.ToLbl.Location = new System.Drawing.Point(731, 401);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(53, 34);
            this.ToLbl.TabIndex = 22;
            this.ToLbl.Text = "To:";
            this.ToLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToDtPicker
            // 
            this.ToDtPicker.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDtPicker.Location = new System.Drawing.Point(798, 397);
            this.ToDtPicker.MaxDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.ToDtPicker.Name = "ToDtPicker";
            this.ToDtPicker.Size = new System.Drawing.Size(178, 38);
            this.ToDtPicker.TabIndex = 21;
            this.ToDtPicker.Value = new System.DateTime(2020, 9, 18, 20, 22, 14, 0);
            this.ToDtPicker.Enter += new System.EventHandler(this.ToDtPicker_Enter);
            // 
            // GoBtn
            // 
            this.GoBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.GoBtn.Location = new System.Drawing.Point(1017, 397);
            this.GoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(67, 38);
            this.GoBtn.TabIndex = 23;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // CancelledOrderView
            // 
            this.CancelledOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CancelledOrderView.Location = new System.Drawing.Point(76, 450);
            this.CancelledOrderView.Name = "CancelledOrderView";
            this.CancelledOrderView.RowHeadersVisible = false;
            this.CancelledOrderView.RowHeadersWidth = 51;
            this.CancelledOrderView.RowTemplate.Height = 24;
            this.CancelledOrderView.Size = new System.Drawing.Size(1018, 196);
            this.CancelledOrderView.TabIndex = 24;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.PrintBtn.Location = new System.Drawing.Point(521, 651);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(98, 49);
            this.PrintBtn.TabIndex = 25;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // CancelledOrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.CancelledOrderView);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.ToLbl);
            this.Controls.Add(this.ToDtPicker);
            this.Controls.Add(this.FromLbl);
            this.Controls.Add(this.FromDtPicker);
            this.Controls.Add(this.ShowReportBtn);
            this.Controls.Add(this.CancelOrderBtn);
            this.Controls.Add(this.SalesDetailsView);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.OrderIdTxt);
            this.Controls.Add(this.OrderIdLbl);
            this.Controls.Add(this.CancelledOrderHeadLbl);
            this.Name = "CancelledOrderUserControl";
            this.Size = new System.Drawing.Size(1121, 702);
            this.Load += new System.EventHandler(this.CancelledOrderUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDetailsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelledOrderView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CancelledOrderHeadLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox OrderIdTxt;
        private System.Windows.Forms.Label OrderIdLbl;
        private System.Windows.Forms.DataGridView SalesDetailsView;
        private System.Windows.Forms.Button CancelOrderBtn;
        private System.Windows.Forms.Button ShowReportBtn;
        private System.Windows.Forms.DateTimePicker FromDtPicker;
        private System.Windows.Forms.Label FromLbl;
        private System.Windows.Forms.Label ToLbl;
        private System.Windows.Forms.DateTimePicker ToDtPicker;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.DataGridView CancelledOrderView;
        private System.Windows.Forms.Button PrintBtn;
    }
}
