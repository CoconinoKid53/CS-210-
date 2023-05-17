using System;

class Program
{
    static void Main(string[] args)
    {
        var savings = new account();
        savings.Deposit(500);
        savings.Deposit(1000);

        savings._transactions.Add(400);
    }
}

public class account{

    private List<int>_transactions = new List<int>();

    public void Deposit(int amount) {
        _transactions.Add(amount);
        
    public int Balance() {
        var balance = 0;
        foreach (var transactions in _transactions) {
            balance += transaction;
        }

        return balance;
    }

    }
}