@echo off
dotnet build .\FizzBuzz.EqualExperts\FizzBuzz.EqualExperts.csproj
dotnet build .\FizzBuzz.EqualExperts.Tests\FizzBuzz.EqualExperts.Tests.csproj
dotnet test .\FizzBuzz.EqualExperts.Tests\FizzBuzz.EqualExperts.Tests.csproj