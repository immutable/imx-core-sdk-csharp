# Imx.Sdk.Gen.Api.MetadataApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMetadataSchemaToCollection**](MetadataApi.md#addmetadataschematocollection) | **POST** /v1/collections/{address}/metadata-schema | Add metadata schema to collection |
| [**GetMetadataSchema**](MetadataApi.md#getmetadataschema) | **GET** /v1/collections/{address}/metadata-schema | Get collection metadata schema |
| [**UpdateMetadataSchemaByName**](MetadataApi.md#updatemetadataschemabyname) | **PATCH** /v1/collections/{address}/metadata-schema/{name} | Update metadata schema by name |

<a name="addmetadataschematocollection"></a>
# **AddMetadataSchemaToCollection**
> SuccessResponse AddMetadataSchemaToCollection (string address, string iMXSignature, string iMXTimestamp, AddMetadataSchemaToCollectionRequest addMetadataSchemaToCollectionRequest)

Add metadata schema to collection

Add metadata schema to collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class AddMetadataSchemaToCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MetadataApi(config);
            var address = "address_example";  // string | Collection contract address
            var iMXSignature = "iMXSignature_example";  // string | String created by signing wallet address and timestamp
            var iMXTimestamp = "iMXTimestamp_example";  // string | Unix Epoc timestamp
            var addMetadataSchemaToCollectionRequest = new AddMetadataSchemaToCollectionRequest(); // AddMetadataSchemaToCollectionRequest | add metadata schema to a collection

            try
            {
                // Add metadata schema to collection
                SuccessResponse result = apiInstance.AddMetadataSchemaToCollection(address, iMXSignature, iMXTimestamp, addMetadataSchemaToCollectionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.AddMetadataSchemaToCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMetadataSchemaToCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add metadata schema to collection
    ApiResponse<SuccessResponse> response = apiInstance.AddMetadataSchemaToCollectionWithHttpInfo(address, iMXSignature, iMXTimestamp, addMetadataSchemaToCollectionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.AddMetadataSchemaToCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | Collection contract address |  |
| **iMXSignature** | **string** | String created by signing wallet address and timestamp |  |
| **iMXTimestamp** | **string** | Unix Epoc timestamp |  |
| **addMetadataSchemaToCollectionRequest** | [**AddMetadataSchemaToCollectionRequest**](AddMetadataSchemaToCollectionRequest.md) | add metadata schema to a collection |  |

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetadataschema"></a>
# **GetMetadataSchema**
> List&lt;MetadataSchemaProperty&gt; GetMetadataSchema (string address)

Get collection metadata schema

Get collection metadata schema

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetMetadataSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MetadataApi(config);
            var address = "address_example";  // string | Collection contract address

            try
            {
                // Get collection metadata schema
                List<MetadataSchemaProperty> result = apiInstance.GetMetadataSchema(address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.GetMetadataSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetadataSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get collection metadata schema
    ApiResponse<List<MetadataSchemaProperty>> response = apiInstance.GetMetadataSchemaWithHttpInfo(address);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.GetMetadataSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | Collection contract address |  |

### Return type

[**List&lt;MetadataSchemaProperty&gt;**](MetadataSchemaProperty.md)

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

<a name="updatemetadataschemabyname"></a>
# **UpdateMetadataSchemaByName**
> SuccessResponse UpdateMetadataSchemaByName (string address, string name, string iMXSignature, string iMXTimestamp, MetadataSchemaRequest metadataSchemaRequest)

Update metadata schema by name

Update metadata schema by name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class UpdateMetadataSchemaByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MetadataApi(config);
            var address = "address_example";  // string | Collection contract address
            var name = "name_example";  // string | Metadata schema name
            var iMXSignature = "iMXSignature_example";  // string | String created by signing wallet address and timestamp
            var iMXTimestamp = "iMXTimestamp_example";  // string | Unix Epoc timestamp
            var metadataSchemaRequest = new MetadataSchemaRequest(); // MetadataSchemaRequest | update metadata schema

            try
            {
                // Update metadata schema by name
                SuccessResponse result = apiInstance.UpdateMetadataSchemaByName(address, name, iMXSignature, iMXTimestamp, metadataSchemaRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateMetadataSchemaByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMetadataSchemaByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update metadata schema by name
    ApiResponse<SuccessResponse> response = apiInstance.UpdateMetadataSchemaByNameWithHttpInfo(address, name, iMXSignature, iMXTimestamp, metadataSchemaRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.UpdateMetadataSchemaByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | Collection contract address |  |
| **name** | **string** | Metadata schema name |  |
| **iMXSignature** | **string** | String created by signing wallet address and timestamp |  |
| **iMXTimestamp** | **string** | Unix Epoc timestamp |  |
| **metadataSchemaRequest** | [**MetadataSchemaRequest**](MetadataSchemaRequest.md) | update metadata schema |  |

### Return type

[**SuccessResponse**](SuccessResponse.md)

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

