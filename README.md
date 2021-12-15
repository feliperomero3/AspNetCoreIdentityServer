# ASP.NET Core Identity with IdentityServer4

ASP.NET Core Identity with IdentityServer4

This code is based from the ASP.NET Core Template "IdentityServer4AspNetCoreIdentityTemplate" built by [damienbod](https://github.com/damienbod).
Specifically the release [5.1.3](https://github.com/damienbod/IdentityServer4AspNetCoreIdentityTemplate/tree/release_5_1_3)

Your first have to install the template and then you can create a new project.

## Getting started

In order to get the `.nupkg` package file you have to build from the source.

```cmd
nuget pack content/IdentityServer4AspNetCoreIdentityTemplate.nuspec

dotnet new -i IdentityServer4AspNetCoreIdentityTemplate.5.1.3.nupkg

dotnet new sts -n AspNetCoreIdentityServer
```

## Features

- ASP.NET Core 3.1
- ASP.NET Core Identity 3.1
- Bootstrap 4 UI
- 2FA
- TOTP
- FIDO2 MFA
- Personal data, download, delete (part of ASP.NET Core Identity)
- Azure AD, Cert, key vault deployments API
- SendGrid Email API
- npm with bundleconfig used for frontend packages
- EF Core
- Support for ui_locales using OIDC logins
