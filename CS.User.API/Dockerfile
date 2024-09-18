# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CS.User.API/CS.User.API.csproj", "CS.User.API/"]
COPY ["CS.User.Domain/CS.User.Domain.csproj", "CS.User.Domain/"]
COPY ["CS.User.Infrastructure/CS.User.Infrastructure.csproj", "CS.User.Infrastructure/"]
RUN dotnet restore "./CS.User.API/CS.User.API.csproj"
COPY . .
WORKDIR "/src/CS.User.API"
RUN dotnet build "./CS.User.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CS.User.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CS.User.API.dll"]