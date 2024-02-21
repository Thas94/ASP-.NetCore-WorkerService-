using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditQuestion
{
    public int Id { get; set; }

    public string Question { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool RequiresTextAnswer { get; set; }

    public virtual ICollection<AbsAuditAnswer> AbsAuditAnswers { get; set; } = new List<AbsAuditAnswer>();

    public virtual ICollection<AbsAuditDrugDefaultQuestion> AbsAuditDrugDefaultQuestions { get; set; } = new List<AbsAuditDrugDefaultQuestion>();

    public virtual ICollection<AbsAuditQuestionDrug> AbsAuditQuestionDrugs { get; set; } = new List<AbsAuditQuestionDrug>();

    public virtual ICollection<AbsAuditQuestionMandatoryValidation> AbsAuditQuestionMandatoryValidations { get; set; } = new List<AbsAuditQuestionMandatoryValidation>();
}
