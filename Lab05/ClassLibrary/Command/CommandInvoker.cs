
namespace ClassLibrary.Command
{
    public class CommandInvoker
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }
}
