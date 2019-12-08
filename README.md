## Dotnet Docker Tools

This project aims to ease CICD pipelines using Docker and Microsoft`s own images by having some popular tools already added to them.

### Supported Tools

Currently no tools are yet added

#### Base

The base images contain the DotNet Global Tools added to its `Path`, thus enabling use of said tools.

#### Cake

The Cake images contain the `Cake.Tool` global dotnet tool. It can be used by running: `dotnet cake <command>`.

### Roadmap

+ Sonarscanner
+ Coverlet