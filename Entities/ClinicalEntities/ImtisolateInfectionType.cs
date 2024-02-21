﻿using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateInfectionType
{
    public int IsolateInfectionTypeId { get; set; }

    public string IsolateInfectionType { get; set; } = null!;

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
