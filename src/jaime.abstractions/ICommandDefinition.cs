namespace mxwlf.net.Jaime.Abstractions
{
    public interface ICommandDefinition
    {
        #region Options
        ICommandDefinition WithOption(string longOptionName);
        ICommandDefinition WithOption(char shortOptionName);
        ICommandDefinition WithOption(char shortOptionName, string longOptionName);
        #endregion
        
        #region Optional Arguments 
        ICommandDefinition WithOptionalArgument(char shortArgumentName);
        ICommandDefinition WithOptionalArgument(string longArgumentName);
        ICommandDefinition WithOptionalArgument(char shortArgumentName, string longArgumentName);
        
        ICommandDefinition WithOptionalArgument<T>(char shortArgumentName);
        ICommandDefinition WithOptionalArgument<T>(string longArgumentName);
        ICommandDefinition WithOptionalArgument<T>(char shortArgumentName, string longArgumentName);
        #endregion
        
        #region Required Arguments
        ICommandDefinition WithRequiredArgument(char shortArgumentName);
        ICommandDefinition WithRequiredArgument(string longArgumentName);
        ICommandDefinition WithRequiredArgument(char shortArgumentName, string longArgumentName);
        
        ICommandDefinition WithRequiredArgument<T>(char shortArgumentName);
        ICommandDefinition WithRequiredArgument<T>(string longArgumentName);
        ICommandDefinition WithRequiredArgument<T>(char shortArgumentName, string longArgumentName);
        #endregion
        
    }
}