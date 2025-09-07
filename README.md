# MMG (My MonoGame Library)

A collection of useful utilities and extensions for MonoGame Projects.

## Build and Create Nuget Package
```bash
dotnet build -c Release
dotnet pack -c Release
```

## Publish
```bash
git tag v1.0.0
git push origin v1.0.0
```

## Use
```bash
dotnet nuget add source "https://nuget.pkg.github.com/Infael/index.json" \
  --name github \
  --username <username> \
  --password <PAT>
```