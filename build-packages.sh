#!/bin/zsh

VERSION_STR="0.1.0"

SRC_DIR="./Src/IMX"
OUT_DIR="NugetPackages"
WORK_DIR=`pwd`

rm -rf ${OUT_DIR}
mkdir ${OUT_DIR}

cd ${SRC_DIR}

dotnet clean
dotnet build --configuration Release -p:Version=${VERSION_STR} --no-incremental --no-restore

cd ${WORK_DIR}
cp -f **/*.nupkg ${OUT_DIR}

echo "Copied built nuget packages to ${OUT_DIR}"
exit 0