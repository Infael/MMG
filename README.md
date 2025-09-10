# MMG (My MonoGame Library)

A collection of useful utilities and extensions for MonoGame Projects.

## Build and Create Nuget Package
```bash
dotnet build -c Release
dotnet pack -c Release
```

## Publish
Published via Release Please and GitHub Actions to GitHub Packages.

## Use
```bash
dotnet nuget add source "https://nuget.pkg.github.com/Infael/index.json" \
  --name github \
  --username <username> \
  --password <PAT>

# and

dotnet add package MMG --version 1.0.0
```