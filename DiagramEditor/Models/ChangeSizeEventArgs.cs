﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramEditor.Models
{
    public class ChangeSizeEventArgs
    {
        public double OldSize { get; set; }
        public double NewSize { get; set; }
    }
}
