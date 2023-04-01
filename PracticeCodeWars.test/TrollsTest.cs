using PracticeCodeWares;
using System;

namespace PracticeCodeWars.test
{
    
    public class TrollsTest
    {
        [Theory]
        [InlineData(null, "")]
        [InlineData("This website is for losers LOL!", "Ths wbst s fr lsrs LL!")]
        [InlineData("No offense but,\nYour writing is among the worst I've ever read", "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd")]
        [InlineData("What are you, a communist?", "Wht r y,  cmmnst?")]
        [InlineData("123", "123")]
        public void Disemvowel_test(string input, string expected)
        {

            //act
            var result = Trolls.Disemvowel(input);

            //assert
            Assert.Equal(result, expected);
        }
    }
}