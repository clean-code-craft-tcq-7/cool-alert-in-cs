CoolingAlert C# port
=====================

This folder contains a C# port of the C project, implemented from scratch.

Structure

- CoolingAlert/: C# library project (net8.0)
- CoolingAlert.Tests/: xUnit test project

Notes

- The C source had commented markers for incremental steps: "----STEP 2----" through "----STEP 6----". Those markers were preserved in the C# source at the analogous locations. They indicate places where minimal working code was progressively enabled in the original project and are intentionally left as comments so you can follow the original tutorial workflow.

Build & Test

- From the `csharp` folder run:

```cmd
dotnet build
dotnet test
```

The projects target .NET 8.0. Use an SDK that supports net8.0.
