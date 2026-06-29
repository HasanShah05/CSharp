using System;

class Bank
{
    private int balance = 1000;

    public void ShowBalance()
    {
        Console.WriteLine(balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();
        bank.ShowBalance();

    }
}