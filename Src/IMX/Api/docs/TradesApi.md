# Imx.Sdk.Gen.Api.TradesApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTrade**](TradesApi.md#gettrade) | **GET** /v1/trades/{id} | Get details of a trade with the given ID |
| [**ListTrades**](TradesApi.md#listtrades) | **GET** /v1/trades | Get a list of trades |

<a name="gettrade"></a>
# **GetTrade**
> Trade GetTrade (string id)

Get details of a trade with the given ID

Get details of a trade with the given ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetTradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new TradesApi(config);
            var id = "id_example";  // string | Trade ID

            try
            {
                // Get details of a trade with the given ID
                Trade result = apiInstance.GetTrade(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradesApi.GetTrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details of a trade with the given ID
    ApiResponse<Trade> response = apiInstance.GetTradeWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TradesApi.GetTradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Trade ID |  |

### Return type

[**Trade**](Trade.md)

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

<a name="listtrades"></a>
# **ListTrades**
> ListTradesResponse ListTrades (string partyATokenType = null, string partyATokenAddress = null, string partyBTokenType = null, string partyBTokenAddress = null, string partyBTokenId = null, int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, string minTimestamp = null, string maxTimestamp = null)

Get a list of trades

Get a list of trades

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class ListTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new TradesApi(config);
            var partyATokenType = "partyATokenType_example";  // string | Party A's (buy order) token type of currency used to buy (optional) 
            var partyATokenAddress = "partyATokenAddress_example";  // string | Party A's (buy order) token address of currency used to buy (optional) 
            var partyBTokenType = "partyBTokenType_example";  // string | Party B's (sell order) token type of NFT sold - always ERC721 (optional) 
            var partyBTokenAddress = "partyBTokenAddress_example";  // string | Party B's (sell order) collection address of NFT sold (optional) 
            var partyBTokenId = "partyBTokenId_example";  // string | Party B's (sell order) token id of NFT sold (optional) 
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "orderBy_example";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 
            var minTimestamp = "minTimestamp_example";  // string | Minimum timestamp for this trade, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var maxTimestamp = "maxTimestamp_example";  // string | Maximum timestamp for this trade, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 

            try
            {
                // Get a list of trades
                ListTradesResponse result = apiInstance.ListTrades(partyATokenType, partyATokenAddress, partyBTokenType, partyBTokenAddress, partyBTokenId, pageSize, cursor, orderBy, direction, minTimestamp, maxTimestamp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradesApi.ListTrades: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTradesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of trades
    ApiResponse<ListTradesResponse> response = apiInstance.ListTradesWithHttpInfo(partyATokenType, partyATokenAddress, partyBTokenType, partyBTokenAddress, partyBTokenId, pageSize, cursor, orderBy, direction, minTimestamp, maxTimestamp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TradesApi.ListTradesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **partyATokenType** | **string** | Party A&#39;s (buy order) token type of currency used to buy | [optional]  |
| **partyATokenAddress** | **string** | Party A&#39;s (buy order) token address of currency used to buy | [optional]  |
| **partyBTokenType** | **string** | Party B&#39;s (sell order) token type of NFT sold - always ERC721 | [optional]  |
| **partyBTokenAddress** | **string** | Party B&#39;s (sell order) collection address of NFT sold | [optional]  |
| **partyBTokenId** | **string** | Party B&#39;s (sell order) token id of NFT sold | [optional]  |
| **pageSize** | **int?** | Page size of the result | [optional]  |
| **cursor** | **string** | Cursor | [optional]  |
| **orderBy** | **string** | Property to sort by | [optional]  |
| **direction** | **string** | Direction to sort (asc/desc) | [optional]  |
| **minTimestamp** | **string** | Minimum timestamp for this trade, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **maxTimestamp** | **string** | Maximum timestamp for this trade, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |

### Return type

[**ListTradesResponse**](ListTradesResponse.md)

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

