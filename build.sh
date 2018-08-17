#!/usr/bin/env bash
[[ -e build.sh ]] || { echo >&2 "Please cd into the script location before running it."; exit 1; }
set -e
dotnet --info
dotnet restore
dotnet run --no-restore -c Release -p src/RdatasetsGenerator/RdatasetsGenerator.csproj -- data src/Rdatasets
for c in Debug Release; do
    dotnet build --no-restore -c $c
done
