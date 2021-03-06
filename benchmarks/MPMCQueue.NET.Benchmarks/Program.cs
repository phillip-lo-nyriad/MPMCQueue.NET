﻿using BenchmarkDotNet.Running;

namespace MPMCQueue.NET.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<MultiThreadedConcurrentQueueBenchmark>();
            BenchmarkRunner.Run<MultiThreadedMPMCQueueBenchmark>();
        }
    }
}