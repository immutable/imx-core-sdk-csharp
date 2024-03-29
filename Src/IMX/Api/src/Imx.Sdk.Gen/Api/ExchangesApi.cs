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
    public interface IExchangesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get an exchange by ID
        /// </summary>
        /// <remarks>
        /// Get an exchange by ID
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Exchange ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Exchange</returns>
        Exchange GetExchange(string id, int operationIndex = 0);

        /// <summary>
        /// Get an exchange by ID
        /// </summary>
        /// <remarks>
        /// Get an exchange by ID
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Exchange ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Exchange</returns>
        ApiResponse<Exchange> GetExchangeWithHttpInfo(string id, int operationIndex = 0);
        /// <summary>
        /// Returns a list of exchanges based on the request
        /// </summary>
        /// <remarks>
        /// Returns a list of exchanges based on the request
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (optional)</param>
        /// <param name="id">Transaction ID (optional)</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="transferId">Transfer ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetTransactionsResponse</returns>
        GetTransactionsResponse GetExchanges(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string), int operationIndex = 0);

        /// <summary>
        /// Returns a list of exchanges based on the request
        /// </summary>
        /// <remarks>
        /// Returns a list of exchanges based on the request
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (optional)</param>
        /// <param name="id">Transaction ID (optional)</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="transferId">Transfer ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetTransactionsResponse</returns>
        ApiResponse<GetTransactionsResponse> GetExchangesWithHttpInfo(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExchangesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get an exchange by ID
        /// </summary>
        /// <remarks>
        /// Get an exchange by ID
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Exchange ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Exchange</returns>
        System.Threading.Tasks.Task<Exchange> GetExchangeAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get an exchange by ID
        /// </summary>
        /// <remarks>
        /// Get an exchange by ID
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Exchange ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Exchange)</returns>
        System.Threading.Tasks.Task<ApiResponse<Exchange>> GetExchangeWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns a list of exchanges based on the request
        /// </summary>
        /// <remarks>
        /// Returns a list of exchanges based on the request
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (optional)</param>
        /// <param name="id">Transaction ID (optional)</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="transferId">Transfer ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetTransactionsResponse</returns>
        System.Threading.Tasks.Task<GetTransactionsResponse> GetExchangesAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns a list of exchanges based on the request
        /// </summary>
        /// <remarks>
        /// Returns a list of exchanges based on the request
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (optional)</param>
        /// <param name="id">Transaction ID (optional)</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="transferId">Transfer ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetTransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetTransactionsResponse>> GetExchangesWithHttpInfoAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExchangesApi : IExchangesApiSync, IExchangesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExchangesApi : IExchangesApi
    {
        private Imx.Sdk.Gen.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExchangesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExchangesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ExchangesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExchangesApi(Imx.Sdk.Gen.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ExchangesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ExchangesApi(Imx.Sdk.Gen.Client.ISynchronousClient client, Imx.Sdk.Gen.Client.IAsynchronousClient asyncClient, Imx.Sdk.Gen.Client.IReadableConfiguration configuration)
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
        /// Get an exchange by ID Get an exchange by ID
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Exchange ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Exchange</returns>
        public Exchange GetExchange(string id, int operationIndex = 0)
        {
            Imx.Sdk.Gen.Client.ApiResponse<Exchange> localVarResponse = GetExchangeWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an exchange by ID Get an exchange by ID
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Exchange ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Exchange</returns>
        public Imx.Sdk.Gen.Client.ApiResponse<Exchange> GetExchangeWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Imx.Sdk.Gen.Client.ApiException(400, "Missing required parameter 'id' when calling ExchangesApi->GetExchange");
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

            localVarRequestOptions.PathParameters.Add("id", Imx.Sdk.Gen.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "ExchangesApi.GetExchange";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Exchange>("/v3/exchanges/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExchange", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an exchange by ID Get an exchange by ID
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Exchange ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Exchange</returns>
        public async System.Threading.Tasks.Task<Exchange> GetExchangeAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Imx.Sdk.Gen.Client.ApiResponse<Exchange> localVarResponse = await GetExchangeWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an exchange by ID Get an exchange by ID
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Exchange ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Exchange)</returns>
        public async System.Threading.Tasks.Task<Imx.Sdk.Gen.Client.ApiResponse<Exchange>> GetExchangeWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Imx.Sdk.Gen.Client.ApiException(400, "Missing required parameter 'id' when calling ExchangesApi->GetExchange");
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

            localVarRequestOptions.PathParameters.Add("id", Imx.Sdk.Gen.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "ExchangesApi.GetExchange";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Exchange>("/v3/exchanges/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExchange", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a list of exchanges based on the request Returns a list of exchanges based on the request
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (optional)</param>
        /// <param name="id">Transaction ID (optional)</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="transferId">Transfer ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetTransactionsResponse</returns>
        public GetTransactionsResponse GetExchanges(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string), int operationIndex = 0)
        {
            Imx.Sdk.Gen.Client.ApiResponse<GetTransactionsResponse> localVarResponse = GetExchangesWithHttpInfo(pageSize, cursor, orderBy, direction, id, walletAddress, status, provider, transferId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of exchanges based on the request Returns a list of exchanges based on the request
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (optional)</param>
        /// <param name="id">Transaction ID (optional)</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="transferId">Transfer ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetTransactionsResponse</returns>
        public Imx.Sdk.Gen.Client.ApiResponse<GetTransactionsResponse> GetExchangesWithHttpInfo(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string), int operationIndex = 0)
        {
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

            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "order_by", orderBy));
            }
            if (direction != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "direction", direction));
            }
            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (walletAddress != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "wallet_address", walletAddress));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "status", status));
            }
            if (provider != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "provider", provider));
            }
            if (transferId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "transfer_id", transferId));
            }

            localVarRequestOptions.Operation = "ExchangesApi.GetExchanges";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<GetTransactionsResponse>("/v3/exchanges", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExchanges", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a list of exchanges based on the request Returns a list of exchanges based on the request
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (optional)</param>
        /// <param name="id">Transaction ID (optional)</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="transferId">Transfer ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<GetTransactionsResponse> GetExchangesAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Imx.Sdk.Gen.Client.ApiResponse<GetTransactionsResponse> localVarResponse = await GetExchangesWithHttpInfoAsync(pageSize, cursor, orderBy, direction, id, walletAddress, status, provider, transferId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of exchanges based on the request Returns a list of exchanges based on the request
        /// </summary>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (optional)</param>
        /// <param name="id">Transaction ID (optional)</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="transferId">Transfer ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetTransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<Imx.Sdk.Gen.Client.ApiResponse<GetTransactionsResponse>> GetExchangesWithHttpInfoAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "order_by", orderBy));
            }
            if (direction != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "direction", direction));
            }
            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (walletAddress != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "wallet_address", walletAddress));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "status", status));
            }
            if (provider != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "provider", provider));
            }
            if (transferId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Imx.Sdk.Gen.Client.ClientUtils.ParameterToMultiMap("", "transfer_id", transferId));
            }

            localVarRequestOptions.Operation = "ExchangesApi.GetExchanges";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetTransactionsResponse>("/v3/exchanges", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExchanges", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
