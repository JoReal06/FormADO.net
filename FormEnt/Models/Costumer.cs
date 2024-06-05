using System;
using System.Collections.Generic;

namespace FormEnt.Models;

public partial class Costumer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;
}
