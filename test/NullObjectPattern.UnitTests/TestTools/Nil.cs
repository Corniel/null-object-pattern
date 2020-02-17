namespace NullObjectPattern.UnitTests
{
    public static class Nil
    {
        public static T Value<T>() where T: class => null;
    }
}
