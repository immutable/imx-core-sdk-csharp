# api.Api.OrdersApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelOrder**](OrdersApi.md#cancelorder) | **DELETE** /v1/orders/{id} | Cancel an order |
| [**CreateOrder**](OrdersApi.md#createorder) | **POST** /v1/orders | Create an order |
| [**GetOrder**](OrdersApi.md#getorder) | **GET** /v1/orders/{id} | Get details of an order with the given ID |
| [**GetSignableCancelOrder**](OrdersApi.md#getsignablecancelorder) | **POST** /v1/signable-cancel-order-details | Get details a signable cancel order |
| [**GetSignableOrder**](OrdersApi.md#getsignableorder) | **POST** /v3/signable-order-details | Get a signable order request (V3) |
| [**ListOrders**](OrdersApi.md#listorders) | **GET** /v1/orders | Get a list of orders |

<a name="cancelorder"></a>
# **CancelOrder**
> CancelOrderResponse CancelOrder (string xImxEthAddress, string xImxEthSignature, string id, CancelOrderRequest cancelOrderRequest)

Cancel an order

Cancel an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class CancelOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new OrdersApi(config);
            var xImxEthAddress = "xImxEthAddress_example";  // string | eth address
            var xImxEthSignature = "xImxEthSignature_example";  // string | eth signature
            var id = "id_example";  // string | Order ID to cancel
            var cancelOrderRequest = new CancelOrderRequest(); // CancelOrderRequest | cancel an order

            try
            {
                // Cancel an order
                CancelOrderResponse result = apiInstance.CancelOrder(xImxEthAddress, xImxEthSignature, id, cancelOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CancelOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel an order
    ApiResponse<CancelOrderResponse> response = apiInstance.CancelOrderWithHttpInfo(xImxEthAddress, xImxEthSignature, id, cancelOrderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.CancelOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xImxEthAddress** | **string** | eth address |  |
| **xImxEthSignature** | **string** | eth signature |  |
| **id** | **string** | Order ID to cancel |  |
| **cancelOrderRequest** | [**CancelOrderRequest**](CancelOrderRequest.md) | cancel an order |  |

### Return type

[**CancelOrderResponse**](CancelOrderResponse.md)

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

<a name="createorder"></a>
# **CreateOrder**
> CreateOrderResponse CreateOrder (string xImxEthAddress, string xImxEthSignature, CreateOrderRequest createOrderRequest)

Create an order

Create an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new OrdersApi(config);
            var xImxEthAddress = "xImxEthAddress_example";  // string | eth address
            var xImxEthSignature = "xImxEthSignature_example";  // string | eth signature
            var createOrderRequest = new CreateOrderRequest(); // CreateOrderRequest | create an order

            try
            {
                // Create an order
                CreateOrderResponse result = apiInstance.CreateOrder(xImxEthAddress, xImxEthSignature, createOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an order
    ApiResponse<CreateOrderResponse> response = apiInstance.CreateOrderWithHttpInfo(xImxEthAddress, xImxEthSignature, createOrderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.CreateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xImxEthAddress** | **string** | eth address |  |
| **xImxEthSignature** | **string** | eth signature |  |
| **createOrderRequest** | [**CreateOrderRequest**](CreateOrderRequest.md) | create an order |  |

### Return type

[**CreateOrderResponse**](CreateOrderResponse.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorder"></a>
# **GetOrder**
> Order GetOrder (string id, bool? includeFees = null, string auxiliaryFeePercentages = null, string auxiliaryFeeRecipients = null)

Get details of an order with the given ID

Get details of an order with the given ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new OrdersApi(config);
            var id = "id_example";  // string | Order ID
            var includeFees = true;  // bool? | Set flag to true to include fee body for the order (optional) 
            var auxiliaryFeePercentages = "auxiliaryFeePercentages_example";  // string | Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients (optional) 
            var auxiliaryFeeRecipients = "auxiliaryFeeRecipients_example";  // string | Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages (optional) 

            try
            {
                // Get details of an order with the given ID
                Order result = apiInstance.GetOrder(id, includeFees, auxiliaryFeePercentages, auxiliaryFeeRecipients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details of an order with the given ID
    ApiResponse<Order> response = apiInstance.GetOrderWithHttpInfo(id, includeFees, auxiliaryFeePercentages, auxiliaryFeeRecipients);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.GetOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Order ID |  |
| **includeFees** | **bool?** | Set flag to true to include fee body for the order | [optional]  |
| **auxiliaryFeePercentages** | **string** | Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients | [optional]  |
| **auxiliaryFeeRecipients** | **string** | Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages | [optional]  |

### Return type

[**Order**](Order.md)

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

<a name="getsignablecancelorder"></a>
# **GetSignableCancelOrder**
> GetSignableCancelOrderResponse GetSignableCancelOrder (GetSignableCancelOrderRequest getSignableCancelOrderRequest)

Get details a signable cancel order

Get details a signable cancel order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetSignableCancelOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new OrdersApi(config);
            var getSignableCancelOrderRequest = new GetSignableCancelOrderRequest(); // GetSignableCancelOrderRequest | get a signable cancel order

            try
            {
                // Get details a signable cancel order
                GetSignableCancelOrderResponse result = apiInstance.GetSignableCancelOrder(getSignableCancelOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetSignableCancelOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSignableCancelOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details a signable cancel order
    ApiResponse<GetSignableCancelOrderResponse> response = apiInstance.GetSignableCancelOrderWithHttpInfo(getSignableCancelOrderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.GetSignableCancelOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSignableCancelOrderRequest** | [**GetSignableCancelOrderRequest**](GetSignableCancelOrderRequest.md) | get a signable cancel order |  |

### Return type

[**GetSignableCancelOrderResponse**](GetSignableCancelOrderResponse.md)

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

<a name="getsignableorder"></a>
# **GetSignableOrder**
> GetSignableOrderResponse GetSignableOrder (GetSignableOrderRequest getSignableOrderRequestV3)

Get a signable order request (V3)

Get a signable order request (V3)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetSignableOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new OrdersApi(config);
            var getSignableOrderRequestV3 = new GetSignableOrderRequest(); // GetSignableOrderRequest | get a signable order

            try
            {
                // Get a signable order request (V3)
                GetSignableOrderResponse result = apiInstance.GetSignableOrder(getSignableOrderRequestV3);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetSignableOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSignableOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a signable order request (V3)
    ApiResponse<GetSignableOrderResponse> response = apiInstance.GetSignableOrderWithHttpInfo(getSignableOrderRequestV3);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.GetSignableOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSignableOrderRequestV3** | [**GetSignableOrderRequest**](GetSignableOrderRequest.md) | get a signable order |  |

### Return type

[**GetSignableOrderResponse**](GetSignableOrderResponse.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listorders"></a>
# **ListOrders**
> ListOrdersResponse ListOrders (int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, string user = null, string status = null, string minTimestamp = null, string maxTimestamp = null, string updatedMinTimestamp = null, string updatedMaxTimestamp = null, string buyTokenType = null, string buyTokenId = null, string buyAssetId = null, string buyTokenAddress = null, string buyTokenName = null, string buyMinQuantity = null, string buyMaxQuantity = null, string buyMetadata = null, string sellTokenType = null, string sellTokenId = null, string sellAssetId = null, string sellTokenAddress = null, string sellTokenName = null, string sellMinQuantity = null, string sellMaxQuantity = null, string sellMetadata = null, string auxiliaryFeePercentages = null, string auxiliaryFeeRecipients = null, bool? includeFees = null)

Get a list of orders

Get a list of orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class ListOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new OrdersApi(config);
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "created_at";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 
            var user = "user_example";  // string | Ethereum address of the user who submitted this order (optional) 
            var status = "active";  // string | Status of this order (optional) 
            var minTimestamp = "minTimestamp_example";  // string | Minimum created at timestamp for this order, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var maxTimestamp = "maxTimestamp_example";  // string | Maximum created at timestamp for this order, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var updatedMinTimestamp = "updatedMinTimestamp_example";  // string | Minimum updated at timestamp for this order, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var updatedMaxTimestamp = "updatedMaxTimestamp_example";  // string | Maximum updated at timestamp for this order, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var buyTokenType = "buyTokenType_example";  // string | Token type of the asset this order buys (optional) 
            var buyTokenId = "buyTokenId_example";  // string | ERC721 Token ID of the asset this order buys (optional) 
            var buyAssetId = "buyAssetId_example";  // string | Internal IMX ID of the asset this order buys (optional) 
            var buyTokenAddress = "buyTokenAddress_example";  // string | Token address of the asset this order buys (optional) 
            var buyTokenName = "buyTokenName_example";  // string | Token name of the asset this order buys (optional) 
            var buyMinQuantity = "buyMinQuantity_example";  // string | Min quantity for the asset this order buys (optional) 
            var buyMaxQuantity = "buyMaxQuantity_example";  // string | Max quantity for the asset this order buys (optional) 
            var buyMetadata = "buyMetadata_example";  // string | JSON-encoded metadata filters for the asset this order buys (optional) 
            var sellTokenType = "sellTokenType_example";  // string | Token type of the asset this order sells (optional) 
            var sellTokenId = "sellTokenId_example";  // string | ERC721 Token ID of the asset this order sells (optional) 
            var sellAssetId = "sellAssetId_example";  // string | Internal IMX ID of the asset this order sells (optional) 
            var sellTokenAddress = "sellTokenAddress_example";  // string | Token address of the asset this order sells (optional) 
            var sellTokenName = "sellTokenName_example";  // string | Token name of the asset this order sells (optional) 
            var sellMinQuantity = "sellMinQuantity_example";  // string | Min quantity for the asset this order sells (optional) 
            var sellMaxQuantity = "sellMaxQuantity_example";  // string | Max quantity for the asset this order sells (optional) 
            var sellMetadata = "sellMetadata_example";  // string | JSON-encoded metadata filters for the asset this order sells (optional) 
            var auxiliaryFeePercentages = "auxiliaryFeePercentages_example";  // string | Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients (optional) 
            var auxiliaryFeeRecipients = "auxiliaryFeeRecipients_example";  // string | Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages (optional) 
            var includeFees = true;  // bool? | Set flag to true to include fee object for orders (optional) 

            try
            {
                // Get a list of orders
                ListOrdersResponse result = apiInstance.ListOrders(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, updatedMinTimestamp, updatedMaxTimestamp, buyTokenType, buyTokenId, buyAssetId, buyTokenAddress, buyTokenName, buyMinQuantity, buyMaxQuantity, buyMetadata, sellTokenType, sellTokenId, sellAssetId, sellTokenAddress, sellTokenName, sellMinQuantity, sellMaxQuantity, sellMetadata, auxiliaryFeePercentages, auxiliaryFeeRecipients, includeFees);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ListOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of orders
    ApiResponse<ListOrdersResponse> response = apiInstance.ListOrdersWithHttpInfo(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, updatedMinTimestamp, updatedMaxTimestamp, buyTokenType, buyTokenId, buyAssetId, buyTokenAddress, buyTokenName, buyMinQuantity, buyMaxQuantity, buyMetadata, sellTokenType, sellTokenId, sellAssetId, sellTokenAddress, sellTokenName, sellMinQuantity, sellMaxQuantity, sellMetadata, auxiliaryFeePercentages, auxiliaryFeeRecipients, includeFees);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersApi.ListOrdersWithHttpInfo: " + e.Message);
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
| **user** | **string** | Ethereum address of the user who submitted this order | [optional]  |
| **status** | **string** | Status of this order | [optional]  |
| **minTimestamp** | **string** | Minimum created at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **maxTimestamp** | **string** | Maximum created at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **updatedMinTimestamp** | **string** | Minimum updated at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **updatedMaxTimestamp** | **string** | Maximum updated at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **buyTokenType** | **string** | Token type of the asset this order buys | [optional]  |
| **buyTokenId** | **string** | ERC721 Token ID of the asset this order buys | [optional]  |
| **buyAssetId** | **string** | Internal IMX ID of the asset this order buys | [optional]  |
| **buyTokenAddress** | **string** | Token address of the asset this order buys | [optional]  |
| **buyTokenName** | **string** | Token name of the asset this order buys | [optional]  |
| **buyMinQuantity** | **string** | Min quantity for the asset this order buys | [optional]  |
| **buyMaxQuantity** | **string** | Max quantity for the asset this order buys | [optional]  |
| **buyMetadata** | **string** | JSON-encoded metadata filters for the asset this order buys | [optional]  |
| **sellTokenType** | **string** | Token type of the asset this order sells | [optional]  |
| **sellTokenId** | **string** | ERC721 Token ID of the asset this order sells | [optional]  |
| **sellAssetId** | **string** | Internal IMX ID of the asset this order sells | [optional]  |
| **sellTokenAddress** | **string** | Token address of the asset this order sells | [optional]  |
| **sellTokenName** | **string** | Token name of the asset this order sells | [optional]  |
| **sellMinQuantity** | **string** | Min quantity for the asset this order sells | [optional]  |
| **sellMaxQuantity** | **string** | Max quantity for the asset this order sells | [optional]  |
| **sellMetadata** | **string** | JSON-encoded metadata filters for the asset this order sells | [optional]  |
| **auxiliaryFeePercentages** | **string** | Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients | [optional]  |
| **auxiliaryFeeRecipients** | **string** | Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages | [optional]  |
| **includeFees** | **bool?** | Set flag to true to include fee object for orders | [optional]  |

### Return type

[**ListOrdersResponse**](ListOrdersResponse.md)

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

