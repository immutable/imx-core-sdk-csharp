# Imx.Sdk.Gen.Api.DepositsApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDeposit**](DepositsApi.md#getdeposit) | **GET** /v1/deposits/{id} | Get details of a deposit with the given ID |
| [**GetSignableDeposit**](DepositsApi.md#getsignabledeposit) | **POST** /v1/signable-deposit-details | Gets details of a signable deposit |
| [**ListDeposits**](DepositsApi.md#listdeposits) | **GET** /v1/deposits | Get a list of deposits |

<a name="getdeposit"></a>
# **GetDeposit**
> Deposit GetDeposit (string id)

Get details of a deposit with the given ID

Get details of a deposit with the given ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetDepositExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new DepositsApi(config);
            var id = "id_example";  // string | Deposit ID

            try
            {
                // Get details of a deposit with the given ID
                Deposit result = apiInstance.GetDeposit(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepositsApi.GetDeposit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDepositWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details of a deposit with the given ID
    ApiResponse<Deposit> response = apiInstance.GetDepositWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepositsApi.GetDepositWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Deposit ID |  |

### Return type

[**Deposit**](Deposit.md)

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

<a name="getsignabledeposit"></a>
# **GetSignableDeposit**
> GetSignableDepositResponse GetSignableDeposit (GetSignableDepositRequest getSignableDepositRequest)

Gets details of a signable deposit

Gets details of a signable deposit

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetSignableDepositExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new DepositsApi(config);
            var getSignableDepositRequest = new GetSignableDepositRequest(); // GetSignableDepositRequest | Get details of signable deposit

            try
            {
                // Gets details of a signable deposit
                GetSignableDepositResponse result = apiInstance.GetSignableDeposit(getSignableDepositRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepositsApi.GetSignableDeposit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSignableDepositWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets details of a signable deposit
    ApiResponse<GetSignableDepositResponse> response = apiInstance.GetSignableDepositWithHttpInfo(getSignableDepositRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepositsApi.GetSignableDepositWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSignableDepositRequest** | [**GetSignableDepositRequest**](GetSignableDepositRequest.md) | Get details of signable deposit |  |

### Return type

[**GetSignableDepositResponse**](GetSignableDepositResponse.md)

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

<a name="listdeposits"></a>
# **ListDeposits**
> ListDepositsResponse ListDeposits (int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, string user = null, string status = null, string minTimestamp = null, string maxTimestamp = null, string tokenType = null, string tokenId = null, string assetId = null, string tokenAddress = null, string tokenName = null, string minQuantity = null, string maxQuantity = null, string metadata = null)

Get a list of deposits

Get a list of deposits

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class ListDepositsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new DepositsApi(config);
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "orderBy_example";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 
            var user = "user_example";  // string | Ethereum address of the user who submitted this deposit (optional) 
            var status = "status_example";  // string | Status of this deposit (optional) 
            var minTimestamp = "minTimestamp_example";  // string | Minimum timestamp for this deposit, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var maxTimestamp = "maxTimestamp_example";  // string | Maximum timestamp for this deposit, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var tokenType = "tokenType_example";  // string | Token type of the deposited asset (optional) 
            var tokenId = "tokenId_example";  // string | ERC721 Token ID of the minted asset (optional) 
            var assetId = "assetId_example";  // string | Internal IMX ID of the minted asset (optional) 
            var tokenAddress = "tokenAddress_example";  // string | Token address of the deposited asset (optional) 
            var tokenName = "tokenName_example";  // string | Token name of the deposited asset (optional) 
            var minQuantity = "minQuantity_example";  // string | Min quantity for the deposited asset (optional) 
            var maxQuantity = "maxQuantity_example";  // string | Max quantity for the deposited asset (optional) 
            var metadata = "metadata_example";  // string | JSON-encoded metadata filters for the deposited asset (optional) 

            try
            {
                // Get a list of deposits
                ListDepositsResponse result = apiInstance.ListDeposits(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepositsApi.ListDeposits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDepositsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of deposits
    ApiResponse<ListDepositsResponse> response = apiInstance.ListDepositsWithHttpInfo(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepositsApi.ListDepositsWithHttpInfo: " + e.Message);
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
| **user** | **string** | Ethereum address of the user who submitted this deposit | [optional]  |
| **status** | **string** | Status of this deposit | [optional]  |
| **minTimestamp** | **string** | Minimum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **maxTimestamp** | **string** | Maximum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **tokenType** | **string** | Token type of the deposited asset | [optional]  |
| **tokenId** | **string** | ERC721 Token ID of the minted asset | [optional]  |
| **assetId** | **string** | Internal IMX ID of the minted asset | [optional]  |
| **tokenAddress** | **string** | Token address of the deposited asset | [optional]  |
| **tokenName** | **string** | Token name of the deposited asset | [optional]  |
| **minQuantity** | **string** | Min quantity for the deposited asset | [optional]  |
| **maxQuantity** | **string** | Max quantity for the deposited asset | [optional]  |
| **metadata** | **string** | JSON-encoded metadata filters for the deposited asset | [optional]  |

### Return type

[**ListDepositsResponse**](ListDepositsResponse.md)

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

