# Imx.Sdk.Gen.Api.ExchangesApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetExchange**](ExchangesApi.md#getexchange) | **GET** /v3/exchanges/{id} | Get an exchange by ID |
| [**GetExchanges**](ExchangesApi.md#getexchanges) | **GET** /v3/exchanges | Returns a list of exchanges based on the request |

<a name="getexchange"></a>
# **GetExchange**
> Exchange GetExchange (string id)

Get an exchange by ID

Get an exchange by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetExchangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new ExchangesApi(config);
            var id = "id_example";  // string | Exchange ID

            try
            {
                // Get an exchange by ID
                Exchange result = apiInstance.GetExchange(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExchangesApi.GetExchange: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExchangeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an exchange by ID
    ApiResponse<Exchange> response = apiInstance.GetExchangeWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExchangesApi.GetExchangeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Exchange ID |  |

### Return type

[**Exchange**](Exchange.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexchanges"></a>
# **GetExchanges**
> GetTransactionsResponse GetExchanges (int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, int? id = null, string walletAddress = null, string status = null, string provider = null, string transferId = null)

Returns a list of exchanges based on the request

Returns a list of exchanges based on the request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetExchangesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new ExchangesApi(config);
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "id";  // string | Property to sort by (optional) 
            var direction = "asc";  // string | Direction to sort (optional) 
            var id = 56;  // int? | Transaction ID (optional) 
            var walletAddress = "walletAddress_example";  // string | Ethereum address of the user who created transaction (optional) 
            var status = "created";  // string | Transaction status (optional) 
            var provider = "moonpay";  // string | Provider name (optional) 
            var transferId = "transferId_example";  // string | Transfer ID (optional) 

            try
            {
                // Returns a list of exchanges based on the request
                GetTransactionsResponse result = apiInstance.GetExchanges(pageSize, cursor, orderBy, direction, id, walletAddress, status, provider, transferId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExchangesApi.GetExchanges: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExchangesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of exchanges based on the request
    ApiResponse<GetTransactionsResponse> response = apiInstance.GetExchangesWithHttpInfo(pageSize, cursor, orderBy, direction, id, walletAddress, status, provider, transferId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExchangesApi.GetExchangesWithHttpInfo: " + e.Message);
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
| **direction** | **string** | Direction to sort | [optional]  |
| **id** | **int?** | Transaction ID | [optional]  |
| **walletAddress** | **string** | Ethereum address of the user who created transaction | [optional]  |
| **status** | **string** | Transaction status | [optional]  |
| **provider** | **string** | Provider name | [optional]  |
| **transferId** | **string** | Transfer ID | [optional]  |

### Return type

[**GetTransactionsResponse**](GetTransactionsResponse.md)

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

