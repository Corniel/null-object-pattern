using NUnit.Framework;

namespace NullObjectPattern.UnitTests
{
    public class StringTest
    {
        [Test]
        public void NotNull_ReturnsSameValue()
        {
            var notnil = "notNull";
            var actual = notnil.StringEmptyIfNull();
            Assert.AreEqual("notNull", actual);
        }

        [Test]
        public void Null_ReturnsStringEmpty()
        {
            var actual = Nil.Value<string>().StringEmptyIfNull();
            Assert.AreEqual(string.Empty, actual);
        }
    }
}
