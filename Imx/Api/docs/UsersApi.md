# api.Api.UsersApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSignableRegistration**](UsersApi.md#getsignableregistration) | **POST** /v1/signable-registration | Get operator signature to allow clients to register the user |
| [**GetSignableRegistrationOffchain**](UsersApi.md#getsignableregistrationoffchain) | **POST** /v1/signable-registration-offchain | Get encoded details to allow clients to register the user offchain |
| [**GetUsers**](UsersApi.md#getusers) | **GET** /v1/users/{user} | Get stark keys for a registered user |
| [**RegisterUser**](UsersApi.md#registeruser) | **POST** /v1/users | Registers a user |

<a name="getsignableregistration"></a>
# **GetSignableRegistration**
> GetSignableRegistrationResponse GetSignableRegistration (GetSignableRegistrationRequest getSignableRegistrationRequest)

Get operator signature to allow clients to register the user

Get operator signature to allow clients to register the user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetSignableRegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new UsersApi(config);
            var getSignableRegistrationRequest = new GetSignableRegistrationRequest(); // GetSignableRegistrationRequest | Register User

            try
            {
                // Get operator signature to allow clients to register the user
                GetSignableRegistrationResponse result = apiInstance.GetSignableRegistration(getSignableRegistrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetSignableRegistration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSignableRegistrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get operator signature to allow clients to register the user
    ApiResponse<GetSignableRegistrationResponse> response = apiInstance.GetSignableRegistrationWithHttpInfo(getSignableRegistrationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetSignableRegistrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSignableRegistrationRequest** | [**GetSignableRegistrationRequest**](GetSignableRegistrationRequest.md) | Register User |  |

### Return type

[**GetSignableRegistrationResponse**](GetSignableRegistrationResponse.md)

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

<a name="getsignableregistrationoffchain"></a>
# **GetSignableRegistrationOffchain**
> GetSignableRegistrationOffchainResponse GetSignableRegistrationOffchain (GetSignableRegistrationRequest getSignableRegistrationRequest)

Get encoded details to allow clients to register the user offchain

Get encoded details to allow clients to register the user offchain

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetSignableRegistrationOffchainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new UsersApi(config);
            var getSignableRegistrationRequest = new GetSignableRegistrationRequest(); // GetSignableRegistrationRequest | Register User Offchain

            try
            {
                // Get encoded details to allow clients to register the user offchain
                GetSignableRegistrationOffchainResponse result = apiInstance.GetSignableRegistrationOffchain(getSignableRegistrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetSignableRegistrationOffchain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSignableRegistrationOffchainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get encoded details to allow clients to register the user offchain
    ApiResponse<GetSignableRegistrationOffchainResponse> response = apiInstance.GetSignableRegistrationOffchainWithHttpInfo(getSignableRegistrationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetSignableRegistrationOffchainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getSignableRegistrationRequest** | [**GetSignableRegistrationRequest**](GetSignableRegistrationRequest.md) | Register User Offchain |  |

### Return type

[**GetSignableRegistrationOffchainResponse**](GetSignableRegistrationOffchainResponse.md)

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

<a name="getusers"></a>
# **GetUsers**
> GetUsersApiResponse GetUsers (string user)

Get stark keys for a registered user

Get stark keys for a registered user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class GetUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new UsersApi(config);
            var user = "user_example";  // string | User

            try
            {
                // Get stark keys for a registered user
                GetUsersApiResponse result = apiInstance.GetUsers(user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get stark keys for a registered user
    ApiResponse<GetUsersApiResponse> response = apiInstance.GetUsersWithHttpInfo(user);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **user** | **string** | User |  |

### Return type

[**GetUsersApiResponse**](GetUsersApiResponse.md)

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

<a name="registeruser"></a>
# **RegisterUser**
> RegisterUserResponse RegisterUser (RegisterUserRequest registerUserRequest)

Registers a user

Registers a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using api.Api;
using api.Client;
using api.Model;

namespace Example
{
    public class RegisterUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new UsersApi(config);
            var registerUserRequest = new RegisterUserRequest(); // RegisterUserRequest | Register User

            try
            {
                // Registers a user
                RegisterUserResponse result = apiInstance.RegisterUser(registerUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.RegisterUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Registers a user
    ApiResponse<RegisterUserResponse> response = apiInstance.RegisterUserWithHttpInfo(registerUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.RegisterUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerUserRequest** | [**RegisterUserRequest**](RegisterUserRequest.md) | Register User |  |

### Return type

[**RegisterUserResponse**](RegisterUserResponse.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

