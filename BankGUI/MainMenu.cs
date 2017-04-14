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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckingAccountButton_Click(object sender, EventArgs e)
        {
            CheckingAccount checkingAccount = new CheckingAccount();
            this.Hide();
            checkingAccount.Show();
            
        }

        private void SavingsAccountButton_Click(object sender, EventArgs e)
        {
            SavingsAccount savingsAccount = new SavingsAccount();
            this.Hide();
            savingsAccount.Show();
        }
    }
}
