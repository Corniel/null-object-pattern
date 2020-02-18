using NUnit.Framework;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NullObjectPattern.UnitTests
{
    public class TypeTest
    {
        [Test]
        public void NotNull_ReturnsSameInstance()
        {
            var notnil = typeof(TypeTest);
            var actual = notnil.NullObjectIfNull();
            Assert.AreEqual(notnil, actual);
        }
        [Test]
        public void Null_ReturnsNullType()
        {
            var actual = default(Type).NullObjectIfNull();

            var props = PropertyValues.FromInstance(actual);
            var expected = new PropertyValues
            {
                { nameof(Type.Assembly), System.Reflection.NullObject.Assembly },
                { nameof(Type.AssemblyQualifiedName), string.Empty },
                { nameof(Type.Attributes), TypeAttributes.Class },
                { nameof(Type.BaseType), null },
                { nameof(Type.ContainsGenericParameters), false },
                { nameof(Type.CustomAttributes), Array.Empty<CustomAttributeData>() },
                { nameof(Type.DeclaringMethod), null },
                { nameof(Type.DeclaringType), null },
                { nameof(Type.FullName), string.Empty },
                { nameof(Type.GenericParameterAttributes), GenericParameterAttributes.None },
                { nameof(Type.GenericParameterPosition), 0 },
                { nameof(Type.GenericTypeArguments), Array.Empty<Type>() },
                { nameof(Type.GUID), Guid.Empty },
                { nameof(Type.HasElementType), false },
                { nameof(Type.IsAbstract), false },
                { nameof(Type.IsAnsiClass), true },
                { nameof(Type.IsArray), false },
                { nameof(Type.IsAutoClass), false },
                { nameof(Type.IsAutoLayout), true },
                { nameof(Type.IsByRef), Throw.TargetInvocationException() },
                { nameof(Type.IsByRefLike), true },
                { nameof(Type.IsClass), true },
                { nameof(Type.IsCollectible), true },
                { nameof(Type.IsCOMObject), false },
                { nameof(Type.IsConstructedGenericType), false },
                { nameof(Type.IsContextful), false },
                { nameof(Type.IsEnum), false },
                { nameof(Type.IsExplicitLayout), false },
                { nameof(Type.IsGenericMethodParameter), false },
                { nameof(Type.IsGenericParameter), false },
                { nameof(Type.IsGenericType), false },
                { nameof(Type.IsGenericTypeDefinition), false },
                { nameof(Type.IsGenericTypeParameter), false },
                { nameof(Type.IsImport), false },
                { nameof(Type.IsInterface), false },
                { nameof(Type.IsLayoutSequential), false },
                { nameof(Type.IsMarshalByRef), false },
                { nameof(Type.IsNested), false },
                { nameof(Type.IsNestedAssembly), false },
                { nameof(Type.IsNestedFamANDAssem), false },
                { nameof(Type.IsNestedFamily), false },
                { nameof(Type.IsNestedFamORAssem), false },
                { nameof(Type.IsNestedPrivate), false },
                { nameof(Type.IsNestedPublic), false },
                { nameof(Type.IsNotPublic), true },
                { nameof(Type.IsPointer), false },
                { nameof(Type.IsPrimitive), false },
                { nameof(Type.IsPublic), false },
                { nameof(Type.IsSealed), false },
                { nameof(Type.IsSecurityCritical), false },
                { nameof(Type.IsSecuritySafeCritical), false },
                { nameof(Type.IsSecurityTransparent), false },
                { nameof(Type.IsSerializable), false },
                { nameof(Type.IsSignatureType), false },
                { nameof(Type.IsSpecialName), false },
                { nameof(Type.IsSZArray), Throw.TargetInvocationException() },
                { nameof(Type.IsTypeDefinition), Throw.TargetInvocationException() },
                { nameof(Type.IsUnicodeClass), false },
                { nameof(Type.IsValueType), false },
                { nameof(Type.IsVariableBoundArray), false },
                { nameof(Type.IsVisible), false },
                { nameof(Type.MemberType), default(MemberTypes) },
                { nameof(Type.MetadataToken), 0 },
                { nameof(Type.Module), System.Reflection.NullObject.Module },
                { nameof(Type.Name), string.Empty },
                { nameof(Type.Namespace), string.Empty },
                { nameof(Type.ReflectedType),  System.NullObject.Type  },
                { nameof(Type.StructLayoutAttribute), new StructLayoutAttribute(LayoutKind.Sequential) },
                { nameof(Type.TypeHandle), default(RuntimeTypeHandle) },
                { nameof(Type.TypeInitializer), null },
                { nameof(Type.UnderlyingSystemType), System.NullObject.Type },
            };

            PropertyAssert.AreEqual(expected, props);
        }
    }
}