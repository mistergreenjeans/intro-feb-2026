
namespace Banking.Domain;

public class Account
{
    decimal balance = 5000;
    public void Deposit(decimal amountToDeposit)
    {
       
        balance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return balance; // Fake. Bs. Slime. 
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if(amountToWithdraw <= balance && amountToWithdraw >= 0)
        {
            balance -= amountToWithdraw;
        }
        
    }
}