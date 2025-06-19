# EdFi.OdsApi.Sdk.v54.Models.All.EdFiCourse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CourseCode** | **string** | A unique alphanumeric code assigned to a course. | 
**IdentificationCodes** | [**List&lt;EdFiCourseIdentificationCode&gt;**](EdFiCourseIdentificationCode.md) | An unordered collection of courseIdentificationCodes. The code that identifies the organization of subject matter and related learning experiences provided for the instruction of students. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**CourseTitle** | **string** | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts). | 
**NumberOfParts** | **int** | The number of parts identified for a course. | 
**Id** | **string** |  | [optional] 
**AcademicSubjectDescriptor** | **string** | The intended major subject area of the course. | [optional] 
**CareerPathwayDescriptor** | **string** | Indicates the career cluster or pathway the course is associated with as part of a CTE curriculum. | [optional] 
**CompetencyLevels** | [**List&lt;EdFiCourseCompetencyLevel&gt;**](EdFiCourseCompetencyLevel.md) | An unordered collection of courseCompetencyLevels. The competency levels defined to rate the student for the course. | [optional] 
**CourseDefinedByDescriptor** | **string** | Specifies whether the course was defined by the SEA, LEA, School, or national organization. | [optional] 
**CourseDescription** | **string** | A description of the content standards and goals covered in the course. Reference may be made to state or national content standards. | [optional] 
**CourseGPAApplicabilityDescriptor** | **string** | An indicator of whether or not the course being described is included in the computation of the student&#39;s Grade Point Average, and if so, if it is weighted differently from regular courses. | [optional] 
**DateCourseAdopted** | **DateOnly** | Date the course was adopted by the education agency. | [optional] 
**HighSchoolCourseRequirement** | **bool** | An indication that this course may satisfy high school graduation requirements in the course&#39;s subject area. | [optional] 
**LearningObjectives** | [**List&lt;EdFiCourseLearningObjective&gt;**](EdFiCourseLearningObjective.md) | An unordered collection of courseLearningObjectives. Learning Objectives to be mastered in the course. | [optional] 
**LearningStandards** | [**List&lt;EdFiCourseLearningStandard&gt;**](EdFiCourseLearningStandard.md) | An unordered collection of courseLearningStandards. Learning Standard(s) to be taught by the course. | [optional] 
**LevelCharacteristics** | [**List&lt;EdFiCourseLevelCharacteristic&gt;**](EdFiCourseLevelCharacteristic.md) | An unordered collection of courseLevelCharacteristics. The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE). | [optional] 
**MaxCompletionsForCredit** | **int** | Designates how many times the course may be taken with credit received by the student. | [optional] 
**MaximumAvailableCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**MaximumAvailableCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**MaximumAvailableCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**MinimumAvailableCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**MinimumAvailableCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**MinimumAvailableCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**OfferedGradeLevels** | [**List&lt;EdFiCourseOfferedGradeLevel&gt;**](EdFiCourseOfferedGradeLevel.md) | An unordered collection of courseOfferedGradeLevels. The grade levels in which the course is offered. | [optional] 
**TimeRequiredForCompletion** | **int** | The actual or estimated number of clock minutes required for class completion.  This number is especially important for career and technical education classes and may represent (in minutes) the clock hour requirement of the class. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the Course entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

