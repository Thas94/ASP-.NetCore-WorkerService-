using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtscheduler
{
    public int SchedulerId { get; set; }

    public int SchedulerTypeId { get; set; }

    public int ItemId { get; set; }

    public bool RunWeekly { get; set; }

    public bool RunMonthly { get; set; }

    public bool Monday { get; set; }

    public bool Tuesday { get; set; }

    public bool Wednesday { get; set; }

    public bool Thursday { get; set; }

    public bool Friday { get; set; }

    public bool Saturday { get; set; }

    public bool Sunday { get; set; }

    public bool? RunEveryDay { get; set; }

    public TimeSpan? ExcutionTime { get; set; }

    public bool Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
