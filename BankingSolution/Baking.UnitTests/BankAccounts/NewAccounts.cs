
using Banking.Domain;

namespace Baking.UnitTests.BankAccounts
{
    public class NewAccounts
    {
        [Fact]
        public void NewAccoutnsHaveCorrectOpeningBalance()
        {
            var account = new BankAccount(new Mock<ICanCalculateBonusesForBankAccountDeposits>().Object);

            decimal balance = account.GetBalance();

            Assert.Equal(5000, balance);
        
        }
    }
}
