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
        /// <summary>The null object representation of <see cref="Reflection.Module"/>.</summary>
        public static readonly Module Module = new NullModule();

        /// <summary>Gets the <see cref="Module"/> value if not null, otherwise the <see cref="Reflection.Module"/> null-object value.</summary>
        public static Module NullObjectIfNull([ValidatedNotNull]this Module type) => type ?? Module;

        private class NullModule : Module
        {
            public override Assembly Assembly => NullObject.Assembly;
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
