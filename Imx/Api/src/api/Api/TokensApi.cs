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
using api.Client;
using api.Model;

namespace api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get details of a token
        /// </summary>
        /// <remarks>
        /// Get details of a token
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Token Contract Address</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TokenDetails</returns>
        TokenDetails GetToken(string address, int operationIndex = 0);

        /// <summary>
        /// Get details of a token
        /// </summary>
        /// <remarks>
        /// Get details of a token
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Token Contract Address</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TokenDetails</returns>
        ApiResponse<TokenDetails> GetTokenWithHttpInfo(string address, int operationIndex = 0);
        /// <summary>
        /// Get a list of tokens
        /// </summary>
        /// <remarks>
        /// Get a list of tokens
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="address">Contract address of the token (optional)</param>
        /// <param name="symbols">Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListTokensResponse</returns>
        ListTokensResponse ListTokens(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0);

        /// <summary>
        /// Get a list of tokens
        /// </summary>
        /// <remarks>
        /// Get a list of tokens
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="address">Contract address of the token (optional)</param>
        /// <param name="symbols">Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ListTokensResponse</returns>
        ApiResponse<ListTokensResponse> ListTokensWithHttpInfo(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get details of a token
        /// </summary>
        /// <remarks>
        /// Get details of a token
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Token Contract Address</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TokenDetails</returns>
        System.Threading.Tasks.Task<TokenDetails> GetTokenAsync(string address, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get details of a token
        /// </summary>
        /// <remarks>
        /// Get details of a token
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Token Contract Address</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TokenDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<TokenDetails>> GetTokenWithHttpInfoAsync(string address, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a list of tokens
        /// </summary>
        /// <remarks>
        /// Get a list of tokens
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="address">Contract address of the token (optional)</param>
        /// <param name="symbols">Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListTokensResponse</returns>
        System.Threading.Tasks.Task<ListTokensResponse> ListTokensAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a list of tokens
        /// </summary>
        /// <remarks>
        /// Get a list of tokens
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="address">Contract address of the token (optional)</param>
        /// <param name="symbols">Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListTokensResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListTokensResponse>> ListTokensWithHttpInfoAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApi : ITokensApiSync, ITokensApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TokensApi : ITokensApi
    {
        private api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokensApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokensApi(string basePath)
        {
            this.Configuration = api.Client.Configuration.MergeConfigurations(
                api.Client.GlobalConfiguration.Instance,
                new api.Client.Configuration { BasePath = basePath }
            );
            this.Client = new api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new api.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokensApi(api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = api.Client.Configuration.MergeConfigurations(
                api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new api.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TokensApi(api.Client.ISynchronousClient client, api.Client.IAsynchronousClient asyncClient, api.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public api.Client.ISynchronousClient Client { get; set; }

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
        public api.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public api.Client.ExceptionFactory ExceptionFactory
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
        /// Get details of a token Get details of a token
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Token Contract Address</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TokenDetails</returns>
        public TokenDetails GetToken(string address, int operationIndex = 0)
        {
            api.Client.ApiResponse<TokenDetails> localVarResponse = GetTokenWithHttpInfo(address);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get details of a token Get details of a token
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Token Contract Address</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TokenDetails</returns>
        public api.Client.ApiResponse<TokenDetails> GetTokenWithHttpInfo(string address, int operationIndex = 0)
        {
            // verify the required parameter 'address' is set
            if (address == null)
            {
                throw new api.Client.ApiException(400, "Missing required parameter 'address' when calling TokensApi->GetToken");
            }

            api.Client.RequestOptions localVarRequestOptions = new api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("x-sdk-version", "imx-core-sdk-csharp-0.1.0");

            localVarRequestOptions.PathParameters.Add("address", api.Client.ClientUtils.ParameterToString(address)); // path parameter

            localVarRequestOptions.Operation = "TokensApi.GetToken";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<TokenDetails>("/v1/tokens/{address}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get details of a token Get details of a token
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Token Contract Address</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TokenDetails</returns>
        public async System.Threading.Tasks.Task<TokenDetails> GetTokenAsync(string address, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            api.Client.ApiResponse<TokenDetails> localVarResponse = await GetTokenWithHttpInfoAsync(address, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get details of a token Get details of a token
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Token Contract Address</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TokenDetails)</returns>
        public async System.Threading.Tasks.Task<api.Client.ApiResponse<TokenDetails>> GetTokenWithHttpInfoAsync(string address, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'address' is set
            if (address == null)
            {
                throw new api.Client.ApiException(400, "Missing required parameter 'address' when calling TokensApi->GetToken");
            }


            api.Client.RequestOptions localVarRequestOptions = new api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("address", api.Client.ClientUtils.ParameterToString(address)); // path parameter

            localVarRequestOptions.Operation = "TokensApi.GetToken";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<TokenDetails>("/v1/tokens/{address}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of tokens Get a list of tokens
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="address">Contract address of the token (optional)</param>
        /// <param name="symbols">Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListTokensResponse</returns>
        public ListTokensResponse ListTokens(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0)
        {
            api.Client.ApiResponse<ListTokensResponse> localVarResponse = ListTokensWithHttpInfo(pageSize, cursor, orderBy, direction, address, symbols);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of tokens Get a list of tokens
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="address">Contract address of the token (optional)</param>
        /// <param name="symbols">Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ListTokensResponse</returns>
        public api.Client.ApiResponse<ListTokensResponse> ListTokensWithHttpInfo(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0)
        {
            api.Client.RequestOptions localVarRequestOptions = new api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("x-sdk-version", "imx-core-sdk-csharp-0.1.0");

            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "order_by", orderBy));
            }
            if (direction != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "direction", direction));
            }
            if (address != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "address", address));
            }
            if (symbols != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "symbols", symbols));
            }

            localVarRequestOptions.Operation = "TokensApi.ListTokens";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<ListTokensResponse>("/v1/tokens", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListTokens", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of tokens Get a list of tokens
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="address">Contract address of the token (optional)</param>
        /// <param name="symbols">Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListTokensResponse</returns>
        public async System.Threading.Tasks.Task<ListTokensResponse> ListTokensAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            api.Client.ApiResponse<ListTokensResponse> localVarResponse = await ListTokensWithHttpInfoAsync(pageSize, cursor, orderBy, direction, address, symbols, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of tokens Get a list of tokens
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="address">Contract address of the token (optional)</param>
        /// <param name="symbols">Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListTokensResponse)</returns>
        public async System.Threading.Tasks.Task<api.Client.ApiResponse<ListTokensResponse>> ListTokensWithHttpInfoAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            api.Client.RequestOptions localVarRequestOptions = new api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "order_by", orderBy));
            }
            if (direction != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "direction", direction));
            }
            if (address != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "address", address));
            }
            if (symbols != null)
            {
                localVarRequestOptions.QueryParameters.Add(api.Client.ClientUtils.ParameterToMultiMap("", "symbols", symbols));
            }

            localVarRequestOptions.Operation = "TokensApi.ListTokens";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ListTokensResponse>("/v1/tokens", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListTokens", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
