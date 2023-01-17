# api.Api.MetadataRefreshesApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAListOfMetadataRefreshes**](MetadataRefreshesApi.md#getalistofmetadatarefreshes) | **GET** /v1/metadata-refreshes |  |
| [**GetMetadataRefreshErrors**](MetadataRefreshesApi.md#getmetadatarefresherrors) | **GET** /v1/metadata-refreshes/{refresh_id}/errors |  |
| [**GetMetadataRefreshResults**](MetadataRefreshesApi.md#getmetadatarefreshresults) | **GET** /v1/metadata-refreshes/{refresh_id} |  |
| [**RequestAMetadataRefresh**](MetadataRefreshesApi.md#requestametadatarefresh) | **POST** /v1/metadata-refreshes |  |

<a name="getalistofmetadatarefreshes"></a>
# **GetAListOfMetadataRefreshes**
> GetMetadataRefreshes GetAListOfMetadataRefreshes (string xImxEthSignature, string xImxEthTimestamp, string xImxEthAddress, int? pageSize = null, string cursor = null, string collectionAddress = null)



Get a list of metadata refreshes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetAListOfMetadataRefreshesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MetadataRefreshesApi(config);
            var xImxEthSignature = "xImxEthSignature_example";  // string | String created by signing wallet address and timestamp. See https://docs.x.immutable.com/docs/generate-imx-signature
            var xImxEthTimestamp = "xImxEthTimestamp_example";  // string | Unix Epoc timestamp
            var xImxEthAddress = "xImxEthAddress_example";  // string | Wallet Address that signed the signature
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var collectionAddress = "collectionAddress_example";  // string | Collection address (optional) 

            try
            {
                GetMetadataRefreshes result = apiInstance.GetAListOfMetadataRefreshes(xImxEthSignature, xImxEthTimestamp, xImxEthAddress, pageSize, cursor, collectionAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataRefreshesApi.GetAListOfMetadataRefreshes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAListOfMetadataRefreshesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMetadataRefreshes> response = apiInstance.GetAListOfMetadataRefreshesWithHttpInfo(xImxEthSignature, xImxEthTimestamp, xImxEthAddress, pageSize, cursor, collectionAddress);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataRefreshesApi.GetAListOfMetadataRefreshesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xImxEthSignature** | **string** | String created by signing wallet address and timestamp. See https://docs.x.immutable.com/docs/generate-imx-signature |  |
| **xImxEthTimestamp** | **string** | Unix Epoc timestamp |  |
| **xImxEthAddress** | **string** | Wallet Address that signed the signature |  |
| **pageSize** | **int?** | Page size of the result | [optional]  |
| **cursor** | **string** | Cursor | [optional]  |
| **collectionAddress** | **string** | Collection address | [optional]  |

### Return type

[**GetMetadataRefreshes**](GetMetadataRefreshes.md)

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
| **401** | Unauthorized Request |  -  |
| **403** | Forbidden Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadatarefresherrors"></a>
# **GetMetadataRefreshErrors**
> GetMetadataRefreshErrorsResponse GetMetadataRefreshErrors (string refreshId, string xImxEthSignature, string xImxEthTimestamp, string xImxEthAddress, int? pageSize = null, string cursor = null)



Get metadata refresh errors

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetMetadataRefreshErrorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MetadataRefreshesApi(config);
            var refreshId = "refreshId_example";  // string | The metadata refresh ID
            var xImxEthSignature = "xImxEthSignature_example";  // string | String created by signing wallet address and timestamp. See https://docs.x.immutable.com/docs/generate-imx-signature
            var xImxEthTimestamp = "xImxEthTimestamp_example";  // string | Unix Epoc timestamp
            var xImxEthAddress = "xImxEthAddress_example";  // string | Wallet Address that signed the signature
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 

            try
            {
                GetMetadataRefreshErrorsResponse result = apiInstance.GetMetadataRefreshErrors(refreshId, xImxEthSignature, xImxEthTimestamp, xImxEthAddress, pageSize, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataRefreshesApi.GetMetadataRefreshErrors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetadataRefreshErrorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMetadataRefreshErrorsResponse> response = apiInstance.GetMetadataRefreshErrorsWithHttpInfo(refreshId, xImxEthSignature, xImxEthTimestamp, xImxEthAddress, pageSize, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataRefreshesApi.GetMetadataRefreshErrorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refreshId** | **string** | The metadata refresh ID |  |
| **xImxEthSignature** | **string** | String created by signing wallet address and timestamp. See https://docs.x.immutable.com/docs/generate-imx-signature |  |
| **xImxEthTimestamp** | **string** | Unix Epoc timestamp |  |
| **xImxEthAddress** | **string** | Wallet Address that signed the signature |  |
| **pageSize** | **int?** | Page size of the result | [optional]  |
| **cursor** | **string** | Cursor | [optional]  |

### Return type

[**GetMetadataRefreshErrorsResponse**](GetMetadataRefreshErrorsResponse.md)

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
| **401** | Unauthorized Request |  -  |
| **403** | Forbidden Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadatarefreshresults"></a>
# **GetMetadataRefreshResults**
> GetMetadataRefreshResponse GetMetadataRefreshResults (string refreshId, string xImxEthSignature, string xImxEthTimestamp, string xImxEthAddress)



Get metadata refresh results

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetMetadataRefreshResultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MetadataRefreshesApi(config);
            var refreshId = "refreshId_example";  // string | The metadata refresh ID
            var xImxEthSignature = "xImxEthSignature_example";  // string | String created by signing wallet address and timestamp. See https://docs.x.immutable.com/docs/generate-imx-signature
            var xImxEthTimestamp = "xImxEthTimestamp_example";  // string | Unix Epoc timestamp
            var xImxEthAddress = "xImxEthAddress_example";  // string | Wallet Address that signed the signature

            try
            {
                GetMetadataRefreshResponse result = apiInstance.GetMetadataRefreshResults(refreshId, xImxEthSignature, xImxEthTimestamp, xImxEthAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataRefreshesApi.GetMetadataRefreshResults: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetadataRefreshResultsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMetadataRefreshResponse> response = apiInstance.GetMetadataRefreshResultsWithHttpInfo(refreshId, xImxEthSignature, xImxEthTimestamp, xImxEthAddress);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataRefreshesApi.GetMetadataRefreshResultsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refreshId** | **string** | The metadata refresh ID |  |
| **xImxEthSignature** | **string** | String created by signing wallet address and timestamp. See https://docs.x.immutable.com/docs/generate-imx-signature |  |
| **xImxEthTimestamp** | **string** | Unix Epoc timestamp |  |
| **xImxEthAddress** | **string** | Wallet Address that signed the signature |  |

### Return type

[**GetMetadataRefreshResponse**](GetMetadataRefreshResponse.md)

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
| **401** | Unauthorized Request |  -  |
| **403** | Forbidden Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestametadatarefresh"></a>
# **RequestAMetadataRefresh**
> CreateMetadataRefreshResponse RequestAMetadataRefresh (string xImxEthSignature, string xImxEthTimestamp, string xImxEthAddress, CreateMetadataRefreshRequest createMetadataRefreshRequest)



Request metadata refresh for provided tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class RequestAMetadataRefreshExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MetadataRefreshesApi(config);
            var xImxEthSignature = "xImxEthSignature_example";  // string | String created by signing wallet address and timestamp. See https://docs.x.immutable.com/docs/generate-imx-signature
            var xImxEthTimestamp = "xImxEthTimestamp_example";  // string | Unix Epoc timestamp
            var xImxEthAddress = "xImxEthAddress_example";  // string | Wallet Address that signed the signature
            var createMetadataRefreshRequest = new CreateMetadataRefreshRequest(); // CreateMetadataRefreshRequest | Create metadata refresh request

            try
            {
                CreateMetadataRefreshResponse result = apiInstance.RequestAMetadataRefresh(xImxEthSignature, xImxEthTimestamp, xImxEthAddress, createMetadataRefreshRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataRefreshesApi.RequestAMetadataRefresh: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestAMetadataRefreshWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CreateMetadataRefreshResponse> response = apiInstance.RequestAMetadataRefreshWithHttpInfo(xImxEthSignature, xImxEthTimestamp, xImxEthAddress, createMetadataRefreshRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataRefreshesApi.RequestAMetadataRefreshWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xImxEthSignature** | **string** | String created by signing wallet address and timestamp. See https://docs.x.immutable.com/docs/generate-imx-signature |  |
| **xImxEthTimestamp** | **string** | Unix Epoc timestamp |  |
| **xImxEthAddress** | **string** | Wallet Address that signed the signature |  |
| **createMetadataRefreshRequest** | [**CreateMetadataRefreshRequest**](CreateMetadataRefreshRequest.md) | Create metadata refresh request |  |

### Return type

[**CreateMetadataRefreshResponse**](CreateMetadataRefreshResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  * x-imx-refresh-limit-reset - The expiry date of the current one-hour window. <br>  * x-imx-remaining-refreshes - The amount of refresh requests remaining for current one-hour window. <br>  * x-imx-refreshes-limit - The refresh request limit available to the project for each one-hour window. <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized Request |  -  |
| **403** | Forbidden Request |  -  |
| **429** | Too Many Requests |  * x-imx-refresh-limit-reset - The expiry date of the current one-hour window. <br>  * x-imx-remaining-refreshes - The amount of refresh requests remaining for current one-hour window. <br>  * x-imx-refreshes-limit - The refresh request limit available to the project for each one-hour window. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

