namespace Amazon_Accounts
{
    partial class ReportsUserControl
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
            this.ReportsHeadLbl = new System.Windows.Forms.Label();
            this.ReportTypeLbl = new System.Windows.Forms.Label();
            this.SalesRadioBtn = new System.Windows.Forms.RadioButton();
            this.SalesReturnsRadioBtn = new System.Windows.Forms.RadioButton();
            this.GoBtn = new System.Windows.Forms.Button();
            this.ToLbl = new System.Windows.Forms.Label();
            this.ToDtPicker = new System.Windows.Forms.DateTimePicker();
            this.FromLbl = new System.Windows.Forms.Label();
            this.FromDtPicker = new System.Windows.Forms.DateTimePicker();
            this.ReportDisplayView = new System.Windows.Forms.DataGridView();
            this.PrintBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDisplayView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportsHeadLbl
            // 
            this.ReportsHeadLbl.AutoSize = true;
            this.ReportsHeadLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportsHeadLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsHeadLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.ReportsHeadLbl.Location = new System.Drawing.Point(461, 25);
            this.ReportsHeadLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportsHeadLbl.Name = "ReportsHeadLbl";
            this.ReportsHeadLbl.Size = new System.Drawing.Size(246, 72);
            this.ReportsHeadLbl.TabIndex = 9;
            this.ReportsHeadLbl.Text = "Reports";
            // 
            // ReportTypeLbl
            // 
            this.ReportTypeLbl.AutoSize = true;
            this.ReportTypeLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTypeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.ReportTypeLbl.Location = new System.Drawing.Point(53, 138);
            this.ReportTypeLbl.Name = "ReportTypeLbl";
            this.ReportTypeLbl.Size = new System.Drawing.Size(379, 37);
            this.ReportTypeLbl.TabIndex = 10;
            this.ReportTypeLbl.Text = "Select the type of report :";
            // 
            // SalesRadioBtn
            // 
            this.SalesRadioBtn.AutoSize = true;
            this.SalesRadioBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.SalesRadioBtn.Location = new System.Drawing.Point(461, 137);
            this.SalesRadioBtn.Name = "SalesRadioBtn";
            this.SalesRadioBtn.Size = new System.Drawing.Size(104, 38);
            this.SalesRadioBtn.TabIndex = 11;
            this.SalesRadioBtn.TabStop = true;
            this.SalesRadioBtn.Text = "Sales";
            this.SalesRadioBtn.UseVisualStyleBackColor = true;
            this.SalesRadioBtn.CheckedChanged += new System.EventHandler(this.SalesRadioBtn_CheckedChanged);
            // 
            // SalesReturnsRadioBtn
            // 
            this.SalesReturnsRadioBtn.AutoSize = true;
            this.SalesReturnsRadioBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReturnsRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.SalesReturnsRadioBtn.Location = new System.Drawing.Point(461, 181);
            this.SalesReturnsRadioBtn.Name = "SalesReturnsRadioBtn";
            this.SalesReturnsRadioBtn.Size = new System.Drawing.Size(210, 38);
            this.SalesReturnsRadioBtn.TabIndex = 12;
            this.SalesReturnsRadioBtn.TabStop = true;
            this.SalesReturnsRadioBtn.Text = "Sales Returns";
            this.SalesReturnsRadioBtn.UseVisualStyleBackColor = true;
            this.SalesReturnsRadioBtn.CheckedChanged += new System.EventHandler(this.SalesReturnsRadioBtn_CheckedChanged);
            // 
            // GoBtn
            // 
            this.GoBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.GoBtn.Location = new System.Drawing.Point(642, 254);
            this.GoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(67, 38);
            this.GoBtn.TabIndex = 28;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // ToLbl
            // 
            this.ToLbl.AutoSize = true;
            this.ToLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.ToLbl.Location = new System.Drawing.Point(358, 258);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(53, 34);
            this.ToLbl.TabIndex = 27;
            this.ToLbl.Text = "To:";
            this.ToLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToDtPicker
            // 
            this.ToDtPicker.CustomFormat = "dd-MM-yyyy";
            this.ToDtPicker.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDtPicker.Location = new System.Drawing.Point(425, 254);
            this.ToDtPicker.MaxDate = new System.DateTime(2020, 9, 19, 0, 0, 0, 0);
            this.ToDtPicker.Name = "ToDtPicker";
            this.ToDtPicker.Size = new System.Drawing.Size(188, 38);
            this.ToDtPicker.TabIndex = 26;
            this.ToDtPicker.Value = new System.DateTime(2020, 9, 18, 20, 22, 14, 0);
            this.ToDtPicker.Enter += new System.EventHandler(this.ToDtPicker_Enter);
            // 
            // FromLbl
            // 
            this.FromLbl.AutoSize = true;
            this.FromLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.FromLbl.Location = new System.Drawing.Point(54, 258);
            this.FromLbl.Name = "FromLbl";
            this.FromLbl.Size = new System.Drawing.Size(89, 34);
            this.FromLbl.TabIndex = 25;
            this.FromLbl.Text = "From:";
            this.FromLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromDtPicker
            // 
            this.FromDtPicker.CustomFormat = "dd-MM-yyyy";
            this.FromDtPicker.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDtPicker.Location = new System.Drawing.Point(149, 254);
            this.FromDtPicker.Name = "FromDtPicker";
            this.FromDtPicker.Size = new System.Drawing.Size(188, 38);
            this.FromDtPicker.TabIndex = 24;
            this.FromDtPicker.Value = new System.DateTime(2020, 9, 18, 20, 22, 14, 0);
            this.FromDtPicker.ValueChanged += new System.EventHandler(this.FromDtPicker_ValueChanged);
            this.FromDtPicker.Enter += new System.EventHandler(this.FromDtPicker_Enter);
            // 
            // ReportDisplayView
            // 
            this.ReportDisplayView.AllowUserToAddRows = false;
            this.ReportDisplayView.AllowUserToDeleteRows = false;
            this.ReportDisplayView.AllowUserToResizeColumns = false;
            this.ReportDisplayView.AllowUserToResizeRows = false;
            this.ReportDisplayView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDisplayView.Location = new System.Drawing.Point(60, 315);
            this.ReportDisplayView.Name = "ReportDisplayView";
            this.ReportDisplayView.RowHeadersVisible = false;
            this.ReportDisplayView.RowHeadersWidth = 51;
            this.ReportDisplayView.RowTemplate.Height = 24;
            this.ReportDisplayView.Size = new System.Drawing.Size(1032, 313);
            this.ReportDisplayView.TabIndex = 29;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.PrintBtn.Location = new System.Drawing.Point(530, 633);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(104, 44);
            this.PrintBtn.TabIndex = 30;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ReportsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.ReportDisplayView);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.ToLbl);
            this.Controls.Add(this.ToDtPicker);
            this.Controls.Add(this.FromLbl);
            this.Controls.Add(this.FromDtPicker);
            this.Controls.Add(this.SalesReturnsRadioBtn);
            this.Controls.Add(this.SalesRadioBtn);
            this.Controls.Add(this.ReportTypeLbl);
            this.Controls.Add(this.ReportsHeadLbl);
            this.Name = "ReportsUserControl";
            this.Size = new System.Drawing.Size(1121, 702);
            this.Load += new System.EventHandler(this.ReportsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDisplayView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportsHeadLbl;
        private System.Windows.Forms.Label ReportTypeLbl;
        private System.Windows.Forms.RadioButton SalesRadioBtn;
        private System.Windows.Forms.RadioButton SalesReturnsRadioBtn;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Label ToLbl;
        private System.Windows.Forms.DateTimePicker ToDtPicker;
        private System.Windows.Forms.Label FromLbl;
        private System.Windows.Forms.DateTimePicker FromDtPicker;
        private System.Windows.Forms.DataGridView ReportDisplayView;
        private System.Windows.Forms.Button PrintBtn;
    }
}
