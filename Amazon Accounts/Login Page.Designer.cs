namespace Amazon_Accounts
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.UserIdLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.ShowPassCheckBox = new System.Windows.Forms.CheckBox();
            this.SignupLinklbl = new System.Windows.Forms.LinkLabel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.UseriDtxt = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LogoPicBox);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 99);
            this.panel1.TabIndex = 9;
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.BackColor = System.Drawing.Color.Maroon;
            this.LogoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoPicBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicBox.Image")));
            this.LogoPicBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(134, 99);
            this.LogoPicBox.TabIndex = 1;
            this.LogoPicBox.TabStop = false;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.titleLbl.Location = new System.Drawing.Point(132, 30);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(616, 52);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Mahipal Textiles Amazon Accounts";
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.BackColor = System.Drawing.Color.Transparent;
            this.LoginLbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLbl.ForeColor = System.Drawing.Color.Maroon;
            this.LoginLbl.Location = new System.Drawing.Point(232, 102);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(190, 47);
            this.LoginLbl.TabIndex = 6;
            this.LoginLbl.Text = "User Login";
            this.LoginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserIdLbl
            // 
            this.UserIdLbl.AutoSize = true;
            this.UserIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserIdLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdLbl.ForeColor = System.Drawing.Color.DarkMagenta;
            this.UserIdLbl.Location = new System.Drawing.Point(133, 186);
            this.UserIdLbl.Name = "UserIdLbl";
            this.UserIdLbl.Size = new System.Drawing.Size(132, 42);
            this.UserIdLbl.TabIndex = 7;
            this.UserIdLbl.Text = "User ID";
            this.UserIdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.DarkMagenta;
            this.PasswordLbl.Location = new System.Drawing.Point(133, 251);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(147, 42);
            this.PasswordLbl.TabIndex = 8;
            this.PasswordLbl.Text = "Password";
            this.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.White;
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(313, 257);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '•';
            this.PasswordTxt.Size = new System.Drawing.Size(126, 35);
            this.PasswordTxt.TabIndex = 1;
            // 
            // ShowPassCheckBox
            // 
            this.ShowPassCheckBox.AutoSize = true;
            this.ShowPassCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ShowPassCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ShowPassCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassCheckBox.ForeColor = System.Drawing.Color.DeepPink;
            this.ShowPassCheckBox.Location = new System.Drawing.Point(445, 258);
            this.ShowPassCheckBox.Name = "ShowPassCheckBox";
            this.ShowPassCheckBox.Size = new System.Drawing.Size(178, 32);
            this.ShowPassCheckBox.TabIndex = 2;
            this.ShowPassCheckBox.Text = "Show Password";
            this.ShowPassCheckBox.UseVisualStyleBackColor = true;
            this.ShowPassCheckBox.CheckedChanged += new System.EventHandler(this.ShowPassCheckBox_CheckedChanged);
            // 
            // SignupLinklbl
            // 
            this.SignupLinklbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupLinklbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLinklbl.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.SignupLinklbl.LinkColor = System.Drawing.Color.DarkMagenta;
            this.SignupLinklbl.Location = new System.Drawing.Point(201, 391);
            this.SignupLinklbl.Name = "SignupLinklbl";
            this.SignupLinklbl.Size = new System.Drawing.Size(238, 24);
            this.SignupLinklbl.TabIndex = 5;
            this.SignupLinklbl.TabStop = true;
            this.SignupLinklbl.Text = "New? Click here to  sign up";
            this.SignupLinklbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignupLinklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignupLinklbl_LinkClicked);
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.LoginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginBtn.ImageKey = "(none)";
            this.LoginBtn.Location = new System.Drawing.Point(204, 342);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(104, 46);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.ExitBtn.FlatAppearance.BorderSize = 2;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.ExitBtn.Location = new System.Drawing.Point(335, 342);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(104, 46);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // UseriDtxt
            // 
            this.UseriDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UseriDtxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseriDtxt.Location = new System.Drawing.Point(313, 186);
            this.UseriDtxt.Mask = "0000";
            this.UseriDtxt.Name = "UseriDtxt";
            this.UseriDtxt.Size = new System.Drawing.Size(126, 35);
            this.UseriDtxt.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(640, 449);
            this.Controls.Add(this.UseriDtxt);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.SignupLinklbl);
            this.Controls.Add(this.ShowPassCheckBox);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserIdLbl);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(662, 500);
            this.MinimumSize = new System.Drawing.Size(662, 500);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mahipal Textiles Amazon Accounts";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.Label UserIdLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.CheckBox ShowPassCheckBox;
        private System.Windows.Forms.LinkLabel SignupLinklbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.MaskedTextBox UseriDtxt;
    }
}

