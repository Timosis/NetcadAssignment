using NetcadAssignment.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Models
{
    public class ShapeVm
    {        
        public ShapeType ShapeType { get; set; }
        public string Color { get; set; }
        public char Key { get; set; }
        public bool IsFilled { get; set; }
        public double LengthA { get; set; }
        public double LengthB { get; set; }
        public int BorderThickness { get; set; }
        public Color BorderColor { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
    }
}
