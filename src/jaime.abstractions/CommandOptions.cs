using System;

namespace mxwlf.net.Jaime.Abstractions
{
    public class CommandOptions
    {
        private readonly string _longName;
        private readonly char _shortName;
        private readonly bool _value;
        private readonly bool _evaluated;

        public CommandOptions(string longName, char shortName)
        {
            _longName = longName;
            _shortName = shortName;
            _value = default;
            _evaluated = false;
        }
        
        private CommandOptions(string longName, char shortName, bool value):this(longName, shortName)
        {
            _value = value;
            _evaluated = true;
        }
        
        public CommandOptions Evaluate(bool value)
        {
            return new CommandOptions(_longName, _shortName, value);
        }
        

        public string LongName => _longName;

        public char ShortName => _shortName;

        public bool GetValue()
        {
            if (!_evaluated)
                throw new InvalidOperationException($"Cannot read value of a yet to be evaluated option.");

            return _value;
        }
    }
}