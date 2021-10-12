using System;

namespace HW3_1
{
    public static class CalculationMethod
    {
        public static float[] CountDistanceSimpleClassFloat(PointClass<float>[] pointOne, PointClass<float>[] pointTwo)
        {
            int index = 0;
            float x = 0, y = 0;
            float[] result = new float[100];
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                    result[index] = MathF.Sqrt((x * x) + (y * y));
                    index++;
                }
            }
            return result;
        }

        public static float[] CountDistanceSimpleStructFloat(PointStruct<float>[] pointOne, PointStruct<float>[] pointTwo)
        {
            int index = 0;
            float x = 0, y = 0;
            float[] result = new float[100];
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                    result[index] = MathF.Sqrt((x * x) + (y * y));
                    index++;
                }
            }
            return result;
        }
        public static float[] CountDistanceNoSqrtStructFloat(PointStruct<float>[] pointOne, PointStruct<float>[] pointTwo)
        {
            int index = 0;
            float x = 0, y = 0;
            float[] result = new float[100];
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                    result[index] = (x * x) + (y * y);
                    index++;
                }
            }
            return result;
        }

        public static double[] CountDistanceSimpleStructDouble(PointStruct<double>[] pointOne, PointStruct<double>[] pointTwo)
        {
            int index = 0;
            double x = 0, y = 0;
            double[] result = new double[100];
            for (int i = 0; i < pointOne.Length; i++)
            {
                for (int j = pointTwo.Length; j <= 0; j--)
                {
                    x = pointOne[i].X - pointTwo[j].X;
                    y = pointOne[i].Y - pointTwo[j].Y;
                    result[index] = Math.Sqrt((x * x) + (y * y));
                    index++;
                }
            }
            return result;
        }
    }

}
