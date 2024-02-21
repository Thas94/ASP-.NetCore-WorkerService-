using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class PharmacyAtcCode
{
    public string? L1Code { get; set; }

    public string? L1Description { get; set; }

    public string? L2Code { get; set; }

    public string? L2Description { get; set; }

    public string? L3Code { get; set; }

    public string? L3Description { get; set; }

    public string? L4Code { get; set; }

    public string? L4Description { get; set; }

    public string L5Code { get; set; } = null!;

    public string? L5Description { get; set; }

    public int Pharmacycodeid { get; set; }
}
