#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["cloud-project-BackgroundWorker/cloud-project-BackgroundWorker.csproj", "cloud-project-BackgroundWorker/"]
RUN dotnet restore "cloud-project-BackgroundWorker/cloud-project-BackgroundWorker.csproj"
COPY . .
WORKDIR "/src/cloud-project-BackgroundWorker"
RUN dotnet build "cloud-project-BackgroundWorker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cloud-project-BackgroundWorker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cloud-project-BackgroundWorker.dll"]