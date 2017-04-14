using FontAwesome.Sharp;

namespace BankGUI
{
    partial class CheckingAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckingAccount));
            this.CheckingWithdrawalButton = new System.Windows.Forms.Button();
            this.CheckingDepositButton = new System.Windows.Forms.Button();
            this.CheckingCurrentBalanceLabel = new System.Windows.Forms.Label();
            this.BackButton = new FontAwesome.Sharp.IconButton();
            this.CurrentBalanceAmt = new System.Windows.Forms.Label();
            this.OverdraftAmt = new System.Windows.Forms.Label();
            this.OverdraftLabel = new System.Windows.Forms.Label();
            this.MaxWithdrawalAmt = new System.Windows.Forms.Label();
            this.MaxWithdrawalLabel = new System.Windows.Forms.Label();
            this.AccountNumber = new System.Windows.Forms.Label();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.SetOverdraftBtn = new System.Windows.Forms.Button();
            this.SetMaxWithdrawalBtn = new System.Windows.Forms.Button();
            this.CheckingAmtTextBox = new System.Windows.Forms.TextBox();
            this.AccountNumberText = new System.Windows.Forms.Label();
            this.AcctNumTextBox = new System.Windows.Forms.TextBox();
            this.SubmitAcctNumButton = new FontAwesome.Sharp.IconButton();
            this.Warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckingWithdrawalButton
            // 
            this.CheckingWithdrawalButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckingWithdrawalButton.Location = new System.Drawing.Point(288, 315);
            this.CheckingWithdrawalButton.Name = "CheckingWithdrawalButton";
            this.CheckingWithdrawalButton.Size = new System.Drawing.Size(207, 88);
            this.CheckingWithdrawalButton.TabIndex = 0;
            this.CheckingWithdrawalButton.Text = "Withdrawal";
            this.CheckingWithdrawalButton.UseVisualStyleBackColor = true;
            this.CheckingWithdrawalButton.Visible = false;
            this.CheckingWithdrawalButton.Click += new System.EventHandler(this.Withdrawal_Click);
            // 
            // CheckingDepositButton
            // 
            this.CheckingDepositButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckingDepositButton.Location = new System.Drawing.Point(525, 315);
            this.CheckingDepositButton.Name = "CheckingDepositButton";
            this.CheckingDepositButton.Size = new System.Drawing.Size(207, 88);
            this.CheckingDepositButton.TabIndex = 1;
            this.CheckingDepositButton.Text = "Deposit";
            this.CheckingDepositButton.UseVisualStyleBackColor = true;
            this.CheckingDepositButton.Visible = false;
            this.CheckingDepositButton.Click += new System.EventHandler(this.CheckingDepositButton_Click);
            // 
            // CheckingCurrentBalanceLabel
            // 
            this.CheckingCurrentBalanceLabel.AutoSize = true;
            this.CheckingCurrentBalanceLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckingCurrentBalanceLabel.Location = new System.Drawing.Point(278, 63);
            this.CheckingCurrentBalanceLabel.Name = "CheckingCurrentBalanceLabel";
            this.CheckingCurrentBalanceLabel.Size = new System.Drawing.Size(354, 55);
            this.CheckingCurrentBalanceLabel.TabIndex = 2;
            this.CheckingCurrentBalanceLabel.Text = "Current Balance : ";
            this.CheckingCurrentBalanceLabel.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Icon = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BackButton.IconColor = System.Drawing.Color.Black;
            this.BackButton.IconSize = 32;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(22, 23);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(57, 46);
            this.BackButton.TabIndex = 4;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CurrentBalanceAmt
            // 
            this.CurrentBalanceAmt.AutoSize = true;
            this.CurrentBalanceAmt.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalanceAmt.Location = new System.Drawing.Point(641, 63);
            this.CurrentBalanceAmt.Name = "CurrentBalanceAmt";
            this.CurrentBalanceAmt.Size = new System.Drawing.Size(70, 55);
            this.CurrentBalanceAmt.TabIndex = 5;
            this.CurrentBalanceAmt.Text = "$0";
            this.CurrentBalanceAmt.Visible = false;
            // 
            // OverdraftAmt
            // 
            this.OverdraftAmt.AutoSize = true;
            this.OverdraftAmt.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverdraftAmt.Location = new System.Drawing.Point(641, 118);
            this.OverdraftAmt.Name = "OverdraftAmt";
            this.OverdraftAmt.Size = new System.Drawing.Size(70, 55);
            this.OverdraftAmt.TabIndex = 7;
            this.OverdraftAmt.Text = "$0";
            this.OverdraftAmt.Visible = false;
            // 
            // OverdraftLabel
            // 
            this.OverdraftLabel.AutoSize = true;
            this.OverdraftLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverdraftLabel.Location = new System.Drawing.Point(278, 118);
            this.OverdraftLabel.Name = "OverdraftLabel";
            this.OverdraftLabel.Size = new System.Drawing.Size(235, 55);
            this.OverdraftLabel.TabIndex = 6;
            this.OverdraftLabel.Text = "Overdraft : ";
            this.OverdraftLabel.Visible = false;
            // 
            // MaxWithdrawalAmt
            // 
            this.MaxWithdrawalAmt.AutoSize = true;
            this.MaxWithdrawalAmt.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxWithdrawalAmt.Location = new System.Drawing.Point(641, 173);
            this.MaxWithdrawalAmt.Name = "MaxWithdrawalAmt";
            this.MaxWithdrawalAmt.Size = new System.Drawing.Size(70, 55);
            this.MaxWithdrawalAmt.TabIndex = 9;
            this.MaxWithdrawalAmt.Text = "$0";
            this.MaxWithdrawalAmt.Visible = false;
            // 
            // MaxWithdrawalLabel
            // 
            this.MaxWithdrawalLabel.AutoSize = true;
            this.MaxWithdrawalLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxWithdrawalLabel.Location = new System.Drawing.Point(278, 173);
            this.MaxWithdrawalLabel.Name = "MaxWithdrawalLabel";
            this.MaxWithdrawalLabel.Size = new System.Drawing.Size(356, 55);
            this.MaxWithdrawalLabel.TabIndex = 8;
            this.MaxWithdrawalLabel.Text = "Max Withdrawal : ";
            this.MaxWithdrawalLabel.Visible = false;
            // 
            // AccountNumber
            // 
            this.AccountNumber.AutoSize = true;
            this.AccountNumber.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumber.Location = new System.Drawing.Point(641, 8);
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Size = new System.Drawing.Size(47, 55);
            this.AccountNumber.TabIndex = 11;
            this.AccountNumber.Text = "0";
            this.AccountNumber.Visible = false;
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.AutoSize = true;
            this.AccountNumberLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberLabel.Location = new System.Drawing.Point(278, 8);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(361, 55);
            this.AccountNumberLabel.TabIndex = 10;
            this.AccountNumberLabel.Text = "Account Number: ";
            this.AccountNumberLabel.Visible = false;
            // 
            // SetOverdraftBtn
            // 
            this.SetOverdraftBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetOverdraftBtn.Location = new System.Drawing.Point(525, 423);
            this.SetOverdraftBtn.Name = "SetOverdraftBtn";
            this.SetOverdraftBtn.Size = new System.Drawing.Size(207, 88);
            this.SetOverdraftBtn.TabIndex = 13;
            this.SetOverdraftBtn.Text = "Set Overdraft";
            this.SetOverdraftBtn.UseVisualStyleBackColor = true;
            this.SetOverdraftBtn.Visible = false;
            this.SetOverdraftBtn.Click += new System.EventHandler(this.SetOverdraftBtn_Click);
            // 
            // SetMaxWithdrawalBtn
            // 
            this.SetMaxWithdrawalBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetMaxWithdrawalBtn.Location = new System.Drawing.Point(288, 423);
            this.SetMaxWithdrawalBtn.Name = "SetMaxWithdrawalBtn";
            this.SetMaxWithdrawalBtn.Size = new System.Drawing.Size(207, 88);
            this.SetMaxWithdrawalBtn.TabIndex = 12;
            this.SetMaxWithdrawalBtn.Text = "Set Max Withdrawal";
            this.SetMaxWithdrawalBtn.UseVisualStyleBackColor = true;
            this.SetMaxWithdrawalBtn.Visible = false;
            this.SetMaxWithdrawalBtn.Click += new System.EventHandler(this.SetMaxWithdrawalBtn_Click);
            // 
            // CheckingAmtTextBox
            // 
            this.CheckingAmtTextBox.Location = new System.Drawing.Point(419, 253);
            this.CheckingAmtTextBox.Name = "CheckingAmtTextBox";
            this.CheckingAmtTextBox.Size = new System.Drawing.Size(189, 26);
            this.CheckingAmtTextBox.TabIndex = 14;
            this.CheckingAmtTextBox.Text = "0";
            this.CheckingAmtTextBox.Visible = false;
            // 
            // AccountNumberText
            // 
            this.AccountNumberText.AutoSize = true;
            this.AccountNumberText.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberText.Location = new System.Drawing.Point(190, 214);
            this.AccountNumberText.Name = "AccountNumberText";
            this.AccountNumberText.Size = new System.Drawing.Size(627, 55);
            this.AccountNumberText.TabIndex = 15;
            this.AccountNumberText.Text = "Please enter an account number";
            // 
            // AcctNumTextBox
            // 
            this.AcctNumTextBox.Location = new System.Drawing.Point(419, 275);
            this.AcctNumTextBox.Name = "AcctNumTextBox";
            this.AcctNumTextBox.Size = new System.Drawing.Size(184, 26);
            this.AcctNumTextBox.TabIndex = 16;
            // 
            // SubmitAcctNumButton
            // 
            this.SubmitAcctNumButton.Icon = FontAwesome.Sharp.IconChar.Check;
            this.SubmitAcctNumButton.IconColor = System.Drawing.Color.Black;
            this.SubmitAcctNumButton.IconSize = 16;
            this.SubmitAcctNumButton.Image = ((System.Drawing.Image)(resources.GetObject("SubmitAcctNumButton.Image")));
            this.SubmitAcctNumButton.Location = new System.Drawing.Point(480, 325);
            this.SubmitAcctNumButton.Name = "SubmitAcctNumButton";
            this.SubmitAcctNumButton.Size = new System.Drawing.Size(57, 46);
            this.SubmitAcctNumButton.TabIndex = 17;
            this.SubmitAcctNumButton.UseVisualStyleBackColor = true;
            this.SubmitAcctNumButton.Click += new System.EventHandler(this.SubmitAcctNumButton_Click);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.Red;
            this.Warning.Location = new System.Drawing.Point(290, 227);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(421, 38);
            this.Warning.TabIndex = 18;
            this.Warning.Text = "Please enter a positive number";
            this.Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Warning.Visible = false;
            // 
            // CheckingAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 537);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.SubmitAcctNumButton);
            this.Controls.Add(this.CheckingAmtTextBox);
            this.Controls.Add(this.SetOverdraftBtn);
            this.Controls.Add(this.SetMaxWithdrawalBtn);
            this.Controls.Add(this.AccountNumber);
            this.Controls.Add(this.AccountNumberLabel);
            this.Controls.Add(this.MaxWithdrawalAmt);
            this.Controls.Add(this.MaxWithdrawalLabel);
            this.Controls.Add(this.OverdraftAmt);
            this.Controls.Add(this.OverdraftLabel);
            this.Controls.Add(this.CurrentBalanceAmt);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CheckingCurrentBalanceLabel);
            this.Controls.Add(this.CheckingDepositButton);
            this.Controls.Add(this.CheckingWithdrawalButton);
            this.Controls.Add(this.AccountNumberText);
            this.Controls.Add(this.AcctNumTextBox);
            this.Name = "CheckingAccount";
            this.Text = "CheckingAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckingWithdrawalButton;
        private System.Windows.Forms.Button CheckingDepositButton;
        private System.Windows.Forms.Label CheckingCurrentBalanceLabel;
        private IconButton BackButton;
        private System.Windows.Forms.Label CurrentBalanceAmt;
        private System.Windows.Forms.Label OverdraftAmt;
        private System.Windows.Forms.Label OverdraftLabel;
        private System.Windows.Forms.Label MaxWithdrawalAmt;
        private System.Windows.Forms.Label MaxWithdrawalLabel;
        private System.Windows.Forms.Label AccountNumber;
        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.Button SetOverdraftBtn;
        private System.Windows.Forms.Button SetMaxWithdrawalBtn;
        private System.Windows.Forms.TextBox CheckingAmtTextBox;
        private System.Windows.Forms.Label AccountNumberText;
        private System.Windows.Forms.TextBox AcctNumTextBox;
        private IconButton SubmitAcctNumButton;
        private System.Windows.Forms.Label Warning;
    }
}