# EdFi.OdsApi.Sdk.v54.Apis.All.SurveySectionResponseEducationOrganizationTargetAssociationsApi

All URIs are relative to *https://api.ed-fi.org:443/v5.4/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteSurveySectionResponseEducationOrganizationTargetAssociationById**](SurveySectionResponseEducationOrganizationTargetAssociationsApi.md#deletesurveysectionresponseeducationorganizationtargetassociationbyid) | **DELETE** /ed-fi/surveySectionResponseEducationOrganizationTargetAssociations/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesSurveySectionResponseEducationOrganizationTargetAssociations**](SurveySectionResponseEducationOrganizationTargetAssociationsApi.md#deletessurveysectionresponseeducationorganizationtargetassociations) | **GET** /ed-fi/surveySectionResponseEducationOrganizationTargetAssociations/deletes | Retrieves deleted resources based on change version. |
| [**GetSurveySectionResponseEducationOrganizationTargetAssociations**](SurveySectionResponseEducationOrganizationTargetAssociationsApi.md#getsurveysectionresponseeducationorganizationtargetassociations) | **GET** /ed-fi/surveySectionResponseEducationOrganizationTargetAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetSurveySectionResponseEducationOrganizationTargetAssociationsById**](SurveySectionResponseEducationOrganizationTargetAssociationsApi.md#getsurveysectionresponseeducationorganizationtargetassociationsbyid) | **GET** /ed-fi/surveySectionResponseEducationOrganizationTargetAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**PostSurveySectionResponseEducationOrganizationTargetAssociation**](SurveySectionResponseEducationOrganizationTargetAssociationsApi.md#postsurveysectionresponseeducationorganizationtargetassociation) | **POST** /ed-fi/surveySectionResponseEducationOrganizationTargetAssociations | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutSurveySectionResponseEducationOrganizationTargetAssociation**](SurveySectionResponseEducationOrganizationTargetAssociationsApi.md#putsurveysectionresponseeducationorganizationtargetassociation) | **PUT** /ed-fi/surveySectionResponseEducationOrganizationTargetAssociations/{id} | Updates a resource based on the resource identifier. |

<a id="deletesurveysectionresponseeducationorganizationtargetassociationbyid"></a>
# **DeleteSurveySectionResponseEducationOrganizationTargetAssociationById**
> void DeleteSurveySectionResponseEducationOrganizationTargetAssociationById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v54.Apis.All;
using EdFi.OdsApi.Sdk.v54.Client;
using EdFi.OdsApi.Sdk.v54.Models.All;

namespace Example
{
    public class DeleteSurveySectionResponseEducationOrganizationTargetAssociationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveySectionResponseEducationOrganizationTargetAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteSurveySectionResponseEducationOrganizationTargetAssociationById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.DeleteSurveySectionResponseEducationOrganizationTargetAssociationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSurveySectionResponseEducationOrganizationTargetAssociationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteSurveySectionResponseEducationOrganizationTargetAssociationByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.DeleteSurveySectionResponseEducationOrganizationTargetAssociationByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifMatch** | **string** | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was successfully deleted. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **405** | Method Is Not Allowed. When the Snapshot-Identifier header is present the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletessurveysectionresponseeducationorganizationtargetassociations"></a>
# **DeletesSurveySectionResponseEducationOrganizationTargetAssociations**
> List&lt;DeletedResource&gt; DeletesSurveySectionResponseEducationOrganizationTargetAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, string snapshotIdentifier = null)

Retrieves deleted resources based on change version.

The DELETES operation is used to retrieve deleted resources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v54.Apis.All;
using EdFi.OdsApi.Sdk.v54.Client;
using EdFi.OdsApi.Sdk.v54.Models.All;

namespace Example
{
    public class DeletesSurveySectionResponseEducationOrganizationTargetAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveySectionResponseEducationOrganizationTargetAssociationsApi(config);
            var offset = 0;  // int | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List<DeletedResource> result = apiInstance.DeletesSurveySectionResponseEducationOrganizationTargetAssociations(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.DeletesSurveySectionResponseEducationOrganizationTargetAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesSurveySectionResponseEducationOrganizationTargetAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<DeletedResource>> response = apiInstance.DeletesSurveySectionResponseEducationOrganizationTargetAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.DeletesSurveySectionResponseEducationOrganizationTargetAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **snapshotIdentifier** | **string** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;DeletedResource&gt;**](DeletedResource.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsurveysectionresponseeducationorganizationtargetassociations"></a>
# **GetSurveySectionResponseEducationOrganizationTargetAssociations**
> List&lt;EdFiSurveySectionResponseEducationOrganizationTargetAssociation&gt; GetSurveySectionResponseEducationOrganizationTargetAssociations (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, int educationOrganizationId = null, string varNamespace = null, string surveyIdentifier = null, string surveyResponseIdentifier = null, string surveySectionTitle = null, string id = null, string snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v54.Apis.All;
using EdFi.OdsApi.Sdk.v54.Client;
using EdFi.OdsApi.Sdk.v54.Models.All;

namespace Example
{
    public class GetSurveySectionResponseEducationOrganizationTargetAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveySectionResponseEducationOrganizationTargetAssociationsApi(config);
            var offset = 0;  // int | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var educationOrganizationId = 56;  // int | The identifier assigned to an education organization. (optional) 
            var varNamespace = "varNamespace_example";  // string | Namespace for the Survey. (optional) 
            var surveyIdentifier = "surveyIdentifier_example";  // string | The unique survey identifier from the survey tool. (optional) 
            var surveyResponseIdentifier = "surveyResponseIdentifier_example";  // string | The identifier of the survey typically from the survey application. (optional) 
            var surveySectionTitle = "surveySectionTitle_example";  // string | The title or label for the survey section. (optional) 
            var id = "id_example";  // string |  (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiSurveySectionResponseEducationOrganizationTargetAssociation> result = apiInstance.GetSurveySectionResponseEducationOrganizationTargetAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, educationOrganizationId, varNamespace, surveyIdentifier, surveyResponseIdentifier, surveySectionTitle, id, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.GetSurveySectionResponseEducationOrganizationTargetAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSurveySectionResponseEducationOrganizationTargetAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiSurveySectionResponseEducationOrganizationTargetAssociation>> response = apiInstance.GetSurveySectionResponseEducationOrganizationTargetAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, educationOrganizationId, varNamespace, surveyIdentifier, surveyResponseIdentifier, surveySectionTitle, id, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.GetSurveySectionResponseEducationOrganizationTargetAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **educationOrganizationId** | **int** | The identifier assigned to an education organization. | [optional]  |
| **varNamespace** | **string** | Namespace for the Survey. | [optional]  |
| **surveyIdentifier** | **string** | The unique survey identifier from the survey tool. | [optional]  |
| **surveyResponseIdentifier** | **string** | The identifier of the survey typically from the survey application. | [optional]  |
| **surveySectionTitle** | **string** | The title or label for the survey section. | [optional]  |
| **id** | **string** |  | [optional]  |
| **snapshotIdentifier** | **string** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;EdFiSurveySectionResponseEducationOrganizationTargetAssociation&gt;**](EdFiSurveySectionResponseEducationOrganizationTargetAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsurveysectionresponseeducationorganizationtargetassociationsbyid"></a>
# **GetSurveySectionResponseEducationOrganizationTargetAssociationsById**
> EdFiSurveySectionResponseEducationOrganizationTargetAssociation GetSurveySectionResponseEducationOrganizationTargetAssociationsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v54.Apis.All;
using EdFi.OdsApi.Sdk.v54.Client;
using EdFi.OdsApi.Sdk.v54.Models.All;

namespace Example
{
    public class GetSurveySectionResponseEducationOrganizationTargetAssociationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveySectionResponseEducationOrganizationTargetAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiSurveySectionResponseEducationOrganizationTargetAssociation result = apiInstance.GetSurveySectionResponseEducationOrganizationTargetAssociationsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.GetSurveySectionResponseEducationOrganizationTargetAssociationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSurveySectionResponseEducationOrganizationTargetAssociationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiSurveySectionResponseEducationOrganizationTargetAssociation> response = apiInstance.GetSurveySectionResponseEducationOrganizationTargetAssociationsByIdWithHttpInfo(id, ifNoneMatch, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.GetSurveySectionResponseEducationOrganizationTargetAssociationsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifNoneMatch** | **string** | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. | [optional]  |
| **snapshotIdentifier** | **string** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**EdFiSurveySectionResponseEducationOrganizationTargetAssociation**](EdFiSurveySectionResponseEducationOrganizationTargetAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postsurveysectionresponseeducationorganizationtargetassociation"></a>
# **PostSurveySectionResponseEducationOrganizationTargetAssociation**
> void PostSurveySectionResponseEducationOrganizationTargetAssociation (EdFiSurveySectionResponseEducationOrganizationTargetAssociation surveySectionResponseEducationOrganizationTargetAssociation)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v54.Apis.All;
using EdFi.OdsApi.Sdk.v54.Client;
using EdFi.OdsApi.Sdk.v54.Models.All;

namespace Example
{
    public class PostSurveySectionResponseEducationOrganizationTargetAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveySectionResponseEducationOrganizationTargetAssociationsApi(config);
            var surveySectionResponseEducationOrganizationTargetAssociation = new EdFiSurveySectionResponseEducationOrganizationTargetAssociation(); // EdFiSurveySectionResponseEducationOrganizationTargetAssociation | The JSON representation of the \"surveySectionResponseEducationOrganizationTargetAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostSurveySectionResponseEducationOrganizationTargetAssociation(surveySectionResponseEducationOrganizationTargetAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.PostSurveySectionResponseEducationOrganizationTargetAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSurveySectionResponseEducationOrganizationTargetAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostSurveySectionResponseEducationOrganizationTargetAssociationWithHttpInfo(surveySectionResponseEducationOrganizationTargetAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.PostSurveySectionResponseEducationOrganizationTargetAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **surveySectionResponseEducationOrganizationTargetAssociation** | [**EdFiSurveySectionResponseEducationOrganizationTargetAssociation**](EdFiSurveySectionResponseEducationOrganizationTargetAssociation.md) | The JSON representation of the \&quot;surveySectionResponseEducationOrganizationTargetAssociation\&quot; resource to be created or updated. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The resource was updated.  An updated ETag value is available in the ETag header of the response. |  -  |
| **201** | The resource was created.  An ETag value is available in the ETag header, and the location of the resource is available in the Location header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **405** | Method Is Not Allowed. When the Snapshot-Identifier header is present the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putsurveysectionresponseeducationorganizationtargetassociation"></a>
# **PutSurveySectionResponseEducationOrganizationTargetAssociation**
> void PutSurveySectionResponseEducationOrganizationTargetAssociation (string id, EdFiSurveySectionResponseEducationOrganizationTargetAssociation surveySectionResponseEducationOrganizationTargetAssociation, string ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v54.Apis.All;
using EdFi.OdsApi.Sdk.v54.Client;
using EdFi.OdsApi.Sdk.v54.Models.All;

namespace Example
{
    public class PutSurveySectionResponseEducationOrganizationTargetAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveySectionResponseEducationOrganizationTargetAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var surveySectionResponseEducationOrganizationTargetAssociation = new EdFiSurveySectionResponseEducationOrganizationTargetAssociation(); // EdFiSurveySectionResponseEducationOrganizationTargetAssociation | The JSON representation of the \"surveySectionResponseEducationOrganizationTargetAssociation\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutSurveySectionResponseEducationOrganizationTargetAssociation(id, surveySectionResponseEducationOrganizationTargetAssociation, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.PutSurveySectionResponseEducationOrganizationTargetAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutSurveySectionResponseEducationOrganizationTargetAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutSurveySectionResponseEducationOrganizationTargetAssociationWithHttpInfo(id, surveySectionResponseEducationOrganizationTargetAssociation, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveySectionResponseEducationOrganizationTargetAssociationsApi.PutSurveySectionResponseEducationOrganizationTargetAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **surveySectionResponseEducationOrganizationTargetAssociation** | [**EdFiSurveySectionResponseEducationOrganizationTargetAssociation**](EdFiSurveySectionResponseEducationOrganizationTargetAssociation.md) | The JSON representation of the \&quot;surveySectionResponseEducationOrganizationTargetAssociation\&quot; resource to be created or updated. |  |
| **ifMatch** | **string** | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was updated.  An updated ETag value is available in the ETag header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **405** | Method Is Not Allowed. When the Snapshot-Identifier header is present the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

