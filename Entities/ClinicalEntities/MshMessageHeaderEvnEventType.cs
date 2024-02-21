using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class MshMessageHeaderEvnEventType
{
    public int LogId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public string OriginalMessage { get; set; } = null!;

    public string? Msh1FieldSeparator { get; set; }

    public string? Msh2EncodingCharacters { get; set; }

    public string? Msh3SendingApplication { get; set; }

    public string? Msh31SendingApplicationNamespaceId { get; set; }

    public string? Msh32SendingApplicationUniversalId { get; set; }

    public string? Msh33SendingApplicationUniversalIdType { get; set; }

    public string? Msh40SendingFacilityNameSpace { get; set; }

    public string? Msh41SendingFacilityUniversalId { get; set; }

    public string? Msh42SendingFacilityUniversalIdtype { get; set; }

    public string? Msh5ReceivingApplication { get; set; }

    public string? Msh50ReceivingApplicationNamespaceId { get; set; }

    public string? Msh51ReceivingApplicationUniversalId { get; set; }

    public string? Msh52ReceivingApplicationUniversalIdType { get; set; }

    public string? Msh6ReceivingFacility { get; set; }

    public string? Msh60ReceivingFacilityNamespaceId { get; set; }

    public string? Msh61ReceivingFacilityUniversalId { get; set; }

    public string? Msh62ReceivingFacilityUniversalIdType { get; set; }

    public DateTime Msh7DateTimeofMessage { get; set; }

    public string? Msh8Security { get; set; }

    public string? Msh90MessageTypeMessageCode { get; set; }

    public string? Msh91MessageTypeTriggerEvent { get; set; }

    public string? Msh92MessageTypeMessageStructure { get; set; }

    public string? Msh10MessageControlId { get; set; }

    public string? Msh11ProcessingId { get; set; }

    public string? Msh12VersionId { get; set; }

    public string? Msh13SequenceNumber { get; set; }

    public string? Msh14ContinuationPointer { get; set; }

    public string? Msh15AcceptAcknowledgmentType { get; set; }

    public string? Msh16ApplicationAcknowledgmentType { get; set; }

    public string? Msh17CountryCode { get; set; }

    public string? Msh190PrincipalLanguageOfMessageIdentifier { get; set; }

    public string? Msh191PrincipalLanguageOfMessageText { get; set; }

    public string? Msh192PrincipalLanguageOfMessageNameOfCodingSystem { get; set; }

    public string? Msh193PrincipalLanguageOfMessageAlternateIdentifier { get; set; }

    public string? Msh194PrincipalLanguageOfMessageAlternateText { get; set; }

    public string? Msh195PrincipalLanguageOfMessageNameOfAlternateCodingSystem { get; set; }

    public string? Msh20AlternateCharacterSetHandlingScheme { get; set; }

    public string? Evn1EventTypeCode { get; set; }

    public DateTime? Evn3DateTimePlannedEvent { get; set; }

    public string? Evn4EventReasonCode { get; set; }

    public string? Evn5OperatorId { get; set; }

    public DateTime? Evn6EventOccurred { get; set; }

    public string? Evn7EventFacility { get; set; }

    public DateTime DateTimeInserted { get; set; }

    public DateTime? Evn2RecordedDateTime { get; set; }
}
