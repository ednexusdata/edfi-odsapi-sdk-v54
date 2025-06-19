# EdFi.OdsApi.Sdk.v54.Models.All.EdFiRestraintEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RestraintEventIdentifier** | **string** | A unique number or alphanumeric code assigned to a restraint event by a school, school system, state, or other agency or entity. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EventDate** | **DateOnly** | Month, day, and year of the RestraintEvent. | 
**Id** | **string** |  | [optional] 
**EducationalEnvironmentDescriptor** | **string** | The setting where the RestraintEvent was exercised. | [optional] 
**Programs** | [**List&lt;EdFiRestraintEventProgram&gt;**](EdFiRestraintEventProgram.md) | An unordered collection of restraintEventPrograms. The special education program associated with the RestraintEvent. | [optional] 
**Reasons** | [**List&lt;EdFiRestraintEventReason&gt;**](EdFiRestraintEventReason.md) | An unordered collection of restraintEventReasons. A categorization of the circumstances or reason for the RestraintEvent. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the RestraintEvent entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

