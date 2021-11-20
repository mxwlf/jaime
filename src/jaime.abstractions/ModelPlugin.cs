using System.Threading.Tasks;

namespace mxwlf.net.Jaime.Abstractions
{
    public class ModelPlugin : IJaimePlugin
    {
        public void RegisterPlugin(IRegistrationHelper registration)
        {
            registration.RegisterCommand("large bird")
                .WithOption("option1");
            
        }

        public Task<CommandExecutionOutcome> ExecuteCommand(CommandRequest commandRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}