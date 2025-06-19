# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStaffEducationOrganizationEmploymentAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmploymentStatusDescriptor** | **string** | Reflects the type of employment or contract; for example:        Probationary        Contractual        Substitute/temporary        Tenured or permanent        Volunteer/no contract        ... | 
**HireDate** | **DateOnly** | The month, day, and year on which an individual was hired for a position. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**Id** | **string** |  | [optional] 
**CredentialReference** | [**EdFiCredentialReference**](EdFiCredentialReference.md) |  | [optional] 
**Department** | **string** | The department or suborganization the employee/contractor is associated with in the EducationOrganization. | [optional] 
**EndDate** | **DateOnly** | The month, day, and year on which a contract between an individual and a governing authority ends or is terminated under the provisions of the contract (or the date on which the agreement is made invalid). | [optional] 
**FullTimeEquivalency** | **double** | The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting. | [optional] 
**HourlyWage** | **double** | Hourly wage associated with the employment position being reported. | [optional] 
**OfferDate** | **DateOnly** | Date at which the staff member was made an official offer for this employment. | [optional] 
**SeparationDescriptor** | **string** | Type of employment separation; for example: Voluntary separation, Involuntary separation,        Mutual agreement        Other, etc. | [optional] 
**SeparationReasonDescriptor** | **string** | Reason for terminating the employment; for example:        Employment in education        Employment outside of education        Retirement        Family/personal relocation        Change of assignment. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StaffEducationOrganizationEmploymentAssociation entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

