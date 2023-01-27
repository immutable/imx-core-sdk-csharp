# Imx.Sdk.Gen.Api.EncodingApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EncodeAsset**](EncodingApi.md#encodeasset) | **POST** /v1/encode/{assetType} | Retrieves the Starkex Encoded format for a given asset |

<a name="encodeasset"></a>
# **EncodeAsset**
> EncodeAssetResponse EncodeAsset (string assetType, EncodeAssetRequest encodeAssetRequest)

Retrieves the Starkex Encoded format for a given asset

Retrieves the Starkex Encoded format for a given asset so that it can be used as parameter for Starkex smart contracts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class EncodeAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new EncodingApi(config);
            var assetType = "assetType_example";  // string | Asset type to be encoded. (asset/mintable-asset)
            var encodeAssetRequest = new EncodeAssetRequest(); // EncodeAssetRequest | Encode Asset

            try
            {
                // Retrieves the Starkex Encoded format for a given asset
                EncodeAssetResponse result = apiInstance.EncodeAsset(assetType, encodeAssetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EncodingApi.EncodeAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EncodeAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the Starkex Encoded format for a given asset
    ApiResponse<EncodeAssetResponse> response = apiInstance.EncodeAssetWithHttpInfo(assetType, encodeAssetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EncodingApi.EncodeAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetType** | **string** | Asset type to be encoded. (asset/mintable-asset) |  |
| **encodeAssetRequest** | [**EncodeAssetRequest**](EncodeAssetRequest.md) | Encode Asset |  |

### Return type

[**EncodeAssetResponse**](EncodeAssetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

