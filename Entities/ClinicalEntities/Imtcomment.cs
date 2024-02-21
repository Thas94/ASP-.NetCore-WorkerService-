using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtcomment
{
    public int CommentId { get; set; }

    public int ContentId { get; set; }

    public int ContentType { get; set; }

    public int CommentTypeId { get; set; }

    public string? Comment { get; set; }

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CaseNumber { get; set; }

    public string? PmiNumber { get; set; }
}
