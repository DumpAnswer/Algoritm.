using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace TestBencmark
{
    public class PointClass
    {
        public float X;
        public float Y;
    }
    public struct PointStruct
    {
        public float X;
        public float Y;
    }
    public struct PointStructOne
    {
        public double X;
        public double Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        } 
    }

    public class BenchmarkClass 
    { 
        //Обычный метод расчёта дистанции со ссылочным типом float
        public static float PointFloatDistation (PointClass pointOne ,PointClass pointTwo )
        {
            return MathF.Sqrt(MathF.Pow(pointTwo.X - pointOne.X, 2) +MathF.Pow(pointTwo.Y - pointOne.Y, 2));
        }

        //Обычный метод расчёта дистанции со значимым типом float
        public static float PointStructFloat (PointStruct pointOne, PointStruct pointTwo)
        {
            return MathF.Sqrt(MathF.Pow(pointTwo.X - pointOne.X, 2) + MathF.Pow(pointTwo.Y - pointOne.Y, 2));
        }

        //Обычный метод расчёта дистанции со значимым типом  double
        public static double PointDistanceDouble(PointStructOne pointOne, PointStructOne pointTwo)
        {
            return Math.Sqrt(Math.Pow(pointTwo.X - pointOne.X, 2) + Math.Pow(pointTwo.Y - pointOne.Y, 2));
        }
        //Метод расчёта дистанции без квадратного корня со значимым типом  float
        public static float  NoMathDistancePoint(PointStruct pointOne , PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
 
        }

        public static PointStruct GeneratePoint(PointStruct point)
        {
            Random rand = new Random();
            point.X = rand.Next(100);
            point.Y = rand.Next(100);
            return point;
        }

        public static PointStructOne GeneratePoint(PointStructOne point)
        {
            Random rand = new Random();
            point.X = rand.Next(100);
            point.Y = rand.Next(100);
            return point;
        }

        public static PointClass GeneratePoint(PointClass point)
        {
            Random rand = new Random();
            point.X = rand.Next(100);
            point.Y = rand.Next(100);
            return point;
        }

        [Benchmark]
        public float ClassFloatTest()
        {
            PointClass point = new PointClass();
           return PointFloatDistation(GeneratePoint(point), GeneratePoint(point));
        }

        [Benchmark]
        public float StructFloatTest()
        {
            PointStruct point = new PointStruct();
            return PointStructFloat(GeneratePoint(point), GeneratePoint(point));
        }

        [Benchmark]
        public double StructDoubleTest()
        {
            PointStructOne point = new PointStructOne();
            return PointDistanceDouble(GeneratePoint(point), GeneratePoint(point));
        }

        [Benchmark]
        public float NoMathFloatTest()
        {
            PointStruct point = new PointStruct();
            return NoMathDistancePoint(GeneratePoint(point), GeneratePoint(point));
        }

    }
}
