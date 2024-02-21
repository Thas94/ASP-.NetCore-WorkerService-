using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateSpecimenQuestion
{
    public int SpecimenQuestionId { get; set; }

    public int SpecimenGroupId { get; set; }

    public int QuestionId { get; set; }

    public int IsolateCategoryId { get; set; }

    public bool Required { get; set; }
}
