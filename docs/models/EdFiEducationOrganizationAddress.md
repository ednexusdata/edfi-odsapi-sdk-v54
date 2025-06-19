# EdFi.OdsApi.Sdk.v54.Models.All.EdFiEducationOrganizationAddress

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressTypeDescriptor** | **string** | The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.) | 
**StateAbbreviationDescriptor** | **string** | The abbreviation for the state (within the United States) or outlying area in which an address is located. | 
**City** | **string** | The name of the city in which an address is located. | 
**PostalCode** | **string** | The five or nine digit zip code or overseas postal code portion of an address. | 
**StreetNumberName** | **string** | The street number and street name or post office box number of an address. | 
**LocaleDescriptor** | **string** | A general geographic indicator that categorizes U.S. territory (e.g., City, Suburban). | [optional] 
**ApartmentRoomSuiteNumber** | **string** | The apartment, room, or suite number of an address. | [optional] 
**BuildingSiteNumber** | **string** | The number of the building on the site, if more than one building shares the same address. | [optional] 
**CongressionalDistrict** | **string** | The congressional district in which an address is located. | [optional] 
**CountyFIPSCode** | **string** | The Federal Information Processing Standards (FIPS) numeric code for the county issued by the National Institute of Standards and Technology (NIST). Counties are considered to be the \&quot;first-order subdivisions\&quot; of each State and statistically equivalent entity, regardless of their local designations (county, parish, borough, etc.) Counties in different States will have the same code. A unique county number is created when combined with the 2-digit FIPS State Code. | [optional] 
**DoNotPublishIndicator** | **bool** | An indication that the address should not be published. | [optional] 
**Latitude** | **string** | The geographic latitude of the physical address. | [optional] 
**Longitude** | **string** | The geographic longitude of the physical address. | [optional] 
**NameOfCounty** | **string** | The name of the county, parish, borough, or comparable unit (within a state) in                      &#39;which an address is located. | [optional] 
**Periods** | [**List&lt;EdFiEducationOrganizationAddressPeriod&gt;**](EdFiEducationOrganizationAddressPeriod.md) | An unordered collection of educationOrganizationAddressPeriods. The time periods for which the address is valid. For physical addresses, the periods in which the person lived at that address. | [optional] 
**Ext** | **Object** | Extensions to the EducationOrganizationAddress entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

