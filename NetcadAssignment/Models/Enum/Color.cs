using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Models.Enum
{
    public enum Color
    {
        [Description("Red")]
        Red = 1,

        [Description("Blue")]
        Blue = 2,

        [Description("Green")]
        Green = 3,

        [Description("Orange")]
        Orange = 4,

        [Description("Yellow")]
        Yellow = 5,

        [Description("Purple")]
        Purple = 6,

        [Description("Black")]
        Black = 7,
    }
}
