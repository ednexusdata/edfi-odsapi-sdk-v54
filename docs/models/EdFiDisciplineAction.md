# EdFi.OdsApi.Sdk.v54.Models.All.EdFiDisciplineAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisciplineActionIdentifier** | **string** | Identifier assigned by the education organization to the DisciplineAction. | 
**DisciplineDate** | **DateOnly** | The date of the DisciplineAction. | 
**Disciplines** | [**List&lt;EdFiDisciplineActionDiscipline&gt;**](EdFiDisciplineActionDiscipline.md) | An unordered collection of disciplineActionDisciplines. Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident. | 
**StudentDisciplineIncidentAssociations** | [**List&lt;EdFiDisciplineActionStudentDisciplineIncidentAssociation&gt;**](EdFiDisciplineActionStudentDisciplineIncidentAssociation.md) | An unordered collection of disciplineActionStudentDisciplineIncidentAssociations. Reference to the DisciplineIncident associated with the DisciplineAction. | 
**ResponsibilitySchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**AssignmentSchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | [optional] 
**ActualDisciplineActionLength** | **double** | Indicates the actual length in school days of a student&#39;s disciplinary assignment. | [optional] 
**DisciplineActionLength** | **double** | The length of time in school days for the DisciplineAction (e.g. removal, detention), if applicable. | [optional] 
**DisciplineActionLengthDifferenceReasonDescriptor** | **string** | Indicates the reason for the difference, if any, between the official and actual lengths of a student&#39;s disciplinary assignment. | [optional] 
**IepPlacementMeetingIndicator** | **bool** | An indication as to whether an offense and/or disciplinary action resulted in a meeting of a student&#39;s Individualized Education Program (IEP) team to determine appropriate placement. | [optional] 
**ReceivedEducationServicesDuringExpulsion** | **bool** | An indication of whether the student received educational services when removed from the regular school program for disciplinary reasons. | [optional] 
**RelatedToZeroTolerancePolicy** | **bool** | An indication of whether or not this disciplinary action taken against a student was imposed as a consequence of state or local zero tolerance policies. | [optional] 
**Staffs** | [**List&lt;EdFiDisciplineActionStaff&gt;**](EdFiDisciplineActionStaff.md) | An unordered collection of disciplineActionStaffs. The staff responsible for enforcing the DisciplineAction. | [optional] 
**StudentDisciplineIncidentBehaviorAssociations** | [**List&lt;EdFiDisciplineActionStudentDisciplineIncidentBehaviorAssociation&gt;**](EdFiDisciplineActionStudentDisciplineIncidentBehaviorAssociation.md) | An unordered collection of disciplineActionStudentDisciplineIncidentBehaviorAssociations. A reference to the behavior(s) by the student that led or contributed to this specific action. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the DisciplineAction entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

