using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtabsmonitoring
{
    public int MonitorRuleId { get; set; }

    public string PatientIdnumber { get; set; } = null!;

    public string Pminumber { get; set; } = null!;

    public string CaseNo { get; set; } = null!;

    public int AtcdrugId { get; set; }

    public DateTime? AtcobservationDrugStartDateTime { get; set; }

    public string? LabObservationIdentifier { get; set; }

    public string? LabObservationIdentifierText { get; set; }

    public string? LabReferenceRange { get; set; }

    public string? LabObservationValue { get; set; }

    public string? LabObservationValueUnits { get; set; }

    public string? Rxeatcdrug { get; set; }

    public string? RxeatcobservationDrugValue { get; set; }

    public string? RxeatcobservationDrugValueUnits { get; set; }

    public DateTime? RxeatcobservationDrugStartDateTime { get; set; }

    public int DayCountSinceAtcobservationDrugStartDateTime { get; set; }

    public int? ExtentionDayCount { get; set; }

    public int FlagId { get; set; }
}
