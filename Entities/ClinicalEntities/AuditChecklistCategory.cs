using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AuditChecklistCategory
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public int ContentType { get; set; }

    public virtual ICollection<CapauditAnswer> CapauditAnswers { get; set; } = new List<CapauditAnswer>();

    public virtual ICollection<CapauditQuestionCategory> CapauditQuestionCategories { get; set; } = new List<CapauditQuestionCategory>();

    public virtual ICollection<CapauditQuestionOption> CapauditQuestionOptions { get; set; } = new List<CapauditQuestionOption>();
}
