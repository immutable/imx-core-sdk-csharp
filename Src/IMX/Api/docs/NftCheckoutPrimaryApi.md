# Imx.Sdk.Gen.Api.NftCheckoutPrimaryApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNftPrimary**](NftCheckoutPrimaryApi.md#createnftprimary) | **POST** /v2/nft/primary | Create NFT primary sale transaction |
| [**GetCurrenciesNFTCheckoutPrimary**](NftCheckoutPrimaryApi.md#getcurrenciesnftcheckoutprimary) | **GET** /v2/nft/primary/currencies | Get currencies with limits |
| [**GetNftPrimaryTransaction**](NftCheckoutPrimaryApi.md#getnftprimarytransaction) | **GET** /v2/nft/primary/{transaction_id} | Get NFT primary sale transaction by id |
| [**GetNftPrimaryTransactions**](NftCheckoutPrimaryApi.md#getnftprimarytransactions) | **GET** /v2/nft/primary | Get a list of NFT primary sales transactions |
| [**RegisterNftPrimarySalesContract**](NftCheckoutPrimaryApi.md#registernftprimarysalescontract) | **POST** /v2/nft/primary/register | Executes NFT primary sales contract registration |

<a name="createnftprimary"></a>
# **CreateNftPrimary**
> NftprimarytransactionCreateResponse CreateNftPrimary (NftprimarytransactionCreateAPIRequest createAPIRequest)

Create NFT primary sale transaction

Creates a transaction representing minting an NFT with a card payment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class CreateNftPrimaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new NftCheckoutPrimaryApi(config);
            var createAPIRequest = new NftprimarytransactionCreateAPIRequest(); // NftprimarytransactionCreateAPIRequest | req

            try
            {
                // Create NFT primary sale transaction
                NftprimarytransactionCreateResponse result = apiInstance.CreateNftPrimary(createAPIRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NftCheckoutPrimaryApi.CreateNftPrimary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNftPrimaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create NFT primary sale transaction
    ApiResponse<NftprimarytransactionCreateResponse> response = apiInstance.CreateNftPrimaryWithHttpInfo(createAPIRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NftCheckoutPrimaryApi.CreateNftPrimaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAPIRequest** | [**NftprimarytransactionCreateAPIRequest**](NftprimarytransactionCreateAPIRequest.md) | req |  |

### Return type

[**NftprimarytransactionCreateResponse**](NftprimarytransactionCreateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrenciesnftcheckoutprimary"></a>
# **GetCurrenciesNFTCheckoutPrimary**
> CurrencyWithLimits GetCurrenciesNFTCheckoutPrimary (string provider = null, bool? includeLimits = null)

Get currencies with limits

Returns a list of supported currencies and their limits

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetCurrenciesNFTCheckoutPrimaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new NftCheckoutPrimaryApi(config);
            var provider = "moonpay";  // string | Provider name (optional) 
            var includeLimits = true;  // bool? | Flag if limits should be included in the response or not (optional) 

            try
            {
                // Get currencies with limits
                CurrencyWithLimits result = apiInstance.GetCurrenciesNFTCheckoutPrimary(provider, includeLimits);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NftCheckoutPrimaryApi.GetCurrenciesNFTCheckoutPrimary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrenciesNFTCheckoutPrimaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get currencies with limits
    ApiResponse<CurrencyWithLimits> response = apiInstance.GetCurrenciesNFTCheckoutPrimaryWithHttpInfo(provider, includeLimits);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NftCheckoutPrimaryApi.GetCurrenciesNFTCheckoutPrimaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **provider** | **string** | Provider name | [optional]  |
| **includeLimits** | **bool?** | Flag if limits should be included in the response or not | [optional]  |

### Return type

[**CurrencyWithLimits**](CurrencyWithLimits.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnftprimarytransaction"></a>
# **GetNftPrimaryTransaction**
> NftprimarytransactionGetResponse GetNftPrimaryTransaction (string transactionId)

Get NFT primary sale transaction by id

given a transaction id, returns the corresponding transaction representing a mint executed from a card payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetNftPrimaryTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new NftCheckoutPrimaryApi(config);
            var transactionId = "transactionId_example";  // string | Transaction id

            try
            {
                // Get NFT primary sale transaction by id
                NftprimarytransactionGetResponse result = apiInstance.GetNftPrimaryTransaction(transactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NftCheckoutPrimaryApi.GetNftPrimaryTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNftPrimaryTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get NFT primary sale transaction by id
    ApiResponse<NftprimarytransactionGetResponse> response = apiInstance.GetNftPrimaryTransactionWithHttpInfo(transactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NftCheckoutPrimaryApi.GetNftPrimaryTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | Transaction id |  |

### Return type

[**NftprimarytransactionGetResponse**](NftprimarytransactionGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnftprimarytransactions"></a>
# **GetNftPrimaryTransactions**
> NftprimarytransactionListTransactionsResponse GetNftPrimaryTransactions (int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, string transactionId = null, string contractAddress = null, string sellerWalletAddress = null, string userWalletAddress = null, string status = null, string provider = null, string mintId = null)

Get a list of NFT primary sales transactions

Returns a list of NFT primary sales transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetNftPrimaryTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new NftCheckoutPrimaryApi(config);
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "transaction_id";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 
            var transactionId = "transactionId_example";  // string | Transaction id (optional) 
            var contractAddress = "contractAddress_example";  // string | Contract address of the asset (optional) 
            var sellerWalletAddress = "sellerWalletAddress_example";  // string | Ethereum address of the seller (optional) 
            var userWalletAddress = "userWalletAddress_example";  // string | Ethereum address of the user who wants to create transaction (optional) 
            var status = "created";  // string | Transaction status (optional) 
            var provider = "moonpay";  // string | Checkout provider name (optional) 
            var mintId = "mintId_example";  // string | Minting transaction ID - see mintTokens response (optional) 

            try
            {
                // Get a list of NFT primary sales transactions
                NftprimarytransactionListTransactionsResponse result = apiInstance.GetNftPrimaryTransactions(pageSize, cursor, orderBy, direction, transactionId, contractAddress, sellerWalletAddress, userWalletAddress, status, provider, mintId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NftCheckoutPrimaryApi.GetNftPrimaryTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNftPrimaryTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of NFT primary sales transactions
    ApiResponse<NftprimarytransactionListTransactionsResponse> response = apiInstance.GetNftPrimaryTransactionsWithHttpInfo(pageSize, cursor, orderBy, direction, transactionId, contractAddress, sellerWalletAddress, userWalletAddress, status, provider, mintId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NftCheckoutPrimaryApi.GetNftPrimaryTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **int?** | Page size of the result | [optional]  |
| **cursor** | **string** | Cursor | [optional]  |
| **orderBy** | **string** | Property to sort by | [optional]  |
| **direction** | **string** | Direction to sort (asc/desc) | [optional]  |
| **transactionId** | **string** | Transaction id | [optional]  |
| **contractAddress** | **string** | Contract address of the asset | [optional]  |
| **sellerWalletAddress** | **string** | Ethereum address of the seller | [optional]  |
| **userWalletAddress** | **string** | Ethereum address of the user who wants to create transaction | [optional]  |
| **status** | **string** | Transaction status | [optional]  |
| **provider** | **string** | Checkout provider name | [optional]  |
| **mintId** | **string** | Minting transaction ID - see mintTokens response | [optional]  |

### Return type

[**NftprimarytransactionListTransactionsResponse**](NftprimarytransactionListTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registernftprimarysalescontract"></a>
# **RegisterNftPrimarySalesContract**
> ContractCreateResponse RegisterNftPrimarySalesContract (ContractCreateAPIRequest createAPIRequest)

Executes NFT primary sales contract registration

Registers a new contract for use in the minting with fiat card flow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class RegisterNftPrimarySalesContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new NftCheckoutPrimaryApi(config);
            var createAPIRequest = new ContractCreateAPIRequest(); // ContractCreateAPIRequest | req

            try
            {
                // Executes NFT primary sales contract registration
                ContractCreateResponse result = apiInstance.RegisterNftPrimarySalesContract(createAPIRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NftCheckoutPrimaryApi.RegisterNftPrimarySalesContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterNftPrimarySalesContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Executes NFT primary sales contract registration
    ApiResponse<ContractCreateResponse> response = apiInstance.RegisterNftPrimarySalesContractWithHttpInfo(createAPIRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NftCheckoutPrimaryApi.RegisterNftPrimarySalesContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAPIRequest** | [**ContractCreateAPIRequest**](ContractCreateAPIRequest.md) | req |  |

### Return type

[**ContractCreateResponse**](ContractCreateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

