using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class PidPatientIdentificationImportHistory
{
    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public long? Pid1SetIdpid { get; set; }

    public string? Pid2PatientId { get; set; }

    public string Pid3PatientIdentifierList { get; set; } = null!;

    public string? Pid4AlternatePatientId { get; set; }

    public string? Pid50PatientNameFamilyName { get; set; }

    public string? Pid51PatientNameGivenName { get; set; }

    public string? Pid52PatientNameSecondNamesOrInitials { get; set; }

    public string? Pid53PatientNameSuffix { get; set; }

    public string? Pid54PatientNamePrefix { get; set; }

    public string? Pid6MothersMaidenName { get; set; }

    public DateTime? Pid7DateTimeOfBirth { get; set; }

    public string? Pid8AdministrativeSex { get; set; }

    public string? Pid9PatientAlias { get; set; }

    public string? Pid10Race { get; set; }

    public string? Pid110PatientAddressStreetAddress { get; set; }

    public string? Pid111PatientAddressOtherDesignation { get; set; }

    public string? Pid112PatientAddressCity { get; set; }

    public string? Pid113PatientAddressProvince { get; set; }

    public string? Pid114PatientAddressPostalCode { get; set; }

    public string? Pid115PatientAddressCountry { get; set; }

    public string? Pid12CountyCode { get; set; }

    public string? Pid130PhoneNumberHome { get; set; }

    public string? Pid131PhoneNumberHome { get; set; }

    public string? Pid132PhoneNumberHome { get; set; }

    public string? Pid14PhoneNumberBusiness { get; set; }

    public string? Pid15PrimaryLanguage { get; set; }

    public string? Pid16MaritalStatus { get; set; }

    public string? Pid17Religion { get; set; }

    public string? Pid18PatientAccountNumber { get; set; }

    public string? Pid19SsnnumberPatient { get; set; }

    public string? Pid20DriversLicenseNumberPatient { get; set; }

    public string? Pid21MothersIdentifier { get; set; }

    public string? Pid22EthnicGroup { get; set; }

    public string? Pid23BirthPlace { get; set; }

    public string? Pid24MultipleBirthIndicator { get; set; }

    public string? Pid25BirthOrder { get; set; }

    public string? Pid26Citizenship { get; set; }

    public string? Pid27VeteransMilitaryStatus { get; set; }

    public string? Pid28Nationality { get; set; }

    public DateTime? Pid29PatientDeathDateTime { get; set; }

    public string? Pid30PatientDeathIndicator { get; set; }

    public DateTime DateTimeInserted { get; set; }

    public string? Pid19PSsnnumberPatientPatch { get; set; }
}
