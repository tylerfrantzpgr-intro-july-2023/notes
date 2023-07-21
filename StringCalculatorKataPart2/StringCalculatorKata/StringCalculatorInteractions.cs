using Castle.Core.Logging;

namespace StringCalculatorKata
{
    internal class StringCalculatorInteractions
    {

        [Fact]
        public void ResultsAreLogged()
        {
            var loggerMock = new Mock<ILogger>();

            var calculator = new StringCalculator(loggerMock.Object);
            calculator.Add("15");

            loggerMock.Verify(logger ==> logger.Log("15"));

        }
    }
}
