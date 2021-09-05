using System;
using Xunit;

namespace LeapYear.Tests
{
    public class IsItLeapYearTests
    {
        [Theory]
        [InlineData(4, true)]
        [InlineData(1600, true)]
        [InlineData(1998, false)]
        public void IsLeapYear_divisible_by_4(int input, bool expected)
        {
            var earth = new LifetimeOfEarth();

            var actual = earth.IsLeapYear(input);

            Assert.Equal(expected, actual);
        }

        /* This theory is failing.
        ** That would eventually have happened since 
        ** the givenn year can't be treatet correctly for
        ** the first two criterias of the excersise in one method.
        */
        [Theory]
        [InlineData(400, false)]
        [InlineData(1600, false)]
        [InlineData(1996, true)]
        [InlineData(2004, true)]
        public void IsLeapYear_divisible_by_4_not_100(int input, bool expected){
            
            var earth = new LifetimeOfEarth();

            var actual = earth.IsLeapYear(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(400, true)]
        [InlineData(1600, true)]
        [InlineData(1996, true)]
        [InlineData(2004, true)]
        [InlineData(1700, false)]
        public void IsLeapYear_divisible_by_4_and_400_not_100(int input, bool expected){
            
            var earth = new LifetimeOfEarth();

            var actual = earth.IsLeapYear(input);

            Assert.Equal(expected, actual);
        }
    }
}
