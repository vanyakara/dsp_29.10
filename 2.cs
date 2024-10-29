using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void InputPoint()
        {
            Console.Write("Въведете X: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Въведете Y: ");
            Y = double.Parse(Console.ReadLine());
        }
        public void PrintPoint()
        {
            Console.WriteLine($"Точка: ({X}, {Y})");
        }
    }
    public class Area
    {
        public static Area instance;
        public double MinX { get; }
        public double MaxX { get; }
        public double MinY { get; }
        public double MaxY { get; }
        public Area(double minX,double maxX,double minY,double maxY)
        {
            MinX = minX;
            MaxX = maxX;
            MinY = minY;
            MaxY = maxY;
        }
        public static Area GetInstance(double minX,double maxX, double minY, double maxY)
        {
            if (instance == null)
            {
                instance = new Area(minX, maxX, minY, maxY);
            }
            return instance;
        }
        public bool IsPointInArea(Point point)
        {
            return point.X >= MinX && point.X <= MaxX && point.Y >= MinY && point.Y <= MaxY;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double minX = 0;
            double maxX = 10;
            double minY = 0;
            double maxY = 10;
            Area area = Area.GetInstance(minX, maxX, minY, maxY);
            List<Point> points = new List<Point>();
            Console.Write("Въведете броя точки, които искате да добавите: ");
            int numberOfPoints = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberOfPoints; i++)
            {
                Console.WriteLine($"Въвеждане на точка {i + 1}: ");
                Point point = new Point(0, 0);
                point.InputPoint();
                if (area.IsPointInArea(point))
                {
                    points.Add(point);
                    Console.WriteLine("Точката е добавена.");
                }
                else
                {
                    Console.WriteLine("Точката не попада в зададената област.");
                }
            }
            Console.WriteLine("\nВалидни точки в областта: ");
            foreach (var point in points)
            {
                point.PrintPoint();
            }
            Console.ReadLine();
        }
    }
}
