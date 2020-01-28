#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;

namespace KeyboardSharp.Shared
{
    public class Scenario
    {
        private string[] _sequences;
        private int _next;
        private Random _random;

        public Scenario([DisallowNull]string[] sequences)
        {
            _sequences = sequences;
            _random = new Random((int)DateTime.Now.Ticks);

            Reset();
        }

        public int Counter { get; private set; }

        private string _NextAtIndex(int index)
        {
            Counter++;
            if (_sequences.Length > index)
                return _sequences[index];
            return string.Empty;
        }

        public string Next()
        {
            if (_sequences.Length <= _next)
                _next = 0;
            return _NextAtIndex(_next++);
        }

        public string NextRandom() => _NextAtIndex(_random.Next(0, _sequences.Length));

        public void Reset()
        {
            _next = 0;
            Counter = 0;
        }
    }
}
