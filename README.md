# Null object pattern
*In object-oriented computer programming, a **null object** is an object with no
referenced value or with defined neutral ("null") behavior. The null object
design pattern describes the uses of such objects and their behavior (or lack
thereof).*[[1]](https://en.wikipedia.org/wiki/Null_object_pattern)

Thanks to the null-coalescing operator (`??`), things are already
straightforward in C#:

```C#
MyClass other = someVariable ?? MyClass.Nil;
```

With the notion that `MyClass` should have a null object implementation that
should be accessible via `MyClass.Nil`.

However, the purpose of this repository is to advocate for the use of some
syntactic sugar to make things even easier. The idea is that by creating a
extension method the code becomes cleaner, hides the null object
implementation, and allows the same approach for classes you defined yourself
and classes you just have to deal with.

## Example

``` C#
public class Vehicle
{
    public virtual void Move()
    {
        this.Location += Direction * Velocity;
    }
}

public static class NullObjectExtensions
{
     public static Vehicle NullObjectIfNull([ValidatedNotNull]this Vehicle verhicle)
          => verhicle ?? NullVehicle.Nil;

     // This will help Roslyn analyzers to detect the null-check.
     [AttributeUsage(AttributeTargets.Parameter)]
     private sealed class ValidatedNotNullAttribute : Attribute {}

    // The null object implementation can be kept private fully.
    private class NullVehicle : Vehicle
    {
         public override void Move(){ /* Do nothing. */ }
    }
}

```

This allows clean and readable code like:
``` C#
vehicle.NullObjectIfNull().Move();
```
