# api.Api.TransfersApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransfer**](TransfersApi.md#createtransfer) | **POST** /v2/transfers | Creates a transfer of multiple tokens between two parties |
| [**CreateTransferV1**](TransfersApi.md#createtransferv1) | **POST** /v1/transfers | Creates a transfer of tokens between two parties |
| [**GetSignableTransfer**](TransfersApi.md#getsignabletransfer) | **POST** /v2/signable-transfer-details | Gets bulk details of a signable transfer |
| [**GetSignableTransferV1**](TransfersApi.md#getsignabletransferv1) | **POST** /v1/signable-transfer-details | Gets details of a signable transfer |
| [**GetTransfer**](TransfersApi.md#gettransfer) | **GET** /v1/transfers/{id} | Get details of a transfer with the given ID |
| [**ListTransfers**](TransfersApi.md#listtransfers) | **GET** /v1/transfers | Get a list of transfers |

<a name="createtransfer"></a>
# **CreateTransfer**
> CreateTransferResponse CreateTransfer (string xImxEthAddress, string xImxEthSignature, CreateTransferRequest createTransferRequestV2)

Creates a transfer of multiple tokens between two parties

Create a new transfer request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class CreateTransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new TransfersApi(config);
            var xImxEthAddress = "xImxEthAddress_example";  // string | eth address
            var xImxEthSignature = "xImxEthSignature_example";  // string | eth signature
            var createTransferRequestV2 = new CreateTransferRequest(); // CreateTransferRequest | Create transfer

            try
            {
                // Creates a transfer of multiple tokens between two parties
                CreateTransferResponse result = apiInstance.CreateTransfer(xImxEthAddress, xImxEthSignature, createTransferRequestV2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransfersApi.CreateTransfer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTransferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a transfer of multiple tokens between two parties
    ApiResponse<CreateTransferResponse> response = apiInstance.CreateTransferWithHttpInfo(xImxEthAddress, xImxEthSignature, createTransferRequestV2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransfersApi.CreateTransferWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xImxEthAddress** | **string** | eth address |  |
| **xImxEthSignature** | **string** | eth signature |  |
| **createTransferRequestV2** | [**CreateTransferRequest**](CreateTransferRequest.md) | Create transfer |  |

### Return type

[**CreateTransferResponse**](CreateTransferResponse.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtransferv1"></a>
# **CreateTransferV1**
> CreateTransferResponseV1 CreateTransferV1 (string xImxEthAddress, string xImxEthSignature, CreateTransferRequestV1 createTransferRequest)

Creates a transfer of tokens between two parties

Create a new transfer request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class CreateTransferV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new TransfersApi(config);
            var xImxEthAddress = "xImxEthAddress_example";  // string | eth address
            var xImxEthSignature = "xImxEthSignature_example";  // string | eth signature
            var createTransferRequest = new CreateTransferRequestV1(); // CreateTransferRequestV1 | Create transfer

            try
            {
                // Creates a transfer of tokens between two parties
                CreateTransferResponseV1 result = apiInstance.CreateTransferV1(xImxEthAddress, xImxEthSignature, createTransferRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransfersApi.CreateTransferV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTransferV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a transfer of tokens between two parties
    ApiResponse<CreateTransferResponseV1> response = apiInstance.CreateTransferV1WithHttpInfo(xImxEthAddress, xImxEthSignature, createTransferRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransfersApi.CreateTransferV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xImxEthAddress** | **string** | eth address |  |
| **xImxEthSignature** | **string** | eth signature |  |
| **createTransferRequest** | [**CreateTransferRequestV1**](CreateTransferRequestV1.md) | Create transfer |  |

### Return type

[**CreateTransferResponseV1**](CreateTransferResponseV1.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsignabletransfer"></a>
# **GetSignableTransfer**
> GetSignableTransferResponse GetSignableTransfer (GetSignableTransferRequest getSignableTransferRequestV2)

Gets bulk details of a signable transfer

Gets bulk details of a signable transfer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetSignableTransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new TransfersApi(config);
            var getSignableTransferRequestV2 = new GetSignableTransferRequest(); // GetSignableTransferRequest | get details of signable transfer

            try
            {
                // Gets bulk details of a signable transfer
                GetSignableTransferResponse result = apiInstance.GetSignableTransfer(getSignableTransferRequestV2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransfersApi.GetSignableTransfer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSignableTransferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets bulk details of a signable transfer
    ApiResponse<GetSignableTransferResponse> response = apiInstance.GetSignableTransferWithHttpInfo(getSignableTransferRequestV2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransfersApi.GetSignableTransferWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSignableTransferRequestV2** | [**GetSignableTransferRequest**](GetSignableTransferRequest.md) | get details of signable transfer |  |

### Return type

[**GetSignableTransferResponse**](GetSignableTransferResponse.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsignabletransferv1"></a>
# **GetSignableTransferV1**
> GetSignableTransferResponseV1 GetSignableTransferV1 (GetSignableTransferRequestV1 getSignableTransferRequest)

Gets details of a signable transfer

Gets details of a signable transfer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetSignableTransferV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new TransfersApi(config);
            var getSignableTransferRequest = new GetSignableTransferRequestV1(); // GetSignableTransferRequestV1 | get details of signable transfer

            try
            {
                // Gets details of a signable transfer
                GetSignableTransferResponseV1 result = apiInstance.GetSignableTransferV1(getSignableTransferRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransfersApi.GetSignableTransferV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSignableTransferV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets details of a signable transfer
    ApiResponse<GetSignableTransferResponseV1> response = apiInstance.GetSignableTransferV1WithHttpInfo(getSignableTransferRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransfersApi.GetSignableTransferV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSignableTransferRequest** | [**GetSignableTransferRequestV1**](GetSignableTransferRequestV1.md) | get details of signable transfer |  |

### Return type

[**GetSignableTransferResponseV1**](GetSignableTransferResponseV1.md)

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

<a name="gettransfer"></a>
# **GetTransfer**
> Transfer GetTransfer (string id)

Get details of a transfer with the given ID

Get details of a transfer with the given ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

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
using api.Api;
using api.Client;
using api.Model;

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

