namespace BankGUI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BankTitle = new System.Windows.Forms.Label();
            this.AppalachianLogo = new System.Windows.Forms.PictureBox();
            this.CheckingAccountButton = new System.Windows.Forms.Button();
            this.SavingsAccountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppalachianLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BankTitle
            // 
            this.BankTitle.AutoSize = true;
            this.BankTitle.Font = new System.Drawing.Font("Open Sans", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankTitle.Location = new System.Drawing.Point(146, 317);
            this.BankTitle.Name = "BankTitle";
            this.BankTitle.Size = new System.Drawing.Size(664, 71);
            this.BankTitle.TabIndex = 0;
            this.BankTitle.Text = "Welcome To The AppBank";
            this.BankTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // AppalachianLogo
            // 
            this.AppalachianLogo.Image = ((System.Drawing.Image)(resources.GetObject("AppalachianLogo.Image")));
            this.AppalachianLogo.Location = new System.Drawing.Point(12, 13);
            this.AppalachianLogo.Name = "AppalachianLogo";
            this.AppalachianLogo.Size = new System.Drawing.Size(941, 292);
            this.AppalachianLogo.TabIndex = 1;
            this.AppalachianLogo.TabStop = false;
            // 
            // CheckingAccountButton
            // 
            this.CheckingAccountButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckingAccountButton.Location = new System.Drawing.Point(158, 414);
            this.CheckingAccountButton.Name = "CheckingAccountButton";
            this.CheckingAccountButton.Size = new System.Drawing.Size(310, 88);
            this.CheckingAccountButton.TabIndex = 2;
            this.CheckingAccountButton.Text = "Start Checking Account";
            this.CheckingAccountButton.UseVisualStyleBackColor = true;
            this.CheckingAccountButton.Click += new System.EventHandler(this.CheckingAccountButton_Click);
            // 
            // SavingsAccountButton
            // 
            this.SavingsAccountButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsAccountButton.Location = new System.Drawing.Point(508, 414);
            this.SavingsAccountButton.Name = "SavingsAccountButton";
            this.SavingsAccountButton.Size = new System.Drawing.Size(302, 88);
            this.SavingsAccountButton.TabIndex = 3;
            this.SavingsAccountButton.Text = "Start Savings Account";
            this.SavingsAccountButton.UseVisualStyleBackColor = true;
            this.SavingsAccountButton.Click += new System.EventHandler(this.SavingsAccountButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 537);
            this.Controls.Add(this.SavingsAccountButton);
            this.Controls.Add(this.CheckingAccountButton);
            this.Controls.Add(this.AppalachianLogo);
            this.Controls.Add(this.BankTitle);
            this.Name = "MainMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AppalachianLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BankTitle;
        private System.Windows.Forms.PictureBox AppalachianLogo;
        private System.Windows.Forms.Button CheckingAccountButton;
        private System.Windows.Forms.Button SavingsAccountButton;
    }
}

