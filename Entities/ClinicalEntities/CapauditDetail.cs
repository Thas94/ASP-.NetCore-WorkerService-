using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CapauditDetail
{
    public int Id { get; set; }

    public int AuditId { get; set; }

    public string? PatientIdNumber { get; set; }

    public string? PmiNumber { get; set; }

    public int CapStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual ICollection<CapauditAnswer> CapauditAnswers { get; set; } = new List<CapauditAnswer>();
}
