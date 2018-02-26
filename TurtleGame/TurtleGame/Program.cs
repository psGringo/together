using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();

            GraphicsWindow.BrushColor = "Red"; // выбираем красный цвет
            var eat = Shapes.AddRectangle(10, 10); // рисуем квадрат
            int x = 200;
            int y = 200;
            Shapes.Move(eat, x, y); // ставим eat в координаты x, y

            Random rand = new Random();

            int Level = 1;
            Console.WriteLine("Level " + Level);

            while (true)
            {
                Turtle.Move(10);
 
                if ((Turtle.X >= x && Turtle.X <= x + 10) && (Turtle.Y >= y && Turtle.Y <= y + 10))
                {
                    x = rand.Next(0, GraphicsWindow.Width);
                    y = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(eat, x, y);
                    Turtle.Speed++;
                    Level++;
                    Console.WriteLine("Level "+Level);
                }

                if (Level == 12) break;

                Grence(Turtle.X, Turtle.Y, GraphicsWindow.Height, GraphicsWindow.Width);
            }

            PrintYouWin();
        }

        private static void GraphicsWindow_KeyDown()
            {
                if (GraphicsWindow.LastKey == "Up")
                {
                    Turtle.Angle = 0;
                }
                else if (GraphicsWindow.LastKey == "Right")
                {
                    Turtle.Angle = 90;
                }
                else if (GraphicsWindow.LastKey == "Left")
                {
                    Turtle.Angle = 270;
                }
                else if (GraphicsWindow.LastKey == "Down")
                {
                    Turtle.Angle = 180;
                }
            }

        static void Grence(int Tx, int Ty, int Height, int Width)
            {
                if (Tx >= Width)
                {
                    Turtle.Angle = 270;
                }

                if (Tx <= 0)
                {
                    Turtle.Angle = 90;
                }

                if (Ty >= Height)
                {
                    Turtle.Angle = 0;
                }

                if (Ty <= 0)
                {
                    Turtle.Angle = 180;
                }
            }

        static void PrintYouWin()
        {
            Turtle.X = 220;
            Turtle.Y = 200;
            Turtle.PenDown();

            PrintY();

            Turtle.X = 235;
            Turtle.Y = 200;

            PrintO();

            Turtle.X = 270;
            Turtle.Y = 175;

            PrintU();

            Turtle.X = 315;
            Turtle.Y = 152;

            PrintW();

            Turtle.X = 350;
            Turtle.Y = 200;

            PrintI();

            Turtle.X = 360;
            Turtle.Y = 200;

            PrintN();

            Turtle.X = 399;
            Turtle.Y = 150;

            PrintVscl();

        }

        static void PrintY()
        {
            Turtle.Angle = 0;
            Turtle.Move(25);
            Turtle.Angle=315;
            Turtle.Move(25);
            Turtle.Angle = 135;
            Turtle.Move(25);
            Turtle.Angle = 45;
            Turtle.Move(25);            
        }

        static void PrintO()
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(25);
                Turtle.TurnRight();
            }            
        }

        static void PrintU()
        {
            Turtle.Angle = 180;
            for (int i = 0; i < 3; i++)
            {
                Turtle.Move(25);
                Turtle.TurnLeft();
            }
        }

        static void PrintW()
        {
            Turtle.Angle = 180;
            Turtle.Move(48);
            Turtle.Angle = 30;
            Turtle.Move(25);
            Turtle.Angle = 150;
            Turtle.Move(25);
            Turtle.Angle = 0;
            Turtle.Move(48);
        }

        static void PrintI()
        {
            Turtle.Angle = 0;
            Turtle.Move(25);
        }

        static void PrintN()
        {
            Turtle.Angle = 0;
            Turtle.Move(25);
            Turtle.Angle = 135;
            Turtle.Move(35);
            Turtle.Angle = 0;
            Turtle.Move(25);
        }

        static void PrintVscl()
        {
            Turtle.Angle = 180;
            Turtle.Move(35);
            Turtle.PenUp();
            Turtle.Move(14);
        }




    }
}
