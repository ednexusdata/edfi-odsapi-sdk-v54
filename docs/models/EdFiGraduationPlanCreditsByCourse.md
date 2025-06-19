# EdFi.OdsApi.Sdk.v54.Models.All.EdFiGraduationPlanCreditsByCourse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CourseSetName** | **string** | Identifying name given to a collection of courses. | 
**Credits** | **double** | The value of credits or units of value awarded for the completion of a course. | 
**Courses** | [**List&lt;EdFiGraduationPlanCreditsByCourseCourse&gt;**](EdFiGraduationPlanCreditsByCourseCourse.md) | An unordered collection of graduationPlanCreditsByCourseCourses. The course reference that identifies the organization of subject matter and related learning experiences provided for the instruction of students. | 
**CreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**WhenTakenGradeLevelDescriptor** | **string** | The grade level when the student is planned to take the course. | [optional] 
**CreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**Ext** | **Object** | Extensions to the GraduationPlanCreditsByCourse entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

