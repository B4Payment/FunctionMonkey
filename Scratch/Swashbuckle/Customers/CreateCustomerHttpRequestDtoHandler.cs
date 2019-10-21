using AzureFromTheTrenches.Commanding.Abstractions;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Swashbuckle.Customers
{
    internal class CreateCustomerHttpRequestDtoHandler : ICommandHandler<CreateCustomerHttpRequestDto, IActionResult>
    {
        public Task<IActionResult> ExecuteAsync(CreateCustomerHttpRequestDto command, IActionResult previousResult)
        {
            throw new NotImplementedException();
        }
    }
}