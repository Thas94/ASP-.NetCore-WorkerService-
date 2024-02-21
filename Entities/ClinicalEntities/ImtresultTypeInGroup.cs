﻿using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtresultTypeInGroup
{
    public int ResultTypeId { get; set; }

    public int ResultTypeGroupId { get; set; }

    public string ResultTypeName { get; set; } = null!;

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? LabId { get; set; }

    public int? MarkedForNotifications { get; set; }
}
