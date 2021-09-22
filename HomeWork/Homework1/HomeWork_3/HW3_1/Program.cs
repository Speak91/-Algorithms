using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace HW3_1
{
    public class Program
    {
        private static int arraySize = 100;
        public static PointClass<float>[] FloatPointClassA = new PointClass<float>[arraySize];
        public static PointClass<float>[] FloatPointClassB = new PointClass<float>[arraySize];

        public static PointStruct<float>[] FloatPointStructA = new PointStruct<float>[arraySize];
        public static PointStruct<float>[] FloatPointStructB = new PointStruct<float>[arraySize];

        public static PointStruct<double>[] DoublePointStructA = new PointStruct<double>[arraySize];
        public static PointStruct<double>[] DoublePointStructB = new PointStruct<double>[arraySize];

        static void Main(string[] args)
        {
            FloatPointClassA = FillingWithRandomNumbers.FillingWithRandomNumbersFloatTypesPointClass();
            FloatPointClassB = FillingWithRandomNumbers.FillingWithRandomNumbersFloatTypesPointClass();

            FloatPointStructA = FillingWithRandomNumbers.FillingWithRandomNumbersFloatTypesPointStruct();
            FloatPointStructB = FillingWithRandomNumbers.FillingWithRandomNumbersFloatTypesPointStruct();

            DoublePointStructA = FillingWithRandomNumbers.FillingWithRandomNumbersDoubleTypesPointStruct();
            DoublePointStructB = FillingWithRandomNumbers.FillingWithRandomNumbersDoubleTypesPointStruct();

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
        public class BechmarkClass
        {
            [Benchmark]
            public void PointClassFloatTest()
            {
                CalculationMethod.CountDistanceSimpleClassFloat(FloatPointClassA, FloatPointClassB);
            }

            [Benchmark]
            public void PointStructFloatTest()
            {
                CalculationMethod.CountDistanceSimpleStructFloat(FloatPointStructA, FloatPointStructB);
            }

            [Benchmark]
            public void PointStructDoubleTest()
            {
                CalculationMethod.CountDistanceSimpleStructDouble(DoublePointStructA, DoublePointStructB);
            }

            [Benchmark]
            public void PointStructNoSqrtTest()
            {
                CalculationMethod.CountDistanceNoSqrtStructFloat(FloatPointStructA, FloatPointStructB);
            }
        }


    }

}
