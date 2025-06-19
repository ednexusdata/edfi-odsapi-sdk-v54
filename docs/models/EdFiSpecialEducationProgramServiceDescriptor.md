# EdFi.OdsApi.Sdk.v54.Models.All.EdFiSpecialEducationProgramServiceDescriptor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CodeValue** | **string** | A code or abbreviation that is used to refer to the descriptor. | 
**Namespace** | **string** | A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary. | 
**ShortDescription** | **string** | A shortened description for the descriptor. | 
**Id** | **string** |  | [optional] 
**SpecialEducationProgramServiceDescriptorId** | **int** | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional] 
**Description** | **string** | The description of the descriptor. | [optional] 
**EffectiveBeginDate** | **DateOnly** | The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness. | [optional] 
**EffectiveEndDate** | **DateOnly** | The end date of the period when the descriptor is in effect. | [optional] 
**PriorDescriptorId** | **int** | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

