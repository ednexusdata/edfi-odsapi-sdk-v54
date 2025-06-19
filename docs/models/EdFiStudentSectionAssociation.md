# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStudentSectionAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | Month, day, and year of the Student&#39;s entry or assignment to the Section. | 
**SectionReference** | [**EdFiSectionReference**](EdFiSectionReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**AttemptStatusDescriptor** | **string** | An indication of the student&#39;s completion status for the section. | [optional] 
**EndDate** | **DateOnly** | Month, day, and year of the withdrawal or exit of the Student from the Section. | [optional] 
**HomeroomIndicator** | **bool** | Indicates the Section is the student&#39;s homeroom. Homeroom period may the convention for taking daily attendance. | [optional] 
**RepeatIdentifierDescriptor** | **string** | An indication as to whether a student has previously taken a given course.        Repeated, counted in grade point average        Repeated, not counted in grade point average        Not repeated        Other. | [optional] 
**TeacherStudentDataLinkExclusion** | **bool** | Indicates that the student-section combination is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StudentSectionAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

