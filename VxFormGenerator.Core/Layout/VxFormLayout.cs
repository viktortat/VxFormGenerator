﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VxFormGenerator.Core.Layout
{
    public class VxFormLayoutAttribute : Attribute
    {
        public int ColSpan { get; set; }

        public int RowId { get; set; }

        public string Label { get; set; }

        public int Order { get; set; }
    }

    public class VxFormGroupAttribute : Attribute
    {
        public string Label { get; set; }
        public int Order { get; set; }
    }
}
