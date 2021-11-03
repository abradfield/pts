using System.Collections.Generic;
using NUnit.Framework;

namespace Operations.Tests
{
    [TestFixture]
    public class StringRotationTests
    {
        [Test]
        public void Should_handle_null_string()
        {
            string value = null;
            var result = Operations.StringRotation(value, 2);

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void Should_handle_zero_rotation()
        {
            string value = "hello";
            var result = Operations.StringRotation(value, 0);

            Assert.That(result, Is.EqualTo(value));
        }

        [Test]
        public void Should_handle_positive_rotation()
        {
            string value = "hello";
            var result = Operations.StringRotation(value, 2);

            Assert.That(result, Is.EqualTo("llohe"));
        }

        [Test]
        public void Should_handle_negative_rotation()
        {
            string value = "hello";
            var result = Operations.StringRotation(value, -2);

            Assert.That(result, Is.EqualTo(value));
        }

        [Test]
        public void Should_handle_rotation_longer_than_length()
        {
            string value = "hello";
            var result = Operations.StringRotation(value, value.Length + 1);

            Assert.That(result, Is.EqualTo(value));
        } 
    }
}