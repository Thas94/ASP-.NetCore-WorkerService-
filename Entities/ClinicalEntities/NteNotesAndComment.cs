using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class NteNotesAndComment
{
    public int PkNteId { get; set; }

    public int? FkObxId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public long Nte1Setidnte { get; set; }

    public string? Nte2SourceofComment { get; set; }

    public string? Nte3Comment { get; set; }

    public string? Nte4CommentType { get; set; }

    public string? Nte41CommentTypeIdentifier { get; set; }

    public string? Nte42CommentTypeText { get; set; }

    public string? Nte43CommentTypeNameOfCodingSystem { get; set; }

    public string? Nte44CommentTypeAlternateIdentifier { get; set; }

    public string? Nte45NameOfAlternateCodingSystem { get; set; }

    public int? FkObrId { get; set; }

    public virtual ObrObservationRequest? FkObr { get; set; }

    public virtual ObxObservationResult? FkObx { get; set; }
}
