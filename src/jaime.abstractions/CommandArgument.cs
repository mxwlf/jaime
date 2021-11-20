using System;

namespace mxwlf.net.Jaime.Abstractions
{
    public class CommandArgument
    {
        private readonly string _longName;
        
                private readonly char _shortName;
        
                private readonly bool _required;
                
                private protected readonly object _value;
        
                private protected bool _evaluated;
        
                public CommandArgument(string longName, char shortName, bool required)
                {
                    _longName = longName;
                    _shortName = shortName;
                    _required = required;
                    _value = default;
                    _evaluated = false;
                }
        
                private CommandArgument(string longName, char shortName, bool required, object value):this(longName, shortName, required)
                {
                    _value = value;
                    _evaluated = true;
                }
        
                public CommandArgument Evaluate(object value)
                {
                    return new CommandArgument(_longName, _shortName, _required, value);
                }
        
                public string LongName => _longName;
        
                public char ShortName => _shortName;
        
                public bool Evaluated => _evaluated;
        
                public bool Required => _required;
                
                public object GetValue()
                {
                    if (!_evaluated)
                        throw new InvalidOperationException($"Cannot read value of a yet to be evaluated argument.");

                    return _value;
                }
    }
}