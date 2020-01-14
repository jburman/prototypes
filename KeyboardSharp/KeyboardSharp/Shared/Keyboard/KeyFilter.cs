using System;
using System.Collections.Generic;

namespace KeyboardSharp
{
    public class KeyFilter : IKeyFilter
    {
        public static readonly IKeyFilter Default = new AnyKeyFilter();

        private HashSet<string> _enabledKeys;
        private HashSet<string> _fingerLabels;
        private HashSet<string> _enabledFingerLabelKeys;

        public KeyFilter(string[] enabledKeys = default, string[] fingerLabels = default, string[] enabledFingerLabelKeys = default)
        {
            if(enabledKeys != null)
                _enabledKeys = new HashSet<string>(enabledKeys, StringComparer.OrdinalIgnoreCase);

            if (fingerLabels != null)
                _fingerLabels = new HashSet<string>(fingerLabels, StringComparer.OrdinalIgnoreCase);

            if (enabledFingerLabelKeys != null)
                _enabledFingerLabelKeys = new HashSet<string>(enabledFingerLabelKeys, StringComparer.OrdinalIgnoreCase);
        }

        public bool IsKeyEnabled(string keyValue) =>
            _enabledKeys?.Contains(keyValue) ?? true;

        public bool IsFingerLabelEnabled(string finger) =>
            _fingerLabels?.Contains(finger) ?? false;

        public bool IsFingerLabelKeyEnabled(string keyValue) =>
            _enabledFingerLabelKeys?.Contains(keyValue) ?? true;

        private class AnyKeyFilter : IKeyFilter
        {
        }
    }
}
