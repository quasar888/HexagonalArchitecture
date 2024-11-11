using Domain.Services;
using Domain.Entities;
using Infrastructure.Adapters;

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Utiliser l'adaptateur de stockage en mémoire pour la démonstration
            var repository = new InMemoryBankAccountRepository();
            var accountService = new BankAccountService(repository);

            // Créer un compte et effectuer des opérations
            var account = new BankAccount(accountId: 1, initialBalance: 1000);
            repository.CreateAccount(account);

            accountService.Deposit(1, 500); // Dépôt de 500
            accountService.Withdraw(1, 200); // Retrait de 200

            var balance = accountService.GetBalance(1);
            Console.WriteLine($"Balance for account 1: {balance}"); // Affiche : 1300
        }
    }
}
