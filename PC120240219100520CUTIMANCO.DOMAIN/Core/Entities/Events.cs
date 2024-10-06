﻿using System;
using System.Collections.Generic;

namespace PC120240219100520CUTIMANCO.DOMAIN.Core.Entities;

public partial class Events
{
    public int Id { get; set; }

    public int? OrganizerId { get; set; }

    public string EventName { get; set; } = null!;

    public DateTime EventDate { get; set; }

    public string Location { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<EventAttendance> EventAttendance { get; set; } = new List<EventAttendance>();

    public virtual Organizers? Organizer { get; set; }
}
