using BenchmarkDotNet.Running;
using CSharp.Data.Structures.Domain.Benchmark;

// ReSharper disable ClassNeverInstantiated.Global

namespace CSharp.Data.Structures.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<ArraysBenchmark>();
        }
    }
}