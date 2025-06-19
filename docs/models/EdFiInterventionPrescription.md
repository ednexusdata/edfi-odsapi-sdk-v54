# EdFi.OdsApi.Sdk.v54.Models.All.EdFiInterventionPrescription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InterventionPrescriptionIdentificationCode** | **string** | A unique number or alphanumeric code assigned to an intervention prescription. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**DeliveryMethodDescriptor** | **string** | The way in which an intervention was implemented: individual, small group, whole class, or whole school. | 
**InterventionClassDescriptor** | **string** | The way in which an intervention is used: curriculum, supplement, or practice. | 
**Id** | **string** |  | [optional] 
**AppropriateGradeLevels** | [**List&lt;EdFiInterventionPrescriptionAppropriateGradeLevel&gt;**](EdFiInterventionPrescriptionAppropriateGradeLevel.md) | An unordered collection of interventionPrescriptionAppropriateGradeLevels. Grade levels for the prescribed intervention. If omitted, considered generally applicable. | [optional] 
**AppropriateSexes** | [**List&lt;EdFiInterventionPrescriptionAppropriateSex&gt;**](EdFiInterventionPrescriptionAppropriateSex.md) | An unordered collection of interventionPrescriptionAppropriateSexes. Sexes for the InterventionPrescription. If omitted, considered generally applicable. | [optional] 
**Diagnoses** | [**List&lt;EdFiInterventionPrescriptionDiagnosis&gt;**](EdFiInterventionPrescriptionDiagnosis.md) | An unordered collection of interventionPrescriptionDiagnoses. Targeted purpose of the InterventionPrescription (e.g., attendance issue, dropout risk). | [optional] 
**EducationContents** | [**List&lt;EdFiInterventionPrescriptionEducationContent&gt;**](EdFiInterventionPrescriptionEducationContent.md) | An unordered collection of interventionPrescriptionEducationContents. Relates the education content source to the education content. | [optional] 
**LearningResourceMetadataURIs** | [**List&lt;EdFiInterventionPrescriptionLearningResourceMetadataURI&gt;**](EdFiInterventionPrescriptionLearningResourceMetadataURI.md) | An unordered collection of interventionPrescriptionLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. | [optional] 
**MaxDosage** | **int** | The maximum duration of time in minutes that is recommended for the intervention. | [optional] 
**MinDosage** | **int** | The minimum duration of time in minutes that is recommended for the intervention. | [optional] 
**PopulationServeds** | [**List&lt;EdFiInterventionPrescriptionPopulationServed&gt;**](EdFiInterventionPrescriptionPopulationServed.md) | An unordered collection of interventionPrescriptionPopulationServeds. A subset of students that are the focus of the InterventionPrescription. | [optional] 
**Uris** | [**List&lt;EdFiInterventionPrescriptionURI&gt;**](EdFiInterventionPrescriptionURI.md) | An unordered collection of interventionPrescriptionURIs. The URI (typical a URL) pointing to an education content item. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the InterventionPrescription entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

