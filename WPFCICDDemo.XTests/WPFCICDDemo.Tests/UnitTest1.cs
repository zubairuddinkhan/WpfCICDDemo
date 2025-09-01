

namespace WPFCICDDemo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.Equal(2, 1 + 1);
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(10, 20, 30)]
        public void Add_MultipleCases_ReturnsSum(int a, int b, int expected)
        {
            Assert.Equal(expected, a + b); 

        }

    }
}