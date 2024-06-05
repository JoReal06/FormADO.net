﻿using System;
using System.Collections.Generic;

namespace FormEnt.Models;

public partial class Inventory
{
    public int Id { get; set; }

    public int MakeId { get; set; }

    public string Color { get; set; } = null!;

    public string PetName { get; set; } = null!;

    public byte[]? TimeStamp { get; set; }

    public virtual Make Make { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
