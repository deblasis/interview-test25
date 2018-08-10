using System;
using System.IO;
using Xunit;

namespace Anagrams.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FileExists()
        {
            var filePath = "./words.txt";
            var expected = File.Exists(filePath);
            Assert.True(expected);
        }


        //TODO: Implement here
        //Feel free to rename, add, delete, do whatever you want. Good luck!
    }
}
