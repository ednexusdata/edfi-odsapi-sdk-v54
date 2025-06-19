# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStudentTitleIPartAProgramAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**TitleIPartAParticipantDescriptor** | **string** | An indication of the type of Title I program, if any, in which the student is participating and by which the student is served:        Public Targeted Assistance Program        Public Schoolwide Program        Private School Students Participating        Local Neglected Program. | 
**Id** | **string** |  | [optional] 
**EndDate** | **DateOnly** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**ParticipationStatus** | [**EdFiGeneralStudentProgramAssociationParticipationStatus**](EdFiGeneralStudentProgramAssociationParticipationStatus.md) |  | [optional] 
**ProgramParticipationStatuses** | [**List&lt;EdFiGeneralStudentProgramAssociationProgramParticipationStatus&gt;**](EdFiGeneralStudentProgramAssociationProgramParticipationStatus.md) | An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**Services** | [**List&lt;EdFiStudentTitleIPartAProgramAssociationService&gt;**](EdFiStudentTitleIPartAProgramAssociationService.md) | An unordered collection of studentTitleIPartAProgramAssociationServices. Indicates the Service(s) being provided to the Student by the Program. | [optional] 
**TitleIPartAProgramServices** | [**List&lt;EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService&gt;**](EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService.md) | An unordered collection of studentTitleIPartAProgramAssociationTitleIPartAProgramServices. Indicates the service(s) being provided to the Student by the Title I Part A Program. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StudentTitleIPartAProgramAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

