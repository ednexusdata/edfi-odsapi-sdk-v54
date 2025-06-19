# EdFi.OdsApi.Sdk.v54.Models.All.EdFiDisciplineIncident

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncidentIdentifier** | **string** | A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**IncidentDate** | **DateOnly** | The month, day, and year on which the DisciplineIncident occurred. | 
**Id** | **string** |  | [optional] 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | [optional] 
**Behaviors** | [**List&lt;EdFiDisciplineIncidentBehavior&gt;**](EdFiDisciplineIncidentBehavior.md) | An unordered collection of disciplineIncidentBehaviors. Describes behavior by category and provides a detailed description. | [optional] 
**CaseNumber** | **string** | The case number assigned to the DisciplineIncident by law enforcement or other organization. | [optional] 
**ExternalParticipants** | [**List&lt;EdFiDisciplineIncidentExternalParticipant&gt;**](EdFiDisciplineIncidentExternalParticipant.md) | An unordered collection of disciplineIncidentExternalParticipants. Information on an individual involved in the Discipline Incident. | [optional] 
**IncidentCost** | **double** | The value of any quantifiable monetary loss directly resulting from the DisciplineIncident. Examples include the value of repairs necessitated by vandalism of a school facility, or the value of personnel resources used for repairs or consumed by the incident. | [optional] 
**IncidentDescription** | **string** | The description for an incident. | [optional] 
**IncidentLocationDescriptor** | **string** | Identifies where the DisciplineIncident occurred and whether or not it occurred on school, for example:        On school        Administrative offices area        Cafeteria area        Classroom        Hallway or stairs        ... | [optional] 
**IncidentTime** | **string** | An indication of the time of day the incident took place. | [optional] 
**ReportedToLawEnforcement** | **bool** | Indicator of whether the incident was reported to law enforcement. | [optional] 
**ReporterDescriptionDescriptor** | **string** | Information on the type of individual who reported the DisciplineIncident. When known and/or if useful, use a more specific option code (e.g., \&quot;Counselor\&quot; rather than \&quot;Professional Staff\&quot;); for example:        Student        Parent/guardian        Law enforcement officer        Nonschool personnel        Representative of visiting school        ... | [optional] 
**ReporterName** | **string** | Identifies the reporter of the DisciplineIncident by name. | [optional] 
**Weapons** | [**List&lt;EdFiDisciplineIncidentWeapon&gt;**](EdFiDisciplineIncidentWeapon.md) | An unordered collection of disciplineIncidentWeapons. Identifies the type of weapon used during an incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the DisciplineIncident entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

