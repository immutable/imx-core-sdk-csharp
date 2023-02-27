#!/bin/zsh

VERSION_STR="0.1.2"

SRC_DIR="./Src/IMX"
OUT_DIR="NugetPackages"
WORK_DIR=`pwd`

rm -rf ${OUT_DIR}
mkdir ${OUT_DIR}

cd ${SRC_DIR}

dotnet clean

# Delete temp build folders
find . -name bin -type d -exec rm -rf {} \;
find . -name obj -type d -exec rm -rf {} \;

# Build and Package
dotnet build --configuration Release -p:Version=${VERSION_STR} --no-incremental

cd ${WORK_DIR}
cp -f **/*.nupkg ${OUT_DIR}

echo "Copied built nuget packages to ${OUT_DIR}"
exit 0