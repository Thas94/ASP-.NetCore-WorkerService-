using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CapauditQuestion
{
    public int Id { get; set; }

    public string Question { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool RequiresTextAnswer { get; set; }

    public bool? IsMultiSelect { get; set; }

    public int? FieldType { get; set; }

    public virtual ICollection<CapauditAnswer> CapauditAnswers { get; set; } = new List<CapauditAnswer>();

    public virtual ICollection<CapauditQuestionCategory> CapauditQuestionCategories { get; set; } = new List<CapauditQuestionCategory>();

    public virtual ICollection<CapauditQuestionOption> CapauditQuestionOptions { get; set; } = new List<CapauditQuestionOption>();

    public virtual ICollection<CapauditSelectableOption> CapauditSelectableOptions { get; set; } = new List<CapauditSelectableOption>();
}
