``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT


```
|  Method | StringCount | StringLength | SearchText |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------- |------------ |------------- |----------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|    **Linq** |        **1000** |          **100** |         **de** | **83.365 us** | **1.5713 us** | **1.5432 us** |     **-** |     **-** |     **-** |     **136 B** |
|     For |        1000 |          100 |         de | 79.092 us | 1.5620 us | 1.7362 us |     - |     - |     - |      57 B |
| ForSpan |        1000 |          100 |         de |  3.190 us | 0.0410 us | 0.0383 us |     - |     - |     - |      24 B |
|    **Linq** |        **1000** |          **100** |       **dema** | **83.815 us** | **1.5288 us** | **1.2767 us** |     **-** |     **-** |     **-** |     **136 B** |
|     For |        1000 |          100 |       dema | 78.022 us | 2.2325 us | 2.6576 us |     - |     - |     - |      24 B |
| ForSpan |        1000 |          100 |       dema |  2.645 us | 0.0392 us | 0.0367 us |     - |     - |     - |      24 B |
