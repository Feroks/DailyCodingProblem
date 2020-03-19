``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  Job-MOCPQW : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
| Method |  InputFile |         Mean |       Error |      StdDev |       Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |----------- |-------------:|------------:|------------:|-------------:|------:|------:|------:|----------:|
|   **Linq** | **tree1.json** |   **1,991.8 ns** |   **148.64 ns** |   **431.25 ns** |   **1,800.0 ns** |     **-** |     **-** |     **-** |     **696 B** |
|    For | tree1.json |     172.7 ns |    25.22 ns |    73.98 ns |     200.0 ns |     - |     - |     - |         - |
|   **Linq** | **tree2.json** | **129,406.7 ns** |   **602.68 ns** |   **563.75 ns** | **129,400.0 ns** |     **-** |     **-** |     **-** |  **176160 B** |
|    For | tree2.json |   9,125.0 ns |   184.03 ns |   180.74 ns |   9,050.0 ns |     - |     - |     - |         - |
|   **Linq** | **tree3.json** | **337,278.6 ns** | **2,174.01 ns** | **1,927.21 ns** | **337,650.0 ns** |     **-** |     **-** |     **-** |  **460384 B** |
|    For | tree3.json |  23,780.0 ns |   246.45 ns |   230.53 ns |  23,700.0 ns |     - |     - |     - |         - |
