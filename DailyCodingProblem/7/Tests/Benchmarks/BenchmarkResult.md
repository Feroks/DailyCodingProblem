``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT


```
|            Method |             Sequence |           Mean |         Error |        StdDev |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |--------------------- |---------------:|--------------:|--------------:|---------:|------:|------:|----------:|
|         **Recursion** |      **127589623153453** |   **3,033.972 ns** |    **25.5979 ns** |    **23.9443 ns** |   **0.6523** |     **-** |     **-** |    **5480 B** |
|     RecursionSpan |      127589623153453 |   1,827.556 ns |    14.0854 ns |    12.4863 ns |        - |     - |     - |         - |
| RecursionSpanPath |      127589623153453 |       9.840 ns |     0.2203 ns |     0.2060 ns |        - |     - |     - |         - |
|         **Recursion** | **21408(...)23053 [32]** | **628,726.198 ns** | **8,461.4918 ns** | **7,914.8847 ns** | **111.3281** |     **-** |     **-** |  **933771 B** |
|     RecursionSpan | 21408(...)23053 [32] | 394,875.203 ns |   431.9719 ns |   337.2552 ns |        - |     - |     - |         - |
| RecursionSpanPath | 21408(...)23053 [32] |       9.421 ns |     0.2079 ns |     0.2703 ns |        - |     - |     - |         - |
