# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStudentAssessmentItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssessmentItemResultDescriptor** | **string** | The analyzed result of a student&#39;s response to an assessment item. For example:        Correct        Incorrect         Met standard        ... | 
**AssessmentItemReference** | [**EdFiAssessmentItemReference**](EdFiAssessmentItemReference.md) |  | 
**ResponseIndicatorDescriptor** | **string** | Indicator of the response. For example:        Nonscorable response        Ineffective response        Effective response        Partial response        ... | [optional] 
**AssessmentResponse** | **string** | A student&#39;s response to a stimulus on a test. | [optional] 
**DescriptiveFeedback** | **string** | The formative descriptive feedback that was given to a learner in response to the results from a scored/evaluated assessment item. | [optional] 
**RawScoreResult** | **double** | A meaningful raw score of the performance of an individual on an assessment item. | [optional] 
**TimeAssessed** | **string** | The overall time a student actually spent during the AssessmentItem. | [optional] 
**Ext** | **Object** | Extensions to the StudentAssessmentItem entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

