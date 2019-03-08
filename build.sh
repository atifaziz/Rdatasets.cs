#!/usr/bin/env bash
set -e
cd "$(dirname "$0")"
dotnet --info
dotnet restore
dotnet run --no-restore -c Release -p src/RdatasetsGenerator/RdatasetsGenerator.csproj -- data src/Rdatasets
for c in Debug Release; do
    dotnet build --no-restore -c $c
done
