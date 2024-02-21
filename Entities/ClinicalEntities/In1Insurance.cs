using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class In1Insurance
{
    public int LogId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public long? In11SetIdin1 { get; set; }

    public string? In120InsurancePlanIdidentifier { get; set; }

    public string? In130InsuranceCompanyIdidnumber { get; set; }

    public string? In140InsuranceCompanyNameOrganizationName { get; set; }

    public string? In150InsuranceCompanyAddressStreetAddress { get; set; }

    public string? In151InsuranceCompanyAddressOtherDesignation { get; set; }

    public string? In152InsuranceCompanyAddressCity { get; set; }

    public string? In153InsuranceCompanyAddressState { get; set; }

    public string? In154InsuranceCompanyAddressZipOrPostalCode { get; set; }

    public string? In155InsuranceCompanyAddressCountry { get; set; }

    public string? In161InsuranceCoContactPersonGivenName { get; set; }

    public string? In170InsuranceCoPhoneNumberTelephoneNumber { get; set; }

    public string? In18GroupNumber { get; set; }

    public string? In190GroupNameOrganizationName { get; set; }

    public string? In1100InsuredsGroupEmpIdidnumber { get; set; }

    public string? In1110InsuredsGroupEmpNameOrganizationName { get; set; }

    public DateTime? In112PlanEffectiveDate { get; set; }

    public DateTime? In113PlanExpirationDate { get; set; }

    public string? In1140AuthorizationInformationAuthorizationNumber { get; set; }

    public string? In115PlanType { get; set; }

    public string? In1160NameOfInsuredFamilyName { get; set; }

    public string? In1161NameOfInsuredGivenName { get; set; }

    public string? In1162NameOfInsuredSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? In1163NameOfInsuredSuffix { get; set; }

    public string? In1164NameOfInsuredPrefix { get; set; }

    public string? In117InsuredsRelationshipToPatient { get; set; }

    public DateTime? In118InsuredsDateOfBirth { get; set; }

    public string? In1190InsuredsAddressStreetAddress { get; set; }

    public string? In1191InsuredsAddressOtherDesignation { get; set; }

    public string? In1192InsuredsAddressCity { get; set; }

    public string? In1193InsuredsAddressStateOrProvince { get; set; }

    public string? In1194InsuredsAddressZipOrPostalCode { get; set; }

    public string? In1195InsuredsAddressCountry { get; set; }

    public string? In120AssignmentOfBenefits { get; set; }

    public string? In121CoordinationOfBenefits { get; set; }

    public string? In122CoordOfBenPriority { get; set; }

    public string? In123NoticeOfAdmissionFlag { get; set; }

    public DateTime? In124NoticeOfAdmissionDate { get; set; }

    public string? In125ReportOfEligibilityFlag { get; set; }

    public DateTime? In126ReportOfEligibilityDate { get; set; }

    public string? In127ReleaseInformationCode { get; set; }

    public string? In128PreAdmitCertPac { get; set; }

    public DateTime? In129VerificationDateTime { get; set; }

    public string? In1300VerificationByIdnumber { get; set; }

    public string? In1301VerificationByFamilyName { get; set; }

    public string? In1302VerificationByGivenName { get; set; }

    public string? In131TypeOfAgreementCode { get; set; }

    public string? In132BillingStatus { get; set; }

    public decimal? In133LifetimeReserveDays { get; set; }

    public decimal? In134DelayBeforeLrday { get; set; }

    public string? In135CompanyPlanCode { get; set; }

    public string? In136PolicyNumber { get; set; }

    public decimal? In13700PolicyDeductiblePriceQuantity { get; set; }

    public string? In138PolicyLimitAmount { get; set; }

    public decimal? In139PolicyLimitDays { get; set; }

    public string? In140RoomRateSemiPrivate { get; set; }

    public string? In141RoomRatePrivate { get; set; }

    public string? In1420InsuredsEmploymentStatusIdentifier { get; set; }

    public string? In143InsuredsAdministrativeSex { get; set; }

    public string? In1440InsuredsEmployersAddressStreetAddress { get; set; }

    public string? In1441InsuredsEmployersAddressOtherDesignation { get; set; }

    public string? In1442InsuredsEmployersAddressCity { get; set; }

    public string? In1443InsuredsEmployersAddressStateOrProvince { get; set; }

    public string? In1444InsuredsEmployersAddressZipOrPostalCode { get; set; }

    public string? In1445InsuredsEmployersAddressCountry { get; set; }

    public string? In145VerificationStatus { get; set; }

    public string? In146PriorInsurancePlanId { get; set; }

    public string? In147CoverageType { get; set; }

    public string? In148Handicap { get; set; }

    public string? In1490InsuredsIdnumberIdnumber { get; set; }

    public DateTime DateTimeInserted { get; set; }
}
