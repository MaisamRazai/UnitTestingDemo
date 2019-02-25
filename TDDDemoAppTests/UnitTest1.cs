using System;
using tdddemoapp;
using Xunit;

namespace TDDDemoAppTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetTotalWordCount_WhenPassedRegularText_ShouldReturnExpectedCount()
        {
            const string textToAnalyze = @"xUnit.net is a free, open source, community-focused
                                        unit testing tool for the .net Framwork";
            var analyzer = new TextAnalyzer();

            var count = analyzer.GetTotalWordCount(textToAnalyze);
            Assert.Equal(14, count);
        }
        
    }
}
