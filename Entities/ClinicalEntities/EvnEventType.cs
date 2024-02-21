using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class EvnEventType
{
    public int LogId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public string? Evn1EventTypeCode { get; set; }

    public DateTime Evn2RecordedDateTime { get; set; }

    public DateTime? Evn3DateTimePlannedEvent { get; set; }

    public string? Evn4EventReasonCode { get; set; }

    public string? Evn51OperatorIdnumber { get; set; }

    public string? Evn521FamilyNameSurname { get; set; }

    public string? Evn522FamilyNameOwnSurnamePrefix { get; set; }

    public string? Evn523FamilyNameOwnSurname { get; set; }

    public string? Evn524FamilyNamePrefixFromPartnerSpouse { get; set; }

    public string? Evn525FamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Evn53GivenName { get; set; }

    public string? Evn54SecondAndFurtherGivenNamesOrInitialsThereOf { get; set; }

    public string? Evn55Suffix { get; set; }

    public string? Evn56Prefix { get; set; }

    public string? Evn57Degree { get; set; }

    public string? Evn58SourceTable { get; set; }

    public string? Evn591AssigningAuthorityNamespaceId { get; set; }

    public string? Evn592AssigningAuthorityUniversalId { get; set; }

    public string? Evn593AssigningAuthorityUniversalIdtype { get; set; }

    public string? Evn510NameTypeCode { get; set; }

    public string? Evn511IdentifierCheckDigit { get; set; }

    public string? Evn512CodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Evn513IdentifierTypeCode { get; set; }

    public string? Evn5141AssigningFacilityNamespaceId { get; set; }

    public string? Evn5142AssigningFacilityUniversalId { get; set; }

    public string? Evn5143AssigningFacilityUniversalIdtype { get; set; }

    public string? Evn515NameRepresentationCode { get; set; }

    public string? Evn15161NameContextIdentifier { get; set; }

    public string? Evn15162NameContextText { get; set; }

    public string? Evn15163NameContextNameOfCodingSystem { get; set; }

    public string? Evn15164NameContextAlternateIdentifier { get; set; }

    public string? Evn15165NameContextAlternateText { get; set; }

    public string? Evn15166NameContextNameOfAlternateCodingSystem { get; set; }

    public DateTime? Evn5171RangeStartDateTime { get; set; }

    public DateTime? Evn5172RangeEndDateTime { get; set; }

    public string? Evn518NameAssemblyOrder { get; set; }

    public DateTime? Evn6EventOccurred { get; set; }

    public string? Evn71EventFacilityNamespaceId { get; set; }

    public string? Evn72EventFacilityUniversalId { get; set; }

    public string? Evn73EventFacilityUniversalIdtype { get; set; }

    public DateTime DateTimeInserted { get; set; }

    public string? Evn7EventFacility { get; set; }
}
