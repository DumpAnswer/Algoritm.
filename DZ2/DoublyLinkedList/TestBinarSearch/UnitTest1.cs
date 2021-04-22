using System;
using Xunit;
using BinarSearch;

namespace TestBinarSearch
{
    public class UnitTest1
    {
        int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        [Fact]
        public void Test1()
        {

            int searchValue = 11;
            int expected = 10;   
            var actual = Program.BinarySearch(inputArray, searchValue);

            Assert.Equal(expected, actual);

           

        }
        [Fact]
        public void Test2()
        {

            int searchValue = 19;
            int expected = 18;
            var actual = Program.BinarySearch(inputArray, searchValue);

            Assert.Equal(expected, actual);



        }
    }
}
