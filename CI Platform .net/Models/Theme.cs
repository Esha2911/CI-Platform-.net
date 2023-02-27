using System;
using System.Collections.Generic;

namespace CI_Platform_.net.Models;

public partial class Theme
{
    public long ThemeId { get; set; }

    public string Title { get; set; } = null!;

    public byte Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<Mission> Missions { get; } = new List<Mission>();
}
