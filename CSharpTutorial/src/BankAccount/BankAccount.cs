using System;


namespace BankAccountDll;
public class BankAccount
{
    private double _amount = 0;

    public double Amount 
    {
        get { return _amount; }
    }

    public void Withdrawn(double amount)
    {
        double new_amount = Amount - amount;
        if (new_amount < 0)
        {
            throw new ArgumentOutOfRangeException($"Amount {new_amount}");
        }
        else
        {
            _amount = new_amount;
        }
    }

    public void Deposit(double amount)
    {
        _amount += amount;
    }
}
