# EdFi.OdsApi.Sdk.v54.Models.All.EdFiProgram

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProgramName** | **string** | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. | 
**ProgramTypeDescriptor** | **string** | The type of program. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**Id** | **string** |  | [optional] 
**Characteristics** | [**List&lt;EdFiProgramCharacteristic&gt;**](EdFiProgramCharacteristic.md) | An unordered collection of programCharacteristics. Reflects important characteristics of the Program, such as categories or particular indications. | [optional] 
**LearningObjectives** | [**List&lt;EdFiProgramLearningObjective&gt;**](EdFiProgramLearningObjective.md) | An unordered collection of programLearningObjectives. References the LearningObjective(s) with which the Program is associated. | [optional] 
**LearningStandards** | [**List&lt;EdFiProgramLearningStandard&gt;**](EdFiProgramLearningStandard.md) | An unordered collection of programLearningStandards. LearningStandard followed by this program. | [optional] 
**ProgramId** | **string** | A unique number or alphanumeric code assigned to a program by a school, school system, a state, or other agency or entity. | [optional] 
**Services** | [**List&lt;EdFiProgramService&gt;**](EdFiProgramService.md) | An unordered collection of programServices. Defines the services this program provides to students. | [optional] 
**Sponsors** | [**List&lt;EdFiProgramSponsor&gt;**](EdFiProgramSponsor.md) | An unordered collection of programSponsors. Ultimate and intermediate providers of funds for a particular educational or service program or activity, or for an individual&#39;s participation in the program or activity (e.g., Federal, State, ESC, District, School, Private Organization). | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the Program entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

