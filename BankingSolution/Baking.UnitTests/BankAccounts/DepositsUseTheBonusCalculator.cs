﻿
using Banking.Domain;

namespace Baking.UnitTests.BankAccounts
{
    public class DepositsUseTheBonusCalculator
    {
        [Fact]
        public void BonusCalculatorIsUsedAndBonusAppliedToBalance()
        {
            // Given
            var stubbedBonusCalculator = new Mock<ICanCalculateBonusesForBankAccountDeposits>();
            var account = new BankAccount(stubbedBonusCalculator.Object);



            var openingBalance = account.GetBalance();
            var amountToDeposit = 112.23M;
            var amountOfBonusToReturn = 69.23M;
            stubbedBonusCalculator.Setup(b => b.CalculateBonusForDeposit(
                openingBalance,
                amountToDeposit)
            ).Returns(amountOfBonusToReturn);




            // When
            account.Deposit(amountToDeposit);



            // Then
            Assert.Equal(
                openingBalance +
                amountOfBonusToReturn +
                amountToDeposit,
                account.GetBalance()
                );



        }
    }
}
