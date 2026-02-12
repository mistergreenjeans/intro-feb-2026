using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Tests.MakingWithdrawals;

public class WithdrawDecreasesBalance
{
    [Fact]
    public void Depositing()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = 123.23M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
    [Fact]
    public void Overdraft()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance * 2;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance, account.GetBalance());
    }
    [Fact]
    public void TransactionMustBeCorrect()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = -100;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance, account.GetBalance());
    }
}
