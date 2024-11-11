using Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services

{
    public class BankAccountService
    {
        private readonly IBankAccountRepository _repository;

        public BankAccountService(IBankAccountRepository repository)
        {
            _repository = repository;
        }

        public void Deposit(int accountId, decimal amount)
        {
            var account = _repository.GetAccount(accountId);
            account.Deposit(amount);
            _repository.UpdateAccount(account);
        }

        public void Withdraw(int accountId, decimal amount)
        {
            var account = _repository.GetAccount(accountId);
            account.Withdraw(amount);
            _repository.UpdateAccount(account);
        }

        public decimal GetBalance(int accountId)
        {
            var account = _repository.GetAccount(accountId);
            return account.Balance;
        }
    }

}
