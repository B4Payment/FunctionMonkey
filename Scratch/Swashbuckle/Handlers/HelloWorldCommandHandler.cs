using AzureFromTheTrenches.Commanding.Abstractions;
using Swashbuckle.Commands;
using System.Threading.Tasks;

namespace Swashbuckle.Handlers
{
    internal class HelloWorldCommandHandler : ICommandHandler<HelloWorldCommand, string>
    {
        public Task<string> ExecuteAsync(HelloWorldCommand command, string previousResult)
        {
            if (string.IsNullOrWhiteSpace(command.Name))
            {
                return Task.FromResult("Hello stranger");
            }
            return Task.FromResult($"Hello {command.Name}");
        }
    }
}
