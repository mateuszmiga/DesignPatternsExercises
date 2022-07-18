﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface IGeoCalculator
    {
        public string CalculateArea();
        public string CalculatePerimeter();

    }
}
