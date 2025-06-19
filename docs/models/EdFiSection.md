# EdFi.OdsApi.Sdk.v54.Models.All.EdFiSection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SectionIdentifier** | **string** | The local identifier assigned to a section. | 
**CourseOfferingReference** | [**EdFiCourseOfferingReference**](EdFiCourseOfferingReference.md) |  | 
**Id** | **string** |  | [optional] 
**LocationReference** | [**EdFiLocationReference**](EdFiLocationReference.md) |  | [optional] 
**LocationSchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | [optional] 
**AvailableCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**AvailableCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**AvailableCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**Characteristics** | [**List&lt;EdFiSectionCharacteristic&gt;**](EdFiSectionCharacteristic.md) | An unordered collection of sectionCharacteristics. Reflects important characteristics of the Section, such as whether or not attendance is taken and the Section is graded. | [optional] 
**ClassPeriods** | [**List&lt;EdFiSectionClassPeriod&gt;**](EdFiSectionClassPeriod.md) | An unordered collection of sectionClassPeriods. The class period during which the Section meets. | [optional] 
**CourseLevelCharacteristics** | [**List&lt;EdFiSectionCourseLevelCharacteristic&gt;**](EdFiSectionCourseLevelCharacteristic.md) | An unordered collection of sectionCourseLevelCharacteristics. The type of specific program or designation with which the section is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course Offering level. | [optional] 
**EducationalEnvironmentDescriptor** | **string** | The setting in which a child receives education and related services; for example:        Center-based instruction        Home-based instruction        Hospital class        Mainstream        Residential care and treatment facility        ... | [optional] 
**InstructionLanguageDescriptor** | **string** | The primary language of instruction, if omitted English is assumed. | [optional] 
**MediumOfInstructionDescriptor** | **string** | The media through which teachers provide instruction to students and students and teachers communicate about instructional matters; for example:        Technology-based instruction in classroom        Correspondence instruction        Face-to-face instruction        Virtual/On-line Distance learning        Center-based instruction        ... | [optional] 
**OfferedGradeLevels** | [**List&lt;EdFiSectionOfferedGradeLevel&gt;**](EdFiSectionOfferedGradeLevel.md) | An unordered collection of sectionOfferedGradeLevels. The grade levels in which the section is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the Course Offering level. | [optional] 
**OfficialAttendancePeriod** | **bool** | Indicator of whether this section is used for official daily attendance. Alternatively, official daily attendance may be tied to a Class Period. | [optional] 
**PopulationServedDescriptor** | **string** | The type of students the Section is offered and tailored to; for example:        Bilingual students        Remedial education students        Gifted and talented students        Career and Technical Education students        Special education students        ... | [optional] 
**Programs** | [**List&lt;EdFiSectionProgram&gt;**](EdFiSectionProgram.md) | An unordered collection of sectionPrograms. Optional reference to program (e.g., CTE) to which the Section is associated. | [optional] 
**SectionName** | **string** | A locally-defined name for the section, generally created to make the section more recognizable in informal contexts and generally distinct from the SectionIdentifier. | [optional] 
**SequenceOfCourse** | **int** | When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the Section entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

