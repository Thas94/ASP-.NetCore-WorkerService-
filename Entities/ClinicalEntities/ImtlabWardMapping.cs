using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtlabWardMapping
{
    public int Id { get; set; }

    public string LabWardCode { get; set; } = null!;

    public string LabWardName { get; set; } = null!;

    public string? LabHospital { get; set; }

    public string? SapWardCode { get; set; }

    public string? SapWardName { get; set; }

    public string? SapHospital { get; set; }

    public int LabId { get; set; }
}
