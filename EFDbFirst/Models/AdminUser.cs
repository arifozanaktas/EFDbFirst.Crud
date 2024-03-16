using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class AdminUser
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }
}
