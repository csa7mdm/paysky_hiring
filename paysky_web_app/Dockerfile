#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["paysky_web_app/paysky_web_app.csproj", "paysky_web_app/"]
RUN dotnet restore "paysky_web_app/paysky_web_app.csproj"
COPY . .
WORKDIR "/src/paysky_web_app"
RUN dotnet build "paysky_web_app.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "paysky_web_app.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "paysky_web_app.dll"]