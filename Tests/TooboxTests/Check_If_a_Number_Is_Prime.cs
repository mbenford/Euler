using Xunit;

namespace ProjectEuler.Tests.ToolboxTests
{
    public class Check_If_a_Number_Is_Prime
    {
        [Fact]
        public void Returns_True_When_Passing_2()
        {
            Assert.True(Toolbox.IsPrime(2));
        }

        [Fact]
        public void Returns_True_When_Passing_3()
        {
            Assert.True(Toolbox.IsPrime(3));
        }

        [Fact]
        public void Returns_False_When_Passing_4()
        {
            Assert.False(Toolbox.IsPrime(4));
        }

        [Fact]
        public void Returns_True_When_Passing_5()
        {
            Assert.True(Toolbox.IsPrime(5));
        }

        [Fact]
        public void Returns_False_When_Passing_6()
        {
            Assert.False(Toolbox.IsPrime(6));
        }

        [Fact]
        public void Returns_True_When_Passing_7()
        {
            Assert.True(Toolbox.IsPrime(7));
        }

        [Fact]
        public void Returns_False_When_Passing_8()
        {
            Assert.False(Toolbox.IsPrime(8));
        }

        [Fact]
        public void Returns_False_When_Passing_9()
        {
            Assert.False(Toolbox.IsPrime(9));
        }

        [Fact]
        public void Returns_True_When_Passing_29()
        {
            Assert.True(Toolbox.IsPrime(29));
        }

        [Fact]
        public void Returns_True_When_Passing_13()
        {
            Assert.True(Toolbox.IsPrime(13));
        }

        [Fact]
        public void Returns_True_When_Passing_19()
        {
            Assert.True(Toolbox.IsPrime(19));
        }
    }
}
