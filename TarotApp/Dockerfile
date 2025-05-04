FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY ["TarotApp.csproj", "."]
RUN dotnet restore

# Copy all files and build
COPY . .
RUN dotnet build "TarotApp.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "TarotApp.csproj" -c Release -o /app/publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY assets/ ./assets/

# Set entry point
ENTRYPOINT ["dotnet", "TarotApp.dll"]
