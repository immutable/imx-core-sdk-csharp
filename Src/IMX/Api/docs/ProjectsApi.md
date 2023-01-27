# Imx.Sdk.Gen.Api.ProjectsApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateProject**](ProjectsApi.md#createproject) | **POST** /v1/projects | Create a project |
| [**GetProject**](ProjectsApi.md#getproject) | **GET** /v1/projects/{id} | Get a project |
| [**GetProjects**](ProjectsApi.md#getprojects) | **GET** /v1/projects | Get projects |

<a name="createproject"></a>
# **CreateProject**
> CreateProjectResponse CreateProject (string iMXSignature, string iMXTimestamp, CreateProjectRequest createProjectRequest)

Create a project

Create a project

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class CreateProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new ProjectsApi(config);
            var iMXSignature = "iMXSignature_example";  // string | String created by signing wallet address and timestamp
            var iMXTimestamp = "iMXTimestamp_example";  // string | Unix Epoc timestamp
            var createProjectRequest = new CreateProjectRequest(); // CreateProjectRequest | create a project

            try
            {
                // Create a project
                CreateProjectResponse result = apiInstance.CreateProject(iMXSignature, iMXTimestamp, createProjectRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.CreateProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a project
    ApiResponse<CreateProjectResponse> response = apiInstance.CreateProjectWithHttpInfo(iMXSignature, iMXTimestamp, createProjectRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.CreateProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMXSignature** | **string** | String created by signing wallet address and timestamp |  |
| **iMXTimestamp** | **string** | Unix Epoc timestamp |  |
| **createProjectRequest** | [**CreateProjectRequest**](CreateProjectRequest.md) | create a project |  |

### Return type

[**CreateProjectResponse**](CreateProjectResponse.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproject"></a>
# **GetProject**
> Project GetProject (string id, string iMXSignature, string iMXTimestamp)

Get a project

Get a project

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new ProjectsApi(config);
            var id = "id_example";  // string | Project ID
            var iMXSignature = "iMXSignature_example";  // string | String created by signing wallet address and timestamp
            var iMXTimestamp = "iMXTimestamp_example";  // string | Unix Epoc timestamp

            try
            {
                // Get a project
                Project result = apiInstance.GetProject(id, iMXSignature, iMXTimestamp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a project
    ApiResponse<Project> response = apiInstance.GetProjectWithHttpInfo(id, iMXSignature, iMXTimestamp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.GetProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project ID |  |
| **iMXSignature** | **string** | String created by signing wallet address and timestamp |  |
| **iMXTimestamp** | **string** | Unix Epoc timestamp |  |

### Return type

[**Project**](Project.md)

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojects"></a>
# **GetProjects**
> GetProjectsResponse GetProjects (string iMXSignature, string iMXTimestamp, int? pageSize = null, string cursor = null, string orderBy = null, string direction = null)

Get projects

Get projects

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetProjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new ProjectsApi(config);
            var iMXSignature = "iMXSignature_example";  // string | String created by signing wallet address and timestamp
            var iMXTimestamp = "iMXTimestamp_example";  // string | Unix Epoc timestamp
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "orderBy_example";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 

            try
            {
                // Get projects
                GetProjectsResponse result = apiInstance.GetProjects(iMXSignature, iMXTimestamp, pageSize, cursor, orderBy, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetProjects: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProjectsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get projects
    ApiResponse<GetProjectsResponse> response = apiInstance.GetProjectsWithHttpInfo(iMXSignature, iMXTimestamp, pageSize, cursor, orderBy, direction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.GetProjectsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMXSignature** | **string** | String created by signing wallet address and timestamp |  |
| **iMXTimestamp** | **string** | Unix Epoc timestamp |  |
| **pageSize** | **int?** | Page size of the result | [optional]  |
| **cursor** | **string** | Cursor | [optional]  |
| **orderBy** | **string** | Property to sort by | [optional]  |
| **direction** | **string** | Direction to sort (asc/desc) | [optional]  |

### Return type

[**GetProjectsResponse**](GetProjectsResponse.md)

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

