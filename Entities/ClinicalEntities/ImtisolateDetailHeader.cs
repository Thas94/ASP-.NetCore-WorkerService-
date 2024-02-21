using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateDetailHeader
{
    public int IsolateDetailHeaderId { get; set; }

    public int IsolateId { get; set; }

    public int PkObrId { get; set; }

    public string? Obr41UniversalServiceDentifierIdentifier { get; set; }

    public string? Obr42UniversalServiceIdentifierText { get; set; }

    public DateTime? Obr71ObservationDateTimeTimeOfEvent { get; set; }

    public string? Obr1511SpecimenSourceSpecimenSourceNameOrCodeIdentifier { get; set; }

    public virtual ICollection<ImtisolateDetail> ImtisolateDetails { get; set; } = new List<ImtisolateDetail>();

    public virtual ImtisolateHeader Isolate { get; set; } = null!;
}
