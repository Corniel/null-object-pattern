//-----------------------------------------------------------------------
// <copyright>
// Copyright © Corniel Nobel 2019-current
// </copyright>
//-----------------------------------------------------------------------
using System.Diagnostics;

namespace System
{
    /// <summary>Extensions that provide a null-object implementation if null.</summary>
    public static partial class NullObject
    {
        /// <summary>The null object representation of <see cref="string"/>.</summary>
        public static readonly string String = string.Empty;

        /// <summary>Gets the <see cref="string"/> value if not null, otherwise <see cref="string.Empty"/> .</summary>
        public static string StringEmptyIfNull([ValidatedNotNull]this string str) => str ?? String;

        /// <summary>Marks the NotNull argument as being validated for not being null, to satisfy the static code analysis.</summary>
        /// <remarks>
        /// Notice that it does not matter what this attribute does, as long as
        /// it is named ValidatedNotNullAttribute.
        /// </remarks>
        [Conditional("Analysis")]
        [AttributeUsage(AttributeTargets.Parameter)]
        private sealed class ValidatedNotNullAttribute : Attribute
        {
        }
    }
}
