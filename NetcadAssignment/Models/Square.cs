using NetcadAssignment.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Models
{
    public class Square : Shape
    {
        public double LengthOfASide { get; set; }

        public Square(double lengthOfASide,
            ShapeType shapeType, bool isFilled,
            char key, Color color, int borderThickness,
            Color borderColor, int xCoordinate, int yCoordinate) :
            base(shapeType, isFilled, key, color, borderThickness, borderColor, xCoordinate, yCoordinate)
        {
            this.LengthOfASide = lengthOfASide;
        }
    }
}
