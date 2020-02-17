using NUnit.Framework;
using System;
using System.Reflection;
using System.Security;

namespace NullObjectPattern.UnitTests
{
    public class AssemblyTest
    {
        [Test]
        public void NotNull_ReturnsSameInstance()
        {
            var notnil = typeof(AssemblyTest).Assembly;
            var actual = notnil.NullObjectIfNull();
            Assert.AreEqual(notnil, actual);
        }
        [Test]
        public void Null_ReturnsNullAssembly()
        {
            var actual = Nil.Value<Assembly>().NullObjectIfNull();

            var props = PropertyValues.FromInstance(actual);
            var expected = new PropertyValues
            {
                { nameof(Assembly.CodeBase), string.Empty },
                { nameof(Assembly.CustomAttributes), Array.Empty<CustomAttributeData>() },
                { nameof(Assembly.DefinedTypes), Array.Empty<TypeInfo>() },
                { nameof(Assembly.EntryPoint), null },
                { nameof(Assembly.EscapedCodeBase), string.Empty },
                { nameof(Assembly.ExportedTypes),  Array.Empty<Type>() },
                { nameof(Assembly.FullName), string.Empty },
                { nameof(Assembly.GlobalAssemblyCache), false },
                { nameof(Assembly.HostContext), 0L },
                { nameof(Assembly.ImageRuntimeVersion), string.Empty },
                { nameof(Assembly.IsCollectible), true },
                { nameof(Assembly.IsDynamic), false },
                { nameof(Assembly.IsFullyTrusted), true },
                { nameof(Assembly.Location), string.Empty },
                { nameof(Assembly.ManifestModule), Nil.Value<Module>().NullObjectIfNull() },
                { nameof(Assembly.Modules),  Array.Empty<Module>()  },
                { nameof(Assembly.ReflectionOnly), false },
                { nameof(Assembly.SecurityRuleSet), SecurityRuleSet.None },
            };

            PropertyAssert.AreEqual(expected, props);
        }
    }
}