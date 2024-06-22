dotnet test --logger "console;verbosity=detailed" Calc.sln
dotnet test --logger "console;verbosity=detailed" E2.sln
findstr /s /R /C:"^[ ]*//" /C:"/\*" /C:"\*/" *.cs | findstr Assert
grep -r --include="*.cs" -B3 Assert.Inconclusive *