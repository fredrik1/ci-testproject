using Should.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CI.Demo.Tests
{
    public class Feature
    {
        public class Constructor
        {
            [Fact]
            public void ValidatesNameIsNotNull()
            {
                //Test
                Assert.Throws<ArgumentNullException>(() =>
                {
                    new Demo.Feature(null);
                });
            }

            [Fact]
            public void ValidatesNameIsNotEmpty()
            {
                Assert.Throws<ArgumentNullException>(() =>
                {
                    new Demo.Feature("");
                });
            }

            [Fact]
            public void StoresTheNameInLowercase()
            {
                var subject = new Demo.Feature("My UPPERcase Feature");
                subject.Name.Should().Equal("my uppercase feature");
            }
        }
    }
}
