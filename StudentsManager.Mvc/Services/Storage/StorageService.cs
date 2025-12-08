using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Options;
using StudentsManager.Mvc.Settings;

namespace StudentsManager.Mvc.Services.Storage
{
    public class StorageService : IStorageService
    {
        private readonly IAzureClientFactory<BlobServiceClient> _azureBlobServiceClientFactory;
        private readonly StorageSettings _settings;

        public StorageService(IOptions<StorageSettings> options,
            IAzureClientFactory<BlobServiceClient> azureBlobServiceClientFactory)
        {
            _azureBlobServiceClientFactory = azureBlobServiceClientFactory;
            _settings = options.Value;
        }

        public string PathBasis => _settings.PathBasis;

        public Task<Response<BlobContainerClient>> CreateBlobContainerByNameAsync(string blobContainerName)
        {
            var blobServiceClient = _azureBlobServiceClientFactory.CreateClient("DefaultBlobService");
            return blobServiceClient.CreateBlobContainerAsync(
                blobContainerName,
                PublicAccessType.BlobContainer);
        }

        public Task<Response<BlobContentInfo>> UploadToContainerAsync(
            string blobContainerName,
            Stream fileStream,
            string fileName)
        {
            var blobServiceClient = _azureBlobServiceClientFactory.CreateClient("DefaultBlobService");
            var blobContainerClient = blobServiceClient.GetBlobContainerClient(blobContainerName);
            var blobClient = blobContainerClient.GetBlobClient(fileName);
            return blobClient.UploadAsync(fileStream);
        }
    }
}