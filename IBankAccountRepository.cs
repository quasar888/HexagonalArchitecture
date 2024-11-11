using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports
{
    public interface IBankAccountRepository
    {
        BankAccount GetAccount(int accountId);
        void UpdateAccount(BankAccount account);
        void CreateAccount(BankAccount account);
    }
}