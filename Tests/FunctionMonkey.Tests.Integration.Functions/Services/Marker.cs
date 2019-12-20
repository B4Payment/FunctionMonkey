using System;
using System.Threading.Tasks;
using FunctionMonkey.Tests.Integration.Functions.Model;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace FunctionMonkey.Tests.Integration.Functions.Services
{
    internal class Marker : IMarker
    {
        public async Task RecordMarker(Guid markerId)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Environment.GetEnvironmentVariable("storageConnectionString"));
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
            CloudTable table = tableClient.GetTableReference(Constants.Storage.Table.Markers);

            await table.ExecuteAsync(TableOperation.InsertOrReplace(new MarkerTableEntity
            {
                PartitionKey = markerId.ToString(),
                RowKey = string.Empty
            }));
        }
    }
}