using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtdeviceAuditing
{
    public int DeviceAuditingId { get; set; }

    public int? DeviceId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? AuditDescription { get; set; }

    public string? CaseNumber { get; set; }

    public virtual Device? Device { get; set; }

    public virtual ICollection<PatientWardDevice> PatientWardDevices { get; set; } = new List<PatientWardDevice>();
}
