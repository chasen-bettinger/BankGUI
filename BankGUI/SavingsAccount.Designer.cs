namespace BankGUI
{
    partial class SavingsAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsAccount));
            this.Warning = new System.Windows.Forms.Label();
            this.SubmitAcctNumButton = new FontAwesome.Sharp.IconButton();
            this.CheckingAmtTextBox = new System.Windows.Forms.TextBox();
            this.SetInterestRateBtn = new System.Windows.Forms.Button();
            this.SetMinAmountBtn = new System.Windows.Forms.Button();
            this.AccountNumber = new System.Windows.Forms.Label();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.MinAmount = new System.Windows.Forms.Label();
            this.MinBalanceLabel = new System.Windows.Forms.Label();
            this.InterestRateAmt = new System.Windows.Forms.Label();
            this.InterestRateLabel = new System.Windows.Forms.Label();
            this.CurrentBalanceAmt = new System.Windows.Forms.Label();
            this.BackButton = new FontAwesome.Sharp.IconButton();
            this.CheckingCurrentBalanceLabel = new System.Windows.Forms.Label();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawalButton = new System.Windows.Forms.Button();
            this.AccountNumberText = new System.Windows.Forms.Label();
            this.AcctNumTextBox = new System.Windows.Forms.TextBox();
            this.AddYearsBtn = new FontAwesome.Sharp.IconButton();
            this.LessYearsBtn = new FontAwesome.Sharp.IconButton();
            this.ViewInterestBtn = new System.Windows.Forms.Button();
            this.YearsNum = new System.Windows.Forms.Label();
            this.YearsLabel = new System.Windows.Forms.Label();
            this.InterestEarned = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.Red;
            this.Warning.Location = new System.Drawing.Point(287, 228);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(421, 38);
            this.Warning.TabIndex = 36;
            this.Warning.Text = "Please enter a positive number";
            this.Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Warning.Visible = false;
            // 
            // SubmitAcctNumButton
            // 
            this.SubmitAcctNumButton.Icon = FontAwesome.Sharp.IconChar.Check;
            this.SubmitAcctNumButton.IconColor = System.Drawing.Color.Black;
            this.SubmitAcctNumButton.IconSize = 16;
            this.SubmitAcctNumButton.Image = ((System.Drawing.Image)(resources.GetObject("SubmitAcctNumButton.Image")));
            this.SubmitAcctNumButton.Location = new System.Drawing.Point(477, 326);
            this.SubmitAcctNumButton.Name = "SubmitAcctNumButton";
            this.SubmitAcctNumButton.Size = new System.Drawing.Size(57, 46);
            this.SubmitAcctNumButton.TabIndex = 35;
            this.SubmitAcctNumButton.UseVisualStyleBackColor = true;
            this.SubmitAcctNumButton.Click += new System.EventHandler(this.SubmitAcctNumButton_Click);
            // 
            // CheckingAmtTextBox
            // 
            this.CheckingAmtTextBox.Location = new System.Drawing.Point(416, 254);
            this.CheckingAmtTextBox.Name = "CheckingAmtTextBox";
            this.CheckingAmtTextBox.Size = new System.Drawing.Size(189, 26);
            this.CheckingAmtTextBox.TabIndex = 32;
            this.CheckingAmtTextBox.Text = "0";
            this.CheckingAmtTextBox.Visible = false;
            // 
            // SetInterestRateBtn
            // 
            this.SetInterestRateBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetInterestRateBtn.Location = new System.Drawing.Point(434, 426);
            this.SetInterestRateBtn.Name = "SetInterestRateBtn";
            this.SetInterestRateBtn.Size = new System.Drawing.Size(207, 88);
            this.SetInterestRateBtn.TabIndex = 31;
            this.SetInterestRateBtn.Text = "Set Interest Rate";
            this.SetInterestRateBtn.UseVisualStyleBackColor = true;
            this.SetInterestRateBtn.Visible = false;
            this.SetInterestRateBtn.Click += new System.EventHandler(this.SetInterestRateBtn_Click);
            // 
            // SetMinAmountBtn
            // 
            this.SetMinAmountBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetMinAmountBtn.Location = new System.Drawing.Point(197, 426);
            this.SetMinAmountBtn.Name = "SetMinAmountBtn";
            this.SetMinAmountBtn.Size = new System.Drawing.Size(207, 88);
            this.SetMinAmountBtn.TabIndex = 30;
            this.SetMinAmountBtn.Text = "Set Min Amount";
            this.SetMinAmountBtn.UseVisualStyleBackColor = true;
            this.SetMinAmountBtn.Visible = false;
            this.SetMinAmountBtn.Click += new System.EventHandler(this.SetMinAmountBtn_Click);
            // 
            // AccountNumber
            // 
            this.AccountNumber.AutoSize = true;
            this.AccountNumber.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumber.Location = new System.Drawing.Point(638, 9);
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Size = new System.Drawing.Size(47, 55);
            this.AccountNumber.TabIndex = 29;
            this.AccountNumber.Text = "0";
            this.AccountNumber.Visible = false;
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.AutoSize = true;
            this.AccountNumberLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberLabel.Location = new System.Drawing.Point(275, 9);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(361, 55);
            this.AccountNumberLabel.TabIndex = 28;
            this.AccountNumberLabel.Text = "Account Number: ";
            this.AccountNumberLabel.Visible = false;
            // 
            // MinAmount
            // 
            this.MinAmount.AutoSize = true;
            this.MinAmount.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinAmount.Location = new System.Drawing.Point(638, 174);
            this.MinAmount.Name = "MinAmount";
            this.MinAmount.Size = new System.Drawing.Size(70, 55);
            this.MinAmount.TabIndex = 27;
            this.MinAmount.Text = "$0";
            this.MinAmount.Visible = false;
            // 
            // MinBalanceLabel
            // 
            this.MinBalanceLabel.AutoSize = true;
            this.MinBalanceLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBalanceLabel.Location = new System.Drawing.Point(275, 174);
            this.MinBalanceLabel.Name = "MinBalanceLabel";
            this.MinBalanceLabel.Size = new System.Drawing.Size(282, 55);
            this.MinBalanceLabel.TabIndex = 26;
            this.MinBalanceLabel.Text = "Min Balance : ";
            this.MinBalanceLabel.Visible = false;
            // 
            // InterestRateAmt
            // 
            this.InterestRateAmt.AutoSize = true;
            this.InterestRateAmt.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestRateAmt.Location = new System.Drawing.Point(638, 119);
            this.InterestRateAmt.Name = "InterestRateAmt";
            this.InterestRateAmt.Size = new System.Drawing.Size(70, 55);
            this.InterestRateAmt.TabIndex = 25;
            this.InterestRateAmt.Text = "$0";
            this.InterestRateAmt.Visible = false;
            // 
            // InterestRateLabel
            // 
            this.InterestRateLabel.AutoSize = true;
            this.InterestRateLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestRateLabel.Location = new System.Drawing.Point(275, 119);
            this.InterestRateLabel.Name = "InterestRateLabel";
            this.InterestRateLabel.Size = new System.Drawing.Size(291, 55);
            this.InterestRateLabel.TabIndex = 24;
            this.InterestRateLabel.Text = "Interest Rate : ";
            this.InterestRateLabel.Visible = false;
            // 
            // CurrentBalanceAmt
            // 
            this.CurrentBalanceAmt.AutoSize = true;
            this.CurrentBalanceAmt.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalanceAmt.Location = new System.Drawing.Point(638, 64);
            this.CurrentBalanceAmt.Name = "CurrentBalanceAmt";
            this.CurrentBalanceAmt.Size = new System.Drawing.Size(70, 55);
            this.CurrentBalanceAmt.TabIndex = 23;
            this.CurrentBalanceAmt.Text = "$0";
            this.CurrentBalanceAmt.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Icon = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BackButton.IconColor = System.Drawing.Color.Black;
            this.BackButton.IconSize = 32;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(19, 24);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(57, 46);
            this.BackButton.TabIndex = 22;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CheckingCurrentBalanceLabel
            // 
            this.CheckingCurrentBalanceLabel.AutoSize = true;
            this.CheckingCurrentBalanceLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckingCurrentBalanceLabel.Location = new System.Drawing.Point(275, 64);
            this.CheckingCurrentBalanceLabel.Name = "CheckingCurrentBalanceLabel";
            this.CheckingCurrentBalanceLabel.Size = new System.Drawing.Size(354, 55);
            this.CheckingCurrentBalanceLabel.TabIndex = 21;
            this.CheckingCurrentBalanceLabel.Text = "Current Balance : ";
            this.CheckingCurrentBalanceLabel.Visible = false;
            // 
            // DepositButton
            // 
            this.DepositButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositButton.Location = new System.Drawing.Point(434, 318);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(207, 88);
            this.DepositButton.TabIndex = 20;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Visible = false;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawalButton
            // 
            this.WithdrawalButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawalButton.Location = new System.Drawing.Point(197, 318);
            this.WithdrawalButton.Name = "WithdrawalButton";
            this.WithdrawalButton.Size = new System.Drawing.Size(207, 88);
            this.WithdrawalButton.TabIndex = 19;
            this.WithdrawalButton.Text = "Withdrawal";
            this.WithdrawalButton.UseVisualStyleBackColor = true;
            this.WithdrawalButton.Visible = false;
            this.WithdrawalButton.Click += new System.EventHandler(this.WithdrawalButton_Click);
            // 
            // AccountNumberText
            // 
            this.AccountNumberText.AutoSize = true;
            this.AccountNumberText.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberText.Location = new System.Drawing.Point(187, 215);
            this.AccountNumberText.Name = "AccountNumberText";
            this.AccountNumberText.Size = new System.Drawing.Size(627, 55);
            this.AccountNumberText.TabIndex = 33;
            this.AccountNumberText.Text = "Please enter an account number";
            // 
            // AcctNumTextBox
            // 
            this.AcctNumTextBox.Location = new System.Drawing.Point(416, 276);
            this.AcctNumTextBox.Name = "AcctNumTextBox";
            this.AcctNumTextBox.Size = new System.Drawing.Size(184, 26);
            this.AcctNumTextBox.TabIndex = 34;
            // 
            // AddYearsBtn
            // 
            this.AddYearsBtn.Icon = FontAwesome.Sharp.IconChar.Plus;
            this.AddYearsBtn.IconColor = System.Drawing.Color.Black;
            this.AddYearsBtn.IconSize = 20;
            this.AddYearsBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddYearsBtn.Image")));
            this.AddYearsBtn.Location = new System.Drawing.Point(678, 343);
            this.AddYearsBtn.Name = "AddYearsBtn";
            this.AddYearsBtn.Size = new System.Drawing.Size(57, 46);
            this.AddYearsBtn.TabIndex = 37;
            this.AddYearsBtn.UseVisualStyleBackColor = true;
            this.AddYearsBtn.Visible = false;
            this.AddYearsBtn.Click += new System.EventHandler(this.AddYearsBtn_Click);
            // 
            // LessYearsBtn
            // 
            this.LessYearsBtn.Icon = FontAwesome.Sharp.IconChar.Minus;
            this.LessYearsBtn.IconColor = System.Drawing.Color.Black;
            this.LessYearsBtn.IconSize = 20;
            this.LessYearsBtn.Image = ((System.Drawing.Image)(resources.GetObject("LessYearsBtn.Image")));
            this.LessYearsBtn.Location = new System.Drawing.Point(828, 343);
            this.LessYearsBtn.Name = "LessYearsBtn";
            this.LessYearsBtn.Size = new System.Drawing.Size(57, 46);
            this.LessYearsBtn.TabIndex = 38;
            this.LessYearsBtn.UseVisualStyleBackColor = true;
            this.LessYearsBtn.Visible = false;
            this.LessYearsBtn.Click += new System.EventHandler(this.LessYearsBtn_Click);
            // 
            // ViewInterestBtn
            // 
            this.ViewInterestBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewInterestBtn.Location = new System.Drawing.Point(678, 426);
            this.ViewInterestBtn.Name = "ViewInterestBtn";
            this.ViewInterestBtn.Size = new System.Drawing.Size(207, 88);
            this.ViewInterestBtn.TabIndex = 39;
            this.ViewInterestBtn.Text = "View Interest Earned";
            this.ViewInterestBtn.UseVisualStyleBackColor = true;
            this.ViewInterestBtn.Visible = false;
            this.ViewInterestBtn.Click += new System.EventHandler(this.ViewInterestBtn_Click);
            // 
            // YearsNum
            // 
            this.YearsNum.AutoSize = true;
            this.YearsNum.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearsNum.Location = new System.Drawing.Point(770, 351);
            this.YearsNum.Name = "YearsNum";
            this.YearsNum.Size = new System.Drawing.Size(23, 27);
            this.YearsNum.TabIndex = 40;
            this.YearsNum.Text = "0";
            this.YearsNum.Visible = false;
            // 
            // YearsLabel
            // 
            this.YearsLabel.AutoSize = true;
            this.YearsLabel.Font = new System.Drawing.Font("Open Sans", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearsLabel.Location = new System.Drawing.Point(747, 318);
            this.YearsLabel.Name = "YearsLabel";
            this.YearsLabel.Size = new System.Drawing.Size(67, 27);
            this.YearsLabel.TabIndex = 41;
            this.YearsLabel.Text = "Years";
            this.YearsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YearsLabel.Visible = false;
            // 
            // InterestEarned
            // 
            this.InterestEarned.AutoSize = true;
            this.InterestEarned.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestEarned.Location = new System.Drawing.Point(744, 334);
            this.InterestEarned.Name = "InterestEarned";
            this.InterestEarned.Size = new System.Drawing.Size(70, 55);
            this.InterestEarned.TabIndex = 42;
            this.InterestEarned.Text = "$0";
            this.InterestEarned.Visible = false;
            // 
            // SavingsAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 537);
            this.Controls.Add(this.InterestEarned);
            this.Controls.Add(this.YearsLabel);
            this.Controls.Add(this.YearsNum);
            this.Controls.Add(this.ViewInterestBtn);
            this.Controls.Add(this.LessYearsBtn);
            this.Controls.Add(this.AddYearsBtn);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.SubmitAcctNumButton);
            this.Controls.Add(this.CheckingAmtTextBox);
            this.Controls.Add(this.SetInterestRateBtn);
            this.Controls.Add(this.SetMinAmountBtn);
            this.Controls.Add(this.AccountNumber);
            this.Controls.Add(this.AccountNumberLabel);
            this.Controls.Add(this.MinAmount);
            this.Controls.Add(this.MinBalanceLabel);
            this.Controls.Add(this.InterestRateAmt);
            this.Controls.Add(this.InterestRateLabel);
            this.Controls.Add(this.CurrentBalanceAmt);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CheckingCurrentBalanceLabel);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.WithdrawalButton);
            this.Controls.Add(this.AccountNumberText);
            this.Controls.Add(this.AcctNumTextBox);
            this.Name = "SavingsAccount";
            this.Text = "SavingsAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Warning;
        private FontAwesome.Sharp.IconButton SubmitAcctNumButton;
        private System.Windows.Forms.TextBox CheckingAmtTextBox;
        private System.Windows.Forms.Button SetInterestRateBtn;
        private System.Windows.Forms.Button SetMinAmountBtn;
        private System.Windows.Forms.Label AccountNumber;
        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.Label MinAmount;
        private System.Windows.Forms.Label MinBalanceLabel;
        private System.Windows.Forms.Label InterestRateAmt;
        private System.Windows.Forms.Label InterestRateLabel;
        private System.Windows.Forms.Label CurrentBalanceAmt;
        private FontAwesome.Sharp.IconButton BackButton;
        private System.Windows.Forms.Label CheckingCurrentBalanceLabel;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button WithdrawalButton;
        private System.Windows.Forms.Label AccountNumberText;
        private System.Windows.Forms.TextBox AcctNumTextBox;
        private FontAwesome.Sharp.IconButton AddYearsBtn;
        private FontAwesome.Sharp.IconButton LessYearsBtn;
        private System.Windows.Forms.Button ViewInterestBtn;
        private System.Windows.Forms.Label YearsNum;
        private System.Windows.Forms.Label YearsLabel;
        private System.Windows.Forms.Label InterestEarned;
    }
}