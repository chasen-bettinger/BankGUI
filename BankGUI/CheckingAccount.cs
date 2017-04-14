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
    public partial class CheckingAccount : Form
    {
        Checking myCheckingAccount;
        int amtMoved = 0;

        public CheckingAccount()
        {
            InitializeComponent();
        }

        private void Withdrawal_Click(object sender, EventArgs e)
        {
            double withdrawalAmt = Convert.ToDouble(CheckingAmtTextBox.Text.ToString());
           
            try
            {  
                myCheckingAccount.Withdrawal(withdrawalAmt);

                ResetErrorMessage();
            }
            catch (PolicyException exception)
            {
                if(withdrawalAmt > myCheckingAccount.MaxWithdrawal && CheckingAmtTextBox.Location.Y < 179
                    && withdrawalAmt < myCheckingAccount.Balance)
                {
                    amtMoved = 48;
                    Warning.Left += amtMoved;
                }
                else if (CheckingAmtTextBox.Location.Y < 179)
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

            CurrentBalanceAmt.Text = $"${myCheckingAccount.Balance.ToString()}";
        }

        private void CheckingDepositButton_Click(object sender, EventArgs e)
        {
            ResetErrorMessage();
            double depositAmt = Convert.ToDouble(CheckingAmtTextBox.Text);
            myCheckingAccount.Deposit(depositAmt);
            CurrentBalanceAmt.Text = $"${myCheckingAccount.Balance.ToString()}";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void SubmitAcctNumButton_Click(object sender, EventArgs e)
        {
            long acctNum = -1;

            while (acctNum < 0)
            {
                long.TryParse(AcctNumTextBox.Text, out acctNum);

                if(acctNum > 0)
                {
                    ShowCheckingElements();
                    HideAcctNumElements();
                    Warning.Refresh();

                    myCheckingAccount = new Checking(acctNum);
                    AccountNumber.Text = myCheckingAccount.AcctNo.ToString();
                    MaxWithdrawalAmt.Text = $"${myCheckingAccount.MaxWithdrawal.ToString()}";
                    OverdraftAmt.Text = $"${myCheckingAccount.OverDraft.ToString()}";
                }
                else
                {
                    
                    Warning.Show();

                    Warning.Top += 25;
                    AcctNumTextBox.Top += 25;
                    SubmitAcctNumButton.Top += 25;
                }
            }
        }

        private void HideAcctNumElements()
        {
            AccountNumberText.Hide();
            AcctNumTextBox.Hide();
            Warning.Hide();
            SubmitAcctNumButton.Hide();
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

        private void SetMaxWithdrawalBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(CheckingAmtTextBox.Text.ToString()))
            {
                double MaxWithdrawalNewAmt = Convert.ToDouble(CheckingAmtTextBox.Text.ToString());
                myCheckingAccount.MaxWithdrawal = MaxWithdrawalNewAmt;
                MaxWithdrawalAmt.Text = $"${myCheckingAccount.MaxWithdrawal.ToString()}";
            }     
        }

        private void SetOverdraftBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CheckingAmtTextBox.Text.ToString()))
            {
                double OverDraftNewAmt = Convert.ToDouble(CheckingAmtTextBox.Text.ToString());
                myCheckingAccount.OverDraft = OverDraftNewAmt;
                OverdraftAmt.Text = $"${myCheckingAccount.OverDraft.ToString()}";
            }
        } 
    }
}
