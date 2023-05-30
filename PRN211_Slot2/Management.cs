using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Slot2
{
    public partial class Management : Form
    {
        int index;
        private string _seacrh;
        BankAccountRepository _bankAccount;
        AccountTypeRepository _accountType;
        private BankAccount BankAccount { get; set; }

        public Management()
        {
            InitializeComponent();

            _bankAccount = new BankAccountRepository();
            _accountType = new AccountTypeRepository();

            var list = _bankAccount.GetAll();

            dgvBankAccount.DataSource = new BindingSource() { DataSource = list };
        }
        private void LoadAccountBank(string search = "")
        {
            var account = _bankAccount.GetAll().Where(x => x.BranchName.Contains(search));
            dgvBankAccount.DataSource = new BindingSource() { DataSource = account };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._seacrh = txtSearch.Text;
            LoadAccountBank(_seacrh);
        }

        private void Management_Load(object sender, EventArgs e)
        {
            var accountList = _accountType.GetAll().Select(x => x.TypeId);
            cboTypeId.Items.Clear();
            cboTypeId.Items.AddRange(accountList.ToArray());
            cboTypeId.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtAccountID.Text) || string.IsNullOrEmpty(txtAccountName.Text) || string.IsNullOrEmpty(txtBranchName.Text))
                {
                    throw new FormatException("All field must not be inputted");
                }
                else if (!txtBranchName.Text.Split(' ').All(word => char.IsUpper(word[0])))
                {
                    throw new FormatException("Each word in branch name must begin with a capital letter");
                }

                else if (txtBranchName.Text.Count() < 5)
                {
                    throw new FormatException("Branch name must greater than 5 characters");
                }
                else if (_bankAccount.GetAll().FirstOrDefault(a => a.AccountId == txtAccountID.Text) != null)
                {
                    throw new FormatException("AccountID already existed");
                }
                else
                {
                    //add bank account
                    var bankAccount = new BankAccount();
                    bankAccount.AccountId = txtAccountID.Text;
                    bankAccount.AccountName = txtAccountName.Text;
                    bankAccount.BranchName = txtBranchName.Text;
                    bankAccount.OpenDate = dtpOpenDate.Value;
                    bankAccount.TypeId = cboTypeId.SelectedItem.ToString();

                    _bankAccount.Add(bankAccount);

                }


                //bind datagridview to binding source
                dgvBankAccount.DataSource = new BindingSource() { DataSource = _bankAccount.GetAll() };
                MessageBox.Show("Add successfully", "Alert", MessageBoxButtons.OK);

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to add", "Alert", MessageBoxButtons.OK);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAccountNameEdit.Text) || string.IsNullOrEmpty(txtBranchNameEdit.Text))
                {
                    throw new FormatException("All field must not be inputted");
                }
                else if (!txtBranchNameEdit.Text.Split(' ').All(word => char.IsUpper(word[0])))
                {
                    throw new FormatException("Each word in branch name must begin with a capital letter");
                }

                else if (txtBranchNameEdit.Text.Count() < 5)
                {
                    throw new FormatException("Branch name must greater than 5 characters");
                }
                /*else if (_bankAccount.GetAll().First(a => a.AccountId == txtAccountIDEdit.Text) != null)
                {
                    throw new FormatException("AccountID already existed");
                }*/
                else
                {
                    var bankAccount = _bankAccount.GetAll()[dgvBankAccount.CurrentRow.Index];

                    bankAccount.AccountId = txtAccountIDEdit.Text;
                    bankAccount.AccountName = txtAccountNameEdit.Text;
                    bankAccount.BranchName = txtBranchNameEdit.Text;
                    bankAccount.OpenDate = dtpOpenDateEdit.Value;
                    bankAccount.TypeId = cboTypeIDEdit.Text;

                    _bankAccount.Update(bankAccount);
                    dgvBankAccount.Refresh();
                    MessageBox.Show("Update Successfully!", "Alert", MessageBoxButtons.OK);

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to update", "Alert", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var account = _bankAccount.GetAll()[dgvBankAccount.CurrentRow.Index];
            _bankAccount.Delete(account);
            dgvBankAccount.DataSource = new BindingSource() { DataSource = _bankAccount.GetAll() };
        }

        private void dgvBankAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var account = _bankAccount.GetAll()[dgvBankAccount.CurrentRow.Index];
            txtAccountIDEdit.Text = account.AccountId.ToString();
            txtAccountNameEdit.Text = account.AccountName.ToString();
            txtBranchNameEdit.Text = account.BranchName.ToString();
            dtpOpenDateEdit.Value = account.OpenDate.Value;
            cboTypeIDEdit.Text = account.TypeId.ToString();
            var accountList = _accountType.GetAll().Select(x => x.TypeId);
            cboTypeIDEdit.Items.Clear();
            cboTypeIDEdit.Items.AddRange(accountList.ToArray());
        }

        private void dgvBankAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
