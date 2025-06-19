# EdFi.OdsApi.Sdk.v54.Models.All.EdFiGradebookEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateAssigned** | **DateOnly** | The date the assignment, homework, or assessment was assigned or executed. | 
**GradebookEntryTitle** | **string** | The name or title of the activity to be recorded in the GradebookEntry. | 
**SectionReference** | [**EdFiSectionReference**](EdFiSectionReference.md) |  | 
**Id** | **string** |  | [optional] 
**GradingPeriodReference** | [**EdFiGradingPeriodReference**](EdFiGradingPeriodReference.md) |  | [optional] 
**Description** | **string** | A description of the assignment, homework, or classroom assessment. | [optional] 
**DueDate** | **DateOnly** | The date the assignment, homework, or assessment is due. | [optional] 
**GradebookEntryTypeDescriptor** | **string** | The type of the GradebookEntry; for example, homework, assignment, quiz, unit test, oral presentation, etc. | [optional] 
**LearningObjectives** | [**List&lt;EdFiGradebookEntryLearningObjective&gt;**](EdFiGradebookEntryLearningObjective.md) | An unordered collection of gradebookEntryLearningObjectives. LearningObjectives associated with the GradebookEntry. | [optional] 
**LearningStandards** | [**List&lt;EdFiGradebookEntryLearningStandard&gt;**](EdFiGradebookEntryLearningStandard.md) | An unordered collection of gradebookEntryLearningStandards. LearningStandard(s) associated with the GradebookEntry. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the GradebookEntry entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

