# api.Api.AssetsApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAsset**](AssetsApi.md#getasset) | **GET** /v1/assets/{token_address}/{token_id} | Get details of an asset |
| [**ListAssets**](AssetsApi.md#listassets) | **GET** /v1/assets | Get a list of assets |

<a name="getasset"></a>
# **GetAsset**
> Asset GetAsset (string tokenAddress, string tokenId, bool? includeFees = null)

Get details of an asset

Get details of an asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new AssetsApi(config);
            var tokenAddress = "tokenAddress_example";  // string | Address of the ERC721 contract
            var tokenId = "tokenId_example";  // string | Either ERC721 token ID or internal IMX ID
            var includeFees = true;  // bool? | Set flag to include fees associated with the asset (optional) 

            try
            {
                // Get details of an asset
                Asset result = apiInstance.GetAsset(tokenAddress, tokenId, includeFees);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details of an asset
    ApiResponse<Asset> response = apiInstance.GetAssetWithHttpInfo(tokenAddress, tokenId, includeFees);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.GetAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tokenAddress** | **string** | Address of the ERC721 contract |  |
| **tokenId** | **string** | Either ERC721 token ID or internal IMX ID |  |
| **includeFees** | **bool?** | Set flag to include fees associated with the asset | [optional]  |

### Return type

[**Asset**](Asset.md)

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

<a name="listassets"></a>
# **ListAssets**
> ListAssetsResponse ListAssets (int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, string user = null, string status = null, string name = null, string metadata = null, bool? sellOrders = null, bool? buyOrders = null, bool? includeFees = null, string collection = null, string updatedMinTimestamp = null, string updatedMaxTimestamp = null, string auxiliaryFeePercentages = null, string auxiliaryFeeRecipients = null)

Get a list of assets

Get a list of assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class ListAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new AssetsApi(config);
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "updated_at";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 
            var user = "user_example";  // string | Ethereum address of the user who owns these assets (optional) 
            var status = "eth";  // string | Status of these assets (optional) 
            var name = "name_example";  // string | Name of the asset to search (optional) 
            var metadata = "metadata_example";  // string | URL JSON-encoded metadata filters for these assets. Javascript example: encodeURI(JSON.stringify({'proto':['1147'],'quality':['Meteorite']})) (optional) 
            var sellOrders = true;  // bool? | Set flag to true to fetch an array of sell order details with accepted status associated with the asset (optional) 
            var buyOrders = true;  // bool? | Set flag to true to fetch an array of buy order details  with accepted status associated with the asset (optional) 
            var includeFees = true;  // bool? | Set flag to include fees associated with the asset (optional) 
            var collection = "collection_example";  // string | Collection contract address (optional) 
            var updatedMinTimestamp = "updatedMinTimestamp_example";  // string | Minimum timestamp for when these assets were last updated, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var updatedMaxTimestamp = "updatedMaxTimestamp_example";  // string | Maximum timestamp for when these assets were last updated, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var auxiliaryFeePercentages = "auxiliaryFeePercentages_example";  // string | Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients (optional) 
            var auxiliaryFeeRecipients = "auxiliaryFeeRecipients_example";  // string | Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages (optional) 

            try
            {
                // Get a list of assets
                ListAssetsResponse result = apiInstance.ListAssets(pageSize, cursor, orderBy, direction, user, status, name, metadata, sellOrders, buyOrders, includeFees, collection, updatedMinTimestamp, updatedMaxTimestamp, auxiliaryFeePercentages, auxiliaryFeeRecipients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.ListAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of assets
    ApiResponse<ListAssetsResponse> response = apiInstance.ListAssetsWithHttpInfo(pageSize, cursor, orderBy, direction, user, status, name, metadata, sellOrders, buyOrders, includeFees, collection, updatedMinTimestamp, updatedMaxTimestamp, auxiliaryFeePercentages, auxiliaryFeeRecipients);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.ListAssetsWithHttpInfo: " + e.Message);
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
| **user** | **string** | Ethereum address of the user who owns these assets | [optional]  |
| **status** | **string** | Status of these assets | [optional]  |
| **name** | **string** | Name of the asset to search | [optional]  |
| **metadata** | **string** | URL JSON-encoded metadata filters for these assets. Javascript example: encodeURI(JSON.stringify({&#39;proto&#39;:[&#39;1147&#39;],&#39;quality&#39;:[&#39;Meteorite&#39;]})) | [optional]  |
| **sellOrders** | **bool?** | Set flag to true to fetch an array of sell order details with accepted status associated with the asset | [optional]  |
| **buyOrders** | **bool?** | Set flag to true to fetch an array of buy order details  with accepted status associated with the asset | [optional]  |
| **includeFees** | **bool?** | Set flag to include fees associated with the asset | [optional]  |
| **collection** | **string** | Collection contract address | [optional]  |
| **updatedMinTimestamp** | **string** | Minimum timestamp for when these assets were last updated, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **updatedMaxTimestamp** | **string** | Maximum timestamp for when these assets were last updated, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **auxiliaryFeePercentages** | **string** | Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients | [optional]  |
| **auxiliaryFeeRecipients** | **string** | Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages | [optional]  |

### Return type

[**ListAssetsResponse**](ListAssetsResponse.md)

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

