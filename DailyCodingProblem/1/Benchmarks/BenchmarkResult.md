``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


```
|       Method | Number |            Mean |         Error |        StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------- |------- |----------------:|--------------:|--------------:|-------:|------:|------:|----------:|
|         **Linq** |    **546** |      **5,153.5 ns** |      **96.24 ns** |      **94.52 ns** | **0.0381** |     **-** |     **-** |     **344 B** |
| LinqParallel |    546 |  7,359,735.4 ns | 145,461.06 ns | 250,913.18 ns |      - |     - |     - |    9265 B |
|          For |    546 |        316.0 ns |       0.22 ns |       0.17 ns |      - |     - |     - |         - |
|         **Linq** |  **11239** |     **98,067.7 ns** |   **1,927.26 ns** |   **1,802.76 ns** |      **-** |     **-** |     **-** |     **345 B** |
| LinqParallel |  11239 | 13,468,389.7 ns | 155,649.11 ns | 145,594.28 ns |      - |     - |     - |   11187 B |
|          For |  11239 |      7,948.0 ns |       3.40 ns |       2.84 ns |      - |     - |     - |         - |
