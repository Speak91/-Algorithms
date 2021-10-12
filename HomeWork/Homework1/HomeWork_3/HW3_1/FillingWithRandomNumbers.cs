using System;

namespace HW3_1
{
    public static class FillingWithRandomNumbers
    {
        public static PointClass<float>[] FillingWithRandomNumbersFloatTypesPointClass()
        {
            Random random = new Random();
            PointClass<float>[] FloatpointClass = new PointClass<float>[100];
            for (int i = 0; i < FloatpointClass.Length; i++)
            {
                FloatpointClass[i] = new PointClass<float>();
                FloatpointClass[i].X = random.Next(1, 100);
                FloatpointClass[i].Y = random.Next(1, 100);
            }
            return FloatpointClass;
        }
        public static PointStruct<float>[] FillingWithRandomNumbersFloatTypesPointStruct()
        {
            Random random = new Random();
            PointStruct<float>[] FloatPointStruct = new PointStruct<float>[100];
            for (int i = 0; i < FloatPointStruct.Length; i++)
            {
                FloatPointStruct[i] = new PointStruct<float>();
                FloatPointStruct[i].X = random.Next(1, 100);
                FloatPointStruct[i].Y = random.Next(1, 100);
            }
            return FloatPointStruct;
        }
        public static PointStruct<double>[] FillingWithRandomNumbersDoubleTypesPointStruct()
        {
            Random random = new Random();
            PointStruct<double>[] DoublePointStruct = new PointStruct<double>[100];
            for (int i = 0; i < DoublePointStruct.Length; i++)
            {
                DoublePointStruct[i] = new PointStruct<double>();
                DoublePointStruct[i].X = random.Next(1, 100);
                DoublePointStruct[i].Y = random.Next(1, 100);
            }
            return DoublePointStruct;
        }
    }

}
