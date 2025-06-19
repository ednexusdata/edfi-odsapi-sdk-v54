# EdFi.OdsApi.Sdk.v54.Models.All.EdFiObjectiveAssessment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentificationCode** | **string** | A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. | 
**AssessmentReference** | [**EdFiAssessmentReference**](EdFiAssessmentReference.md) |  | 
**Id** | **string** |  | [optional] 
**ParentObjectiveAssessmentReference** | [**EdFiObjectiveAssessmentReference**](EdFiObjectiveAssessmentReference.md) |  | [optional] 
**AcademicSubjectDescriptor** | **string** | The subject area of the objective assessment. | [optional] 
**AssessmentItems** | [**List&lt;EdFiObjectiveAssessmentAssessmentItem&gt;**](EdFiObjectiveAssessmentAssessmentItem.md) | An unordered collection of objectiveAssessmentAssessmentItems. References individual test items, if appropriate. | [optional] 
**Description** | **string** | The description of the ObjectiveAssessment (e.g., vocabulary, measurement, or geometry). | [optional] 
**LearningObjectives** | [**List&lt;EdFiObjectiveAssessmentLearningObjective&gt;**](EdFiObjectiveAssessmentLearningObjective.md) | An unordered collection of objectiveAssessmentLearningObjectives. References the LearningObjective(s) the ObjectiveAssessment tests. | [optional] 
**LearningStandards** | [**List&lt;EdFiObjectiveAssessmentLearningStandard&gt;**](EdFiObjectiveAssessmentLearningStandard.md) | An unordered collection of objectiveAssessmentLearningStandards. LearningStandard tested by this ObjectiveAssessment. | [optional] 
**MaxRawScore** | **double** | The maximum raw score achievable across all assessment items that are correct and scored at the maximum. | [optional] 
**Nomenclature** | **string** | Reflects the specific nomenclature used for this level of ObjectiveAssessment. | [optional] 
**PercentOfAssessment** | **double** | The percentage of the Assessment that tests this objective. | [optional] 
**PerformanceLevels** | [**List&lt;EdFiObjectiveAssessmentPerformanceLevel&gt;**](EdFiObjectiveAssessmentPerformanceLevel.md) | An unordered collection of objectiveAssessmentPerformanceLevels. Definition of the performance levels and the associated cut scores. Three styles are supported:        1. Specification of performance level by minimum and maximum score        2. Specification of performance level by cut score, using only minimum score        3. Specification of performance level without any mapping to scores | [optional] 
**Scores** | [**List&lt;EdFiObjectiveAssessmentScore&gt;**](EdFiObjectiveAssessmentScore.md) | An unordered collection of objectiveAssessmentScores. Definition of the scores to be expected from this objective assessment. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the ObjectiveAssessment entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

