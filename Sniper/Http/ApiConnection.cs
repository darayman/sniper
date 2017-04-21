﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sniper.Http
{
    /// <summary>
    /// A connection for making API requests against URI endpoints.
    /// Provides type-friendly convenience methods that wrap <see cref="IConnection"/> methods.
    /// </summary>
    public class ApiConnection : IApiConnection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiConnection"/> class.
        /// </summary>
        /// <param name="connection">A connection for making HTTP requests</param>
        public ApiConnection(IConnection connection)
        {
            Ensure.ArgumentNotNull(nameof(connection), connection);
            
            Connection = connection;
        }

        /// <summary>
        /// The underlying connection.
        /// </summary>
        public IConnection Connection { get; }

        /// <summary>
        /// Gets the API resource at the specified URI.
        /// </summary>
        /// <typeparam name="T">Type of the API resource to get.</typeparam>
        /// <param name="uri">URI of the API resource to get</param>
        /// <returns>The API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public Task<T> Get<T>(Uri uri)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            
            return Get<T>(uri, null);
        }

        /// <summary>
        /// Gets the API resource at the specified URI.
        /// </summary>
        /// <typeparam name="T">Type of the API resource to get.</typeparam>
        /// <param name="uri">URI of the API resource to get</param>
        /// <param name="parameters">Parameters to add to the API request</param>
        /// <returns>The API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<T> Get<T>(Uri uri, IDictionary<string, string> parameters)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);

            var response = await Connection.Get<T>(uri, parameters, null).ConfigureAwait(false);
            return response.Body;
        }

        /// <summary>
        /// Gets the API resource at the specified URI.
        /// </summary>
        /// <typeparam name="T">Type of the API resource to get.</typeparam>
        /// <param name="uri">URI of the API resource to get</param>
        /// <param name="parameters">Parameters to add to the API request</param>
        /// <param name="accepts">Accept header to use for the API request</param>
        /// <returns>The API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<T> Get<T>(Uri uri, IDictionary<string, string> parameters, string accepts)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(accepts), accepts);

            var response = await Connection.Get<T>(uri, parameters, accepts).ConfigureAwait(false);
            return response.Body;
        }

        /// <summary>
        /// Gets the HTML content of the API resource at the specified URI.
        /// </summary>
        /// <param name="uri">URI of the API resource to get</param>
        /// <param name="parameters">Parameters to add to the API request</param>
        /// <returns>The API resource's HTML content.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<string> GetHtml(Uri uri, IDictionary<string, string> parameters)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);

            var response = await Connection.GetHtml(uri, parameters).ConfigureAwait(false);
            return response.Body;
        }


        /// <summary>
        /// Creates a new API resource in the list at the specified URI.
        /// </summary>
        /// <param name="uri">URI endpoint to send request to</param>
        /// <returns><seealso cref="HttpStatusCode"/>Representing the received HTTP response</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public Task Post(Uri uri)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);

            return Connection.Post(uri);
        }

        /// <summary>
        /// Creates a new API resource in the list at the specified URI.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to get</param>
        /// <returns>The created API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<T> Post<T>(Uri uri)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);

            var response = await Connection.Post<T>(uri).ConfigureAwait(false);
            return response.Body;
        }

        /// <summary>
        /// Creates a new API resource in the list at the specified URI.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to get</param>
        /// <param name="data">Object that describes the new API resource; this will be serialized and used as the request's body</param>
        /// <returns>The created API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public Task<T> Post<T>(Uri uri, object data)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);

            return Post<T>(uri, data, null, null);
        }

        /// <summary>
        /// Creates a new API resource in the list at the specified URI.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to get</param>
        /// <param name="data">Object that describes the new API resource; this will be serialized and used as the request's body</param>
        /// <param name="accepts">Accept header to use for the API request</param>
        /// <returns>The created API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public Task<T> Post<T>(Uri uri, object data, string accepts)
        {
            return Post<T>(uri, data, accepts, null);
        }

        /// <summary>
        /// Creates a new API resource in the list at the specified URI.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to get</param>
        /// <param name="data">Object that describes the new API resource; this will be serialized and used as the request's body</param>
        /// <param name="accepts">Accept header to use for the API request</param>
        /// <param name="contentType">Content type of the API request</param>
        /// <returns>The created API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<T> Post<T>(Uri uri, object data, string accepts, string contentType)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);

            var response = await Connection.Post<T>(uri, data, accepts, contentType).ConfigureAwait(false);
            return response.Body;
        }

        /// <summary>
        /// Creates a new API resource in the list at the specified URI.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to get</param>
        /// <param name="data">Object that describes the new API resource; this will be serialized and used as the request's body</param>
        /// <param name="accepts">Accept header to use for the API request</param>
        /// <param name="contentType">Content type of the API request</param>
        /// <param name="twoFactorAuthenticationCode">Two Factor Authentication Code</param>
        /// <returns>The created API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<T> Post<T>(Uri uri, object data, string accepts, string contentType, string twoFactorAuthenticationCode)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);
            Ensure.ArgumentNotNull(nameof(twoFactorAuthenticationCode), twoFactorAuthenticationCode);

            var response = await Connection.Post<T>(uri, data, accepts, contentType, twoFactorAuthenticationCode).ConfigureAwait(false);
            return response.Body;
        }


        public async Task<T> Post<T>(Uri uri, object data, string accepts, string contentType, TimeSpan timeout)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);

            var response = await Connection.Post<T>(uri, data, accepts, contentType, timeout).ConfigureAwait(false);
            return response.Body;
        }

        /// <summary>
        /// Creates or replaces the API resource at the specified URI
        /// </summary>
        /// <param name="uri">URI of the API resource to put</param>
        /// <returns>A <see cref="Task"/> for the request's execution.</returns>
        public Task Put(Uri uri)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);

            return Connection.Put(uri);
        }

        /// <summary>
        /// Creates or replaces the API resource at the specified URI.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to create or replace</param>
        /// <param name="data">Object that describes the API resource; this will be serialized and used as the request's body</param>
        /// <returns>The created API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<T> Put<T>(Uri uri, object data)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);

            var response = await Connection.Put<T>(uri, data).ConfigureAwait(false);

            return response.Body;
        }

        /// <summary>
        /// Creates or replaces the API resource at the specified URI.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to create or replace</param>
        /// <param name="data">Object that describes the API resource; this will be serialized and used as the request's body</param>
        /// <param name="twoFactorAuthenticationCode">The two-factor authentication code in response to the current user's previous challenge</param>
        /// <returns>The created API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<T> Put<T>(Uri uri, object data, string twoFactorAuthenticationCode)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);
            
            Ensure.ArgumentNotNullOrEmptyString(nameof(twoFactorAuthenticationCode), twoFactorAuthenticationCode);

            var response = await Connection.Put<T>(uri, data, twoFactorAuthenticationCode).ConfigureAwait(false);

            return response.Body;
        }

        /// <summary>
        /// Creates or replaces the API resource at the specified URI.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to create or replace</param>
        /// <param name="data">Object that describes the API resource; this will be serialized and used as the request's body</param>
        /// <param name="twoFactorAuthenticationCode">The two-factor authentication code in response to the current user's previous challenge</param>
        /// <param name="accepts">Accept header to use for the API request</param>
        /// <returns>The created API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<T> Put<T>(Uri uri, object data, string twoFactorAuthenticationCode, string accepts)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);

            var response = await Connection.Put<T>(uri, data, twoFactorAuthenticationCode, accepts).ConfigureAwait(false);

            return response.Body;
        }

        /// <summary>
        /// Updates the API resource at the specified URI.
        /// </summary>
        /// <param name="uri">URI of the API resource to patch</param>
        /// <returns>A <see cref="Task"/> for the request's execution.</returns>
        public Task Patch(Uri uri)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);

            return Connection.Patch(uri);
        }

        /// <summary>
        /// Updates the API resource at the specified URI.
        /// </summary>
        /// <param name="uri">URI of the API resource to patch</param>
        /// <param name="accepts">Accept header to use for the API request</param>
        /// <returns>A <see cref="Task"/> for the request's execution.</returns>
        public Task Patch(Uri uri, string accepts)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(accepts), accepts);

            return Connection.Patch(uri, accepts);
        }

        /// <summary>
        /// Updates the API resource at the specified URI.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to update</param>
        /// <param name="data">Object that describes the API resource; this will be serialized and used as the request's body</param>
        /// <returns>The updated API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<T> Patch<T>(Uri uri, object data)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);

            var response = await Connection.Patch<T>(uri, data).ConfigureAwait(false);

            return response.Body;
        }

        /// <summary>
        /// Updates the API resource at the specified URI.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to update</param>
        /// <param name="data">Object that describes the API resource; this will be serialized and used as the request's body</param>
        /// <param name="accepts">Accept header to use for the API request</param>
        /// <returns>The updated API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<T> Patch<T>(Uri uri, object data, string accepts)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);
            Ensure.ArgumentNotNull(nameof(accepts), accepts);

            var response = await Connection.Patch<T>(uri, data, accepts).ConfigureAwait(false);

            return response.Body;
        }

        /// <summary>
        /// Deletes the API object at the specified URI.
        /// </summary>
        /// <param name="uri">URI of the API resource to delete</param>
        /// <returns>A <see cref="Task"/> for the request's execution.</returns>
        public Task Delete(Uri uri)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);

            return Connection.Delete(uri);
        }

        /// <summary>
        /// Deletes the API object at the specified URI.
        /// </summary>
        /// <param name="uri">URI of the API resource to delete</param>
        /// <param name="twoFactorAuthenticationCode">Two Factor Code</param>
        /// <returns>A <see cref="Task"/> for the request's execution.</returns>
        public Task Delete(Uri uri, string twoFactorAuthenticationCode)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);

            return Connection.Delete(uri, twoFactorAuthenticationCode);
        }

        /// <summary>
        /// Deletes the API object at the specified URI.
        /// </summary>
        /// <param name="uri">URI of the API resource to delete</param>
        /// <param name="data">Object that describes the API resource; this will be serialized and used as the request's body</param>
        /// <returns>A <see cref="Task"/> for the request's execution.</returns>
        public Task Delete(Uri uri, object data)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);

            return Connection.Delete(uri, data);
        }

        /// <summary>
        /// Performs an asynchronous HTTP DELETE request that expects an empty response.
        /// </summary>
        /// <param name="uri">URI endpoint to send request to</param>
        /// <param name="data">The object to serialize as the body of the request</param>
        /// <param name="accepts">Specifies accept response media type</param>
        /// <returns>The returned <seealso cref="HttpStatusCode"/></returns>
        public Task Delete(Uri uri, object data, string accepts)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);
            Ensure.ArgumentNotNull(nameof(accepts), accepts);

            return Connection.Delete(uri, data, accepts);
        }

        /// <summary>
        /// Performs an asynchronous HTTP DELETE request.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI endpoint to send request to</param>
        /// <param name="data">The object to serialize as the body of the request</param>
        public async Task<T> Delete<T>(Uri uri, object data)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);

            var response = await Connection.Delete<T>(uri, data).ConfigureAwait(false);

            return response.Body;
        }

        /// <summary>
        /// Performs an asynchronous HTTP DELETE request.
        /// Attempts to map the response body to an object of type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type to map the response to</typeparam>
        /// <param name="uri">URI endpoint to send request to</param>
        /// <param name="data">The object to serialize as the body of the request</param>
        /// <param name="accepts">Specifies accept response media type</param>
        public async Task<T> Delete<T>(Uri uri, object data, string accepts)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);
            Ensure.ArgumentNotNull(nameof(data), data);
            Ensure.ArgumentNotNull(nameof(accepts), accepts);

            var response = await Connection.Delete<T>(uri, data, accepts).ConfigureAwait(false);

            return response.Body;
        }
