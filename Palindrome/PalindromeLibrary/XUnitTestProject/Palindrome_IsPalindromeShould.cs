using Xunit;
using PalindromeLibrary;

namespace Palindrome.Tests
{
    public class Palindrome_IsPalindromeShould
    {
        private readonly PalindromeClass _palindrome;
        public Palindrome_IsPalindromeShould()
        {
            _palindrome = new PalindromeClass();
        }

        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even")]
        [InlineData(" ")]
        public void IsPalindrome_InputIsPalindrome_ReturnTrue(string value)
        {
            var result = _palindrome.IsPalindrome(value);
            Assert.True(result, $"{value} should be a palindrome");
        }

        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void IsPalindrome_InputIsNotPalindrome_ReturnFalse(string value)
        {
            var result = _palindrome.IsPalindrome("one two one");
            Assert.False(result, $"{value} should not be a palindrome");
        }

    }
}
