``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-EWFSRY : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
| Method | ElementCount |           Mean |        Error |        StdDev |         Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |------------- |---------------:|-------------:|--------------:|---------------:|------:|------:|------:|----------:|
|   **Linq** |            **5** |     **2,408.3 ns** |    **159.40 ns** |     **459.90 ns** |     **2,250.0 ns** |     **-** |     **-** |     **-** |    **1256 B** |
|    For |            5 |       820.0 ns |    141.94 ns |     418.51 ns |       650.0 ns |     - |     - |     - |      48 B |
|   **Linq** |           **50** |    **39,954.3 ns** |    **795.53 ns** |   **1,307.07 ns** |    **39,900.0 ns** |     **-** |     **-** |     **-** |   **10416 B** |
|    For |           50 |     3,009.7 ns |     61.79 ns |      94.36 ns |     3,000.0 ns |     - |     - |     - |     224 B |
|   **Linq** |          **500** | **3,105,234.8 ns** | **59,605.43 ns** | **114,839.43 ns** | **3,160,500.0 ns** |     **-** |     **-** |     **-** |  **100472 B** |
|    For |          500 |   182,471.4 ns |  1,934.95 ns |   1,715.28 ns |   182,100.0 ns |     - |     - |     - |    2024 B |
