using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Device
{
    public int Id { get; set; }

    public string? DeviceSerialNumber { get; set; }

    public int DeviceTypeId { get; set; }

    public int? IndicationId { get; set; }

    public int? SiteId { get; set; }

    public int? SideId { get; set; }

    public int? SubTypeId { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual DeviceType DeviceType { get; set; } = null!;

    public virtual ICollection<ImtdeviceAuditing> ImtdeviceAuditings { get; set; } = new List<ImtdeviceAuditing>();

    public virtual ICollection<PatientWardDevice> PatientWardDevices { get; set; } = new List<PatientWardDevice>();

    public virtual ICollection<SapwardDevice> SapwardDevices { get; set; } = new List<SapwardDevice>();
}
