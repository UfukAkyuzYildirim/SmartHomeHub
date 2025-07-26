# Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["Gateway.Api/Gateway.Api.csproj", "Gateway.Api/"]
RUN dotnet restore "Gateway.Api/Gateway.Api.csproj"

COPY . .
WORKDIR "/src/Gateway.Api"
RUN dotnet publish "Gateway.Api.csproj" -c Release -o /app/publish

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# PROD Env
ENV ASPNETCORE_ENVIRONMENT=Production

ENTRYPOINT ["dotnet", "Gateway.Api.dll"]
