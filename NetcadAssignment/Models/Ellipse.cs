using NetcadAssignment.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Models
{
    public class Ellipse : Shape
    {
        public double RadiusA { get; set; }
        public double RadiusB { get; set; }


        public Ellipse(double radiusA,double radiusB,
            ShapeType shapeType, bool isFilled,
            char key, Color color, int borderThickness,
            Color borderColor, int xCoordinate, int yCoordinate) :
            base(shapeType, isFilled, key, color, borderThickness, borderColor, xCoordinate, yCoordinate)
        {
            this.RadiusA = radiusA;
            this.RadiusB = radiusB;
        }
    }
}
