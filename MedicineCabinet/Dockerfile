# Build Stage

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS Build
WORKDIR /source
COPY . .
RUN dotnet restore "./MedicineCabinet.API/MedicineCabinet.API.csproj" --disable-parallel
RUN dotnet restore "./MedicineCabinet.Domain/MedicineCabinet.Domain.csproj" --disable-parallel
RUN dotnet restore "./MedicineCabinet.Persistence/MedicineCabinet.Persistence.csproj" --disable-parallel
RUN dotnet restore "./MedicineCabinet.Application/MedicineCabinet.Application.csproj" --disable-parallel
RUN dotnet publish "./MedicineCabinet.API/MedicineCabinet.API.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT [ "dotnet", "MedicineCabinet.API.dll" ]