# Dockerfile for the .NET backend (MisterPasta.Server)

# Stage 1: Build the server
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build_server
WORKDIR /app

# Copy the csproj file(s) and restore
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the files and build
COPY . ./
RUN dotnet publish -c Release -o /app

# Stage 2: Run the server
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS server
WORKDIR /app
COPY --from=build_server /app .
EXPOSE 5186

# Set ASPNETCORE_URLS to tell the app to listen on port 5186
ENV ASPNETCORE_URLS=http://+:5186
ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_HOSTINGSTARTUPASSEMBLIES=Microsoft.AspNetCore.SpaProxy

ENTRYPOINT ["dotnet", "MisterPasta.Server.dll"]