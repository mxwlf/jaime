using Microsoft.Extensions.Logging;

namespace mxwlf.net.Jaime.Abstractions
{
    public class CommandArgsParser : ICommandArgsParser
    {
        private readonly ILogger<CommandArgsParser> _logger;
        
        public CommandArgsParser(ILogger<CommandArgsParser> logger)
        {
            _logger = logger;
        }
        
        public CommandRequest ParseArguments(string[] args)
        {
            _logger.LogInformation("Point of entry with arguments" + args.Length);

            return null;
        }
    }
}