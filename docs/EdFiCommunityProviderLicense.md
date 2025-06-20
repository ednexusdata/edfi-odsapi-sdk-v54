# EdFi.OdsApi.Sdk.v54.Models.All.EdFiCommunityProviderLicense

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**LicenseIdentifier** | **string** | The unique identifier issued by the licensing organization. | 
**LicensingOrganization** | **string** | The organization issuing the license. | 
**CommunityProviderReference** | [**EdFiCommunityProviderReference**](EdFiCommunityProviderReference.md) |  | 
**AuthorizedFacilityCapacity** | **int** | The maximum number that can be contained or accommodated which a provider is authorized or licensed to serve. | [optional] 
**LicenseEffectiveDate** | **DateOnly** | The month, day, and year on which a license is active or becomes effective. | 
**LicenseExpirationDate** | **DateOnly** | The month, day, and year on which a license will expire. | [optional] 
**LicenseIssueDate** | **DateOnly** | The month, day, and year on which an active license was issued. | [optional] 
**LicenseStatusDescriptor** | **string** | An indication of the status of the license. | [optional] 
**LicenseTypeDescriptor** | **string** | An indication of the category of the license. | 
**OldestAgeAuthorizedToServe** | **int** | The oldest age of children a provider is authorized or licensed to serve. | [optional] 
**YoungestAgeAuthorizedToServe** | **int** | The youngest age of children a provider is authorized or licensed to serve. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the CommunityProviderLicense entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

