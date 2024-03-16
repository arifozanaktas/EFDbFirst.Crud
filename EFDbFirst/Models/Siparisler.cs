using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class Siparisler
{
    public int OrderId { get; set; }

    public string SirketAd { get; set; } = null!;

    public DateTime? OrderDate { get; set; }
}
