# EdFi.OdsApi.Sdk.v54.Models.All.EdFiGraduationPlan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GraduationPlanTypeDescriptor** | **string** | The type of academic plan the student is following for graduation: for example, Minimum, Recommended, Distinguished, or Standard. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**GraduationSchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | 
**TotalRequiredCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | 
**Id** | **string** |  | [optional] 
**CreditsByCourses** | [**List&lt;EdFiGraduationPlanCreditsByCourse&gt;**](EdFiGraduationPlanCreditsByCourse.md) | An unordered collection of graduationPlanCreditsByCourses. The total credits required for graduation by taking a specific course, or by taking one or more from a set of courses. | [optional] 
**CreditsByCreditCategories** | [**List&lt;EdFiGraduationPlanCreditsByCreditCategory&gt;**](EdFiGraduationPlanCreditsByCreditCategory.md) | An unordered collection of graduationPlanCreditsByCreditCategories. The total credits required for graduation based on the credit category. | [optional] 
**CreditsBySubjects** | [**List&lt;EdFiGraduationPlanCreditsBySubject&gt;**](EdFiGraduationPlanCreditsBySubject.md) | An unordered collection of graduationPlanCreditsBySubjects. The total credits required in subject to graduate. Only those courses identified as a high school course requirement are eligible to meet subject credit requirements. | [optional] 
**IndividualPlan** | **bool** | An indicator of whether the GraduationPlan is tailored for an individual. | [optional] 
**RequiredAssessments** | [**List&lt;EdFiGraduationPlanRequiredAssessment&gt;**](EdFiGraduationPlanRequiredAssessment.md) | An unordered collection of graduationPlanRequiredAssessments. The assessments and associated required score and performance level needed to satisfy graduation requirements. | [optional] 
**TotalRequiredCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**TotalRequiredCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the GraduationPlan entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

