namespace Amazon_Accounts
{
    partial class PaymentsUserControl
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
            this.PaymentsHeadLbl = new System.Windows.Forms.Label();
            this.DateTxt = new System.Windows.Forms.MaskedTextBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.AmtText = new System.Windows.Forms.TextBox();
            this.TransactionLbl = new System.Windows.Forms.Label();
            this.CODRadioBtn = new System.Windows.Forms.RadioButton();
            this.ElectronicRadioBtn = new System.Windows.Forms.RadioButton();
            this.EnterDataBtn = new System.Windows.Forms.Button();
            this.ShowReportBtn = new System.Windows.Forms.Button();
            this.GoBtn = new System.Windows.Forms.Button();
            this.ToLbl = new System.Windows.Forms.Label();
            this.ToDtPicker = new System.Windows.Forms.DateTimePicker();
            this.FromLbl = new System.Windows.Forms.Label();
            this.FromDtPicker = new System.Windows.Forms.DateTimePicker();
            this.PaymentsDetailsView = new System.Windows.Forms.DataGridView();
            this.PrintBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentsHeadLbl
            // 
            this.PaymentsHeadLbl.AutoSize = true;
            this.PaymentsHeadLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaymentsHeadLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsHeadLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.PaymentsHeadLbl.Location = new System.Drawing.Point(416, 33);
            this.PaymentsHeadLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaymentsHeadLbl.Name = "PaymentsHeadLbl";
            this.PaymentsHeadLbl.Size = new System.Drawing.Size(315, 72);
            this.PaymentsHeadLbl.TabIndex = 12;
            this.PaymentsHeadLbl.Text = "Payments";
            // 
            // DateTxt
            // 
            this.DateTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTxt.Location = new System.Drawing.Point(203, 138);
            this.DateTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTxt.Mask = "00/00/0000";
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.Size = new System.Drawing.Size(113, 32);
            this.DateTxt.TabIndex = 13;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.DateLbl.Location = new System.Drawing.Point(45, 136);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(79, 34);
            this.DateLbl.TabIndex = 14;
            this.DateLbl.Text = "Date";
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.AmountLbl.Location = new System.Drawing.Point(45, 188);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(122, 34);
            this.AmountLbl.TabIndex = 15;
            this.AmountLbl.Text = "Amount";
            // 
            // AmtText
            // 
            this.AmtText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtText.Location = new System.Drawing.Point(202, 190);
            this.AmtText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmtText.Name = "AmtText";
            this.AmtText.Size = new System.Drawing.Size(114, 32);
            this.AmtText.TabIndex = 16;
            // 
            // TransactionLbl
            // 
            this.TransactionLbl.AutoSize = true;
            this.TransactionLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.TransactionLbl.Location = new System.Drawing.Point(45, 240);
            this.TransactionLbl.Name = "TransactionLbl";
            this.TransactionLbl.Size = new System.Drawing.Size(418, 34);
            this.TransactionLbl.TabIndex = 17;
            this.TransactionLbl.Text = "Select the type of transaction:";
            // 
            // CODRadioBtn
            // 
            this.CODRadioBtn.AutoSize = true;
            this.CODRadioBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.CODRadioBtn.Location = new System.Drawing.Point(490, 240);
            this.CODRadioBtn.Name = "CODRadioBtn";
            this.CODRadioBtn.Size = new System.Drawing.Size(104, 38);
            this.CODRadioBtn.TabIndex = 18;
            this.CODRadioBtn.TabStop = true;
            this.CODRadioBtn.Text = "COD";
            this.CODRadioBtn.UseVisualStyleBackColor = true;
            this.CODRadioBtn.CheckedChanged += new System.EventHandler(this.CODRadioBtn_CheckedChanged);
            // 
            // ElectronicRadioBtn
            // 
            this.ElectronicRadioBtn.AutoSize = true;
            this.ElectronicRadioBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElectronicRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.ElectronicRadioBtn.Location = new System.Drawing.Point(618, 239);
            this.ElectronicRadioBtn.Name = "ElectronicRadioBtn";
            this.ElectronicRadioBtn.Size = new System.Drawing.Size(171, 38);
            this.ElectronicRadioBtn.TabIndex = 19;
            this.ElectronicRadioBtn.TabStop = true;
            this.ElectronicRadioBtn.Text = "Electronic";
            this.ElectronicRadioBtn.UseVisualStyleBackColor = true;
            this.ElectronicRadioBtn.CheckedChanged += new System.EventHandler(this.ElectronicRadioBtn_CheckedChanged);
            // 
            // EnterDataBtn
            // 
            this.EnterDataBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.EnterDataBtn.Location = new System.Drawing.Point(490, 297);
            this.EnterDataBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterDataBtn.Name = "EnterDataBtn";
            this.EnterDataBtn.Size = new System.Drawing.Size(146, 43);
            this.EnterDataBtn.TabIndex = 20;
            this.EnterDataBtn.Text = "Enter";
            this.EnterDataBtn.UseVisualStyleBackColor = true;
            this.EnterDataBtn.Click += new System.EventHandler(this.EnterDataBtn_Click);
            // 
            // ShowReportBtn
            // 
            this.ShowReportBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.ShowReportBtn.Location = new System.Drawing.Point(51, 365);
            this.ShowReportBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowReportBtn.Name = "ShowReportBtn";
            this.ShowReportBtn.Size = new System.Drawing.Size(353, 43);
            this.ShowReportBtn.TabIndex = 21;
            this.ShowReportBtn.Text = "Show Payments Report";
            this.ShowReportBtn.UseVisualStyleBackColor = true;
            this.ShowReportBtn.Click += new System.EventHandler(this.ShowReportBtn_Click);
            // 
            // GoBtn
            // 
            this.GoBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.GoBtn.Location = new System.Drawing.Point(1014, 370);
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
            this.ToLbl.Location = new System.Drawing.Point(732, 374);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(53, 34);
            this.ToLbl.TabIndex = 27;
            this.ToLbl.Text = "To:";
            this.ToLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToDtPicker
            // 
            this.ToDtPicker.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDtPicker.Location = new System.Drawing.Point(799, 370);
            this.ToDtPicker.MaxDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.ToDtPicker.Name = "ToDtPicker";
            this.ToDtPicker.Size = new System.Drawing.Size(178, 38);
            this.ToDtPicker.TabIndex = 26;
            this.ToDtPicker.Value = new System.DateTime(2020, 9, 18, 20, 22, 14, 0);
            this.ToDtPicker.MouseEnter += new System.EventHandler(this.ToDtPicker_MouseEnter);
            // 
            // FromLbl
            // 
            this.FromLbl.AutoSize = true;
            this.FromLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.FromLbl.Location = new System.Drawing.Point(438, 374);
            this.FromLbl.Name = "FromLbl";
            this.FromLbl.Size = new System.Drawing.Size(89, 34);
            this.FromLbl.TabIndex = 25;
            this.FromLbl.Text = "From:";
            this.FromLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromDtPicker
            // 
            this.FromDtPicker.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDtPicker.Location = new System.Drawing.Point(533, 370);
            this.FromDtPicker.Name = "FromDtPicker";
            this.FromDtPicker.Size = new System.Drawing.Size(177, 38);
            this.FromDtPicker.TabIndex = 24;
            this.FromDtPicker.Value = new System.DateTime(2020, 9, 18, 20, 22, 14, 0);
            this.FromDtPicker.ValueChanged += new System.EventHandler(this.FromDtPicker_ValueChanged);
            this.FromDtPicker.Enter += new System.EventHandler(this.FromDtPicker_Enter);
            // 
            // PaymentsDetailsView
            // 
            this.PaymentsDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentsDetailsView.Location = new System.Drawing.Point(51, 427);
            this.PaymentsDetailsView.Name = "PaymentsDetailsView";
            this.PaymentsDetailsView.RowHeadersWidth = 51;
            this.PaymentsDetailsView.RowTemplate.Height = 24;
            this.PaymentsDetailsView.Size = new System.Drawing.Size(1030, 225);
            this.PaymentsDetailsView.TabIndex = 29;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.PrintBtn.Location = new System.Drawing.Point(490, 659);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(104, 38);
            this.PrintBtn.TabIndex = 30;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // PaymentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.PaymentsDetailsView);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.ToLbl);
            this.Controls.Add(this.ToDtPicker);
            this.Controls.Add(this.FromLbl);
            this.Controls.Add(this.FromDtPicker);
            this.Controls.Add(this.ShowReportBtn);
            this.Controls.Add(this.EnterDataBtn);
            this.Controls.Add(this.ElectronicRadioBtn);
            this.Controls.Add(this.CODRadioBtn);
            this.Controls.Add(this.TransactionLbl);
            this.Controls.Add(this.AmtText);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.DateTxt);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.PaymentsHeadLbl);
            this.Name = "PaymentsUserControl";
            this.Size = new System.Drawing.Size(1121, 702);
            this.Load += new System.EventHandler(this.PaymentsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaymentsHeadLbl;
        private System.Windows.Forms.MaskedTextBox DateTxt;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.TextBox AmtText;
        private System.Windows.Forms.Label TransactionLbl;
        private System.Windows.Forms.RadioButton CODRadioBtn;
        private System.Windows.Forms.RadioButton ElectronicRadioBtn;
        private System.Windows.Forms.Button EnterDataBtn;
        private System.Windows.Forms.Button ShowReportBtn;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Label ToLbl;
        private System.Windows.Forms.DateTimePicker ToDtPicker;
        private System.Windows.Forms.Label FromLbl;
        private System.Windows.Forms.DateTimePicker FromDtPicker;
        private System.Windows.Forms.DataGridView PaymentsDetailsView;
        private System.Windows.Forms.Button PrintBtn;
    }
}
