# EdFi.OdsApi.Sdk.v54.Models.All.EdFiIntervention

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InterventionIdentificationCode** | **string** | A unique number or alphanumeric code assigned to an intervention. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**BeginDate** | **DateOnly** | The start date for the intervention implementation. | 
**DeliveryMethodDescriptor** | **string** | The way in which an intervention was implemented: individual, small group, whole class, or whole school. | 
**InterventionClassDescriptor** | **string** | The way in which an intervention is used: curriculum, supplement, or practice. | 
**Id** | **string** |  | [optional] 
**AppropriateGradeLevels** | [**List&lt;EdFiInterventionAppropriateGradeLevel&gt;**](EdFiInterventionAppropriateGradeLevel.md) | An unordered collection of interventionAppropriateGradeLevels. Grade levels for the Intervention-if omitted, considered generally applicable. | [optional] 
**AppropriateSexes** | [**List&lt;EdFiInterventionAppropriateSex&gt;**](EdFiInterventionAppropriateSex.md) | An unordered collection of interventionAppropriateSexes. Sexes for the Intervention. If omitted, considered generally applicable. | [optional] 
**Diagnoses** | [**List&lt;EdFiInterventionDiagnosis&gt;**](EdFiInterventionDiagnosis.md) | An unordered collection of interventionDiagnoses. Targeted purpose of the Intervention (e.g., attendance issue, dropout risk). | [optional] 
**EducationContents** | [**List&lt;EdFiInterventionEducationContent&gt;**](EdFiInterventionEducationContent.md) | An unordered collection of interventionEducationContents. Relates the education content source to the education content. | [optional] 
**EndDate** | **DateOnly** | The end date for the intervention implementation. | [optional] 
**InterventionPrescriptions** | [**List&lt;EdFiInterventionInterventionPrescription&gt;**](EdFiInterventionInterventionPrescription.md) | An unordered collection of interventionInterventionPrescriptions. The reference to the intervention prescription being followed in this intervention implementation. | [optional] 
**LearningResourceMetadataURIs** | [**List&lt;EdFiInterventionLearningResourceMetadataURI&gt;**](EdFiInterventionLearningResourceMetadataURI.md) | An unordered collection of interventionLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. | [optional] 
**MaxDosage** | **int** | The maximum duration of time in minutes that may be assigned for the intervention. | [optional] 
**MeetingTimes** | [**List&lt;EdFiInterventionMeetingTime&gt;**](EdFiInterventionMeetingTime.md) | An unordered collection of interventionMeetingTimes. The times at which this intervention is scheduled to meet. | [optional] 
**MinDosage** | **int** | The minimum duration of time in minutes that may be assigned for the intervention. | [optional] 
**PopulationServeds** | [**List&lt;EdFiInterventionPopulationServed&gt;**](EdFiInterventionPopulationServed.md) | An unordered collection of interventionPopulationServeds. A subset of students that are the focus of the Intervention. | [optional] 
**Staffs** | [**List&lt;EdFiInterventionStaff&gt;**](EdFiInterventionStaff.md) | An unordered collection of interventionStaffs. Relates the staff member associated with the Intervention. | [optional] 
**Uris** | [**List&lt;EdFiInterventionURI&gt;**](EdFiInterventionURI.md) | An unordered collection of interventionURIs. The URI (typical a URL) pointing to an education content item. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the Intervention entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

