using System.Security.Cryptography;

namespace Assignment_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 1.4
             * Create a class named “Point” and 2 data members: X and Y coordinate. 
             * Declare 2 points: P1 and P2. 
             * Determine if P2 is to the right or left of P1 or on same axis , 
             * by comparing the x xoordinates. 
             * ( if p1.x is more than p2.x , it is to the right ) 
             */

            Point P1 = new(153466, 987245);
            Point P2 = new Point(654262, 874536);

            if (P1.x == P2.x) 
                Console.WriteLine("P1 and P2 are in the same axis.");
            else
                Console.WriteLine( (P1.x < P2.x) ? "P1 is to the left of P2." : "P1 is to the right of P2." );
        }
    }

    public class Point
    {
        public double x;
        public double y;

        public Point(double xCoords, double yCoords)
        {
            this.x = xCoords;
            this.y = yCoords;
        }
    }
}
