#!/bin/zsh

VERSION_STR="0.1.1"
OUT_DIR="NugetPackages"
API_KEY="" # Get API Key from your Nuget Account
cd ${OUT_DIR}

# Publishes locally built packages to Nuget https://www.nuget.org/account/Packages

dotnet nuget push Imx.Sdk.${VERSION_STR}.nupkg --api-key ${API_KEY} --source https://api.nuget.org/v3/index.json
dotnet nuget push Imx.Sdk.Gen.${VERSION_STR}.nupkg --api-key ${API_KEY} --source https://api.nuget.org/v3/index.json
