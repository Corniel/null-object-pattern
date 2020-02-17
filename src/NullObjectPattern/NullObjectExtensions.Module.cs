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
        /// <summary>Gets the <see cref="Module"/> value if not null, otherwise the <see cref="Module"/> null-object value.</summary>
        public static Module NullObjectIfNull([ValidatedNotNull]this Module type) => type ?? NullModule.Nil;

        private class NullModule : Module
        {
            public static readonly NullModule Nil = new NullModule();

            public override Assembly Assembly => NullAssembly.Nil;
            public override IEnumerable<CustomAttributeData> CustomAttributes => Array.Empty<CustomAttributeData>();
            public override string FullyQualifiedName => string.Empty;
            public override int MDStreamVersion => 0;
            public override int MetadataToken => 0;
            public override Guid ModuleVersionId => Guid.Empty;
            public override string Name => string.Empty;
            public override string ScopeName => string.Empty;
        }
   }
}
