/*
 * Immutable X API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 3.0
 * Contact: support@immutable.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Imx.Sdk.Gen.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get stark keys for a registered user
        /// </summary>
        /// <remarks>
        /// Get stark keys for a registered user
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetUsersApiResponse</returns>
        GetUsersApiResponse GetUsers(string user, int operationIndex = 0);

        /// <summary>
        /// Get stark keys for a registered user
        /// </summary>
        /// <remarks>
        /// Get stark keys for a registered user
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetUsersApiResponse</returns>
        ApiResponse<GetUsersApiResponse> GetUsersWithHttpInfo(string user, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get stark keys for a registered user
        /// </summary>
        /// <remarks>
        /// Get stark keys for a registered user
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetUsersApiResponse</returns>
        System.Threading.Tasks.Task<GetUsersApiResponse> GetUsersAsync(string user, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get stark keys for a registered user
        /// </summary>
        /// <remarks>
        /// Get stark keys for a registered user
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetUsersApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetUsersApiResponse>> GetUsersWithHttpInfoAsync(string user, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IUsersApiSync, IUsersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersApi : IUsersApi
    {
        private Imx.Sdk.Gen.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(string basePath)
        {
            this.Configuration = Imx.Sdk.Gen.Client.Configuration.MergeConfigurations(
                Imx.Sdk.Gen.Client.GlobalConfiguration.Instance,
                new Imx.Sdk.Gen.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Imx.Sdk.Gen.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Imx.Sdk.Gen.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Imx.Sdk.Gen.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Imx.Sdk.Gen.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Imx.Sdk.Gen.Client.Configuration.MergeConfigurations(
                Imx.Sdk.Gen.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Imx.Sdk.Gen.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Imx.Sdk.Gen.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Imx.Sdk.Gen.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UsersApi(Imx.Sdk.Gen.Client.ISynchronousClient client, Imx.Sdk.Gen.Client.IAsynchronousClient asyncClient, Imx.Sdk.Gen.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Imx.Sdk.Gen.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Imx.Sdk.Gen.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Imx.Sdk.Gen.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Imx.Sdk.Gen.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Imx.Sdk.Gen.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get stark keys for a registered user Get stark keys for a registered user
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetUsersApiResponse</returns>
        public GetUsersApiResponse GetUsers(string user, int operationIndex = 0)
        {
            Imx.Sdk.Gen.Client.ApiResponse<GetUsersApiResponse> localVarResponse = GetUsersWithHttpInfo(user);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get stark keys for a registered user Get stark keys for a registered user
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetUsersApiResponse</returns>
        public Imx.Sdk.Gen.Client.ApiResponse<GetUsersApiResponse> GetUsersWithHttpInfo(string user, int operationIndex = 0)
        {
            // verify the required parameter 'user' is set
            if (user == null)
            {
                throw new Imx.Sdk.Gen.Client.ApiException(400, "Missing required parameter 'user' when calling UsersApi->GetUsers");
            }

            Imx.Sdk.Gen.Client.RequestOptions localVarRequestOptions = new Imx.Sdk.Gen.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Imx.Sdk.Gen.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Imx.Sdk.Gen.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("x-sdk-version", "imx-core-sdk-csharp-0.1.1");

            localVarRequestOptions.PathParameters.Add("user", Imx.Sdk.Gen.Client.ClientUtils.ParameterToString(user)); // path parameter

            localVarRequestOptions.Operation = "UsersApi.GetUsers";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<GetUsersApiResponse>("/v1/users/{user}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUsers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get stark keys for a registered user Get stark keys for a registered user
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetUsersApiResponse</returns>
        public async System.Threading.Tasks.Task<GetUsersApiResponse> GetUsersAsync(string user, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Imx.Sdk.Gen.Client.ApiResponse<GetUsersApiResponse> localVarResponse = await GetUsersWithHttpInfoAsync(user, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get stark keys for a registered user Get stark keys for a registered user
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetUsersApiResponse)</returns>
        public async System.Threading.Tasks.Task<Imx.Sdk.Gen.Client.ApiResponse<GetUsersApiResponse>> GetUsersWithHttpInfoAsync(string user, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'user' is set
            if (user == null)
            {
                throw new Imx.Sdk.Gen.Client.ApiException(400, "Missing required parameter 'user' when calling UsersApi->GetUsers");
            }


            Imx.Sdk.Gen.Client.RequestOptions localVarRequestOptions = new Imx.Sdk.Gen.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Imx.Sdk.Gen.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Imx.Sdk.Gen.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("user", Imx.Sdk.Gen.Client.ClientUtils.ParameterToString(user)); // path parameter

            localVarRequestOptions.Operation = "UsersApi.GetUsers";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetUsersApiResponse>("/v1/users/{user}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUsers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
