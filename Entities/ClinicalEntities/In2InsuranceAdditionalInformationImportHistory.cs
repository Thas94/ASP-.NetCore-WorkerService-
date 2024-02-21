using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class In2InsuranceAdditionalInformationImportHistory
{
    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public string? In210InsuredsEmployeeIdidnumber { get; set; }

    public string? In22InsuredsSocialSecurityNumber { get; set; }

    public string? In230InsuredsEmployersNameandIdidnumber { get; set; }

    public string? In24EmployerInformationData { get; set; }

    public string? In25MailClaimParty { get; set; }

    public string? In26MedicareHealthInsCardNumber { get; set; }

    public string? In270MedicaidCaseNameFamilyName { get; set; }

    public string? In271MedicaidCaseNameGivenName { get; set; }

    public string? In28MedicaidCaseNumber { get; set; }

    public string? In290MilitarySponsorNameFamilyName { get; set; }

    public string? In291MilitarySponsorNameGivenName { get; set; }

    public string? In210MilitaryIdnumber { get; set; }

    public string? In2110DependentOfMilitaryRecipientIdentifier { get; set; }

    public string? In212MilitaryOrganization { get; set; }

    public string? In213MilitaryStation { get; set; }

    public string? In214MilitaryService { get; set; }

    public string? In215MilitaryRankGrade { get; set; }

    public string? In216MilitaryStatus { get; set; }

    public DateTime? In217MilitaryRetireDate { get; set; }

    public string? In218MilitaryNonAvailCertOnFile { get; set; }

    public string? In219BabyCoverage { get; set; }

    public string? In220CombineBabyBill { get; set; }

    public string? In221BloodDeductible { get; set; }

    public string? In2220SpecialCoverageApprovalNameFamilyName { get; set; }

    public string? In2221SpecialCoverageApprovalNameGivenName { get; set; }

    public string? In223SpecialCoverageApprovalTitle { get; set; }

    public string? In224NonCoveredInsuranceCode { get; set; }

    public string? In2250PayorIdidnumber { get; set; }

    public string? In2260PayorSubscriberIdidnumber { get; set; }

    public string? In227EligibilitySource { get; set; }

    public string? In2280RoomCoverageTypeAmountRoomType { get; set; }

    public string? In2281RoomCoverageTypeAmountAmountType { get; set; }

    public decimal? In2282RoomCoverageTypeAmountCoverageAmount { get; set; }

    public string? In229PolicyTypeAmount { get; set; }

    public decimal? In2300DailyDeductibleDelayDays { get; set; }

    public decimal? In2301DailyDeductibleMonetaryAmount { get; set; }

    public string? In231LivingDependency { get; set; }

    public string? In232AmbulatoryStatus { get; set; }

    public string? In233Citizenship { get; set; }

    public string? In2340PrimaryLanguageIdentifier { get; set; }

    public string? In235LivingArrangement { get; set; }

    public string? In2360PublicityCodeIdentifier { get; set; }

    public string? In237ProtectionIndicator { get; set; }

    public string? In238StudentIndicator { get; set; }

    public string? In239Religion { get; set; }

    public string? In2400MothersMaidenNameFamilyName { get; set; }

    public string? In2410NationalityIdentifier { get; set; }

    public string? In242EthnicGroup { get; set; }

    public string? In243MaritalStatus { get; set; }

    public DateTime? In244InsuredsEmploymentStartDate { get; set; }

    public DateTime? In245EmploymentStopDate { get; set; }

    public string? In246JobTitle { get; set; }

    public string? In2470JobCodeClassJobCode { get; set; }

    public string? In2471JobCodeClassJobClass { get; set; }

    public string? In248JobStatus { get; set; }

    public string? In2490EmployerContactPersonNameFamilyName { get; set; }

    public string? In2491EmployerContactPersonNameGivenName { get; set; }

    public string? In250EmployerContactPersonPhoneNumber { get; set; }

    public string? In251EmployerContactReason { get; set; }

    public string? In2520InsuredsContactPersonsNameFamilyName { get; set; }

    public string? In2521InsuredsContactPersonsNameGivenName { get; set; }

    public string? In253InsuredsContactPersonPhoneNumber { get; set; }

    public string? In254InsuredsContactPersonReason { get; set; }

    public DateTime? In255RelationshiptothePatientStartDate { get; set; }

    public DateTime? In256RelationshiptothePatientStopDate { get; set; }

    public string? In257InsuranceCoContactReason { get; set; }

    public string? In258InsuranceCoContactPhoneNumber { get; set; }

    public string? In259PolicyScope { get; set; }

    public string? In260PolicySource { get; set; }

    public string? In2610PatientMemberNumberIdnumber { get; set; }

    public string? In262GuarantorsRelationshiptoInsured { get; set; }

    public string? In263InsuredsPhoneNumberHome { get; set; }

    public string? In264InsuredsEmployerPhoneNumber { get; set; }

    public string? In2650MilitaryHandicappedProgramIdentifier { get; set; }

    public string? In266SuspendFlag { get; set; }

    public string? In267CopayLimitFlag { get; set; }

    public string? In268StoplossLimitFlag { get; set; }

    public string? In2690InsuredOrganizationNameandIdorganizationName { get; set; }

    public string? In2691InsuredOrganizationNameandIdorganizationNameTypeCode { get; set; }

    public string? In2692InsuredOrganizationNameandIdidnumber { get; set; }

    public string? In2700InsuredEmployerOrganizationNameandIdorganizationName { get; set; }

    public string? In2701InsuredEmployerOrganizationNameandIdorganizationNameTypeCode { get; set; }

    public string? In2702InsuredEmployerOrganizationNameandIdidnumber { get; set; }

    public string? In271Race { get; set; }

    public string? In272PatientsRelationshipToInsured { get; set; }

    public DateTime DateTimeInserted { get; set; }
}
