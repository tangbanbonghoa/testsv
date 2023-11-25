﻿using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Trungtam
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public string? Diachi { get; set; }

    public virtual ICollection<Cuahang> Cuahangs { get; set; } = new List<Cuahang>();
}
