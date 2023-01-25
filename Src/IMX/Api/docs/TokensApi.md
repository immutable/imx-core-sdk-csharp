# api.Api.TokensApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetToken**](TokensApi.md#gettoken) | **GET** /v1/tokens/{address} | Get details of a token |
| [**ListTokens**](TokensApi.md#listtokens) | **GET** /v1/tokens | Get a list of tokens |

<a name="gettoken"></a>
# **GetToken**
> TokenDetails GetToken (string address)

Get details of a token

Get details of a token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new TokensApi(config);
            var address = "address_example";  // string | Token Contract Address

            try
            {
                // Get details of a token
                TokenDetails result = apiInstance.GetToken(address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.GetToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details of a token
    ApiResponse<TokenDetails> response = apiInstance.GetTokenWithHttpInfo(address);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.GetTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | Token Contract Address |  |

### Return type

[**TokenDetails**](TokenDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtokens"></a>
# **ListTokens**
> ListTokensResponse ListTokens (int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, string address = null, string symbols = null)

Get a list of tokens

Get a list of tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class ListTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new TokensApi(config);
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "contract_address";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 
            var address = "address_example";  // string | Contract address of the token (optional) 
            var symbols = "symbols_example";  // string | Token symbols for the token, e.g. ?symbols=IMX,ETH (optional) 

            try
            {
                // Get a list of tokens
                ListTokensResponse result = apiInstance.ListTokens(pageSize, cursor, orderBy, direction, address, symbols);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.ListTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of tokens
    ApiResponse<ListTokensResponse> response = apiInstance.ListTokensWithHttpInfo(pageSize, cursor, orderBy, direction, address, symbols);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.ListTokensWithHttpInfo: " + e.Message);
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
| **address** | **string** | Contract address of the token | [optional]  |
| **symbols** | **string** | Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH | [optional]  |

### Return type

[**ListTokensResponse**](ListTokensResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

