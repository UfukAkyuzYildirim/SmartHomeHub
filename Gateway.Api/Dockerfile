# Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["SmartHomeHub.Gateway.API/SmartHomeHub.Gateway.API.csproj", "SmartHomeHub.Gateway.API/"]
RUN dotnet restore "SmartHomeHub.Gateway.API/SmartHomeHub.Gateway.API.csproj"

COPY . .
WORKDIR "/src/SmartHomeHub.Gateway.API"
RUN dotnet publish "SmartHomeHub.Gateway.API.csproj" -c Release -o /app/publish

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# PROD Env
ENV ASPNETCORE_ENVIRONMENT=Production

ENTRYPOINT ["dotnet", "SmartHomeHub.Gateway.API.dll"]
