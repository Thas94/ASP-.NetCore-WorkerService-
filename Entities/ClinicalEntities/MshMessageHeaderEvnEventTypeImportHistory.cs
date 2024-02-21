using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class MshMessageHeaderEvnEventTypeImportHistory
{
    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public string OriginalMessage { get; set; } = null!;

    public string Msh1FieldSeparator { get; set; } = null!;

    public string Msh2EncodingCharacters { get; set; } = null!;

    public string? Msh3SendingApplication { get; set; }

    public string? Msh40SendingFacilityNameSpace { get; set; }

    public string? Msh41SendingFacilityUniversalId { get; set; }

    public string? Msh5ReceivingApplication { get; set; }

    public string? Msh6ReceivingFacility { get; set; }

    public DateTime Msh7DateTimeofMessage { get; set; }

    public string? Msh8Security { get; set; }

    public string Msh90MessageTypeMessageCode { get; set; } = null!;

    public string Msh91MessageTypeTriggerEvent { get; set; } = null!;

    public string Msh10MessageControlId { get; set; } = null!;

    public string Msh11ProcessingId { get; set; } = null!;

    public string Msh12VersionId { get; set; } = null!;

    public string? Evn1EventTypeCode { get; set; }

    public DateTime Evn2RecordedDateTime { get; set; }

    public DateTime? Evn3DateTimePlannedEvent { get; set; }

    public string? Evn4EventReasonCode { get; set; }

    public string? Evn5OperatorId { get; set; }

    public DateTime? Evn6EventOccurred { get; set; }

    public string? Evn7EventFacility { get; set; }

    public DateTime DateTimeInserted { get; set; }
}
