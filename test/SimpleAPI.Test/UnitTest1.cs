using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Shaun Blackmore", returnValue.Value);
        }

        [Fact]
       public void Test()
       {
           Assert.True(true);
       }
    }
}
