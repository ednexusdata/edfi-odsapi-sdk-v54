# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStaffSchoolAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramAssignmentDescriptor** | **string** | The name of the program for which the individual is assigned; for example:        Regular education        Title I-Academic        Title I-Non-Academic        Special Education        Bilingual/English as a Second Language. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**Id** | **string** |  | [optional] 
**CalendarReference** | [**EdFiCalendarReference**](EdFiCalendarReference.md) |  | [optional] 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | [optional] 
**AcademicSubjects** | [**List&lt;EdFiStaffSchoolAssociationAcademicSubject&gt;**](EdFiStaffSchoolAssociationAcademicSubject.md) | An unordered collection of staffSchoolAssociationAcademicSubjects. The academic subjects the individual is eligible to teach. | [optional] 
**GradeLevels** | [**List&lt;EdFiStaffSchoolAssociationGradeLevel&gt;**](EdFiStaffSchoolAssociationGradeLevel.md) | An unordered collection of staffSchoolAssociationGradeLevels. The grade levels the individual is eligible to teach. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StaffSchoolAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

