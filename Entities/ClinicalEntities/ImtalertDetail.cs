using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtalertDetail
{
    public int ArlertDetailStatusId { get; set; }

    public int AlertId { get; set; }

    public int? AtcdrugId { get; set; }

    public DateTime? AtcobservationDrugStartDateTime { get; set; }

    public DateTime? LabObservationDate { get; set; }

    public string? LabUniversalServiceDentifierIdentifier { get; set; }

    public string? LabUniversalServiceIdentifierText { get; set; }

    public string? LabSpecimen { get; set; }

    public string? LabObservationIdentifier { get; set; }

    public string? LabObservationIdentifierText { get; set; }

    public string? LabReferenceRange { get; set; }

    public string? LabObservationValue { get; set; }

    public string? LabObservationValueUnits { get; set; }

    public string? LabAbnormalFlags { get; set; }

    public string Rxeatcdrug { get; set; } = null!;

    public string? RxeatcobservationDrugValue { get; set; }

    public string? RxeatcobservationDrugValueUnits { get; set; }

    public DateTime? RxeatcobservationDrugStartDateTime { get; set; }

    public DateTime? DayCountSinceAtcobservationDrugStartDateTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? AssociatedObrdrugSensitivityId { get; set; }

    public virtual ImtalertHeader Alert { get; set; } = null!;
}
