using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Models.Enum
{
    // For SelectBox
    public enum ShapeType
    {
        [Description("Circle")]
        Circle = 1,

        [Description("Ellipse")]
        Ellipse = 2,

        [Description("Polygon")]
        Polygon = 3,

        [Description("Square")]
        Square = 4
    }
}
