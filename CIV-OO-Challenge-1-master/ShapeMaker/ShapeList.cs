using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Shapes;

namespace ShapeMaker
{
    class ShapeList
    {
        List<Square> squares;
        List<Rectangle> rectangles;

        public ShapeList() {
            squares = new List<Square>();
            rectangles = new List<Rectangle>();
        }
        public void DisplayAllShapes() {
            DisplaySquares();
            DisplayRectangles();
        }

        public void DisplaySquares() {
            DisplaySeperator();
            try
            {
                if (squares.Count < 1)
                {
                    throw (new LengthLessThanOneException("Length of square list less than one"));
                }
                else
                {
                    Console.WriteLine("Current Squares");
                    for (int i = 0; i < squares.Count; i++)
                    {
                        Console.WriteLine("Square " + i + ": Colour: " + squares[i].Colour + " SideLength = " + squares[i].Side1Length);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        }

        public void DisplayRectangles() {
            DisplaySeperator();
            try
            {
                if (rectangles.Count < 1)
                {
                    throw (new LengthLessThanOneException("Length of rectangle list less than one"));
                }
                else
                {
                    Console.WriteLine("Current Rectangles");
                    for (int i = 0; i < squares.Count; i++)
                    {
                        Console.WriteLine("Square " + i + ": Colour: " + rectangles[i].Colour + " Side1Length = " + rectangles[i].Side1Length + "Side2Length = " + rectangles[i].Side2Length);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DisplaySeperator() {
           Console.WriteLine(string.Concat(Enumerable.Repeat("-", Console.BufferWidth)));
        }

        public int AddLength(string message) {
            Console.WriteLine(message);
            int x = 0;
            //remember to catch more specific exceptions
            //also probably a much better way to do this
            try
            {
                x = int.Parse(Console.ReadLine());

                if (x < 1)
                {
                    throw (new LengthLessThanOneException("Side Length less than 1 Exception"));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return 0;
            }

            return x;

        }

        public string AddColour(string message) {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public void AddSquare(){
            Console.Clear();
            int x = AddLength("What is the length of your square?");
            if (x < 1) {
                return;
            }
            squares.Add(new Square(AddColour("What colour Would you like your square?"), x));
        }

        public void AddRectangle() {
            Console.Clear();
            int x = AddLength("What is the length of your first side");
            if (x < 1)
            {
                return;
            }
            int y = AddLength("What is the length of your second side");
            if (y < 1)
            {
                return;
            }
            rectangles.Add(new Rectangle(AddColour("What colour Would you like your rectangle?"), x, y));
        }

        public void DisplaySInput() {
            Console.Clear();
            DisplaySquares();
            Console.ReadLine();
        }

        public void DisplayRInput() {
            Console.Clear();
            DisplayRectangles();
            Console.ReadLine();
        }

        public void DisplayAInput() {
            Console.Clear();
            DisplayAllShapes();
            Console.ReadLine();
        }

    }
}
