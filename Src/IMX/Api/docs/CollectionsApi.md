# Imx.Sdk.Gen.Api.CollectionsApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCollection**](CollectionsApi.md#getcollection) | **GET** /v1/collections/{address} | Get details of a collection at the given address |
| [**ListCollectionFilters**](CollectionsApi.md#listcollectionfilters) | **GET** /v1/collections/{address}/filters | Get a list of collection filters |
| [**ListCollections**](CollectionsApi.md#listcollections) | **GET** /v1/collections | Get a list of collections |

<a name="getcollection"></a>
# **GetCollection**
> Collection GetCollection (string address)

Get details of a collection at the given address

Get details of a collection at the given address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new CollectionsApi(config);
            var address = "address_example";  // string | Collection contract address

            try
            {
                // Get details of a collection at the given address
                Collection result = apiInstance.GetCollection(address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.GetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details of a collection at the given address
    ApiResponse<Collection> response = apiInstance.GetCollectionWithHttpInfo(address);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionsApi.GetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | Collection contract address |  |

### Return type

**Collection**

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcollectionfilters"></a>
# **ListCollectionFilters**
> CollectionFilter ListCollectionFilters (string address, int? pageSize = null, string nextPageToken = null)

Get a list of collection filters

Get a list of collection filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class ListCollectionFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new CollectionsApi(config);
            var address = "address_example";  // string | Collection contract address
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var nextPageToken = "nextPageToken_example";  // string | Next page token (optional) 

            try
            {
                // Get a list of collection filters
                CollectionFilter result = apiInstance.ListCollectionFilters(address, pageSize, nextPageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.ListCollectionFilters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCollectionFiltersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of collection filters
    ApiResponse<CollectionFilter> response = apiInstance.ListCollectionFiltersWithHttpInfo(address, pageSize, nextPageToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionsApi.ListCollectionFiltersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | Collection contract address |  |
| **pageSize** | **int?** | Page size of the result | [optional]  |
| **nextPageToken** | **string** | Next page token | [optional]  |

### Return type

[**CollectionFilter**](CollectionFilter.md)

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

<a name="listcollections"></a>
# **ListCollections**
> ListCollectionsResponse ListCollections (int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, string blacklist = null, string whitelist = null, string keyword = null)

Get a list of collections

Get a list of collections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class ListCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new CollectionsApi(config);
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "name";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 
            var blacklist = "blacklist_example";  // string | List of collections not to be included, separated by commas (optional) 
            var whitelist = "whitelist_example";  // string | List of collections to be included, separated by commas (optional) 
            var keyword = "keyword_example";  // string | Keyword to search in collection name and description (optional) 

            try
            {
                // Get a list of collections
                ListCollectionsResponse result = apiInstance.ListCollections(pageSize, cursor, orderBy, direction, blacklist, whitelist, keyword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.ListCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of collections
    ApiResponse<ListCollectionsResponse> response = apiInstance.ListCollectionsWithHttpInfo(pageSize, cursor, orderBy, direction, blacklist, whitelist, keyword);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionsApi.ListCollectionsWithHttpInfo: " + e.Message);
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
| **blacklist** | **string** | List of collections not to be included, separated by commas | [optional]  |
| **whitelist** | **string** | List of collections to be included, separated by commas | [optional]  |
| **keyword** | **string** | Keyword to search in collection name and description | [optional]  |

### Return type

[**ListCollectionsResponse**](ListCollectionsResponse.md)

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

