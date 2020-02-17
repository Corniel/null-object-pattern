//-----------------------------------------------------------------------
// <copyright>
// Copyright © Corniel Nobel 2019-current
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;

namespace NullObjectPattern
{
    public static partial class NullObjectExtensions
    {
        /// <summary>Gets the <see cref="Assembly"/> value if not null, otherwise the <see cref="Assembly"/> null-object value.</summary>
        public static Assembly NullObjectIfNull([ValidatedNotNull]this Assembly type) => type ?? NullAssembly.Nil;

        /// <summary>A null-object implementation of <see cref="Assembly"/>.</summary>
        private class NullAssembly : Assembly
        {
            public static readonly NullAssembly Nil = new NullAssembly();
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
            public override Module ManifestModule => NullModule.Nil;
            public override IEnumerable<Module> Modules => Array.Empty<Module>();
            public override bool ReflectionOnly => false;
        }
    }
}
