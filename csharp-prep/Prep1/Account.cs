using System.Diagnostics.CodeAnalysis;

public class Account
{
    private string _accountHolder;
    private decimal _balance;

    public Account(string accountHolderName, decimal balance)
    {
        _accountHolder = accountHolderName;
        _balance = balance;
    }
    
    public void DepositMoney(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
        else
        {
            Console.WriteLine("Negative deposit/Invalid entry");
        }
    }
    public void WithdrawMoney(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }
    public decimal Balance()
    {
        return _balance;
    }
    
        
    

}