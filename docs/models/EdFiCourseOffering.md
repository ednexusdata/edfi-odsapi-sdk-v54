# EdFi.OdsApi.Sdk.v54.Models.All.EdFiCourseOffering

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocalCourseCode** | **string** | The local code assigned by the School that identifies the course offering provided for the instruction of students. | 
**CourseReference** | [**EdFiCourseReference**](EdFiCourseReference.md) |  | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**SessionReference** | [**EdFiSessionReference**](EdFiSessionReference.md) |  | 
**Id** | **string** |  | [optional] 
**CourseLevelCharacteristics** | [**List&lt;EdFiCourseOfferingCourseLevelCharacteristic&gt;**](EdFiCourseOfferingCourseLevelCharacteristic.md) | An unordered collection of courseOfferingCourseLevelCharacteristics. The type of specific program or designation with which the course offering is associated (e.g., AP, IB, Dual Credit, CTE). This collection should only be populated if it differs from the Course Level Characteristics identified at the Course level. | [optional] 
**CurriculumUseds** | [**List&lt;EdFiCourseOfferingCurriculumUsed&gt;**](EdFiCourseOfferingCurriculumUsed.md) | An unordered collection of courseOfferingCurriculumUseds. The type of curriculum used in an early learning classroom or group. | [optional] 
**InstructionalTimePlanned** | **int** | The planned total number of clock minutes of instruction for this course offering. Generally, this should be at least as many minutes as is required for completion by the related state- or district-defined course. | [optional] 
**LocalCourseTitle** | **string** | The descriptive name given to a course of study offered in the school, if different from the CourseTitle. | [optional] 
**OfferedGradeLevels** | [**List&lt;EdFiCourseOfferingOfferedGradeLevel&gt;**](EdFiCourseOfferingOfferedGradeLevel.md) | An unordered collection of courseOfferingOfferedGradeLevels. The grade levels in which the course is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the Course level. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the CourseOffering entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

