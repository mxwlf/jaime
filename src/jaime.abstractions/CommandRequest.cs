namespace mxwlf.net.Jaime.Abstractions
{
    public class CommandRequest
    {
        /// <summary>
        /// When null it signals the default "subcommand-less" behavior.
        /// </summary>
        public string SubCommandName { get; set; }

    }
}