namespace Amazon_Accounts
{
    partial class SalesreturnsUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesreturnsUserControl));
            this.SalesReturnsHeadLbl = new System.Windows.Forms.Label();
            this.OrderIdLbl = new System.Windows.Forms.Label();
            this.OrderIdTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SalesDetailsView = new System.Windows.Forms.DataGridView();
            this.AmtDebitedTxt = new System.Windows.Forms.TextBox();
            this.AmtDebitedLbl = new System.Windows.Forms.Label();
            this.GrossLossTxt = new System.Windows.Forms.TextBox();
            this.GrossLossLbl = new System.Windows.Forms.Label();
            this.ShippingTxt = new System.Windows.Forms.TextBox();
            this.ShippingLbl = new System.Windows.Forms.Label();
            this.NetLoss = new System.Windows.Forms.TextBox();
            this.NetLossLbl = new System.Windows.Forms.Label();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.EnterSalesReturnsBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesReturnsHeadLbl
            // 
            this.SalesReturnsHeadLbl.AutoSize = true;
            this.SalesReturnsHeadLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesReturnsHeadLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReturnsHeadLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.SalesReturnsHeadLbl.Location = new System.Drawing.Point(353, 37);
            this.SalesReturnsHeadLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesReturnsHeadLbl.Name = "SalesReturnsHeadLbl";
            this.SalesReturnsHeadLbl.Size = new System.Drawing.Size(406, 72);
            this.SalesReturnsHeadLbl.TabIndex = 9;
            this.SalesReturnsHeadLbl.Text = "Sales Returns";
            // 
            // OrderIdLbl
            // 
            this.OrderIdLbl.AutoSize = true;
            this.OrderIdLbl.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.OrderIdLbl.Location = new System.Drawing.Point(56, 158);
            this.OrderIdLbl.Name = "OrderIdLbl";
            this.OrderIdLbl.Size = new System.Drawing.Size(151, 39);
            this.OrderIdLbl.TabIndex = 10;
            this.OrderIdLbl.Text = "Order ID";
            // 
            // OrderIdTxt
            // 
            this.OrderIdTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdTxt.Location = new System.Drawing.Point(267, 162);
            this.OrderIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderIdTxt.Multiline = true;
            this.OrderIdTxt.Name = "OrderIdTxt";
            this.OrderIdTxt.Size = new System.Drawing.Size(263, 32);
            this.OrderIdTxt.TabIndex = 0;
            this.OrderIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderIdTxt_KeyPress);
            this.OrderIdTxt.MouseEnter += new System.EventHandler(this.OrderIdTxt_MouseEnter);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.SearchBtn.Location = new System.Drawing.Point(579, 161);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(109, 34);
            this.SearchBtn.TabIndex = 12;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalesDetailsView
            // 
            this.SalesDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDetailsView.Location = new System.Drawing.Point(63, 231);
            this.SalesDetailsView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalesDetailsView.Name = "SalesDetailsView";
            this.SalesDetailsView.ReadOnly = true;
            this.SalesDetailsView.RowHeadersWidth = 51;
            this.SalesDetailsView.RowTemplate.Height = 24;
            this.SalesDetailsView.Size = new System.Drawing.Size(1007, 89);
            this.SalesDetailsView.TabIndex = 13;
            // 
            // AmtDebitedTxt
            // 
            this.AmtDebitedTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtDebitedTxt.Location = new System.Drawing.Point(92, 430);
            this.AmtDebitedTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmtDebitedTxt.Name = "AmtDebitedTxt";
            this.AmtDebitedTxt.Size = new System.Drawing.Size(120, 32);
            this.AmtDebitedTxt.TabIndex = 1;
            this.AmtDebitedTxt.TextChanged += new System.EventHandler(this.AmtDebitedTxt_TextChanged);
            this.AmtDebitedTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmtDebitedTxt_KeyPress);
            this.AmtDebitedTxt.MouseEnter += new System.EventHandler(this.AmtDebitedTxt_MouseEnter);
            // 
            // AmtDebitedLbl
            // 
            this.AmtDebitedLbl.AutoSize = true;
            this.AmtDebitedLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtDebitedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.AmtDebitedLbl.Location = new System.Drawing.Point(57, 374);
            this.AmtDebitedLbl.Name = "AmtDebitedLbl";
            this.AmtDebitedLbl.Size = new System.Drawing.Size(237, 34);
            this.AmtDebitedLbl.TabIndex = 16;
            this.AmtDebitedLbl.Text = "Amount Debited";
            this.AmtDebitedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrossLossTxt
            // 
            this.GrossLossTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossLossTxt.Location = new System.Drawing.Point(355, 430);
            this.GrossLossTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrossLossTxt.Name = "GrossLossTxt";
            this.GrossLossTxt.ReadOnly = true;
            this.GrossLossTxt.Size = new System.Drawing.Size(120, 32);
            this.GrossLossTxt.TabIndex = 4;
            this.GrossLossTxt.MouseEnter += new System.EventHandler(this.GrossLossTxt_MouseEnter);
            // 
            // GrossLossLbl
            // 
            this.GrossLossLbl.AutoSize = true;
            this.GrossLossLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossLossLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.GrossLossLbl.Location = new System.Drawing.Point(340, 374);
            this.GrossLossLbl.Name = "GrossLossLbl";
            this.GrossLossLbl.Size = new System.Drawing.Size(152, 34);
            this.GrossLossLbl.TabIndex = 18;
            this.GrossLossLbl.Text = "Gross Loss";
            this.GrossLossLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShippingTxt
            // 
            this.ShippingTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingTxt.Location = new System.Drawing.Point(557, 430);
            this.ShippingTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShippingTxt.Name = "ShippingTxt";
            this.ShippingTxt.ReadOnly = true;
            this.ShippingTxt.Size = new System.Drawing.Size(120, 32);
            this.ShippingTxt.TabIndex = 5;
            this.ShippingTxt.MouseEnter += new System.EventHandler(this.ShippingTxt_MouseEnter);
            // 
            // ShippingLbl
            // 
            this.ShippingLbl.AutoSize = true;
            this.ShippingLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.ShippingLbl.Location = new System.Drawing.Point(551, 374);
            this.ShippingLbl.Name = "ShippingLbl";
            this.ShippingLbl.Size = new System.Drawing.Size(132, 34);
            this.ShippingLbl.TabIndex = 20;
            this.ShippingLbl.Text = "Shipping";
            this.ShippingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NetLoss
            // 
            this.NetLoss.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetLoss.Location = new System.Drawing.Point(748, 430);
            this.NetLoss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NetLoss.Name = "NetLoss";
            this.NetLoss.ReadOnly = true;
            this.NetLoss.Size = new System.Drawing.Size(120, 32);
            this.NetLoss.TabIndex = 6;
            this.NetLoss.MouseEnter += new System.EventHandler(this.NetLoss_MouseEnter);
            // 
            // NetLossLbl
            // 
            this.NetLossLbl.AutoSize = true;
            this.NetLossLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetLossLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.NetLossLbl.Location = new System.Drawing.Point(747, 374);
            this.NetLossLbl.Name = "NetLossLbl";
            this.NetLossLbl.Size = new System.Drawing.Size(124, 34);
            this.NetLossLbl.TabIndex = 22;
            this.NetLossLbl.Text = "Net Loss";
            this.NetLossLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyBtn
            // 
            this.CopyBtn.Image = ((System.Drawing.Image)(resources.GetObject("CopyBtn.Image")));
            this.CopyBtn.Location = new System.Drawing.Point(92, 482);
            this.CopyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(45, 46);
            this.CopyBtn.TabIndex = 2;
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            this.CopyBtn.MouseEnter += new System.EventHandler(this.CopyBtn_MouseEnter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.linkLabel1.Location = new System.Drawing.Point(177, 501);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(411, 24);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to go to the amazon order detail page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseEnter += new System.EventHandler(this.linkLabel1_MouseEnter);
            // 
            // EnterSalesReturnsBtn
            // 
            this.EnterSalesReturnsBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterSalesReturnsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.EnterSalesReturnsBtn.Location = new System.Drawing.Point(409, 586);
            this.EnterSalesReturnsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterSalesReturnsBtn.Name = "EnterSalesReturnsBtn";
            this.EnterSalesReturnsBtn.Size = new System.Drawing.Size(300, 58);
            this.EnterSalesReturnsBtn.TabIndex = 7;
            this.EnterSalesReturnsBtn.Text = "Enter Sales Return";
            this.EnterSalesReturnsBtn.UseVisualStyleBackColor = true;
            this.EnterSalesReturnsBtn.Click += new System.EventHandler(this.EnterSalesReturnsBtn_Click);
            // 
            // SalesreturnsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnterSalesReturnsBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.NetLoss);
            this.Controls.Add(this.NetLossLbl);
            this.Controls.Add(this.ShippingTxt);
            this.Controls.Add(this.ShippingLbl);
            this.Controls.Add(this.GrossLossTxt);
            this.Controls.Add(this.GrossLossLbl);
            this.Controls.Add(this.AmtDebitedTxt);
            this.Controls.Add(this.AmtDebitedLbl);
            this.Controls.Add(this.SalesDetailsView);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.OrderIdTxt);
            this.Controls.Add(this.OrderIdLbl);
            this.Controls.Add(this.SalesReturnsHeadLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalesreturnsUserControl";
            this.Size = new System.Drawing.Size(1121, 702);
            this.Load += new System.EventHandler(this.SalesreturnsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalesReturnsHeadLbl;
        private System.Windows.Forms.Label OrderIdLbl;
        private System.Windows.Forms.TextBox OrderIdTxt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView SalesDetailsView;
        private System.Windows.Forms.TextBox AmtDebitedTxt;
        private System.Windows.Forms.Label AmtDebitedLbl;
        private System.Windows.Forms.TextBox GrossLossTxt;
        private System.Windows.Forms.Label GrossLossLbl;
        private System.Windows.Forms.TextBox ShippingTxt;
        private System.Windows.Forms.Label ShippingLbl;
        private System.Windows.Forms.TextBox NetLoss;
        private System.Windows.Forms.Label NetLossLbl;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button EnterSalesReturnsBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
