# EdFi.OdsApi.Sdk.v54.Models.All.EdFiSurveyQuestion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuestionCode** | **string** | The identifying code for the question, unique for the survey. | 
**SurveyReference** | [**EdFiSurveyReference**](EdFiSurveyReference.md) |  | 
**QuestionFormDescriptor** | **string** | The form or type of question. | 
**QuestionText** | **string** | The text of the question. | 
**Id** | **string** |  | [optional] 
**SurveySectionReference** | [**EdFiSurveySectionReference**](EdFiSurveySectionReference.md) |  | [optional] 
**Matrices** | [**List&lt;EdFiSurveyQuestionMatrix&gt;**](EdFiSurveyQuestionMatrix.md) | An unordered collection of surveyQuestionMatrices. Information about the matrix element in the survey. | [optional] 
**ResponseChoices** | [**List&lt;EdFiSurveyQuestionResponseChoice&gt;**](EdFiSurveyQuestionResponseChoice.md) | An unordered collection of surveyQuestionResponseChoices. The optional list of possible responses to a survey question. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the SurveyQuestion entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

