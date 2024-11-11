using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Ports;
using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Adapters
{
    public class InMemoryBankAccountRepository : IBankAccountRepository
    {
        private readonly Dictionary<int, BankAccount> _accounts = new();

        public BankAccount GetAccount(int accountId)
        {
            if (_accounts.ContainsKey(accountId))
                return _accounts[accountId];

            throw new KeyNotFoundException("Account not found.");
        }

        public void UpdateAccount(BankAccount account)
        {
            _accounts[account.AccountId] = account;
        }

        public void CreateAccount(BankAccount account)
        {
            if (_accounts.ContainsKey(account.AccountId))
                throw new InvalidOperationException("Account already exists.");

            _accounts[account.AccountId] = account;
        }
    }
}