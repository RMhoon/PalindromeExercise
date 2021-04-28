using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Hello", false)]
        [InlineData("RaceCar",true)]
        public void IsPalindrome(string word, bool expected)
        {
            //Arrange
            var wd = new WordSmith();

            //Act
            bool actual = wd.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
