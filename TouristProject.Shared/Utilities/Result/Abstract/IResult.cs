﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristProject.Shared.Utilities.Result.Abstract
{
    public interface IResult
    {

        bool Success { get; }
        string? Message { get; }

    }
}