#if false
        /// <summary>
        /// Executes a GET to the API object at the specified URI. This operation is appropriate for API calls which 
        /// queue long running calculations and return a collection of a resource.
        /// It expects the API to respond with an initial 202 Accepted, and queries again until a 200 OK is received.
        /// It returns an empty collection if it receives a 204 No Content response.
        /// </summary>
        /// <typeparam name="T">The API resource's type.</typeparam>
        /// <param name="uri">URI of the API resource to update</param>
        /// <param name="cancellationToken">A token used to cancel this potentially long running request</param>
        /// <returns>The updated API resource.</returns>
        /// <exception cref="ApiException">Thrown when an API error occurs.</exception>
        public async Task<IReadOnlyList<T>> GetQueuedOperation<T>(Uri uri, CancellationToken cancellationToken)
        {
            while (true)
            {
                Ensure.ArgumentNotNull(nameof(uri), uri);

                var response = await Connection.GetResponse<IReadOnlyList<T>>(uri, cancellationToken).ConfigureAwait(false);

                switch (response.HttpResponse.StatusCode)
                {
                    case HttpStatusCode.Accepted:
                        continue;
                    case HttpStatusCode.NoContent:
                        return new ReadOnlyCollection<T>(new T[] { });
                    case HttpStatusCode.OK:
                        return response.Body;
                }

                throw new ApiException("Queued Operations expect status codes of Accepted, No Content, or OK.",
                    response.HttpResponse.StatusCode);
            }
        }

        private async Task<IReadOnlyPagedCollection<T>> GetPage<T>(
            Uri uri,
            IDictionary<string, string> parameters,
            string accepts)
        {
            Ensure.ArgumentNotNull(nameof(uri), uri);

            var response = await Connection.Get<List<T>>(uri, parameters, accepts).ConfigureAwait(false);
            return new ReadOnlyPagedCollection<T>(
                response,
                nextPageUri => Connection.Get<List<T>>(nextPageUri, parameters, accepts));
        }
#endif
    }
}