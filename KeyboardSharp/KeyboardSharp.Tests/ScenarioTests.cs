using KeyboardSharp.Shared;
using System;
using Xunit;

namespace KeyboardSharp.Tests
{
    public class ScenarioTests
    {
        [Fact]
        public void CreateAndGetNext()
        {
            var scenario = new Scenario(new string[] { "f", "j" });
            Assert.Equal(0, scenario.Counter);

            for(int i = 0; i < 10; i++)
            {
                var next = scenario.Next();
                if (i % 2 == 0)
                    Assert.Equal("f", next);
                else
                    Assert.Equal("j", next);
                
                Assert.Equal(i + 1, scenario.Counter);
            }
        }

        [Fact]
        public void CreateAndGetNextRandom()
        {
            var scenario = new Scenario(new string[] { "f", "j" });
            Assert.Equal(0, scenario.Counter);

            for (int i = 0; i < 10; i++)
            {
                var next = scenario.NextRandom();
                Assert.True(next == "f" || next == "j");
                Assert.Equal(i + 1, scenario.Counter);
            }
        }
    }
}
