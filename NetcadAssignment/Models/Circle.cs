using NetcadAssignment.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius,
            ShapeType shapeType, bool isFilled,
            char key, Color color, int borderThickness,
            Color borderColor, int xCoordinate, int yCoordinate) : 
            base(shapeType, isFilled, key, color, borderThickness, borderColor, xCoordinate, yCoordinate)
        {
            this.Radius = radius;
        }
    }
}
