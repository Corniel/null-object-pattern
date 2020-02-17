using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace NullObjectPattern.UnitTests
{
    public sealed class Throw : IEquatable<Throw>
    {
        public Throw(Exception exception) => Exception = exception;
        public Exception Exception { get; }

        public override bool Equals(object obj) => Equals(obj as Throw);
        public bool Equals([AllowNull] Throw other) => other?.Exception?.GetType() == Exception?.GetType();
        public override int GetHashCode() => Exception is null ? 0 : Exception.GetType().GetHashCode();

        public override string ToString() => $"throw new {Exception.GetType().FullName}";

        public static Throw TargetInvocationException() => new Throw(new TargetInvocationException(null));
    }

}
