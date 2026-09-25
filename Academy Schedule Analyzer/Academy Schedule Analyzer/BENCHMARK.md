// AfterAll
// Benchmark Process 8248 has exited with code 0.

Mean = 2.083 ms, StdErr = 0.012 ms (0.57%), N = 44, StdDev = 0.078 ms
Min = 1.976 ms, Q1 = 2.037 ms, Median = 2.069 ms, Q3 = 2.107 ms, Max = 2.332 ms
IQR = 0.070 ms, LowerFence = 1.931 ms, UpperFence = 2.213 ms
ConfidenceInterval = [2.041 ms; 2.124 ms] (CI 99.9%), Margin = 0.042 ms (2.00% of Mean)
Skewness = 1.24, Kurtosis = 4.44, MValue = 2

// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2026-09-25 22:01 (0h 0m from now) **
Successfully reverted power plan (GUID: 381b4222-f694-41f0-9685-ff5bb260df2e FriendlyName: Balanced)
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\Academy_Schedule_Analyzer.MyBenchmark-report.csv
  BenchmarkDotNet.Artifacts\results\Academy_Schedule_Analyzer.MyBenchmark-report-github.md
  BenchmarkDotNet.Artifacts\results\Academy_Schedule_Analyzer.MyBenchmark-report.html

// * Detailed results *
MyBenchmark.StringConcatenation: DefaultJob [Iterations=100]
Runtime = .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 4.967 us, StdErr = 0.038 us (0.77%), N = 89, StdDev = 0.362 us
Min = 4.395 us, Q1 = 4.672 us, Median = 4.954 us, Q3 = 5.232 us, Max = 5.896 us
IQR = 0.560 us, LowerFence = 3.832 us, UpperFence = 6.072 us
ConfidenceInterval = [4.836 us; 5.097 us] (CI 99.9%), Margin = 0.131 us (2.63% of Mean)
Skewness = 0.37, Kurtosis = 2.22, MValue = 2.36
-------------------- Histogram --------------------
[4.371 us ; 4.579 us) | @@@@@@@@@@@@@@
[4.579 us ; 4.832 us) | @@@@@@@@@@@@@@@@@@@@@@
[4.832 us ; 5.071 us) | @@@@@@@@@@@@@@@@
[5.071 us ; 5.314 us) | @@@@@@@@@@@@@@@@@@@@
[5.314 us ; 5.527 us) | @@@@@@@@@
[5.527 us ; 5.789 us) | @@@@@@@
[5.789 us ; 6.002 us) | @
---------------------------------------------------

