using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace StudentsManager.Mvc.Services.Storage
{
    public interface IStorageService
    {
        string PathBasis { get; }

        Task<Response<BlobContainerClient>> CreateBlobContainerByNameAsync(string blobContainerName);

        Task<Response<BlobContentInfo>> UploadToContainerAsync(
            string blobContainerName,
            Stream fileStream,
            string fileName);
    }
}