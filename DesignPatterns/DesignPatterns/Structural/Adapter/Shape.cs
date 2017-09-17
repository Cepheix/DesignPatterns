﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public interface Shape
    {
        void BoundingBox();
        void CreateManipulator();
    }
}
