//-----------------------------------------------------------------------
// <copyright>
// Copyright © Corniel Nobel 2019-current
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace System.Reflection
{
    public static partial class NullObject
    {
        /// <summary>The null object representation of <see cref="Reflection.Assembly"/>.</summary>
        public static readonly Assembly Assembly = new NullAssembly();

        /// <summary>Gets the <see cref="Assembly"/> value if not null, otherwise the <see cref="Reflection.Assembly"/> null-object value.</summary>
        public static Assembly NullObjectIfNull([ValidatedNotNull]this Assembly type) => type ?? Assembly;

        /// <summary>A null-object implementation of <see cref="Assembly"/>.</summary>
        private class NullAssembly : Assembly
        {
            public override string CodeBase => string.Empty;
            public override IEnumerable<CustomAttributeData> CustomAttributes => Array.Empty<CustomAttributeData>();
            public override IEnumerable<TypeInfo> DefinedTypes => Array.Empty<TypeInfo>();
            public override MethodInfo EntryPoint => null;
            public override string EscapedCodeBase => string.Empty;
            public override IEnumerable<Type> ExportedTypes => Array.Empty<Type>();
            public override string FullName => string.Empty;
            public override bool GlobalAssemblyCache => false;
            public override long HostContext => 0;
            public override string ImageRuntimeVersion => string.Empty;
            public override string Location => string.Empty;
            public override Module ManifestModule => Module;
            public override IEnumerable<Module> Modules => Array.Empty<Module>();
            public override bool ReflectionOnly => false;
        }
    }
}
