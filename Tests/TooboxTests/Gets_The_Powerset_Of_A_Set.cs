using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace Euler.Tests.TooboxTests
{
    public class Gets_The_Powerset_Of_A_Set
    {
        [Theory]
        [ClassData(typeof(TestArgumentGenerator))]
        public void Returns_The_Powerset_Of_The_Provided_Set(long[] set, IEnumerable<IEnumerable<long>> expected)
        {
            Toolbox.GetPowerSet(set).ShouldBeEquivalentTo(expected);
        }

        class TestArgumentGenerator : IEnumerable<object[]>
        {
            private readonly IList<object[]> data;

            public TestArgumentGenerator()
            {
                data = new List<object[]>
                {
                    new object[] { new long[] {1}, new[] { Set(), Set(1) }},
                    new object[] { new long[] {1, 2}, new[] { Set(), Set(1), Set(2), Set(1, 2) } },
                    new object[] { new long[] {1, 2, 3}, new[] { Set(), Set(1), Set(2), Set(1, 2), Set(3), Set(1, 3), Set(2, 3), Set(1, 2, 3) } },                    
                };
            }

            private long[] Set(params long[] elements)
            {
                return elements;
            }

            public IEnumerator<object[]> GetEnumerator()
            {
                return data.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
