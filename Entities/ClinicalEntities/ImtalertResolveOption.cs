using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtalertResolveOption
{
    public int AlertStatusId { get; set; }

    public int FlagId { get; set; }

    public int SpecimenId { get; set; }

    public int OrganismId { get; set; }

    public int DeviceId { get; set; }

    public int ResultStatusId { get; set; }

    public string CaseNo { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
