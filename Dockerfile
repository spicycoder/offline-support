FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR /app

COPY . .

RUN dotnet restore
RUN dotnet build -c Release
RUN dotnet publish ./src/Api.Http/Api.Http.csproj -c Release -o /artifacts

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS release

WORKDIR /app
COPY --from=build /artifacts .
ENTRYPOINT ["dotnet", "./Api.Http.dll"]