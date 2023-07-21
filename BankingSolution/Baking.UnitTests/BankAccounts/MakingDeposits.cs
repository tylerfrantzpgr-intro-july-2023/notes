
using Banking.Domain;

namespace Baking.UnitTests.BankAccounts
{
    public class MakingDeposits
    {

        [Fact]

        public void DepositsIncreaseTheBalance()
        {
            // Given
            var account = new BankAccount(new Mock<ICanCalculateBonusesForBankAccountDeposits>().Object);
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100.23M;

            // When
            account.Deposit(amountToDeposit);

            // Then
            Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
        }

        public void Demo()
        {
            var jcAccount = new BankAccount(new Mock<ICanCalculateBonusesForBankAccountDeposits>().Object);
            var joeyAccount = new BankAccount(new Mock<ICanCalculateBonusesForBankAccountDeposits>().Object);

            jcAccount.Deposit(100);

            Assert.Equal(5100, jcAccount.GetBalance());
            Assert.Equal(5000, joeyAccount.GetBalance());
        }
    }
}
