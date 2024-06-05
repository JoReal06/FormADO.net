using System;
using System.Collections.Generic;

namespace FormEnt.Models;

public partial class Make
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
