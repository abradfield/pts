using System.Collections.Generic;
using NUnit.Framework;

namespace Operations.Tests
{
    [TestFixture]
    public class AboveBelowTests
    {
        [Test]
            public void Should_handle_empty_list_of_numbers()
            {
                var numbers = new List<int>();
                var result = Operations.AboveBelow(numbers, 1);

                Assert.Multiple(() => {
                    Assert.That(result["above"], Is.EqualTo(0));
                    Assert.That(result["below"], Is.EqualTo(0));
                });
            }

            [Test]
            public void Should_handle_positive_comparison()
            {
                var numbers = new List<int> { 1, 2, 3, 4, 5, 6};
                var result = Operations.AboveBelow(numbers, 3);

                Assert.Multiple(() => {
                    Assert.That(result["above"], Is.EqualTo(3));
                    Assert.That(result["below"], Is.EqualTo(2));
                });
            }

            [Test]
            public void Should_handle_negative_comparison()
            {
                var numbers = new List<int> { 1, 2, 3 };
                var result = Operations.AboveBelow(numbers, -2);

                Assert.Multiple(() => {
                    Assert.That(result["above"], Is.EqualTo(3));
                    Assert.That(result["below"], Is.EqualTo(0));
                });
            }
    }
}