using Domain.Ports;
using Domain.Entities;
using Domain.Services;

namespace Application.Api
{
    public class BankAccountApiAdapter
    {
        private readonly BankAccountService _service;

        public BankAccountApiAdapter(BankAccountService service)
        {
            _service = service;
        }

        public void Deposit(int accountId, decimal amount)
        {
            _service.Deposit(accountId, amount);
        }

        public void Withdraw(int accountId, decimal amount)
        {
            _service.Withdraw(accountId, amount);
        }

        public decimal GetBalance(int accountId)
        {
            return _service.GetBalance(accountId);
        }
    }
}
