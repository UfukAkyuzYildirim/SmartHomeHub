FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["LightingService.API/LightingService.API.csproj", "LightingService.API/"]
COPY ["LightingService.Application/LightingService.Application.csproj", "LightingService.Application/"]
COPY ["LightingService.Domain/LightingService.Domain.csproj", "LightingService.Domain/"]
COPY ["LightingService.Infrastructure/LightingService.Infrastructure.csproj", "LightingService.Infrastructure/"]
RUN dotnet restore "LightingService.API/LightingService.API.csproj"
COPY . .
WORKDIR "/src/LightingService.API"
RUN dotnet build "LightingService.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LightingService.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV ASPNETCORE_URLS=http://+:80

ENTRYPOINT ["dotnet", "LightingService.API.dll"]
