# EdFi.OdsApi.Sdk.v54.Apis.All.StudentSectionAttendanceEventsApi

All URIs are relative to *https://api.ed-fi.org:443/v5.4/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStudentSectionAttendanceEventById**](StudentSectionAttendanceEventsApi.md#deletestudentsectionattendanceeventbyid) | **DELETE** /ed-fi/studentSectionAttendanceEvents/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStudentSectionAttendanceEvents**](StudentSectionAttendanceEventsApi.md#deletesstudentsectionattendanceevents) | **GET** /ed-fi/studentSectionAttendanceEvents/deletes | Retrieves deleted resources based on change version. |
| [**GetStudentSectionAttendanceEvents**](StudentSectionAttendanceEventsApi.md#getstudentsectionattendanceevents) | **GET** /ed-fi/studentSectionAttendanceEvents | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentSectionAttendanceEventsById**](StudentSectionAttendanceEventsApi.md#getstudentsectionattendanceeventsbyid) | **GET** /ed-fi/studentSectionAttendanceEvents/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**PostStudentSectionAttendanceEvent**](StudentSectionAttendanceEventsApi.md#poststudentsectionattendanceevent) | **POST** /ed-fi/studentSectionAttendanceEvents | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStudentSectionAttendanceEvent**](StudentSectionAttendanceEventsApi.md#putstudentsectionattendanceevent) | **PUT** /ed-fi/studentSectionAttendanceEvents/{id} | Updates a resource based on the resource identifier. |

<a id="deletestudentsectionattendanceeventbyid"></a>
# **DeleteStudentSectionAttendanceEventById**
> void DeleteStudentSectionAttendanceEventById (string id, string ifMatch = null)

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
    public class DeleteStudentSectionAttendanceEventByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAttendanceEventsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentSectionAttendanceEventById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.DeleteStudentSectionAttendanceEventById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStudentSectionAttendanceEventByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStudentSectionAttendanceEventByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.DeleteStudentSectionAttendanceEventByIdWithHttpInfo: " + e.Message);
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

<a id="deletesstudentsectionattendanceevents"></a>
# **DeletesStudentSectionAttendanceEvents**
> List&lt;DeletedResource&gt; DeletesStudentSectionAttendanceEvents (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesStudentSectionAttendanceEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAttendanceEventsApi(config);
            var offset = 0;  // int | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List<DeletedResource> result = apiInstance.DeletesStudentSectionAttendanceEvents(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.DeletesStudentSectionAttendanceEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentSectionAttendanceEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<DeletedResource>> response = apiInstance.DeletesStudentSectionAttendanceEventsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.DeletesStudentSectionAttendanceEventsWithHttpInfo: " + e.Message);
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

<a id="getstudentsectionattendanceevents"></a>
# **GetStudentSectionAttendanceEvents**
> List&lt;EdFiStudentSectionAttendanceEvent&gt; GetStudentSectionAttendanceEvents (int offset = null, int limit = null, long minChangeVersion = null, long maxChangeVersion = null, bool totalCount = null, string attendanceEventCategoryDescriptor = null, DateOnly eventDate = null, string localCourseCode = null, int schoolId = null, int schoolYear = null, string sectionIdentifier = null, string sessionName = null, string studentUniqueId = null, string educationalEnvironmentDescriptor = null, string arrivalTime = null, string attendanceEventReason = null, string departureTime = null, double eventDuration = null, string id = null, int sectionAttendanceDuration = null, string snapshotIdentifier = null)

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
    public class GetStudentSectionAttendanceEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAttendanceEventsApi(config);
            var offset = 0;  // int | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var attendanceEventCategoryDescriptor = "attendanceEventCategoryDescriptor_example";  // string | A code describing the attendance event, for example:        Present        Unexcused absence        Excused absence        Tardy. (optional) 
            var eventDate = DateOnly.Parse("2013-10-20");  // DateOnly | Date for this attendance event. (optional) 
            var localCourseCode = "localCourseCode_example";  // string | The local code assigned by the School that identifies the course offering provided for the instruction of students. (optional) 
            var schoolId = 56;  // int | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int | The identifier for the school year. (optional) 
            var sectionIdentifier = "sectionIdentifier_example";  // string | The local identifier assigned to a section. (optional) 
            var sessionName = "sessionName_example";  // string | The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string | A unique alphanumeric code assigned to a student. (optional) 
            var educationalEnvironmentDescriptor = "educationalEnvironmentDescriptor_example";  // string | The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section. (optional) 
            var arrivalTime = "arrivalTime_example";  // string | The time of day the student arrived for the attendance event in ISO 8601 format. (optional) 
            var attendanceEventReason = "attendanceEventReason_example";  // string | The reported reason for a student's absence. (optional) 
            var departureTime = "departureTime_example";  // string | The time of day the student departed for the attendance event in ISO 8601 format. (optional) 
            var eventDuration = 1.2D;  // double | The amount of time for the event as recognized by the school: 1 day = 1, 1/2 day = 0.5, 1/3 day = 0.33. (optional) 
            var id = "id_example";  // string |  (optional) 
            var sectionAttendanceDuration = 56;  // int | The duration in minutes of the section attendance event. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStudentSectionAttendanceEvent> result = apiInstance.GetStudentSectionAttendanceEvents(offset, limit, minChangeVersion, maxChangeVersion, totalCount, attendanceEventCategoryDescriptor, eventDate, localCourseCode, schoolId, schoolYear, sectionIdentifier, sessionName, studentUniqueId, educationalEnvironmentDescriptor, arrivalTime, attendanceEventReason, departureTime, eventDuration, id, sectionAttendanceDuration, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.GetStudentSectionAttendanceEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSectionAttendanceEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStudentSectionAttendanceEvent>> response = apiInstance.GetStudentSectionAttendanceEventsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, attendanceEventCategoryDescriptor, eventDate, localCourseCode, schoolId, schoolYear, sectionIdentifier, sessionName, studentUniqueId, educationalEnvironmentDescriptor, arrivalTime, attendanceEventReason, departureTime, eventDuration, id, sectionAttendanceDuration, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.GetStudentSectionAttendanceEventsWithHttpInfo: " + e.Message);
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
| **attendanceEventCategoryDescriptor** | **string** | A code describing the attendance event, for example:        Present        Unexcused absence        Excused absence        Tardy. | [optional]  |
| **eventDate** | **DateOnly** | Date for this attendance event. | [optional]  |
| **localCourseCode** | **string** | The local code assigned by the School that identifies the course offering provided for the instruction of students. | [optional]  |
| **schoolId** | **int** | The identifier assigned to a school. | [optional]  |
| **schoolYear** | **int** | The identifier for the school year. | [optional]  |
| **sectionIdentifier** | **string** | The local identifier assigned to a section. | [optional]  |
| **sessionName** | **string** | The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). | [optional]  |
| **studentUniqueId** | **string** | A unique alphanumeric code assigned to a student. | [optional]  |
| **educationalEnvironmentDescriptor** | **string** | The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section. | [optional]  |
| **arrivalTime** | **string** | The time of day the student arrived for the attendance event in ISO 8601 format. | [optional]  |
| **attendanceEventReason** | **string** | The reported reason for a student&#39;s absence. | [optional]  |
| **departureTime** | **string** | The time of day the student departed for the attendance event in ISO 8601 format. | [optional]  |
| **eventDuration** | **double** | The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33. | [optional]  |
| **id** | **string** |  | [optional]  |
| **sectionAttendanceDuration** | **int** | The duration in minutes of the section attendance event. | [optional]  |
| **snapshotIdentifier** | **string** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;EdFiStudentSectionAttendanceEvent&gt;**](EdFiStudentSectionAttendanceEvent.md)

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

