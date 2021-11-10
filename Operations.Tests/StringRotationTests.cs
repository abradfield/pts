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
            var value = "MyString";
            var result = Operations.StringRotation(value, 0);

            Assert.That(result, Is.EqualTo(value));
        }

        [Test]
        public void Should_handle_positive_rotation()
        {
            var value = "MyString";
            var result = Operations.StringRotation(value, 2);

            Assert.That(result, Is.EqualTo("ngMyStri"));
        }

        [Test]
        public void Should_handle_negative_rotation()
        {
            var value = "MyString";
            var result = Operations.StringRotation(value, -2);

            Assert.That(result, Is.EqualTo(value));
        }

        [Test]
        public void Should_handle_rotation_longer_than_length()
        {
            var value = "MyString";
            var result = Operations.StringRotation(value, value.Length + 2);

            Assert.That(result, Is.EqualTo("ngMyStri"));
        } 
    }
}