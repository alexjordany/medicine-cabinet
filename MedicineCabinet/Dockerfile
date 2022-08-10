FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS Build
WORKDIR /MedicineCabinet
COPY . .

RUN dotnet restore
COPY . .
WORKDIR /MedicineCabinet/MedicineCabinet.Domain
RUN dotnet build -c Release -o /app

WORKDIR /MedicineCabinet/MedicineCabinet.Persistence
RUN dotnet build -c Release -o /app

WORKDIR /MedicineCabinet/MedicineCabinet.Application
RUN dotnet build -c Release -o /app

WORKDIR /MedicineCabinet/MedicineCabinet.API
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish "/MedicineCabinet/MedicineCabinet.API/MedicineCabinet.API.csproj" -c Release -o app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS http://localhost:7159
ENTRYPOINT [ "dotnet", "MedicineCabinet.API.dll"]