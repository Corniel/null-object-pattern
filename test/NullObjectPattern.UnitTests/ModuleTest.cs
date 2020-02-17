using NUnit.Framework;
using System;
using System.Reflection;

namespace NullObjectPattern.UnitTests
{
    public class ModuleTest
    {
        [Test]
        public void NotNull_ReturnsSameInstance()
        {
            var notnil = typeof(ModuleTest).Module;
            var actual = notnil.NullObjectIfNull();
            Assert.AreEqual(notnil, actual);
        }
        [Test]
        public void Null_ReturnsNullModule()
        {
            var actual = Nil.Value<Module>().NullObjectIfNull();

            var props = PropertyValues.FromInstance(actual);
            var expected = new PropertyValues
            {
                { nameof(Module.Assembly), Nil.Value<Assembly>().NullObjectIfNull() },
                { nameof(Module.CustomAttributes), Array.Empty<CustomAttributeData>() },
                { nameof(Module.FullyQualifiedName), string.Empty },
                { nameof(Module.MDStreamVersion), 0 },
                { nameof(Module.MetadataToken), 0 },
                { nameof(Module.ModuleHandle), default(ModuleHandle) },
                { nameof(Module.ModuleVersionId), Guid.Empty },
                { nameof(Module.Name), string.Empty },
                { nameof(Module.ScopeName), string.Empty },
            };

            //Console.WriteLine(PropertyValues.NullObjectAssert<Module>());

            PropertyAssert.AreEqual(expected, props);

        }
    }
}