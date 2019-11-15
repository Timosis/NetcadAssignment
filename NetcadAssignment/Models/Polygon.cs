using NetcadAssignment.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Models
{
    public class Polygon : Shape
    {
        public double NumberOfSide { get; set; }

        public double LengthOfASide { get; set; }

        public Polygon(double numberOfSide, double lengthOfASide,
              ShapeType shapeType, bool isFilled,
              char key, Color color, int borderThickness,
              Color borderColor, int xCoordinate, int yCoordinate) :
              base(shapeType, isFilled, key, color, borderThickness, borderColor, xCoordinate, yCoordinate)
        {
            this.NumberOfSide = numberOfSide;
            this.LengthOfASide = lengthOfASide;
        }
    }
}
