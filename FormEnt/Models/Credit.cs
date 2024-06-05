using System;
using System.Collections.Generic;

namespace FormEnt.Models;

public partial class Credit
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int CustomerId { get; set; }

    public byte[] TimeStamp { get; set; } = null!;
}
