# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStudentCTEProgramAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**CtePrograms** | [**List&lt;EdFiStudentCTEProgramAssociationCTEProgram&gt;**](EdFiStudentCTEProgramAssociationCTEProgram.md) | An unordered collection of studentCTEProgramAssociationCTEPrograms. The career cluster representing the career path of the Vocational/Career Tech concentrator. | [optional] 
**CteProgramServices** | [**List&lt;EdFiStudentCTEProgramAssociationCTEProgramService&gt;**](EdFiStudentCTEProgramAssociationCTEProgramService.md) | An unordered collection of studentCTEProgramAssociationCTEProgramServices. Indicates the Service(s) being provided to the Student by the CTE Program. | [optional] 
**EndDate** | **DateOnly** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**NonTraditionalGenderStatus** | **bool** | Indicator that student is from a gender group that comprises less than 25% of the individuals employed in an occupation or field of work. | [optional] 
**ParticipationStatus** | [**EdFiGeneralStudentProgramAssociationParticipationStatus**](EdFiGeneralStudentProgramAssociationParticipationStatus.md) |  | [optional] 
**PrivateCTEProgram** | **bool** | Indicator that student participated in career and technical education at private agencies or institutions that are reported by the state for purposes of the Elementary and Secondary Education Act (ESEA).Students in private institutions which do not receive Perkins funding are reported only in the state file. | [optional] 
**ProgramParticipationStatuses** | [**List&lt;EdFiGeneralStudentProgramAssociationProgramParticipationStatus&gt;**](EdFiGeneralStudentProgramAssociationProgramParticipationStatus.md) | An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**Services** | [**List&lt;EdFiStudentCTEProgramAssociationService&gt;**](EdFiStudentCTEProgramAssociationService.md) | An unordered collection of studentCTEProgramAssociationServices. Indicates the Service(s) being provided to the Student by the Program. | [optional] 
**TechnicalSkillsAssessmentDescriptor** | **string** | Results of technical skills assessment aligned with industry recognized standards. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StudentCTEProgramAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

