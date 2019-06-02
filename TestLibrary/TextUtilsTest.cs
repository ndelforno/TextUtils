using Xunit;
using TextUtils;
using System.Diagnostics;

namespace TestLibrary
{
    public class TextUtils_GetWordCountShould
    {
        [Fact]
        public void IgnoreCasing()
        {
            var wordCount = WordCount.GetWordCount("Jack", "Jack jack");

            Assert.Equal(2, wordCount);
        }
    }
}