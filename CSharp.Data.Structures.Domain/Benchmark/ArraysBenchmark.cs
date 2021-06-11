using System.Collections;
using BenchmarkDotNet.Attributes;

namespace CSharp.Data.Structures.Domain.Benchmark
{
    public class ArraysBenchmark
    {
        private const int ItemsNumber = 150000;

        [Benchmark]
        public void BoolArrayInvert()
        {
            var array = new bool[ItemsNumber];
            for (var i = 0; i < ItemsNumber; i++) array.SetValue(false, i);
            for (var i = 0; i < ItemsNumber; i++) array[i] = !array[i];
        }

        [Benchmark]
        public void BitArrayInvert()
        {
            var array = new BitArray(ItemsNumber);
            for (var i = 0; i < ItemsNumber; i++) array.Set(i, false);
            for (var i = 0; i < ItemsNumber; i++) array[i] = !array[i];
        }

        [Benchmark]
        public void BitArrayInvertOptimized()
        {
            var array = new BitArray(ItemsNumber, false);
            array.Not();
        }
    }
}