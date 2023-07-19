using CSharpSyntax;

namespace cSharpSyntax
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 10; int b = 20; int answer;

            answer = a + b;

            Assert.Equal(32, answer);
        }

        [Theory]
        [InlineData("Han", "Solo", "Solo, Han")]

        public void FormattingMyName(string first, string last, string expected)
        {
            string fullName = Utils.FormatName(first, last);
            Assert.Equal(expected, fullName);
        }

    }
}