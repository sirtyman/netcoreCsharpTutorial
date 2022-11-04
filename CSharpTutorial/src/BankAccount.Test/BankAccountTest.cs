using BankAccountDll;


namespace BankAccount.Test;

public class BankAccountUnitTest
{
    [Fact]
    public void BankAccount_Withdrawn_OutOfRangeException()
    {   
        BankAccountDll.BankAccount bankAccount = new BankAccountDll.BankAccount();
        bankAccount.Deposit(100.0);
        Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => bankAccount.Withdrawn(100.01));
    }

    [Theory]
    [InlineData(50.0, 40.0, 90.0)]
    public void Test_Deposit_ExpectedAmount(double deposit1, double deposit2, double expected)
    {
        var bankAccount = new BankAccountDll.BankAccount();
        bankAccount.Deposit(deposit1);
        bankAccount.Deposit(deposit2);
        Assert.Equal(bankAccount.Amount, expected);
    }
}