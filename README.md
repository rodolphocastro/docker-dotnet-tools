## Dotnet Docker Tools

This project aims to ease CICD pipelines using Docker and Microsoft`s own images by having some popular tools already added to them.

You can find all our images in [DockerHub](https://hub.docker.com/r/rodolphoalves/dotnet-tools).

### Supported Tools

Currently no tools are yet added

#### Base

The base images contain the DotNet Global Tools added to its `Path`, thus enabling use of said tools.

#### Cake

The Cake images contain the `Cake.Tool` global dotnet tool. It can be used by running: `dotnet cake <command>`.

#### Coverlet

The Coverlet image contains the `coverlet.console` global dotnet tool. It can be used by running `coverlet <paramenters>`

#### Sonarscanner

The Sonarscanner image constainer the `dotnet-sonarscanner` global dotnet tool. It can be used by running `dotnet-sonarscanner <parameters>`.

### Roadmap

+ CAKE Tasks
+ Support for SDK 3.0
+ Support for images other than Alpine
+ Better documentation