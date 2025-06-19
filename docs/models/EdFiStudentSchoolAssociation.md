# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStudentSchoolAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntryDate** | **DateOnly** | The month, day, and year on which an individual enters and begins to receive instructional services in a school. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EntryGradeLevelDescriptor** | **string** | The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session. | 
**Id** | **string** |  | [optional] 
**CalendarReference** | [**EdFiCalendarReference**](EdFiCalendarReference.md) |  | [optional] 
**ClassOfSchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | [optional] 
**GraduationPlanReference** | [**EdFiGraduationPlanReference**](EdFiGraduationPlanReference.md) |  | [optional] 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | [optional] 
**AlternativeGraduationPlans** | [**List&lt;EdFiStudentSchoolAssociationAlternativeGraduationPlan&gt;**](EdFiStudentSchoolAssociationAlternativeGraduationPlan.md) | An unordered collection of studentSchoolAssociationAlternativeGraduationPlans. The secondary graduation plan or plans associated with the student enrolled in the school. | [optional] 
**EducationPlans** | [**List&lt;EdFiStudentSchoolAssociationEducationPlan&gt;**](EdFiStudentSchoolAssociationEducationPlan.md) | An unordered collection of studentSchoolAssociationEducationPlans. The type of education plan(s) the student is following, if appropriate. | [optional] 
**EmployedWhileEnrolled** | **bool** | An individual who is a paid employee or works in his or her own business, profession, or farm and at the same time is enrolled in secondary, postsecondary, or adult education. | [optional] 
**EntryGradeLevelReasonDescriptor** | **string** | The primary reason as to why a staff member determined that a student should be promoted or not (or be demoted) at the end of a given school term. | [optional] 
**EntryTypeDescriptor** | **string** | The process by which a student enters a school during a given academic session. | [optional] 
**ExitWithdrawDate** | **DateOnly** | The recorded exit or withdraw date for the student. | [optional] 
**ExitWithdrawTypeDescriptor** | **string** | The circumstances under which the student exited from membership in an educational institution. | [optional] 
**FullTimeEquivalency** | **double** | The full-time equivalent ratio for the student s assignment to a school for services or instruction. For example, a full-time student would have an FTE value of 1 while a half-time student would have an FTE value of 0.5. | [optional] 
**PrimarySchool** | **bool** | Indicates if a given enrollment record should be considered the primary record for a student. | [optional] 
**RepeatGradeIndicator** | **bool** | An indicator of whether the student is enrolling to repeat a grade level, either by failure or an agreement to hold the student back. | [optional] 
**ResidencyStatusDescriptor** | **string** | An indication of the location of a persons legal residence relative to (within or outside of) the boundaries of the public school attended and its administrative unit. | [optional] 
**SchoolChoiceTransfer** | **bool** | An indication of whether students transferred in or out of the school did so during the school year under the provisions for public school choice in accordance with Title I, Part A, Section 1116. | [optional] 
**TermCompletionIndicator** | **bool** | Idicates whether or not a student completed the most recent school term. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StudentSchoolAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

