# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStudentInterventionAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InterventionReference** | [**EdFiInterventionReference**](EdFiInterventionReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**CohortReference** | [**EdFiCohortReference**](EdFiCohortReference.md) |  | [optional] 
**DiagnosticStatement** | **string** | A statement provided by the assigner that provides information regarding why the student was assigned to this intervention. | [optional] 
**Dosage** | **int** | The duration of time in minutes for which the student was assigned to participate in the intervention. | [optional] 
**InterventionEffectivenesses** | [**List&lt;EdFiStudentInterventionAssociationInterventionEffectiveness&gt;**](EdFiStudentInterventionAssociationInterventionEffectiveness.md) | An unordered collection of studentInterventionAssociationInterventionEffectivenesses. A measure of the effects of an intervention in each outcome domain. The rating of effectiveness takes into account four factors: the quality of the research on the intervention, the statistical significance of the research findings, the size of the differences between participants in the intervention and comparison groups and the consistency in results. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StudentInterventionAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

