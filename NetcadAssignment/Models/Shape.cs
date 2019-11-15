using NetcadAssignment.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Models
{
    public class Shape
    {
        // Bütün entityler tek bir dosya ya yazılacağından, şekli sorgulamada kolaylık için ek alan olarak tanımlandı.
        public ShapeType Type { get; set; }
        public bool IsFilled { get; set; }
        public char Key { get; set; }
        public Color Color { get; set; }
        public int BorderThickness { get; set; }
        public Color BorderColor { get; set; }
        public int PointX { get; set; }
        public int PointY { get; set; }


        public Shape(ShapeType shapeType, bool isFilled,
               char key, Color color, int borderThickness, Color borderColor, int xCoordinate, int yCoordinate)
        {
            this.Type = shapeType;
            this.IsFilled = isFilled;
            this.Key = key;
            this.Color = color;
            this.BorderThickness = borderThickness;
            this.BorderColor = borderColor;
            this.PointX = xCoordinate;
            this.PointY = yCoordinate;
        }


    }
}
