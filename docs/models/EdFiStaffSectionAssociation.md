# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStaffSectionAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SectionReference** | [**EdFiSectionReference**](EdFiSectionReference.md) |  | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**ClassroomPositionDescriptor** | **string** | The type of position the Staff member holds in the specific class/section; for example:        Teacher of Record, Assistant Teacher, Support Teacher, Substitute Teacher... | 
**Id** | **string** |  | [optional] 
**BeginDate** | **DateOnly** | Month, day, and year of a teacher&#39;s assignment to the Section. If blank, defaults to the first day of the first grading period for the Section. | [optional] 
**EndDate** | **DateOnly** | Month, day, and year of the last day of a staff member&#39;s assignment to the Section. | [optional] 
**HighlyQualifiedTeacher** | **bool** | An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for this section being taught. | [optional] 
**PercentageContribution** | **double** | Indicates the percentage of the total scheduled course time, academic standards, and/or learning activities delivered in this section by this staff member. A teacher of record designation may be based solely or partially on this contribution percentage. | [optional] 
**TeacherStudentDataLinkExclusion** | **bool** | Indicates that the entire section is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StaffSectionAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

