using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class WebUser
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }
}
