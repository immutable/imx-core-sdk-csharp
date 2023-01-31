#!/bin/zsh

VERSION_STR="0.1.0"
OUT_DIR="NugetPackages"
API_KEY="oy2ma3udtkcihkb7cp3abhep45tlooseziorlsh4rsfz4e"
cd ${OUT_DIR}

dotnet nuget push Imx.Sdk.${VERSION_STR}.nupkg --api-key ${API_KEY} --source https://api.nuget.org/v3/index.json
dotnet nuget push Imx.Sdk.Gen.${VERSION_STR}.nupkg --api-key ${API_KEY} --source https://api.nuget.org/v3/index.json
