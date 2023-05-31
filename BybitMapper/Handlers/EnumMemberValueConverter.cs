using BybitMapper.Extensions;

using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BybitMapper.Handlers
{
    internal sealed class EnumMemberValueConverter<T> where T : struct
    {
        [NotNull]
        private readonly Dictionary<string, T> _exchangeFilterValues = new Dictionary<string, T>();

        public EnumMemberValueConverter()
        {
            var type = typeof(T);
            if (!type.IsEnum)
                throw new ArgumentException("Has to be enum!", nameof(T));

            foreach (var name in Enum.GetNames(type))
            {
                _exchangeFilterValues.Add(
                    EnumHelper.GetFieldCustomAttribute<T, EnumMemberAttribute>(name)?.Value ?? name,
                    (T) Enum.Parse(type, name));
            }
        }

        public bool TryGetValue([NotNull] string key, out T value) =>
            _exchangeFilterValues.TryGetValue(key, out value);
    }
}