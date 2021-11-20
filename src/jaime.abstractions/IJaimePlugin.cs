using System.Threading.Tasks;

namespace mxwlf.net.Jaime.Abstractions
{
    public interface IJaimePlugin
    {
        void RegisterPlugin(IRegistrationHelper registration);

        Task<CommandExecutionOutcome> ExecuteCommand(CommandRequest commandRequest);
    }
}