using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtapiuser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Active { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public int? TokenIsActive { get; set; }

    public string? Token { get; set; }

    public DateTime? ExpireyDate { get; set; }

    public int? RoleId { get; set; }
}
