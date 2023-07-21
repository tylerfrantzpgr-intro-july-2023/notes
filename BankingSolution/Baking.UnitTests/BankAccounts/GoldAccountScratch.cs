
namespace Baking.UnitTests.BankAccounts
{
    public class GoldAccountScratch
    {
        [Fact]
        public void GoldAccountGetBonusOnDeposit()
        {
            var account = new BankAccount(new Mock<ICanCalculateBonusesForBankAccountDeposits>().Object);
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;
        }
    }
}
