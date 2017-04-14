using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankGUI
{
    public partial class SavingsAccount : Form
    {
        Savings MySavingsAccount;
        int amtMoved = 0;
        

        public SavingsAccount()
        {
            InitializeComponent();
        }

        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            double withdrawalAmt = Convert.ToDouble(CheckingAmtTextBox.Text.ToString());

            try
            {
                MySavingsAccount.Withdrawal(withdrawalAmt);

                ResetErrorMessage();
            }
            catch (PolicyException exception)
            {
                if (CheckingAmtTextBox.Location.Y < 179)
                {
                    amtMoved = 60;
                    Warning.Left += amtMoved;
                }

                if (CheckingAmtTextBox.Location.Y < 179)
                {
                    CheckingAmtTextBox.Top += 15;
                    Warning.Text = exception.Message;
                    Warning.Show();
                }
            }

            CurrentBalanceAmt.Text = $"${MySavingsAccount.Balance.ToString()}";

        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            ResetErrorMessage();
            double depositAmt = Convert.ToDouble(CheckingAmtTextBox.Text);
            MySavingsAccount.Deposit(depositAmt);
            CurrentBalanceAmt.Text = $"${MySavingsAccount.Balance.ToString()}";
        }

        private void SetInterestRateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CheckingAmtTextBox.Text.ToString()))
            {
                double InterestRateNewAmt = Convert.ToDouble(CheckingAmtTextBox.Text.ToString());
                MySavingsAccount.InterestRate = InterestRateNewAmt;
                InterestRateAmt.Text = $"${MySavingsAccount.InterestRate.ToString()}";
            }
        }

        private void SetMinAmountBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CheckingAmtTextBox.Text.ToString()))
            {
                double MinAmountNewAmt = Convert.ToDouble(CheckingAmtTextBox.Text.ToString());
                MySavingsAccount.MinBalance = MinAmountNewAmt;
                MinAmount.Text = $"${MySavingsAccount.MinBalance.ToString()}";
            }
        }

        private void HideAcctNumElements()
        {
            AccountNumberText.Hide();
            AcctNumTextBox.Hide();
            Warning.Hide();
            SubmitAcctNumButton.Hide();
            InterestEarned.Hide();
        }

        private void ShowCheckingElements()
        {
            foreach (Control c in Controls)
            {
                c.Visible = true;
            }
        }

        private void ResetErrorMessage()
        {
            if (CheckingAmtTextBox.Location.Y == 179)
            {
                CheckingAmtTextBox.Top -= 15;
                Warning.Left -= amtMoved;
                Warning.Hide();
            }
        }

        private void SubmitAcctNumButton_Click(object sender, EventArgs e)
        {
            long acctNum = -1;

            while (acctNum < 0)
            {
                long.TryParse(AcctNumTextBox.Text, out acctNum);

                if (acctNum > 0)
                {
                    ShowCheckingElements();
                    HideAcctNumElements();
                    Warning.Refresh();

                    MySavingsAccount = new Savings(acctNum);
                    AccountNumber.Text = MySavingsAccount.AcctNo.ToString();
                    InterestRateAmt.Text = $"${MySavingsAccount.InterestRate.ToString()}";
                    MinAmount.Text = $"${MySavingsAccount.MinBalance.ToString()}";
                }
                else
                {

                    Warning.Show();

                    if(Warning.Location.Y < 173)
                    {
                        Warning.Top += 25;
                        AcctNumTextBox.Top += 25;
                        SubmitAcctNumButton.Top += 25;
                    }
                  
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void LessYearsBtn_Click(object sender, EventArgs e)
        {
            int yearCounter = Convert.ToInt32(YearsNum.Text.ToString());
            if(yearCounter > 0)
            {
                yearCounter -= 1;
                YearsNum.Text = yearCounter.ToString();
            }
          
        }

        private void AddYearsBtn_Click(object sender, EventArgs e)
        {
            int yearCounter = Convert.ToInt32(YearsNum.Text.ToString());
            yearCounter += 1;
            YearsNum.Text = yearCounter.ToString();
        }

        private void ViewInterestBtn_Click(object sender, EventArgs e)
        {
            if(ViewInterestBtn.Text == "View Interest Earned")
            {
                int yearCounter = Convert.ToInt32(YearsNum.Text.ToString());

                double interestEarned = (double) (MySavingsAccount.Balance * (yearCounter * 
                    MySavingsAccount.InterestRate));

                InterestEarned.Text = $"${interestEarned.ToString()}";

                ViewInterestBtn.Text = "Reset";
                HideInterestButtons();
                InterestEarned.Show();
            }
            else if (ViewInterestBtn.Text == "Reset")
            {
                InterestEarned.Hide();
                ShowInterestButtons();
                ViewInterestBtn.Text = "View Interest Earned";

            }
        }

        private void ShowInterestButtons()
        {
            AddYearsBtn.Show();
            LessYearsBtn.Show();
            YearsLabel.Show();
            YearsNum.Show();
        }

        private void HideInterestButtons()
        {
            AddYearsBtn.Hide();
            LessYearsBtn.Hide();
            YearsLabel.Hide();
            YearsNum.Hide();
        }
    }
}
