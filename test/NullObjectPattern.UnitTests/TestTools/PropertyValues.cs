using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectPattern.UnitTests
{
    public sealed class PropertyValues : Dictionary<string, object>
    {
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("{");
            foreach (var kvp in this)
            {
                sb.Append("    ").Append(kvp.Key).Append(": ");
                if (kvp.Value is null)
                {
                    sb.Append("<nil>");
                }
                else if (kvp.Value is string str)
                {
                    sb.Append('"').Append(str).Append('"');
                }
                else
                {
                    sb.Append(kvp.Value);
                }
                sb.AppendLine(",");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
        public static PropertyValues FromInstance(object obj)
        {
            var values = new PropertyValues();

            var type = obj.GetType();
            var properties = type.GetProperties();

            foreach (var prop in properties.OrderBy(p => p.Name))
            {
                object value;
                try
                {
                    value = prop.GetValue(obj);
                }
                catch (Exception x)
                {
                    value = new Throw(x);
                }
                values[prop.Name] = value;
            }
            return values;
        }

        public static string NullObjectImplementation<T>()
        {
            var sb = new StringBuilder();
            var properties = typeof(T).GetProperties().Where(p => p.GetGetMethod().IsVirtual);

            foreach (var prop in properties.OrderBy(p => p.Name))
            {
                sb.Append($"public override {prop.PropertyType.Name} {prop.Name} => ");

                var type = prop.PropertyType;

                if (type == typeof(string))
                {
                    sb.AppendLine("string.Empty;");
                    continue;
                }

                var enumerableType = GetEnumerableType(type);

                if (enumerableType != null)
                {
                    sb.AppendLine($"Array.Empty<{enumerableType.Name}>();");
                    continue;
                }
                if (type == typeof(int))
                {
                    sb.Append("0");
                }
                else if (type == typeof(long))
                {
                    sb.Append("0");
                }
                else if (type == typeof(bool))
                {
                    sb.Append("false");
                }
                else if (type == typeof(Guid))
                {
                    sb.Append("Guid.Empty");
                }
                else if (type.IsValueType)
                {
                    sb.Append($"default");
                }
                else
                {
                    sb.Append("null");
                }
                sb.AppendLine(";");
            }
            return sb.ToString();
        }

        public static string NullObjectAssert<T>()
        {
            var sb = new StringBuilder();
            sb.AppendLine("new PropertyValues").AppendLine("{");

            var properties = typeof(T).GetProperties();

            foreach (var prop in properties.OrderBy(p => p.Name))
            {
                sb.Append($"    {{ nameof({typeof(T).Name}.{prop.Name}), ");

                var type = prop.PropertyType;

                if (type == typeof(string))
                {
                    sb.AppendLine("string.Empty },");
                    continue;
                }

                var enumerableType = GetEnumerableType(type);

                if (enumerableType != null)
                {
                    sb.AppendLine($"Array.Empty<{enumerableType.Name}>() }},");
                    continue;
                }

                if (type.IsEnum)
                {
                    sb.Append($"{type.Name}.None");
                }
                else if (type == typeof(int))
                {
                    sb.Append("0");
                }
                else if (type == typeof(long))
                {
                    sb.Append("0L");
                }
                else if(type == typeof(bool))
                {
                    sb.Append("false");
                }
                else if(type == typeof(Guid))
                {
                    sb.Append("Guid.Empty");
                }
                else if(type.IsValueType)
                {
                    sb.Append($"default({type.Name})");
                }
                else
                {
                    sb.Append("null");
                }
                sb.AppendLine(" },");
            }
            sb.AppendLine("};");

            return sb.ToString();
        }

        private static Type GetEnumerableType(Type tp)
        {
            var iface = tp
                .GetInterfaces()
                .Concat(new Type[] { tp })
                .FirstOrDefault(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>));

            return iface?.GetGenericArguments()[0];
        }
    }
}
