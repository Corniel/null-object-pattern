//-----------------------------------------------------------------------
// <copyright>
// Copyright © Corniel Nobel 2019-current
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System
{
    public static partial class NullObject
    {
        /// <summary>The null object representation of <see cref="System.Type"/>.</summary>
        public static readonly Type Type = new NullType();

        /// <summary>Gets the <see cref="Type"/> value if not null, otherwise the <see cref="System.Type"/> null-object value.</summary>
        public static Type NullObjectIfNull([ValidatedNotNull]this Type type) => type ?? Type;

        private class NullType : Type
        {
            public override Assembly Assembly => Reflection.NullObject.Assembly;
            public override string AssemblyQualifiedName => string.Empty; public override Type BaseType => null;
            public override bool ContainsGenericParameters => false;
            public override IEnumerable<CustomAttributeData> CustomAttributes => Array.Empty<CustomAttributeData>();
            public override MethodBase DeclaringMethod => null;
            public override Type DeclaringType => null;
            public override string FullName => string.Empty;
            public override GenericParameterAttributes GenericParameterAttributes => default;
            public override int GenericParameterPosition => 0;
            public override Type[] GenericTypeArguments => Array.Empty<Type>();
            public override Guid GUID => Guid.Empty;
            public override bool IsConstructedGenericType => false;
            public override bool IsEnum => false;
            public override bool IsGenericParameter => false;
            public override bool IsGenericType => false;
            public override bool IsGenericTypeDefinition => false;
            public override bool IsSecurityCritical => false;
            public override bool IsSecuritySafeCritical => false;
            public override bool IsSecurityTransparent => false;
            public override bool IsSerializable => false;

            public override MemberTypes MemberType => default;
            public override int MetadataToken => 0;
            public override Module Module => Reflection.NullObject.Module;
            public override string Name => string.Empty;
            public override string Namespace => string.Empty;
            public override Type ReflectedType => this;
            public override StructLayoutAttribute StructLayoutAttribute => new StructLayoutAttribute(LayoutKind.Sequential);
            public override RuntimeTypeHandle TypeHandle => default;
            public override Type UnderlyingSystemType => this;

            public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) => Array.Empty<ConstructorInfo>();
            public override object[] GetCustomAttributes(bool inherit) => Array.Empty<object>();
            public override object[] GetCustomAttributes(Type attributeType, bool inherit) => Array.Empty<object>();
            public override Type GetElementType() => null;

            public override EventInfo GetEvent(string name, BindingFlags bindingAttr) => null;
            public override EventInfo[] GetEvents(BindingFlags bindingAttr) => Array.Empty<EventInfo>();

            public override FieldInfo GetField(string name, BindingFlags bindingAttr) => null;
            public override FieldInfo[] GetFields(BindingFlags bindingAttr) => Array.Empty<FieldInfo>();

            public override Type GetInterface(string name, bool ignoreCase) => null;

            public override Type[] GetInterfaces() => Array.Empty<Type>();

            public override MemberInfo[] GetMembers(BindingFlags bindingAttr) => Array.Empty<MemberInfo>();
            public override MethodInfo[] GetMethods(BindingFlags bindingAttr) => Array.Empty<MethodInfo>();

            public override Type GetNestedType(string name, BindingFlags bindingAttr) => null;
            public override Type[] GetNestedTypes(BindingFlags bindingAttr) => Array.Empty<Type>();

            public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) => Array.Empty<PropertyInfo>();

            public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) => null;

            public override bool IsDefined(Type attributeType, bool inherit) => false;

            protected override TypeAttributes GetAttributeFlagsImpl() => default;

            protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) => null;

            protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) => null;

            protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) => null;

            protected override bool HasElementTypeImpl() => false;

            protected override bool IsArrayImpl() => false;

            protected override bool IsByRefImpl() => false;

            protected override bool IsCOMObjectImpl() => false;

            protected override bool IsPointerImpl() => false;

            protected override bool IsPrimitiveImpl() => false;
        }
    }
}
