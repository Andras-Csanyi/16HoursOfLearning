﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using SalesByMatch;

namespace Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = BenchmarkRunner.Run<Benchmark>();
        }
    }

    [MemoryDiagnoser]
    public class Benchmark
    {
        private readonly ISockMerchant _salesByMatchBruteForce = new SalesByMatchBruteForce();
        private readonly ISockMerchant _salesByMatchBySingleIteration = new SalesByMatchBySingleIteration();
        private readonly ISockMerchant _salesByMatchBySingleIterationV2 = new SalesByMatchBySingleIterationV2();
        private readonly ISockMerchant _salesByMatchList = new SalesByMatchList();

        private int[] data;

        private int[] data_100 = new int[]
        {
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7
        };

        public int[] data_200 = new int[]
        {
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
        };

        public int[] data_1000 = new int[]
        {
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 4, 6, 8, 7, 9, 5, 3, 1, 2,
            3, 4, 5, 6, 7, 8, 9, 0, 2, 2, 3, 4, 5, 1, 3, 2, 1, 3, 4, 5, 6, 7, 8, 8, 7, 6, 5, 4, 4, 2, 3, 4, 53, 2, 6, 7,
            1, 2, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 7, 7, 7, 6, 6, 6, 5, 5, 5,
            2, 3, 5, 6, 7, 8, 9, 2, 4, 5, 6, 7, 2, 1, 4, 2, 3, 4, 5, 6, 8, 96, 5, 4, 3, 2, 1, 4, 5, 6, 7, 8, 9, 0, 7, 6,
            8, 9, 5, 6, 7,
        };

        public Benchmark()
        {
            data = data_1000;
        }

        [Benchmark]
        public void Measure_BruteForce()
        {
            int result = _salesByMatchBruteForce.SockMerchant(data);
        }

        [Benchmark]
        public void Measure_List()
        {
            int result = _salesByMatchList.SockMerchant(data);
        }

        [Benchmark]
        public void Measure_BySingleIteration()
        {
            int result = _salesByMatchBySingleIteration.SockMerchant(data);
        }

        [Benchmark]
        public void Measure_BySingleIterationV2()
        {
            int result = _salesByMatchBySingleIterationV2.SockMerchant(data);
        }
    }
}