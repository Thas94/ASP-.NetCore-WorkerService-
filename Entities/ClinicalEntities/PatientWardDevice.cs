using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class PatientWardDevice
{
    public int PatientWardDeviceId { get; set; }

    public string? CaseNumber { get; set; }

    public string? PmiNumber { get; set; }

    public string? WardNumber { get; set; }

    public string? Bed { get; set; }

    public string? Room { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? SiteId { get; set; }

    public string? StopReason { get; set; }

    public int? DeviceId { get; set; }

    public int? AuditId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? EndDateUserInput { get; set; }

    public string? EndDateUpdatedBy { get; set; }

    public DateTime? EndDateBeforeDischarge { get; set; }

    public string? StopReasonBeforeDischarge { get; set; }

    public DateTime? UpdatedDateBeforeDischarge { get; set; }

    public string? UpdatedByBeforeDischarge { get; set; }

    public int? IsActiveBeforeDischarge { get; set; }

    public bool? IsAddedInTheatre { get; set; }

    public virtual ImtdeviceAuditing? Audit { get; set; }

    public virtual Device? Device { get; set; }
}
