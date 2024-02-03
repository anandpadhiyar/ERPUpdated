FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5001
EXPOSE 5002

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Enterprise.API/Enterprise.API.csproj", "Enterprise.API/"]
COPY ["Enterprise.Application/Enterprise.Application.csproj", "Enterprise.Application/"]
COPY ["Enterprise.Domains/Enterprise.Domains.csproj", "Enterprise.Domains/"]
COPY ["Enterprise.Infrastructure/Enterprise.Infrastructure.csproj", "Enterprise.Infrastructure/"]
RUN dotnet restore "Enterprise.API/Enterprise.API.csproj"
COPY . .
WORKDIR "/src/Enterprise.API"
RUN dotnet build "Enterprise.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Enterprise.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Enterprise.API.dll"]
