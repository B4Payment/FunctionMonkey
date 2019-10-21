using System.Runtime.Serialization;
using AzureFromTheTrenches.Commanding.Abstractions;

namespace Swashbuckle.Commands
{
    [DataContract(Name = "HelloWorld")]
    public class HelloWorldCommand : ICommand<string>
    {
        public string Name { get; set; }
    }
}
