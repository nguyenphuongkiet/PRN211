using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class BankAccountRepository :RepositoryBase<BankAccount>
    {
        public BankAccount GetAccount(string id)
        {
            BankAccount bankAccount;
            bankAccount = this.GetAll().FirstOrDefault(p => p.AccountId == id, null);
            return bankAccount;
        }
    }
}
