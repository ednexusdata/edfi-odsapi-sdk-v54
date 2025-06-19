# EdFi.OdsApi.Sdk.v54.Models.All.EdFiLocalEducationAgency

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Categories** | [**List&lt;EdFiEducationOrganizationCategory&gt;**](EdFiEducationOrganizationCategory.md) | An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. | 
**LocalEducationAgencyId** | **int** | The identifier assigned to a local education agency. | 
**LocalEducationAgencyCategoryDescriptor** | **string** | The category of local education agency/district. For example: Independent or Charter. | 
**NameOfInstitution** | **string** | The full, legally accepted name of the institution. | 
**Id** | **string** |  | [optional] 
**EducationServiceCenterReference** | [**EdFiEducationServiceCenterReference**](EdFiEducationServiceCenterReference.md) |  | [optional] 
**ParentLocalEducationAgencyReference** | [**EdFiLocalEducationAgencyReference**](EdFiLocalEducationAgencyReference.md) |  | [optional] 
**StateEducationAgencyReference** | [**EdFiStateEducationAgencyReference**](EdFiStateEducationAgencyReference.md) |  | [optional] 
**Accountabilities** | [**List&lt;EdFiLocalEducationAgencyAccountability&gt;**](EdFiLocalEducationAgencyAccountability.md) | An unordered collection of localEducationAgencyAccountabilities. This entity maintains information about federal reporting and accountability for local education agencies. | [optional] 
**Addresses** | [**List&lt;EdFiEducationOrganizationAddress&gt;**](EdFiEducationOrganizationAddress.md) | An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4. | [optional] 
**CharterStatusDescriptor** | **string** | A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school. | [optional] 
**FederalFunds** | [**List&lt;EdFiLocalEducationAgencyFederalFunds&gt;**](EdFiLocalEducationAgencyFederalFunds.md) | An unordered collection of localEducationAgencyFederalFunds. Contains the information about the reception and use of federal funds for reporting purposes. | [optional] 
**IdentificationCodes** | [**List&lt;EdFiEducationOrganizationIdentificationCode&gt;**](EdFiEducationOrganizationIdentificationCode.md) | An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity. | [optional] 
**Indicators** | [**List&lt;EdFiEducationOrganizationIndicator&gt;**](EdFiEducationOrganizationIndicator.md) | An unordered collection of educationOrganizationIndicators. An indicator or metric of an Education Organization. | [optional] 
**InstitutionTelephones** | [**List&lt;EdFiEducationOrganizationInstitutionTelephone&gt;**](EdFiEducationOrganizationInstitutionTelephone.md) | An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity. | [optional] 
**InternationalAddresses** | [**List&lt;EdFiEducationOrganizationInternationalAddress&gt;**](EdFiEducationOrganizationInternationalAddress.md) | An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity. | [optional] 
**OperationalStatusDescriptor** | **string** | The current operational status of the EducationOrganization (e.g., active, inactive). | [optional] 
**ShortNameOfInstitution** | **string** | A short name for the institution. | [optional] 
**WebSite** | **string** | The public web site address (URL) for the EducationOrganization. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the LocalEducationAgency entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

