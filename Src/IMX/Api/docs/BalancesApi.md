# api.Api.BalancesApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBalance**](BalancesApi.md#getbalance) | **GET** /v2/balances/{owner}/{address} | Fetches the token balances of the user |
| [**ListBalances**](BalancesApi.md#listbalances) | **GET** /v2/balances/{owner} | Get a list of balances for given user |

<a name="getbalance"></a>
# **GetBalance**
> Balance GetBalance (string owner, string address)

Fetches the token balances of the user

Fetches the token balances of the user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new BalancesApi(config);
            var owner = "owner_example";  // string | Address of the owner/user
            var address = "address_example";  // string | Token address

            try
            {
                // Fetches the token balances of the user
                Balance result = apiInstance.GetBalance(owner, address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancesApi.GetBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches the token balances of the user
    ApiResponse<Balance> response = apiInstance.GetBalanceWithHttpInfo(owner, address);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancesApi.GetBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | Address of the owner/user |  |
| **address** | **string** | Token address |  |

### Return type

[**Balance**](Balance.md)

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

<a name="listbalances"></a>
# **ListBalances**
> ListBalancesResponse ListBalances (string owner, int? pageSize = null, string cursor = null, string orderBy = null, string direction = null)

Get a list of balances for given user

Get a list of balances for given user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class ListBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new BalancesApi(config);
            var owner = "owner_example";  // string | Ethereum wallet address for user
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "orderBy_example";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 

            try
            {
                // Get a list of balances for given user
                ListBalancesResponse result = apiInstance.ListBalances(owner, pageSize, cursor, orderBy, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancesApi.ListBalances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBalancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of balances for given user
    ApiResponse<ListBalancesResponse> response = apiInstance.ListBalancesWithHttpInfo(owner, pageSize, cursor, orderBy, direction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancesApi.ListBalancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | Ethereum wallet address for user |  |
| **pageSize** | **int?** | Page size of the result | [optional]  |
| **cursor** | **string** | Cursor | [optional]  |
| **orderBy** | **string** | Property to sort by | [optional]  |
| **direction** | **string** | Direction to sort (asc/desc) | [optional]  |

### Return type

[**ListBalancesResponse**](ListBalancesResponse.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

