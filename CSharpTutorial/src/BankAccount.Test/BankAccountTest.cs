using BankAccountDll;


namespace BankAccount.Test;

public class BankAccountUnitTest
{
    [Fact]
    public void BankAccount_Withdrawn_OutOfRangeException()
    {   
        BankAccountDll.BankAccount bankAccount = new BankAccountDll.BankAccount();
        bankAccount.Deposit(100.0);
        Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => bankAccount.Withdrawn(10));
    }
}