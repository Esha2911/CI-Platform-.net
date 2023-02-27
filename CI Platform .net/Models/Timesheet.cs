using System;
using System.Collections.Generic;

namespace CI_Platform_.net.Models;

public partial class Timesheet
{
    public long TimesheetId { get; set; }

    public long UserId { get; set; }

    public long MissionId { get; set; }

    public DateTime? Time { get; set; }

    public int? Action { get; set; }

    public DateTime DateVolunteer { get; set; }

    public string? Notes { get; set; }

    public bool Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Mission Mission { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
