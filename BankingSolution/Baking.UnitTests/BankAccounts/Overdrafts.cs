
namespace Baking.UnitTests.BankAccounts
{
    public class Overdrafts
    {
        

        [Fact]

        public void DoesNotDecreaseTheBalanceAndThrowsException()
        {
            var account = new BankAccount(new Mock<ICanCalculateBonusesForBankAccountDeposits>().Object);
            var openingBalance = account.GetBalance();
            var amountToWithdraw = openingBalance + .01M;

            var caught = false;
            try
            {
                account.Withdraw(amountToWithdraw);
            }catch(AccountOverdraftException)
            {
                caught = true; 
            }
            Assert.True(caught);
            Assert.Equal(openingBalance, account.GetBalance());
        }
    }
}
