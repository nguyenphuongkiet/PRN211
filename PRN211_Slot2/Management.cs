using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRN211_Slot2
{
    public partial class Management : Form
    {
        BankAccountRepository _bankAccount;
        AccountTypeRepository _accountType;
        List<BankAccount> _list;
        private BankAccount BankAccount { get; set; }

        public Management()
        {
            InitializeComponent();

            _accountType = new AccountTypeRepository();

            var list = _accountType.GetAll();
            cboType.DisplayMember = "typeName";
            cboType.ValueMember = "typeId";
            cboType.DataSource = list;

            LoadList();
        }

        private void LoadList()
        {
            _bankAccount = new BankAccountRepository();
            _accountType = new AccountTypeRepository();
            _list = _bankAccount.GetAll().Select(p =>
            {
                p.Type = _accountType.GetAll().FirstOrDefault(t => t.TypeId == p.TypeId);
                return p;
            })
            .ToList();
            dgvBankAccount.DataSource = new BindingSource() { DataSource = _list };

        }
        private void resetState()
        {
            txtAccountIDEdit.Text = "";
            txtAccountNameEdit.Text = "";
            dtpOpenDateEdit.Text = "";
            txtBranchNameEdit.Text = "";
            txtSearch.Text = "";
            cboTypeEdit.SelectedIndex = 0;
        }

            private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            var account = _bankAccount.GetAll().Where(x => x.BranchName.Contains(search));
            dgvBankAccount.DataSource = new BindingSource() { DataSource = account };

        }

        private BankAccount getAccount()
        {
            try
            {
                BankAccount account = null;
                _accountType = new AccountTypeRepository();
                String id = txtAccountID.Text;
                String name = txtAccountName.Text;
                String branch = txtBranchName.Text;
                DateTime date = dtpOpenDate.Value;
                String typeId = cboType.SelectedValue.ToString();


                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(branch))
                {
                    throw new FormatException("All field must not be inputted");
                }
                else if (!branch.Split(' ').All(word => char.IsUpper(word[0])))
                {
                    throw new FormatException("Each word in branch name must begin with a capital letter");
                }

                else if (branch.Count() < 5)
                {
                    throw new FormatException("Branch name must greater than 5 characters");
                }
                else if (_bankAccount.GetAll().FirstOrDefault(a => a.AccountId == id) != null)
                {
                    throw new FormatException("AccountID already existed");
                }
                else
                {
                    account = new BankAccount(id, name, date, branch, typeId);
                }
                return account;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK);
                return null;
            }
            catch
            {
                MessageBox.Show("fail!", "Thong bao", MessageBoxButtons.OK);

                return null;
            }
        }

        private BankAccount getAccountEdit()
        {
            try
            {
                BankAccount account = null;
                _accountType = new AccountTypeRepository();
                String id = txtAccountIDEdit.Text;
                String name = txtAccountNameEdit.Text;
                String branch = txtBranchNameEdit.Text;
                DateTime date = dtpOpenDateEdit.Value;
                String typeId = cboTypeEdit.SelectedValue.ToString();


                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(branch))
                {
                    throw new FormatException("All field must not be inputted");
                }
                else if (!branch.Split(' ').All(word => char.IsUpper(word[0])))
                {
                    throw new FormatException("Each word in branch name must begin with a capital letter");
                }

                else if (branch.Count() < 5)
                {
                    throw new FormatException("Branch name must greater than 5 characters");
                }
                /*else if (_bankAccount.GetAll().FirstOrDefault(a => a.AccountId == id) != null)
                {
                    throw new FormatException("AccountID already existed");
                }*/
                else
                {
                    account = new BankAccount(id, name, date, branch, typeId);
                }
                return account;
            }catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK);
                return null;
            }
            catch
            {
                MessageBox.Show("fail!", "Thong bao", MessageBoxButtons.OK);

                return null;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _bankAccount = new BankAccountRepository();
            BankAccount account = getAccount();
            if (account == null)
            {

            }
            else
            {
                _bankAccount.Add(account);
                LoadList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _bankAccount = new BankAccountRepository();
            BankAccount account = getAccountEdit();
            if (account == null)
            {

            }
            else
            {
                _bankAccount.Update(account);
                LoadList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = txtAccountIDEdit.Text;
            _bankAccount = new BankAccountRepository();
            BankAccount account = _bankAccount.GetAccount(id);
            if (account != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to detele the account with id: " + id, "Thong bao", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _bankAccount.Delete(account);
                    LoadList();
                    resetState();
                }
            }
        }

        private void dgvBankAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var account = _list[e.RowIndex];
            txtAccountIDEdit.Text = account.AccountId.ToString();
            txtAccountNameEdit.Text = account.AccountName.ToString();
            txtBranchNameEdit.Text = account.BranchName.ToString();
            dtpOpenDateEdit.Value = account.OpenDate.Value;
            cboTypeEdit.Text = account.Type.ToString();
            var list = _accountType.GetAll();
            cboTypeEdit.DisplayMember = "typeName";
            cboTypeEdit.ValueMember = "typeId";
            cboTypeEdit.DataSource = list;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvBankAccount.Refresh();
            LoadList();
        }
    }
}
