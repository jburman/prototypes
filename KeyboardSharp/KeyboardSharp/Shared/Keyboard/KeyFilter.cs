using System;
using System.Collections.Generic;

namespace KeyboardSharp
{
    public class KeyFilter : IKeyFilter
    {
        public static readonly IKeyFilter Default = new AnyKeyFilter();

        private HashSet<string> _allowedKeyValues;

        public KeyFilter(string[] allowedKeyValues)
        {
            _allowedKeyValues = new HashSet<string>(allowedKeyValues, StringComparer.OrdinalIgnoreCase);
        }

        public bool IsAllowed(string keyValue) =>
            _allowedKeyValues.Contains(keyValue);

        private class AnyKeyFilter : IKeyFilter
        {
        }
    }
}
