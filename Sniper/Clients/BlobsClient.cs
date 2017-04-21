﻿#if false
using System.Threading.Tasks;
using Sniper.Http;
using Sniper.Request;
using Sniper.Response;


namespace Sniper
{
    /// <summary>
    /// A client for GitHub's Git Blobs API.  //TODO: Replace with TargetProcess if this is usable
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/git/blobs/">Git Blobs API documentation</a> for more information.  //TODO: Replace with TargetProcess if this is usable
    /// </remarks>
    public class BlobsClient : ApiClient, IBlobsClient
    {
        /// <summary>
        /// Instantiates a new GitHub Git Blobs API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public BlobsClient(IApiConnection apiConnection) : base(apiConnection) {}

        /// <summary>
        /// Gets a single Blob by SHA.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/blobs/#get-a-blob  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="reference">The SHA of the blob</param>
        public Task<Blob> Get(string owner, string name, string reference)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(owner), owner);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);
            Ensure.ArgumentNotNullOrEmptyString(nameof(reference), reference);

            return ApiConnection.Get<Blob>(ApiUrls.Blob(owner, name, reference));
        }

        /// <summary>
        /// Gets a single Blob by SHA.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/blobs/#get-a-blob  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="reference">The SHA of the blob</param>
        public Task<Blob> Get(long repositoryId, string reference)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(reference), reference);

            return ApiConnection.Get<Blob>(ApiUrls.Blob(repositoryId, reference));
        }

        /// <summary>
        /// Creates a new Blob
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/blobs/#create-a-blob  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="newBlob">The new Blob</param>
        public Task<BlobReference> Create(string owner, string name, NewBlob newBlob)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(owner), owner);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);
            Ensure.ArgumentNotNull(nameof(newBlob), newBlob);

            return ApiConnection.Post<BlobReference>(ApiUrls.Blobs(owner, name), newBlob);
        }

        /// <summary>
        /// Creates a new Blob
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/blobs/#create-a-blob  //TODO: Replace with TargetProcess if this is usable
        /// </remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="newBlob">The new Blob</param>
        public Task<BlobReference> Create(long repositoryId, NewBlob newBlob)
        {
            Ensure.ArgumentNotNull(nameof(newBlob), newBlob);

            return ApiConnection.Post<BlobReference>(ApiUrls.Blobs(repositoryId), newBlob);
        }
    }
}
#endif