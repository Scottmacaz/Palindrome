using FluentAssertions;
using Palindrome.Lib;

namespace Palindrome.Tests
{
    public class IsPalindromeShould
    {
        [Theory]
        [InlineData("radar")]
        [InlineData("Neveroddoreven")]
        [InlineData("aa")]
        [InlineData("Aa")]
        [InlineData("abbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabbaabba")]
        [InlineData("aaaaaaaaaaaaaaaaaaaa")]
        [InlineData("aaaaaaaaaaaaaaaaaaaaa")]
        public void ReturnTrueForTheFollowing(string str)
        {
            var palindromeChecker = new PalindromeChecker();
            var isPalindrome = palindromeChecker.IsPalindrome(str);
            isPalindrome.Should().BeTrue();
        }

        [Theory]
        [InlineData("radarr")]
        [InlineData("Bobby")]
        [InlineData("aabb")]
        [InlineData("ababab")]
        public void ReturnFalseForTheFollowing(string str)
        {
            var palindromeChecker = new PalindromeChecker();
            var isPalindrome = palindromeChecker.IsPalindrome(str);
            isPalindrome.Should().BeFalse();
        }
    }
}