﻿using System;
using System.Collections.Generic;

namespace DienappApi.Models;

public partial class Jobcategory
{
    public int Jobcategoryid { get; set; }

    public string? Jobcategoryname { get; set; }

    public string? Description { get; set; }

    public string? Imagepath { get; set; }

    public string? Status { get; set; }

    public DateTime? Createddate { get; set; }
}
