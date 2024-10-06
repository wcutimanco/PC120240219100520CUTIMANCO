﻿using System;
using System.Collections.Generic;

namespace PC120240219100520CUTIMANCO.DOMAIN.Core.Entities;

public partial class Organizers
{
    public int Id { get; set; }

    public string OrganizerName { get; set; } = null!;

    public string ContactEmail { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Events> Events { get; set; } = new List<Events>();
}
