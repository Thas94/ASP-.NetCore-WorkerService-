using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditDay
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int Day { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<AbsAuditAnswer> AbsAuditAnswers { get; set; } = new List<AbsAuditAnswer>();

    public virtual ICollection<AbsAuditDrugDefaultQuestion> AbsAuditDrugDefaultQuestions { get; set; } = new List<AbsAuditDrugDefaultQuestion>();

    public virtual ICollection<AbsAuditQuestionDrug> AbsAuditQuestionDrugs { get; set; } = new List<AbsAuditQuestionDrug>();

    public virtual ICollection<AbsAuditQuestionOption> AbsAuditQuestionOptions { get; set; } = new List<AbsAuditQuestionOption>();
}
