# This is a forked version of archived IdentityServer4 project ported from .net core 3.1 to .net6

- All projects has been updated to dotnet 6.0, dotnet Packages has been updated to version 6.0.16
- All dependencies have been updated to the most recent possible version as described bellow:

| Package                                         |  From  | To     |
|-------------------------------------------------|:------:|--------|
| MinVer                                          | 2.3.0  | 4.3.0  |
| Microsoft.SourceLink.GitHub                     | 1.0.0  | 1.1.1  |
| FluentAssertions                                | 5.10.2 | 5.10.3 |
| Microsoft.NET.Test.Sdk                          | 16.2.0 | 17.5.0 |
| xunit                                           | 2.4.1  | 2.4.2  |
| xunit.runner.visualstudio                       | 2.4.1  | 2.4.5  |
| IdentityModel                                   | 4.4.0  | 4.6.0  |
| Microsoft.Extensions.Logging.Console            | 3.1.0  | 6.0.0  |
| Newtonsoft.Json                                 | 12.0.2 | 13.0.3 |
| Microsoft.IdentityModel.Protocols.OpenIdConnect | 5.6.0  | 6.10.0 |
| System.IdentityModel.Tokens.Jwt                 | 5.6.0  | 6.10.0 |
| System.Security.Principal.Windows               | 4.7.0  | 5.0.0  |
| AutoMapper                                      | 10.0.0 | 12.0.1 |
| Serilog.AspNetCore                              | 3.1.0  | 6.1.0  |

Some tests arrangement from IdentityServerZoe.EntityFramework project has been updated to support Automapper 12.0.1

# Known Issues

Passing complex objects as token claims is not supported

# Important Notice

The original project <https://github.com/IdentityServer/IdentityServer4> is not maintained anymore, it has been archived on 13th Dec 2022. All new development is happening in the new [Duende Software](https://github.com/duendesoftware) organization.

See [here](https://duendesoftware.com/products/identityserver) for more details.

## About IdentityServerZoe

IdentityServerZoe is a free, open source [OpenID Connect](http://openid.net/connect/) and [OAuth 2.0](https://tools.ietf.org/html/rfc6749) framework for ASP.NET Core.

## How to build

- [Install](https://www.microsoft.com/net/download/core#/current) the latest .NET 6.0 SDK
- Install Git
- Clone this repo
- Run `build.ps1` or `build.sh` in the root of the cloned repo

## Documentation

We have made no changes that affect documentation, so it remains the same.
Please visit [readthedocs](https://identityserver4.readthedocs.io).

## Community Support

This project is not being actively maintained, and it's offered as it is, the use of these bits its on your own responsibility.

## Acknowledgements

IdentityServerZoe is built using the following great open source projects and free services:

- [ASP.NET Core](https://github.com/dotnet/aspnetcore)
- [Bullseye](https://github.com/adamralph/bullseye)
- [SimpleExec](https://github.com/adamralph/simple-exec)
- [MinVer](https://github.com/adamralph/minver)
- [Json.Net](http://www.newtonsoft.com/json)
- [XUnit](https://xunit.github.io/)
- [Fluent Assertions](http://www.fluentassertions.com/)
- [GitReleaseManager](https://github.com/GitTools/GitReleaseManager)
