# api.Api.MintsApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMint**](MintsApi.md#getmint) | **GET** /v1/mints/{id} | Get details of a mint with the given ID |
| [**GetMintableTokenDetailsByClientTokenId**](MintsApi.md#getmintabletokendetailsbyclienttokenid) | **GET** /v1/mintable-token/{token_address}/{token_id} | Get details of a mintable token with the given token address and token ID |
| [**ListMints**](MintsApi.md#listmints) | **GET** /v1/mints | Get a list of mints |
| [**MintTokens**](MintsApi.md#minttokens) | **POST** /v2/mints | Mint Tokens V2 |

<a name="getmint"></a>
# **GetMint**
> Mint GetMint (string id)

Get details of a mint with the given ID

Get details of a mint with the given ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetMintExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MintsApi(config);
            var id = "id_example";  // string | Mint ID. This is the transaction_id returned from listMints

            try
            {
                // Get details of a mint with the given ID
                Mint result = apiInstance.GetMint(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintsApi.GetMint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details of a mint with the given ID
    ApiResponse<Mint> response = apiInstance.GetMintWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintsApi.GetMintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Mint ID. This is the transaction_id returned from listMints |  |

### Return type

[**Mint**](Mint.md)

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
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmintabletokendetailsbyclienttokenid"></a>
# **GetMintableTokenDetailsByClientTokenId**
> MintableTokenDetails GetMintableTokenDetailsByClientTokenId (string tokenAddress, string tokenId)

Get details of a mintable token with the given token address and token ID

Get details of a mintable token with the given token address and token ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetMintableTokenDetailsByClientTokenIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MintsApi(config);
            var tokenAddress = "tokenAddress_example";  // string | Address of the ERC721 contract
            var tokenId = "tokenId_example";  // string | ERC721 token ID

            try
            {
                // Get details of a mintable token with the given token address and token ID
                MintableTokenDetails result = apiInstance.GetMintableTokenDetailsByClientTokenId(tokenAddress, tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintsApi.GetMintableTokenDetailsByClientTokenId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMintableTokenDetailsByClientTokenIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details of a mintable token with the given token address and token ID
    ApiResponse<MintableTokenDetails> response = apiInstance.GetMintableTokenDetailsByClientTokenIdWithHttpInfo(tokenAddress, tokenId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintsApi.GetMintableTokenDetailsByClientTokenIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tokenAddress** | **string** | Address of the ERC721 contract |  |
| **tokenId** | **string** | ERC721 token ID |  |

### Return type

[**MintableTokenDetails**](MintableTokenDetails.md)

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

<a name="listmints"></a>
# **ListMints**
> ListMintsResponse ListMints (int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, string user = null, string status = null, string minTimestamp = null, string maxTimestamp = null, string tokenType = null, string tokenId = null, string assetId = null, string tokenName = null, string tokenAddress = null, string minQuantity = null, string maxQuantity = null, string metadata = null)

Get a list of mints

Get information about token mints. If you want to get information about tokens that have already been minted, use the listAssets endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class ListMintsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MintsApi(config);
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "transaction_id";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 
            var user = "user_example";  // string | Ethereum address of the user who submitted this mint (optional) 
            var status = "status_example";  // string | Status of this mint (optional) 
            var minTimestamp = "minTimestamp_example";  // string | Minimum timestamp for this mint, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var maxTimestamp = "maxTimestamp_example";  // string | Maximum timestamp for this mint, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var tokenType = "tokenType_example";  // string | Token type of the minted asset (optional) 
            var tokenId = "tokenId_example";  // string | ERC721 Token ID of the minted asset (optional) 
            var assetId = "assetId_example";  // string | [DEPRECATED] Internal IMX ID of the minted asset (optional) 
            var tokenName = "tokenName_example";  // string | Token Name of the minted asset (optional) 
            var tokenAddress = "tokenAddress_example";  // string | Token address of the minted asset (optional) 
            var minQuantity = "minQuantity_example";  // string | Min quantity for the minted asset (optional) 
            var maxQuantity = "maxQuantity_example";  // string | Max quantity for the minted asset (optional) 
            var metadata = "metadata_example";  // string | JSON-encoded metadata filters for the minted asset (optional) 

            try
            {
                // Get a list of mints
                ListMintsResponse result = apiInstance.ListMints(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenName, tokenAddress, minQuantity, maxQuantity, metadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintsApi.ListMints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMintsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of mints
    ApiResponse<ListMintsResponse> response = apiInstance.ListMintsWithHttpInfo(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenName, tokenAddress, minQuantity, maxQuantity, metadata);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintsApi.ListMintsWithHttpInfo: " + e.Message);
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
| **user** | **string** | Ethereum address of the user who submitted this mint | [optional]  |
| **status** | **string** | Status of this mint | [optional]  |
| **minTimestamp** | **string** | Minimum timestamp for this mint, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **maxTimestamp** | **string** | Maximum timestamp for this mint, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **tokenType** | **string** | Token type of the minted asset | [optional]  |
| **tokenId** | **string** | ERC721 Token ID of the minted asset | [optional]  |
| **assetId** | **string** | [DEPRECATED] Internal IMX ID of the minted asset | [optional]  |
| **tokenName** | **string** | Token Name of the minted asset | [optional]  |
| **tokenAddress** | **string** | Token address of the minted asset | [optional]  |
| **minQuantity** | **string** | Min quantity for the minted asset | [optional]  |
| **maxQuantity** | **string** | Max quantity for the minted asset | [optional]  |
| **metadata** | **string** | JSON-encoded metadata filters for the minted asset | [optional]  |

### Return type

[**ListMintsResponse**](ListMintsResponse.md)

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

<a name="minttokens"></a>
# **MintTokens**
> MintTokensResponse MintTokens (List<MintRequest> mintTokensRequestV2)

Mint Tokens V2

Mint tokens in a batch with fees

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class MintTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new MintsApi(config);
            var mintTokensRequestV2 = new List<MintRequest>(); // List<MintRequest> | details of tokens to mint

            try
            {
                // Mint Tokens V2
                MintTokensResponse result = apiInstance.MintTokens(mintTokensRequestV2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintsApi.MintTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MintTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mint Tokens V2
    ApiResponse<MintTokensResponse> response = apiInstance.MintTokensWithHttpInfo(mintTokensRequestV2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintsApi.MintTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mintTokensRequestV2** | [**List&lt;MintRequest&gt;**](MintRequest.md) | details of tokens to mint |  |

### Return type

[**MintTokensResponse**](MintTokensResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * Mint_Limit_Reset - The expiry date of the current four-week window. <br>  * Mint_Limit - The mint limit available to the project for each four-week window. <br>  * Mint_Remaining - The amount of mints remaining for current four-week window. <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

