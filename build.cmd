@echo off
pushd "%~dp0"
call :main %*
popd
goto :EOF

:main
    dotnet restore ^
 && dotnet --info ^
 && dotnet run --no-restore -c Release -p src\RdatasetsGenerator\RdatasetsGenerator.csproj -- data src\Rdatasets ^
 && dotnet build --no-restore -c Debug ^
 && dotnet build --no-restore -c Release
goto :EOF
