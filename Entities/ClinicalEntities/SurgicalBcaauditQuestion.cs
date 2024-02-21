using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class SurgicalBcaauditQuestion
{
    public int QuestionId { get; set; }

    public int HeadingId { get; set; }

    public string Text { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<SurgicalBcaauditAnswer> SurgicalBcaauditAnswers { get; set; } = new List<SurgicalBcaauditAnswer>();
}
