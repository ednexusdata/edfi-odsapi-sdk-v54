# EdFi.OdsApi.Sdk.v54.Models.All.EdFiLearningObjective

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcademicSubjects** | [**List&lt;EdFiLearningObjectiveAcademicSubject&gt;**](EdFiLearningObjectiveAcademicSubject.md) | An unordered collection of learningObjectiveAcademicSubjects. The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment. | 
**LearningObjectiveId** | **string** | The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A). | 
**Namespace** | **string** | Namespace for the LearningObjective. | 
**Objective** | **string** | The designated title of the LearningObjective. | 
**Id** | **string** |  | [optional] 
**ParentLearningObjectiveReference** | [**EdFiLearningObjectiveReference**](EdFiLearningObjectiveReference.md) |  | [optional] 
**ContentStandard** | [**EdFiLearningObjectiveContentStandard**](EdFiLearningObjectiveContentStandard.md) |  | [optional] 
**Description** | **string** | The description of the LearningObjective. | [optional] 
**GradeLevels** | [**List&lt;EdFiLearningObjectiveGradeLevel&gt;**](EdFiLearningObjectiveGradeLevel.md) | An unordered collection of learningObjectiveGradeLevels. The grade level for which the LearningObjective is targeted. The semantics of null is assumed to mean that the learning objective is not associated with any grade level. | [optional] 
**LearningStandards** | [**List&lt;EdFiLearningObjectiveLearningStandard&gt;**](EdFiLearningObjectiveLearningStandard.md) | An unordered collection of learningObjectiveLearningStandards. LearningStandard(s) included in this objective. | [optional] 
**Nomenclature** | **string** | Reflects the specific nomenclature used for the LearningObjective. | [optional] 
**SuccessCriteria** | **string** | One or more statements that describes the criteria used by teachers and students to check for attainment of a learning objective. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the LearningObjective. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the LearningObjective entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

