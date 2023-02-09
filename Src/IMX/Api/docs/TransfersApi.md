# Imx.Sdk.Gen.Api.TransfersApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTransfer**](TransfersApi.md#gettransfer) | **GET** /v1/transfers/{id} | Get details of a transfer with the given ID |
| [**ListTransfers**](TransfersApi.md#listtransfers) | **GET** /v1/transfers | Get a list of transfers |

<a name="gettransfer"></a>
# **GetTransfer**
> Transfer GetTransfer (string id)

Get details of a transfer with the given ID

Get details of a transfer with the given ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetTransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new TransfersApi(config);
            var id = "id_example";  // string | Transfer ID

            try
            {
                // Get details of a transfer with the given ID
                Transfer result = apiInstance.GetTransfer(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransfersApi.GetTransfer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details of a transfer with the given ID
    ApiResponse<Transfer> response = apiInstance.GetTransferWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransfersApi.GetTransferWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Transfer ID |  |

### Return type

[**Transfer**](Transfer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtransfers"></a>
# **ListTransfers**
> ListTransfersResponse ListTransfers (int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, string user = null, string receiver = null, string status = null, string minTimestamp = null, string maxTimestamp = null, string tokenType = null, string tokenId = null, string assetId = null, string tokenAddress = null, string tokenName = null, string minQuantity = null, string maxQuantity = null, string metadata = null)

Get a list of transfers

Get a list of transfers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class ListTransfersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new TransfersApi(config);
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "transaction_id";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 
            var user = "user_example";  // string | Ethereum address of the user who submitted this transfer (optional) 
            var receiver = "receiver_example";  // string | Ethereum address of the user who received this transfer (optional) 
            var status = "success";  // string | Status of this transfer (optional) 
            var minTimestamp = "minTimestamp_example";  // string | Minimum timestamp for this transfer, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var maxTimestamp = "maxTimestamp_example";  // string | Maximum timestamp for this transfer, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var tokenType = "tokenType_example";  // string | Token type of the transferred asset (optional) 
            var tokenId = "tokenId_example";  // string | ERC721 Token ID of the minted asset (optional) 
            var assetId = "assetId_example";  // string | Internal IMX ID of the minted asset (optional) 
            var tokenAddress = "tokenAddress_example";  // string | Token address of the transferred asset (optional) 
            var tokenName = "tokenName_example";  // string | Token name of the transferred asset (optional) 
            var minQuantity = "minQuantity_example";  // string | Max quantity for the transferred asset (optional) 
            var maxQuantity = "maxQuantity_example";  // string | Max quantity for the transferred asset (optional) 
            var metadata = "metadata_example";  // string | JSON-encoded metadata filters for the transferred asset (optional) 

            try
            {
                // Get a list of transfers
                ListTransfersResponse result = apiInstance.ListTransfers(pageSize, cursor, orderBy, direction, user, receiver, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransfersApi.ListTransfers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransfersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of transfers
    ApiResponse<ListTransfersResponse> response = apiInstance.ListTransfersWithHttpInfo(pageSize, cursor, orderBy, direction, user, receiver, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransfersApi.ListTransfersWithHttpInfo: " + e.Message);
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
| **user** | **string** | Ethereum address of the user who submitted this transfer | [optional]  |
| **receiver** | **string** | Ethereum address of the user who received this transfer | [optional]  |
| **status** | **string** | Status of this transfer | [optional]  |
| **minTimestamp** | **string** | Minimum timestamp for this transfer, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **maxTimestamp** | **string** | Maximum timestamp for this transfer, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **tokenType** | **string** | Token type of the transferred asset | [optional]  |
| **tokenId** | **string** | ERC721 Token ID of the minted asset | [optional]  |
| **assetId** | **string** | Internal IMX ID of the minted asset | [optional]  |
| **tokenAddress** | **string** | Token address of the transferred asset | [optional]  |
| **tokenName** | **string** | Token name of the transferred asset | [optional]  |
| **minQuantity** | **string** | Max quantity for the transferred asset | [optional]  |
| **maxQuantity** | **string** | Max quantity for the transferred asset | [optional]  |
| **metadata** | **string** | JSON-encoded metadata filters for the transferred asset | [optional]  |

### Return type

[**ListTransfersResponse**](ListTransfersResponse.md)

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

