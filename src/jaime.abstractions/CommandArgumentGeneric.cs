namespace mxwlf.net.Jaime.Abstractions
{
    public class CommandArgument<T> : CommandArgument
    {
        private new readonly T _value;

        public CommandArgument(string longName, char shortName, bool required) : base(longName, shortName, required)
        {
            
        }
        
        private CommandArgument(string longName, char shortName, bool required, T value):this(longName, shortName, required)
        {
            _value = value;
            base._evaluated = true;
        }
        
        public CommandArgument<T> Evaluate(T value)
        {
            return new CommandArgument<T>(LongName, ShortName, Required, value);
        }
        
        public new T GetValue()
        {
            return (T) base.GetValue();
        }

    }
}