MyBenchmark.StringBuilderConcatenation: DefaultJob [Iterations=100]
Runtime = .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 1.079 us, StdErr = 0.011 us (1.06%), N = 100, StdDev = 0.114 us
Min = 0.877 us, Q1 = 0.989 us, Median = 1.058 us, Q3 = 1.160 us, Max = 1.332 us
IQR = 0.171 us, LowerFence = 0.733 us, UpperFence = 1.417 us
ConfidenceInterval = [1.041 us; 1.118 us] (CI 99.9%), Margin = 0.039 us (3.59% of Mean)
Skewness = 0.46, Kurtosis = 2.27, MValue = 2.63
-------------------- Histogram --------------------
[0.845 us ; 0.909 us) | @@@@
[0.909 us ; 0.972 us) | @@@@@@@@@
[0.972 us ; 1.037 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[1.037 us ; 1.115 us) | @@@@@@@@@@@@@@@@@@@@@
[1.115 us ; 1.190 us) | @@@@@@@@@@@@@@@
[1.190 us ; 1.216 us) | @@
[1.216 us ; 1.280 us) | @@@@@@@@@@@@
[1.280 us ; 1.348 us) | @@@@@
---------------------------------------------------

MyBenchmark.StringConcatenation: DefaultJob [Iterations=1000]
Runtime = .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 441.647 us, StdErr = 3.255 us (0.74%), N = 97, StdDev = 32.059 us
Min = 381.140 us, Q1 = 413.489 us, Median = 438.324 us, Q3 = 464.427 us, Max = 536.534 us
IQR = 50.938 us, LowerFence = 337.083 us, UpperFence = 540.833 us
ConfidenceInterval = [430.596 us; 452.697 us] (CI 99.9%), Margin = 11.050 us (2.50% of Mean)
Skewness = 0.58, Kurtosis = 2.82, MValue = 4.44
-------------------- Histogram --------------------
[378.967 us ; 398.143 us) | @@
[398.143 us ; 416.459 us) | @@@@@@@@@@@@@@@@@@@@@@@@@
[416.459 us ; 426.784 us) | @@@@@@@
[426.784 us ; 445.100 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@
[445.100 us ; 459.109 us) | @@@@@
[459.109 us ; 477.424 us) | @@@@@@@@@@@@@@@@@@@@
[477.424 us ; 502.258 us) | @@@@@@@
[502.258 us ; 524.178 us) | @@@
[524.178 us ; 545.691 us) | @
---------------------------------------------------

MyBenchmark.StringBuilderConcatenation: DefaultJob [Iterations=1000]
Runtime = .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 10.601 us, StdErr = 0.072 us (0.68%), N = 96, StdDev = 0.702 us
Min = 8.939 us, Q1 = 10.106 us, Median = 10.459 us, Q3 = 11.017 us, Max = 12.392 us
IQR = 0.912 us, LowerFence = 8.738 us, UpperFence = 12.385 us
ConfidenceInterval = [10.358 us; 10.844 us] (CI 99.9%), Margin = 0.243 us (2.29% of Mean)
Skewness = 0.41, Kurtosis = 2.87, MValue = 2.52
-------------------- Histogram --------------------
[ 8.937 us ;  9.339 us) | @@@
[ 9.339 us ;  9.625 us) |
[ 9.625 us ; 10.025 us) | @@@@@@@@@@@@@
[10.025 us ; 10.427 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[10.427 us ; 10.645 us) | @@@@@@@@@@
[10.645 us ; 11.133 us) | @@@@@@@@@@@@@@@@@@@
[11.133 us ; 11.603 us) | @@@@@@@@@
[11.603 us ; 12.148 us) | @@@@@@@@@
[12.148 us ; 12.593 us) | @@
---------------------------------------------------

MyBenchmark.StringConcatenation: DefaultJob [Iterations=10000]
Runtime = .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 61.468 ms, StdErr = 0.395 ms (0.64%), N = 97, StdDev = 3.891 ms
Min = 54.969 ms, Q1 = 58.505 ms, Median = 60.353 ms, Q3 = 63.767 ms, Max = 72.239 ms
IQR = 5.262 ms, LowerFence = 50.612 ms, UpperFence = 71.660 ms
ConfidenceInterval = [60.127 ms; 62.810 ms] (CI 99.9%), Margin = 1.341 ms (2.18% of Mean)
Skewness = 0.87, Kurtosis = 3.09, MValue = 2.19
-------------------- Histogram --------------------
[53.857 ms ; 55.280 ms) | @
[55.280 ms ; 57.386 ms) | @@@@@
[57.386 ms ; 60.245 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[60.245 ms ; 62.468 ms) | @@@@@@@@@@@@@@@@@@@@
[62.468 ms ; 65.141 ms) | @@@@@@@@@@@@@@
[65.141 ms ; 67.695 ms) | @@@@@@@@
[67.695 ms ; 69.917 ms) | @@@@@
[69.917 ms ; 72.561 ms) | @@@@
---------------------------------------------------

MyBenchmark.StringBuilderConcatenation: DefaultJob [Iterations=10000]
Runtime = .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 103.798 us, StdErr = 0.924 us (0.89%), N = 94, StdDev = 8.959 us
Min = 87.884 us, Q1 = 97.834 us, Median = 105.173 us, Q3 = 109.036 us, Max = 125.343 us
IQR = 11.202 us, LowerFence = 81.030 us, UpperFence = 125.840 us
ConfidenceInterval = [100.658 us; 106.938 us] (CI 99.9%), Margin = 3.140 us (3.03% of Mean)
Skewness = 0.04, Kurtosis = 2.42, MValue = 3.6
-------------------- Histogram --------------------
[ 87.580 us ;  92.753 us) | @@@@@@@@@@@@@@@@@@
[ 92.753 us ;  96.530 us) | @@
[ 96.530 us ; 101.702 us) | @@@@@@@@@@@@@@@@
[101.702 us ; 104.416 us) | @@@@
[104.416 us ; 109.589 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[109.589 us ; 116.444 us) | @@@@@@@@@@@@
[116.444 us ; 123.184 us) | @@@@@@
[123.184 us ; 127.929 us) | @
---------------------------------------------------

MyBenchmark.StringConcatenation: DefaultJob [Iterations=100000]
Runtime = .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 17.674 s, StdErr = 0.075 s (0.42%), N = 15, StdDev = 0.289 s
Min = 17.350 s, Q1 = 17.499 s, Median = 17.520 s, Q3 = 17.819 s, Max = 18.197 s
IQR = 0.320 s, LowerFence = 17.018 s, UpperFence = 18.299 s
ConfidenceInterval = [17.364 s; 17.983 s] (CI 99.9%), Margin = 0.309 s (1.75% of Mean)
Skewness = 0.74, Kurtosis = 1.92, MValue = 2
-------------------- Histogram --------------------
[17.262 s ; 18.224 s) | @@@@@@@@@@@@@@@
---------------------------------------------------

MyBenchmark.StringBuilderConcatenation: DefaultJob [Iterations=100000]
Runtime = .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3; GC = Concurrent Workstation
Mean = 2.083 ms, StdErr = 0.012 ms (0.57%), N = 44, StdDev = 0.078 ms
Min = 1.976 ms, Q1 = 2.037 ms, Median = 2.069 ms, Q3 = 2.107 ms, Max = 2.332 ms
IQR = 0.070 ms, LowerFence = 1.931 ms, UpperFence = 2.213 ms
ConfidenceInterval = [2.041 ms; 2.124 ms] (CI 99.9%), Margin = 0.042 ms (2.00% of Mean)
Skewness = 1.24, Kurtosis = 4.44, MValue = 2
-------------------- Histogram --------------------
[1.968 ms ; 2.021 ms) | @@@@@@@@
[2.021 ms ; 2.080 ms) | @@@@@@@@@@@@@@@@@@@
[2.080 ms ; 2.139 ms) | @@@@@@@@@@
[2.139 ms ; 2.234 ms) | @@@@@
[2.234 ms ; 2.280 ms) |
[2.280 ms ; 2.338 ms) | @@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.7725/22H2/2022Update)
Intel Core i5-6300U CPU 2.40GHz (Max: 2.50GHz) (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.303
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


| Method                     | Iterations | Mean              | Error           | StdDev          | Median            | Gen0          | Gen1          | Gen2          | Allocated     |
|--------------------------- |----------- |------------------:|----------------:|----------------:|------------------:|--------------:|--------------:|--------------:|--------------:|
| StringConcatenation        | 100        |          4.967 us |       0.1305 us |       0.3617 us |          4.954 us |       13.2904 |             - |             - |      20.37 KB |
| StringBuilderConcatenation | 100        |          1.079 us |       0.0387 us |       0.1142 us |          1.058 us |        0.8144 |             - |             - |       1.25 KB |
| StringConcatenation        | 1000       |        441.647 us |      11.0504 us |      32.0591 us |        438.324 us |     1810.5469 |             - |             - |    2773.88 KB |
| StringBuilderConcatenation | 1000       |         10.601 us |       0.2433 us |       0.7020 us |         10.459 us |        9.3384 |             - |             - |      14.37 KB |
| StringConcatenation        | 10000      |     61,468.427 us |   1,341.1407 us |   3,890.8927 us |     60,353.133 us |   238444.4444 |             - |             - |  370543.41 KB |
| StringBuilderConcatenation | 10000      |        103.798 us |       3.1401 us |       8.9590 us |        105.173 us |       99.9756 |             - |             - |     155.69 KB |
| StringConcatenation        | 100000     | 17,673,869.433 us | 309,378.2883 us | 289,392.6430 us | 17,519,974.700 us | 11134000.0000 | 10788000.0000 | 10788000.0000 | 46790207.2 KB |
| StringBuilderConcatenation | 100000     |      2,082.555 us |      41.6234 us |      78.1788 us |      2,068.687 us |      250.0000 |      246.0938 |      246.0938 |    1931.09 KB |

// * Warnings *
MultimodalDistribution
  MyBenchmark.StringConcatenation: Default        -> It seems that the distribution is multimodal (mValue = 4.44)
  MyBenchmark.StringBuilderConcatenation: Default -> It seems that the distribution is bimodal (mValue = 3.6)

// * Hints *
Outliers
  MyBenchmark.StringConcatenation: Default        -> 11 outliers were removed (6.50 us..9.20 us)
  MyBenchmark.StringConcatenation: Default        -> 3 outliers were removed (541.76 us..583.81 us)
  MyBenchmark.StringBuilderConcatenation: Default -> 4 outliers were removed (12.77 us..14.03 us)
  MyBenchmark.StringConcatenation: Default        -> 3 outliers were removed (73.06 ms..78.64 ms)
  MyBenchmark.StringBuilderConcatenation: Default -> 6 outliers were removed (129.03 us..160.57 us)
  MyBenchmark.StringBuilderConcatenation: Default -> 7 outliers were removed (2.38 ms..2.70 ms)

// * Legends *
  Iterations : Value of the 'Iterations' parameter
  Mean       : Arithmetic mean of all measurements
  Error      : Half of 99.9% confidence interval
  StdDev     : Standard deviation of all measurements
  Median     : Value separating the higher half of all measurements (50th percentile)
  Gen0       : GC Generation 0 collects per 1000 operations
  Gen1       : GC Generation 1 collects per 1000 operations
  Gen2       : GC Generation 2 collects per 1000 operations
  Allocated  : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 us       : 1 Microsecond (0.000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:16:07 (967.87 sec), executed benchmarks: 8

Global total time: 00:16:36 (996.84 sec), executed benchmarks: 8
// * Artifacts cleanup *
Artifacts cleanup is finished


Answers:
1.StringBuilderConcatenation is faster as it has 1.079 us and StringConcatenation is 4.967 us.
2.StringBuilderConcatenation is also faster as it has 2,082.555 us ans StringConcatenation is 17,673,869.433 us.
3.StringConcatenation has more memory than StringBuilderConcatenation in all tests.
4.The perforamance difference between StringConcatenation and StringBuilderConcatenation increases as the number of iterations increases. For example, at 100 iterations, the difference is about 3.888 us, while at 100,000 iterations, the difference is about 17,671,786.878 us.
5.StringConcatenation creates more allocations as it copy the string and create new string each time and leave the old string to GC.
6.StringBuilderConcatenation usually perform better when appending as appending in the original string not creating a string in memory.
7.Always better? No. StringBuilder is most useful for repeated/large concatenations; for simple or a small number of concatenations, normal strings are simpler and appropriate.