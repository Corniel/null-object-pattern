//-----------------------------------------------------------------------
// <copyright>
// Copyright © Corniel Nobel 2019-current
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Diagnostics;

namespace NullObjectPattern
{
    /// <summary>Extensions that provide a null-object implementation if null.</summary>
    public static partial class NullObjectExtensions
    {
        /// <summary>Gets the <see cref="string"/> value if not null, otherwise <see cref="string.Empty"/> .</summary>
        public static string StringEmptyIfNull([ValidatedNotNull]this string str) => str ?? string.Empty;

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
