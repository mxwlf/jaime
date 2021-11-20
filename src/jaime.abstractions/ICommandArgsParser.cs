namespace mxwlf.net.Jaime.Abstractions
{
    public interface ICommandArgsParser
    {
        CommandRequest ParseArguments(string[] args);
        
    }
}