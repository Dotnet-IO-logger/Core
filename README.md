# Microsoft IO logger | Core

## Introduction

This is a Core repo of Microsoft IO logger extension project.

## Source code

Structure of project:
```
root
|
|- source
    |- Microsoft.IoLogger.sln
    |- examples
    |- src
        |- Microsoft.IoLogger.Core.csproj
        |- applications
            |- Microsoft.IoLogger.Applications.SignalRService.csproj
    |-tests
        |- IntegrationTests
        |- UnitTests
            |- Microsoft.IoLogger.UnitTests.CodeCoverageTests.csproj
|- etc
```

### Core lib

Path: `/source/src/Microsoft.IoLogger.Core/`

Dotnet version: `dotnetstandart2.0`

### SignalRService (Server)

Path: `/source/src/applcations/Microsoft.IoLogger.Applications.SignalRService/`

Dotnet version: dotnet6

Communication: SignalR

### Tests

Path: `/sources/tests/*`

1. Unit tests
2. Integration tests

## Something else

Coming soon...