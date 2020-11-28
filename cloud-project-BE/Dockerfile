#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["cloud-project-BE/cloud-project-BE.csproj", "cloud-project-BE/"]
COPY ["cloud-project-BackgroundWorker/cloud-project-BackgroundWorker.csproj", "cloud-project-BackgroundWorker/"]
COPY ["cloud-project-Database/cloud-project-Database.csproj", "cloud-project-Database/"]
COPY ["cloud-project-Shared/cloud-project-Shared.csproj", "cloud-project-Shared/"]
COPY ["cloud-project-BL/cloud-project-BL.csproj", "cloud-project-BL/"]
RUN dotnet restore "cloud-project-BE/cloud-project-BE.csproj"
COPY . .
WORKDIR "/src/cloud-project-BE"
RUN dotnet build "cloud-project-BE.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cloud-project-BE.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cloud-project-BE.dll"]