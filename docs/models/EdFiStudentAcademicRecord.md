# EdFi.OdsApi.Sdk.v54.Models.All.EdFiStudentAcademicRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TermDescriptor** | **string** | The term for the session during the school year. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**AcademicHonors** | [**List&lt;EdFiStudentAcademicRecordAcademicHonor&gt;**](EdFiStudentAcademicRecordAcademicHonor.md) | An unordered collection of studentAcademicRecordAcademicHonors. Academic distinctions earned by or awarded to the student. | [optional] 
**ClassRanking** | [**EdFiStudentAcademicRecordClassRanking**](EdFiStudentAcademicRecordClassRanking.md) |  | [optional] 
**CumulativeAttemptedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**CumulativeAttemptedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**CumulativeAttemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**CumulativeEarnedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**CumulativeEarnedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**CumulativeEarnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**CumulativeGradePointAverage** | **double** | A measure of average performance in all courses taken by an individual during his or her school career as determined for record-keeping purposes. This is obtained by dividing the total grade points received by the total number of credits attempted. This usually includes grade points received and credits attempted in his or her current school as well as those transferred from schools in which the individual was previously enrolled. | [optional] 
**CumulativeGradePointsEarned** | **double** | The cumulative number of grade points an individual earns by successfully completing courses or examinations during his or her enrollment in the current school as well as those transferred from schools in which the individual had been previously enrolled. | [optional] 
**Diplomas** | [**List&lt;EdFiStudentAcademicRecordDiploma&gt;**](EdFiStudentAcademicRecordDiploma.md) | An unordered collection of studentAcademicRecordDiplomas. Diploma(s) earned by the student. | [optional] 
**GradePointAverages** | [**List&lt;EdFiStudentAcademicRecordGradePointAverage&gt;**](EdFiStudentAcademicRecordGradePointAverage.md) | An unordered collection of studentAcademicRecordGradePointAverages. The grade point average for an individual computed as the grade points earned divided by the number of credits attempted. | [optional] 
**GradeValueQualifier** | **string** | The scale of equivalents, if applicable, for grades awarded as indicators of performance in schoolwork. For example, numerical equivalents for letter grades used in determining a student&#39;s Grade Point Average (A&#x3D;4, B&#x3D;3, C&#x3D;2, D&#x3D;1 in a four-point system) or letter equivalents for percentage grades (90-100%&#x3D;A, 80-90%&#x3D;B, etc.) | [optional] 
**ProjectedGraduationDate** | **DateOnly** | The month and year the student is projected to graduate. | [optional] 
**Recognitions** | [**List&lt;EdFiStudentAcademicRecordRecognition&gt;**](EdFiStudentAcademicRecordRecognition.md) | An unordered collection of studentAcademicRecordRecognitions. Recognitions given to the student for accomplishments in a co-curricular or extracurricular activity. | [optional] 
**ReportCards** | [**List&lt;EdFiStudentAcademicRecordReportCard&gt;**](EdFiStudentAcademicRecordReportCard.md) | An unordered collection of studentAcademicRecordReportCards. Report cards for the student. | [optional] 
**SessionAttemptedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**SessionAttemptedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**SessionAttemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**SessionEarnedCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**SessionEarnedCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**SessionEarnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**SessionGradePointAverage** | **double** | The grade point average for an individual computed as the grade points earned during the session divided by the number of credits attempted. | [optional] 
**SessionGradePointsEarned** | **double** | The number of grade points an individual earned for this session. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StudentAcademicRecord entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