<a id="getstudentsectionattendanceeventsbyid"></a>
# **GetStudentSectionAttendanceEventsById**
> EdFiStudentSectionAttendanceEvent GetStudentSectionAttendanceEventsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetStudentSectionAttendanceEventsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAttendanceEventsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentSectionAttendanceEvent result = apiInstance.GetStudentSectionAttendanceEventsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.GetStudentSectionAttendanceEventsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentSectionAttendanceEventsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStudentSectionAttendanceEvent> response = apiInstance.GetStudentSectionAttendanceEventsByIdWithHttpInfo(id, ifNoneMatch, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.GetStudentSectionAttendanceEventsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStudentSectionAttendanceEvent**](EdFiStudentSectionAttendanceEvent.md)

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

<a id="poststudentsectionattendanceevent"></a>
# **PostStudentSectionAttendanceEvent**
> void PostStudentSectionAttendanceEvent (EdFiStudentSectionAttendanceEvent studentSectionAttendanceEvent)

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
    public class PostStudentSectionAttendanceEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAttendanceEventsApi(config);
            var studentSectionAttendanceEvent = new EdFiStudentSectionAttendanceEvent(); // EdFiStudentSectionAttendanceEvent | The JSON representation of the \"studentSectionAttendanceEvent\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentSectionAttendanceEvent(studentSectionAttendanceEvent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.PostStudentSectionAttendanceEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStudentSectionAttendanceEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStudentSectionAttendanceEventWithHttpInfo(studentSectionAttendanceEvent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.PostStudentSectionAttendanceEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **studentSectionAttendanceEvent** | [**EdFiStudentSectionAttendanceEvent**](EdFiStudentSectionAttendanceEvent.md) | The JSON representation of the \&quot;studentSectionAttendanceEvent\&quot; resource to be created or updated. |  |

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

<a id="putstudentsectionattendanceevent"></a>
# **PutStudentSectionAttendanceEvent**
> void PutStudentSectionAttendanceEvent (string id, EdFiStudentSectionAttendanceEvent studentSectionAttendanceEvent, string ifMatch = null)

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
    public class PutStudentSectionAttendanceEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v5.4/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAttendanceEventsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var studentSectionAttendanceEvent = new EdFiStudentSectionAttendanceEvent(); // EdFiStudentSectionAttendanceEvent | The JSON representation of the \"studentSectionAttendanceEvent\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentSectionAttendanceEvent(id, studentSectionAttendanceEvent, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.PutStudentSectionAttendanceEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStudentSectionAttendanceEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStudentSectionAttendanceEventWithHttpInfo(id, studentSectionAttendanceEvent, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentSectionAttendanceEventsApi.PutStudentSectionAttendanceEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **studentSectionAttendanceEvent** | [**EdFiStudentSectionAttendanceEvent**](EdFiStudentSectionAttendanceEvent.md) | The JSON representation of the \&quot;studentSectionAttendanceEvent\&quot; resource to be created or updated. |  |
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

