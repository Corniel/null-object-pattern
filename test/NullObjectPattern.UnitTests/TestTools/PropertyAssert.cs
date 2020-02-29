using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectPattern.UnitTests
{
    public static class PropertyAssert
    {
        public static void AreEqual(PropertyValues excepted, PropertyValues actual)
        {
            Assert.NotNull(actual);

            var failure = false;
            var different = new StringBuilder();
            var missing = new List<string>();
            var extra = actual.Keys.Except(excepted.Keys).ToList();

            foreach(var kvp in excepted.OrderBy(k => k.Key))
            {
                var property = kvp.Key;
                var expValue = kvp.Value;
                if(!actual.TryGetValue(property, out var actValue))
                {
                    missing.Add(property);
                    continue;
                }
                if (expValue is null)
                {
                    if (!(actValue is null))
                    {
                        different.AppendLine($"- [{property}] expected: null, actual: {actValue}");
                    }
                }
                else if (!expValue.Equals(actValue))
                {
                    different.AppendLine($"- [{property}] expected: {expValue}, actual: {(actValue is null? "null": actValue.ToString())}");
                }
            }


            var sb = new StringBuilder();
            if(different.Length != 0)
            {
                failure = true;
                sb.AppendLine("Different:");
                sb.Append(different);
            }
            if(missing.Any())
            {
                failure = true;
                sb.AppendLine("Missing:");
                sb.AppendLine($"- {string.Join(", ", missing)}");
            }
            if (extra.Any())
            {
                failure = true;
                sb.AppendLine("Extra:");
                sb.AppendLine($"- {string.Join(", ", extra)}");
            }

            if (failure)
            {
                Assert.Fail(sb.ToString());
            }
        }
    }
}
