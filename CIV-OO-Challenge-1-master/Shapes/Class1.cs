using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//these should probably all have their own file
namespace Shapes
{
    public abstract class Shape
    {
        public string Colour { get; set; }

        public Shape(string pColour)
        {
            Colour = pColour;
        }
    }

    public class Quadrilateral : Shape
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }
        public int Side4Length { get; set; }

        public Quadrilateral(string pColour, int pSide1Length, int pSide2Length, int pSide3Length, int pSide4Length) : base(pColour)
        {
            Side1Length = pSide1Length;
            Side2Length = pSide2Length;
            Side3Length = pSide3Length;
            Side4Length = pSide4Length;
        }

        public int GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length + Side4Length;
        }
    }

    public class Square : Quadrilateral
    {
        public Square(string pColour, int pSide1Length) : base(pColour, pSide1Length, pSide1Length, pSide1Length, pSide1Length) { }

        public int GetArea()
        {
            return Side1Length * Side1Length;
        }
    }

    public class Rectangle : Quadrilateral
    {
        public Rectangle(string pColour, int pSide1Length, int pSide2Length) : base(pColour, pSide1Length, pSide2Length, pSide1Length, pSide2Length) { }

        public int GetArea()
        {
            return Side1Length * Side2Length;
        }
    }

    public class Triangle : Shape
    {
        public float Side1Length { get; set; }
        public float Side2Length { get; set; }
        public float Side3Length { get; set; }

        public Triangle(string pColour) : base(pColour) { }

        public float GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }
    }

    public class RightAngleTriangle : Triangle
    {
        public RightAngleTriangle(string pColour, float pSide1Length, float pSide2Length) : base(pColour)
        {
            Side1Length = pSide1Length;
            Side2Length = pSide2Length;
            Side3Length = (float)Math.Sqrt((pSide1Length * pSide1Length) + (pSide2Length * pSide2Length));
        }

        public float GetArea() {
            return (0.5f * Side1Length * Side2Length);
        }
    }

    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(string pColour, float pSide1Length) : base(pColour)
        {
            Side1Length = pSide1Length;
            Side2Length = pSide1Length;
            Side3Length = pSide1Length;
        }

        public float GetArea() {
            return (float)Math.Sqrt(3)/4 * Side1Length * Side1Length;
        }
    }
}
