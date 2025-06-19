# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStudentMigrantEducationProgramAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginDate** | **DateOnly** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**LastQualifyingMove** | **DateOnly** | Date the last qualifying move occurred; used to compute MEP status. | 
**PriorityForServices** | **bool** | Report migratory children who are classified as having \&quot;priority for services\&quot; because they are failing, or most at risk of failing to meet the State&#39;s challenging State academic content standards and challenging State student academic achievement standards, and their education has been interrupted during the regular school year. | 
**Id** | **string** |  | [optional] 
**ContinuationOfServicesReasonDescriptor** | **string** | The \&quot;continuation of services\&quot; provision found in Section 1304(e) of the statute provides that (1) a child who ceases to be a migratory child during a school term shall be eligible for services until the end of such term; (2) a child who is no longer a migratory child may continue to receive services for one additional school year, but only if comparable services are not available through other programs; and (3) secondary school students who were eligible for services in secondary school may continue to be served through credit accrual programs until graduation. Only students who received services at any time during their 36 month eligibility period may continue to receive services (not necessarily the same service). | [optional] 
**EligibilityExpirationDate** | **DateOnly** | The Eligibility Expiration Date is used to determine end of eligibility and to account for a child&#39;s eligibility expiring earlier than 36 months from the child&#39;s QAD. A child&#39;s eligibility would end earlier than 36 months from the child&#39;s QAD, if the child is no longer entitled to a free public education (e.g., graduated with a high school diploma, obtained a high school equivalency diploma (HSED), or for other reasons as determined by States&#39; requirements), or if the child passes away. | [optional] 
**EndDate** | **DateOnly** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**MigrantEducationProgramServices** | [**List&lt;EdFiStudentMigrantEducationProgramAssociationMigrantEducationProgramService&gt;**](EdFiStudentMigrantEducationProgramAssociationMigrantEducationProgramService.md) | An unordered collection of studentMigrantEducationProgramAssociationMigrantEducationProgramServices. Indicates the Service(s) being provided to the Student by the Migrant Education Program. | [optional] 
**ParticipationStatus** | [**EdFiGeneralStudentProgramAssociationParticipationStatus**](EdFiGeneralStudentProgramAssociationParticipationStatus.md) |  | [optional] 
**ProgramParticipationStatuses** | [**List&lt;EdFiGeneralStudentProgramAssociationProgramParticipationStatus&gt;**](EdFiGeneralStudentProgramAssociationProgramParticipationStatus.md) | An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation. | [optional] 
**QualifyingArrivalDate** | **DateOnly** | The Qualifying Arrival Date (QAD) is the date the child joins the worker who has already moved, or the date when the worker joins the child who has already moved. The QAD is the date that the child&#39;s eligibility for the MEP begins. The QAD is not affected by subsequent non-qualifying moves. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**StateResidencyDate** | **DateOnly** | The verified State residency for the student. | [optional] 
**UsInitialEntry** | **DateOnly** | The month, day, and year on which the Student first entered the U.S. | [optional] 
**UsInitialSchoolEntry** | **DateOnly** | The month, day, and year on which the Student first entered a U.S. school. | [optional] 
**UsMostRecentEntry** | **DateOnly** | The month, day, and year of the Student&#39;s most recent entry into the U.S. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StudentMigrantEducationProgramAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

