# EdFi.OdsApi.Sdk.v54.Models.All.EdFiSurveyResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SurveyResponseIdentifier** | **string** | The identifier of the survey typically from the survey application. | 
**SurveyReference** | [**EdFiSurveyReference**](EdFiSurveyReference.md) |  | 
**ResponseDate** | **DateOnly** | Date of the survey response. | 
**Id** | **string** |  | [optional] 
**ParentReference** | [**EdFiParentReference**](EdFiParentReference.md) |  | [optional] 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | [optional] 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | [optional] 
**ElectronicMailAddress** | **string** | Email address of the respondent. | [optional] 
**FullName** | **string** | Full name of the respondent. | [optional] 
**Location** | **string** | Location of the respondent, often a city, district, or school. | [optional] 
**ResponseTime** | **int** | The amount of time (in seconds) it took for the respondent to complete the survey. | [optional] 
**SurveyLevels** | [**List&lt;EdFiSurveyResponseSurveyLevel&gt;**](EdFiSurveyResponseSurveyLevel.md) | An unordered collection of surveyResponseSurveyLevels. Provides information about the respondents of a survey and how they can be grouped together. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the SurveyResponse entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

