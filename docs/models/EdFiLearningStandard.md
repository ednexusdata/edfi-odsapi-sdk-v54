# EdFi.OdsApi.Sdk.v54.Models.All.EdFiLearningStandard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcademicSubjects** | [**List&lt;EdFiLearningStandardAcademicSubject&gt;**](EdFiLearningStandardAcademicSubject.md) | An unordered collection of learningStandardAcademicSubjects. Subject area for the LearningStandard. | 
**GradeLevels** | [**List&lt;EdFiLearningStandardGradeLevel&gt;**](EdFiLearningStandardGradeLevel.md) | An unordered collection of learningStandardGradeLevels. The grade levels for the specific learning standard. | 
**LearningStandardId** | **string** | The identifier for the specific learning standard (e.g., 111.15.3.1.A). | 
**Description** | **string** | The text of the statement. The textual content that either describes a specific competency such as \&quot;Apply the Pythagorean Theorem to determine unknown side lengths in right triangles in real-world and mathematical problems in two and three dimensions.\&quot; or describes a less granular group of competencies within the taxonomy of the standards document, e.g. \&quot;Understand and apply the Pythagorean Theorem,\&quot; or \&quot;Geometry\&quot;. | 
**Namespace** | **string** | The namespace of the organization or entity who governs the standard. It is recommended the namespaces observe a URI format and begin with a domain name under the governing organization or entity control. | 
**Id** | **string** |  | [optional] 
**ParentLearningStandardReference** | [**EdFiLearningStandardReference**](EdFiLearningStandardReference.md) |  | [optional] 
**ContentStandard** | [**EdFiLearningStandardContentStandard**](EdFiLearningStandardContentStandard.md) |  | [optional] 
**CourseTitle** | **string** | The official Course Title with which this learning standard is associated. | [optional] 
**IdentificationCodes** | [**List&lt;EdFiLearningStandardIdentificationCode&gt;**](EdFiLearningStandardIdentificationCode.md) | An unordered collection of learningStandardIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a learning standard. | [optional] 
**LearningStandardCategoryDescriptor** | **string** | An additional classification of the type of a specific learning standard. | [optional] 
**LearningStandardItemCode** | **string** | A code designated by the promulgating body to identify the statement, e.g. 1.N.3 (usually not globally unique). | [optional] 
**LearningStandardScopeDescriptor** | **string** | Signals the scope of usage the standard. Does not necessarily relate the standard to the governing body. | [optional] 
**PrerequisiteLearningStandards** | [**List&lt;EdFiLearningStandardPrerequisiteLearningStandard&gt;**](EdFiLearningStandardPrerequisiteLearningStandard.md) | An unordered collection of learningStandardPrerequisiteLearningStandards. The unique identifier of a prerequisite learning standard item, a competency needed prior to learning this one. (Some items may have no prerequisites others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites). | [optional] 
**SuccessCriteria** | **string** | One or more statements that describes the criteria used by teachers and students to check for attainment of a learning standard. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the LearningStandard. | [optional] 
**Uri** | **string** | An unambiguous reference to the statement using a network-resolvable URI. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the LearningStandard entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

