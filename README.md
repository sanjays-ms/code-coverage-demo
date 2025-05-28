# Code Coverage Demo

This project demonstrates how to generate code coverage reports using .NET with xUnit and Coverlet.

## Prerequisites
- .NET SDK 8.0 or higher
- Git (optional, for cloning)

## Getting Started

### 1. Clone or Download the Project
Clone this repository or download the source code to your local machine.

### 2. Build the Solution
From the root directory, run:
```
dotnet build
```

### 3. Run Tests
To run tests without coverage:
```
dotnet test
```

## Generating Code Coverage Reports

### Method 1: MSBuild Method (Recommended)

Navigate to the test project directory:
```
cd Numbers.Tests
```

Then run tests with coverage:

**For Windows Command Prompt / PowerShell:**
```
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
```

**For Git Bash / Linux / macOS:**
```
dotnet test -p:CollectCoverage=true -p:CoverletOutputFormat=cobertura
```

This generates `coverage.cobertura.xml` in the Numbers.Tests directory.

### Method 2: Data Collector Method

From the test project directory:
```
dotnet test --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=cobertura
```

This generates coverage file in `TestResults/{guid}/coverage.cobertura.xml`

## Output Location

- **MSBuild Method**: `Numbers.Tests/coverage.cobertura.xml`
- **Collector Method**: `Numbers.Tests/TestResults/{guid}/coverage.cobertura.xml`
