using System.Buffers;
using System.Runtime;

public class BankAccount
{
    public string Owner;
    public double Balance;

public BankAccount(string owner, double balance)
{
    Owner = owner;
    Balance = balance;
}

public void Deposit(double amount)
{
    Balance += amount;
    Console.WriteLine($"deposited: {amount}");
}
public void Withdraw(double amount)
    {
        Balance -= amount;
        Console.WriteLine($"Withdrew {amount}");
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Owner: {Owner} - current balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount Account = new BankAccount("Mykhailo", 100);
        Account.ShowBalance();
        Account.Deposit(43.3);
        Account.Withdraw(20);
        Account.Deposit(10000);

        Console.WriteLine(" Summary");
        Account.ShowBalance();
    }
}