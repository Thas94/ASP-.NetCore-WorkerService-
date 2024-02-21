using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditQuestionOption
{
    public int Id { get; set; }

    public int DayId { get; set; }

    public int? DefaultQuestionId { get; set; }

    public int? QuestionDrugId { get; set; }

    public int QuestionOptionLookupId { get; set; }

    public bool IsDeleted { get; set; }

    public bool CreateIntervention { get; set; }

    public bool IsDefaultValue { get; set; }

    public virtual ICollection<AbsAuditQuestionMandatoryValidation> AbsAuditQuestionMandatoryValidations { get; set; } = new List<AbsAuditQuestionMandatoryValidation>();

    public virtual AbsAuditDay Day { get; set; } = null!;

    public virtual AbsAuditDrugDefaultQuestion? DefaultQuestion { get; set; }

    public virtual AbsAuditQuestionDrug? QuestionDrug { get; set; }

    public virtual AbsAuditQuestionOptionLookup QuestionOptionLookup { get; set; } = null!;
}
